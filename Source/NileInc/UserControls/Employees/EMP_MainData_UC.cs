using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NileInc.Properties;
using Syncfusion.Windows.Forms;
using System.IO;

namespace NileInc
{
	public partial class EMP_MainData_UC : UserControl
	{
		#region Private Variables

		DBDataContext MainDB = new DBDataContext(DataBaseClass.LocalDB);

		EMP_MainData selectedEMP;

		List<EMP_MainData> RefreshResult;

		#endregion

		#region Constructor

		/// <summary>
		/// Default Constructor
		/// </summary>
		public EMP_MainData_UC()
		{
			InitializeComponent();
			RefreshDGV();
			GetDepartments();
			ConfigSearchColumns();
		}

		#endregion

		private void ConfigButtonDisplay(int permission)
		{
			if(permission != 1)
			{
				tlpButtons.Controls.Remove(btnEdit);
				tlpButtons.Controls.Remove(btnDelete);
				tlpButtons.SetCellPosition(btnDetails, new TableLayoutPanelCellPosition(0, 1));
				tlpButtons.SetCellPosition(btnWallet, new TableLayoutPanelCellPosition(0, 2));
				tlpButtons.SetCellPosition(btnConfig, new TableLayoutPanelCellPosition(0, 3));
			}
		}

		private void ConfigSearchColumns()
		{
			cbSearchColumns.Items.Add("الاسم");
			cbSearchColumns.Items.Add("رقم الموبايل");
			cbSearchColumns.Items.Add("العنوان");
			cbSearchColumns.Items.Add("ملاحظات");
		}


		#region Public Methods

		/// <summary>
		/// Gets all employees data and binds them to <see cref="dataGridView1"/>
		/// </summary>
		public void RefreshDGV(int dep = 0,int deg = 0)
		{
			var result = MainDB.EMP_MainDatas.ToList();

			if (dep != 0)
				result = result.Where(a => a.REF_Degree.DEP_ID.Equals(dep)).ToList();

			if (deg != 0)
				result = result.Where(a => a.REF_Degree.ID.Equals(deg)).ToList();

			if(txtSearch.Text.Trim() != "")
			{
				if (cbSearchColumns.SelectedIndex == 0)
					result = result.Where(a => a.Name.ToLower().StartsWith(txtSearch.Text.ToLower())).ToList();
				if (cbSearchColumns.SelectedIndex == 1)
					result = result.Where(a => a.MobileNumber.ToLower().StartsWith(txtSearch.Text.ToLower())).ToList();
				if (cbSearchColumns.SelectedIndex == 2)
					result = result.Where(a => a.Address.ToLower().StartsWith(txtSearch.Text.ToLower())).ToList();
				if (cbSearchColumns.SelectedIndex == 3)
					result = result.Where(a => a.Notes.ToLower().StartsWith(txtSearch.Text.ToLower())).ToList();
			}

			dataGridView1.DataSource = result.Select(a => new
			{
				EMPID = a.ID,
				EMPName = a.Name,
				EMPDep = a.REF_Degree.REF_Department.Name,
				EMPDeg = a.REF_Degree.Name,
				EMPPhoneNumber = a.MobileNumber,
				EMPAddress = a.Address,
				EMPBirthDate = a.BirthDate.ToString("dd/MM/yyyy"),
				EMPJoinDate = a.JoinDate.ToString("dd/MM/yyyy"),
				EMPNotes = a.Notes
			}).AC_AsDataTable();

			RefreshResult = result;
			lblSearchResult.Text = $"نتيجة البحث: {result.Count}";
		}

		/// <summary>
		/// Get all departments and bind them to <see cref="cbDeps"/>
		/// </summary>
		public void GetDepartments(ComboBox cb = null)
		{
			if (cb == null)
			{
				cbDeps.ValueMember = "ID";
				cbDeps.DisplayMember = "Name";
			}
			else
			{
				cb.ValueMember = "ID";
				cb.DisplayMember = "Name";
			}

			if (cb == null)
				cbDeps.DataSource = MainDB.REF_Departments.Select(a => new
				{
					ID = a.ID,
					Name = a.Name
				}).AC_AsDataTable();
			else
				cb.DataSource = MainDB.REF_Departments.Select(a => new
				{
					ID = a.ID,
					Name = a.Name
				}).AC_AsDataTable();
		}

		/// <summary>
		/// Gets all degrees according department id and bind them to <see cref="cbDegs"/>
		/// if <paramref name="depID"/> = 0 get all degrees
		/// </summary>
		/// <param name="depID">The ID of the department to get it's degrees</param>
		public void GetDegrees(int depID = 0 , ComboBox cb = null)
		{
			if (cb == null)
			{
				cbDegs.ValueMember = "ID";
				cbDegs.DisplayMember = "Name";
			}
			else
			{
				cb.ValueMember = "ID";
				cb.DisplayMember = "Name";
			}

			var result = MainDB.REF_Degrees.ToList();

			if (depID != 0)
				result = result.Where(b => b.DEP_ID.Equals(depID)).ToList();

			if (cb == null)
				cbDegs.DataSource = result.Select(a => new
				{
					ID = a.ID,
					Name = a.Name
				}).AC_AsDataTable();
			else
				cb.DataSource = result.Select(a => new
				{
					ID = a.ID,
					Name = a.Name
				}).AC_AsDataTable();
		}

		#endregion

		private void BtnConfig_Click(object sender, EventArgs e)
		{
			tlpButtons.AC_ConfigButtons(true, dataGridView1);
			tlpRows.AC_ClearFields();

			btnWallet.Enabled = !btnAddNew.Enabled;
			btnWallet.Image = btnWallet.Enabled ? Resources.Wallet32px : Resources.WalletBlack32px;
			btnDetails.Enabled = !btnAddNew.Enabled;
			btnDetails.Image = btnDetails.Enabled ? Resources.Details32px : Resources.DetailsBlack32px;
		}

		private void CbDeps_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(cbDeps.SelectedIndex > -1)
			{
				GetDegrees((int)cbDeps.SelectedValue);
			}
		}

		private void BtnAddNew_Click(object sender, EventArgs e)
		{
			try
			{
				if (tlpRows.AC_CheckRequiredFields(txtName, cbDeps, cbDegs))
				{
					EMP_MainData emp = new EMP_MainData();
					emp.Name = txtName.Text;
					emp.MobileNumber = txtPhoneNumber.Text;
					emp.JoinDate = dtJoinDate.Value.Value.Date;
					emp.BirthDate = dtBirthDate.Value.Value.Date;
					emp.Address = txtAddress.Text;
					emp.DEG_ID = (int)cbDegs.SelectedValue;
					emp.DEP_ID = (int)cbDeps.SelectedValue;
					emp.Notes = txtNotes.Text;
					MainDB.EMP_MainDatas.InsertOnSubmit(emp);
					MainDB.SubmitChanges();
					RefreshDGV();
					btnConfig.PerformClick();
					MessageBoxAdv.Show("تمت الاضافه بنجاح");
				}
				else
				{
					MessageBoxAdv.Show("برجاء ادخل كل العناصر المرمزه برمز (*) لاتمام عملية الاضافه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch(Exception ex)
			{
				MessageBoxAdv.Show("خطأ, برجاء التواصل مع الدعم الفني", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MainDB.AC_DiscardPendingChanges();
				DataBaseClass.SendExceptionToOfflineDB(ex);
			}
		}

		private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex > -1)
			{
				selectedEMP = MainDB.EMP_MainDatas.FirstOrDefault(a => a.ID.Equals(dataGridView1.Rows[e.RowIndex].Cells["EMPID"].Value));
				if(selectedEMP != null)
				{
					txtName.Text = selectedEMP.Name;
					txtPhoneNumber.Text = selectedEMP.MobileNumber;
					txtNotes.Text = selectedEMP.Notes;
					txtAddress.Text = selectedEMP.Address;
					cbDeps.SelectedValue = selectedEMP.REF_Degree.REF_Department.ID;
					cbDegs.SelectedValue = selectedEMP.DEG_ID;
					dtBirthDate.Value = selectedEMP.BirthDate;
					dtJoinDate.Value = selectedEMP.JoinDate;
					if (selectedEMP.PhotoPath != null)
					{
						if (File.Exists(selectedEMP.PhotoPath))
						{
							picEmpPhoto.ImageLocation = selectedEMP.PhotoPath;
							btnAddPhoto.Image = Resources.Cancel32px;
							btnAddPhoto.Text = "حذف الصورة";
						}
						else
						{
							picEmpPhoto.Image = Resources.NoPhotoFound;
							btnAddPhoto.Image = Resources.AddPhoto32px;
							btnAddPhoto.Text = "اضافة صورة";
						}
					}
					else
					{
						picEmpPhoto.Image = Resources.NoPhotoFound;
						btnAddPhoto.Image = Resources.AddPhoto32px;
						btnAddPhoto.Text = "اضافة صورة";
					}
				}
			}
		}

		private void BtnEdit_Click(object sender, EventArgs e)
		{
			try
			{
				if (selectedEMP != null)
				{
					if (tlpRows.AC_CheckRequiredFields(txtName, cbDeps, cbDegs))
					{

						selectedEMP.Name = txtName.Text;
						selectedEMP.MobileNumber = txtPhoneNumber.Text;
						selectedEMP.JoinDate = dtJoinDate.Value.Value.Date;
						selectedEMP.BirthDate = dtBirthDate.Value.Value.Date;
						selectedEMP.Address = txtAddress.Text;
						selectedEMP.DEG_ID = (int)cbDegs.SelectedValue;
						selectedEMP.DEP_ID = (int)cbDeps.SelectedValue;
						selectedEMP.Notes = txtNotes.Text;
						MainDB.SubmitChanges();
						RefreshDGV();
						MessageBoxAdv.Show("تمت عملية التعديل بنجاح");
					}
					else
					{
						MessageBoxAdv.Show("برجاء ادخل كل العناصر المرمزه برمز (*) لاتمام عملية التعديل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					MessageBoxAdv.Show("برجاء اختيار موظف للتعديل");
				}
			}
			catch (Exception ex)
			{
				MessageBoxAdv.Show("خطأ, برجاء التواصل مع الدعم الفني", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MainDB.AC_DiscardPendingChanges();
				DataBaseClass.SendExceptionToOfflineDB(ex);
			}
		}

		private void BtnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				if (selectedEMP != null)
				{
					if (MessageBoxAdv.Show("هل انت متاكد من حذف الموظف و جميع بياناته؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
					{

						if(selectedEMP.EMP_AddAndDeductions.Count > 0)
						{
							MainDB.EMP_AddAndDeductions.DeleteAllOnSubmit(MainDB.EMP_AddAndDeductions.Where(a => a.EMP_ID.Equals(selectedEMP.ID)));
						}

						if(selectedEMP.EMP_NetSalaries.Count > 0)
						{
							MainDB.EMP_NetSalaries.DeleteAllOnSubmit(MainDB.EMP_NetSalaries.Where(a => a.EMP_ID.Equals(selectedEMP.ID)));
						}

						if (selectedEMP.PhotoPath != null)
						{
							if (selectedEMP.PhotoPath.Trim() != "")
							{
								try
								{
									File.Delete(Directory.GetCurrentDirectory() + selectedEMP.PhotoPath);
								}
								catch { }
							}
						}

						if(selectedEMP.EMP_Documents.Count > 0)
						{
							MainDB.EMP_Documents.DeleteAllOnSubmit(MainDB.EMP_Documents.Where(a => a.EMP_ID.Equals(selectedEMP.ID)));
							foreach(var doc in selectedEMP.EMP_Documents)
							{
								try
								{
									File.Delete(Directory.GetCurrentDirectory() + doc.DocPath);
								}
								catch { continue; }
							}
						}


						MainDB.EMP_MainDatas.DeleteOnSubmit(selectedEMP);
						MainDB.SubmitChanges();
						RefreshDGV();
						MessageBoxAdv.Show("تمت عملية الحذف بنجاح");
					}
				}
				else
				{
					MessageBoxAdv.Show("برجاء اختيار موظف لحذفه");
				}
			}
			catch (Exception ex)
			{
				MessageBoxAdv.Show("خطأ, برجاء التواصل مع الدعم الفني", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MainDB.AC_DiscardPendingChanges();
				DataBaseClass.SendExceptionToOfflineDB(ex);
			}
		}

		public void EMP_MainData_UC_Load(object sender, EventArgs e)
		{
			ConfigButtonDisplay(MainDashboard.Instance.LoggedUser.Permission.Value);
			MainDB = new DBDataContext(DataBaseClass.LocalDB);
			GetDepartments();
			RefreshDGV();
		}

		private void BtnAddPhoto_Click(object sender, EventArgs e)
		{
			if (selectedEMP != null)
			{
				if (selectedEMP.PhotoPath != null && picEmpPhoto.ImageLocation != null)
				{
					picEmpPhoto.Image = Resources.NoPhotoFound;
					string imgPath = selectedEMP.PhotoPath;
					try
					{
						File.Delete(Directory.GetCurrentDirectory() + imgPath);
					}
					catch { }
					selectedEMP.PhotoPath = null;
					MainDB.SubmitChanges();
					btnAddPhoto.Image = Resources.AddPhoto32px;
					btnAddPhoto.Text = "اضافة صورة";
					MessageBoxAdv.Show("تم حذف الصورة بنجاح");

				}
				else
				{
					OpenFileDialog ofd = new OpenFileDialog();
					ofd.Filter = "Photos (*.jpeg,*.png,*.jpg) | *.jpeg; *.png; *.jpg;";

					if (ofd.ShowDialog() == DialogResult.OK)
					{
						string imgPath = ofd.FileName;
						Image img = Image.FromFile(imgPath);
						string ext = Path.GetExtension(ofd.FileName);
						string toPath = Directory.GetCurrentDirectory() + "\\Photos\\" + selectedEMP.ID + ext;
						File.Copy(imgPath, toPath, true);
						selectedEMP.PhotoPath = "\\Photos\\" + selectedEMP.ID + ext;
						btnAddPhoto.Image = Resources.Cancel32px;
						btnAddPhoto.Text = "حذف الصورة";
						MainDB.SubmitChanges();
						picEmpPhoto.Image = img;/*.CropCircle(new PointF(img.Width / 2 , img.Height / 2) , img.Width / 2 , Color.White);*/
						MessageBoxAdv.Show("تمت اضافة الصورة بنجاح");
					}
				}
			}
			else
			{
				MessageBoxAdv.Show("برجاء اختيار موظف اولا");
			}
		}

		private void BtnDetails_Click(object sender, EventArgs e)
		{
			if(selectedEMP!= null)
			{
				SingleUC_Form singUC = new SingleUC_Form(false);
				EMPDetails_UC empDetails = new EMPDetails_UC(selectedEMP);
				singUC.DataSource(empDetails, "تفاصيل: " + selectedEMP.Name, btnDetails);
			}
			else
			{
				MessageBoxAdv.Show("برجاء اختيار موظف اولا");
			}
		}

		private void TxtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void BtnWallet_Click(object sender, EventArgs e)
		{
			if (selectedEMP != null)
			{
				SingleUC_Form singUC = new SingleUC_Form(false);
				EMPWallet_UC empWallet = new EMPWallet_UC(selectedEMP);
				singUC.DataSource(empWallet, "محفظة: " + selectedEMP.Name, btnWallet);
			}
		}

		private void RbAll_CheckedChanged(object sender, EventArgs e)
		{
			if (rbAll.Checked)
			{
				RefreshDGV();
				cbView.Visible = false;
			}
			else if (rbDepartment.Checked)
			{
				cbView.Visible = true;
				GetDepartments(cbView);
			}
			else if (rbDegree.Checked)
			{
				cbView.Visible = true;
				GetDegrees(cb: cbView);
			}
		}

		private void CbView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (rbDepartment.Checked)
				RefreshDGV(dep: (int)cbView.SelectedValue);
			else if(rbDegree.Checked)
				RefreshDGV(deg: (int)cbView.SelectedValue);
		}

		private void BtnSearch_Click(object sender, EventArgs e)
		{
			if (txtSearch.Text.Trim() != "")
			{
				if (rbDepartment.Checked)
					RefreshDGV(dep: (int)cbView.SelectedValue);
				else if (rbDegree.Checked)
					RefreshDGV(deg: (int)cbView.SelectedValue);
			}
		}

		private void TxtSearch_TextChanged(object sender, EventArgs e)
		{
			if (txtSearch.Text.Trim() != "")
			{
				if (chAutoSearch.Checked)
					btnSearch.PerformClick();
			}
			else
			{
				if (rbDepartment.Checked)
					RefreshDGV(dep: (int)cbView.SelectedValue);
				else if (rbDegree.Checked)
					RefreshDGV(deg: (int)cbView.SelectedValue);
			}
		}
	}
}

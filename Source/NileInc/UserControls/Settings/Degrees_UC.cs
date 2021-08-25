using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace NileInc
{
	public partial class Degrees_UC : UserControl
	{
		DBDataContext MainDB = new DBDataContext(DataBaseClass.LocalDB);

		REF_Degree selectedDeg;

		int OpenedDepID { get; set; } = -1;

		public Degrees_UC()
		{
			InitializeComponent();
			RefreshDGV();
			GetDepartments();
			tlpButtons.ConfigButtonDisplay(MainDashboard.Instance.LoggedUser.Permission.Value);
			ConfigSearchColumns();
		}

		public Degrees_UC(int depID)
		{
			InitializeComponent();
			OpenedDepID = depID;
			RefreshDGV(depID);
			GetDepartments();
			cbDeps.Enabled = false;
			cbDeps.SelectedValue = depID;
			tlpButtons.ConfigButtonDisplay(MainDashboard.Instance.LoggedUser.Permission.Value);
			ConfigSearchColumns();
		}

		private void ConfigSearchColumns()
		{
			cbSearchColumns.Items.Add("الاسم");
			cbSearchColumns.Items.Add("ملاحظات");
		}


		public void RefreshDGV(int dep = 0)
		{
			var result = MainDB.REF_Degrees.ToList();

			if (dep != 0)
				result = result.Where(a => a.DEP_ID.Equals(dep)).ToList();

			if(txtSearch.Text.Trim() != "")
			{
				if (cbSearchColumns.SelectedIndex == 0)
					result = result.Where(a => a.Name.ToLower().StartsWith(txtSearch.Text)).ToList();
				else if(cbSearchColumns.SelectedIndex == 1)
					result = result.Where(a => a.Notes.ToLower().StartsWith(txtSearch.Text)).ToList();
			}

			dataGridView1.DataSource = result.Select(a => new
			{
				DEPID = a.DEP_ID.Value,
				DEGID = a.ID,
				DEGName = a.Name,
				DEGDepName = a.REF_Department.Name,
				DEGBasicSalary = a.BaseSalary.ToString("0.00 L.E"),
				DEGIncentives = a.Incentives.ToString("0.00 L.E"),
				DEGAdds = a.StaticAdds.ToString("0.00 L.E"),
				DEGNotes = a.Notes
			}).AC_AsDataTable();

		}

		public void GetDepartments()
		{
			cbDeps.ValueMember = "ID";
			cbDeps.DisplayMember = "Name";
			cbDeps.DataSource = MainDB.REF_Departments.Select(a => new
			{
				ID = a.ID,
				Name = a.Name
			}).AC_AsDataTable();
		}

		public void GetViewDepartments()
		{
			cbView.ValueMember = "ID";
			cbView.DisplayMember = "Name";
			cbView.DataSource = MainDB.REF_Departments.Select(a => new
			{
				ID = a.ID,
				Name = a.Name
			}).AC_AsDataTable();
		}

		private void BtnConfig_Click(object sender, EventArgs e)
		{
			tlpButtons.AC_ConfigButtons(false, dataGridView1);
			tlpFields.AC_ClearFields();
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				if (tlpFields.AC_CheckRequiredFields(cbDeps, txtName, txtBasicSalary))
				{
					REF_Degree deg = new REF_Degree();
					deg.DEP_ID = (int)cbDeps.SelectedValue;
					deg.Name = txtName.Text;
					deg.BaseSalary = (decimal)txtBasicSalary.Value.Value;
					deg.Incentives = (decimal)txtIncentives.Value.Value;
					deg.StaticAdds = (decimal)txtAdds.Value.Value;
					deg.Notes = txtNotes.Text;
					MainDB.REF_Degrees.InsertOnSubmit(deg);
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
			catch (Exception ex)
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
				selectedDeg = MainDB.REF_Degrees.FirstOrDefault(a => a.ID.Equals(dataGridView1.Rows[e.RowIndex].Cells["DEGID"].Value));
				if(selectedDeg != null)
				{
					txtName.Text = selectedDeg.Name;
					txtNotes.Text = selectedDeg.Notes;
					cbDeps.SelectedValue = selectedDeg.DEP_ID;
					txtBasicSalary.Value = (double)selectedDeg.BaseSalary;
					txtIncentives.Value = (double)selectedDeg.Incentives;
					txtAdds.Value = (double)selectedDeg.StaticAdds;
				}
			}
		}

		private void BtnEdit_Click(object sender, EventArgs e)
		{
			try
			{
				if (selectedDeg != null)
				{
					if (tlpFields.AC_CheckRequiredFields(cbDeps, txtName, txtBasicSalary))
					{
						if (selectedDeg.DEP_ID != (int)cbDeps.SelectedValue)
						{
							selectedDeg.REF_Department = MainDB.REF_Departments.FirstOrDefault(a => a.ID.Equals(cbDeps.SelectedValue));
						}
						selectedDeg.Name = txtName.Text;
						selectedDeg.BaseSalary = (decimal)txtBasicSalary.Value.Value;
						selectedDeg.Incentives = (decimal)txtIncentives.Value.Value;
						selectedDeg.StaticAdds = (decimal)txtAdds.Value.Value;
						selectedDeg.Notes = txtNotes.Text;
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
					MessageBoxAdv.Show("برجاء اختيار درجة للتعديل");
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
				if (selectedDeg != null)
				{
					if (selectedDeg.EMP_MainDatas.Count <= 0)
					{
						if (MessageBoxAdv.Show("هل تريد الحذف؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
						{
							MainDB.REF_Degrees.DeleteOnSubmit(selectedDeg);
							MainDB.SubmitChanges();
							RefreshDGV();
							selectedDeg = null;
							MessageBoxAdv.Show("تمت عملية الحذف بنجاح");
						}
					}
					else
					{
						MessageBoxAdv.Show("لا يمكن حذف هذه الدرجة لاحتواءها على موظفين", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					MessageBoxAdv.Show("برجاء اختيار درجة للحذف");
				}
			}
			catch (Exception ex)
			{
				MessageBoxAdv.Show("خطأ, برجاء التواصل مع الدعم الفني", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MainDB.AC_DiscardPendingChanges();
				DataBaseClass.SendExceptionToOfflineDB(ex);
			}
		}

		private void RbAll_CheckedChanged(object sender, EventArgs e)
		{
			if (rbAll.Checked)
			{
				cbView.Visible = false;
				RefreshDGV();
			}
			else if (rbDepartment.Checked)
			{
				cbView.Visible = true;
				GetViewDepartments();
				RefreshDGV(dep: (int)cbView.SelectedValue);
			}
		}

		private void TxtSearch_TextChanged(object sender, EventArgs e)
		{
			if (txtSearch.Text.Trim() != "")
			{
				if (rbAll.Checked)
					RefreshDGV();
				else if (rbDepartment.Checked)
					RefreshDGV(dep: (int)cbView.SelectedValue);
			}
			else
				RefreshDGV();
		}

		private void CbView_SelectedIndexChanged(object sender, EventArgs e)
		{
			RefreshDGV((int)cbView.SelectedValue);
		}
	}
}

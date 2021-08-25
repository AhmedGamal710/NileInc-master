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
	public partial class Departments_UC : UserControl
	{
		public DBDataContext MainDB = new DBDataContext(DataBaseClass.LocalDB);

		REF_Department selectedDep;

		public Departments_UC()
		{
			InitializeComponent();
			RefreshDGV();
			tlpButtons.ConfigButtonDisplay(MainDashboard.Instance.LoggedUser.Permission.Value);
		}


		public void RefreshDGV(string name = "")
		{
			var result = MainDB.REF_Departments.ToList();

			if (name.Trim() != "")
				result = result.Where(a => a.Name.ToLower().StartsWith(name.ToLower())).ToList();

			dataGridView1.DataSource = result.Select(a => new
			{
				DEPID = a.ID,
				DEPName = a.Name,
				DEPNotes = a.Notes
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
				if (tlpFields.AC_CheckRequiredFields(txtName))
				{
					REF_Department dep = new REF_Department();
					dep.Name = txtName.Text;
					dep.Notes = txtNotes.Text;
					MainDB.REF_Departments.InsertOnSubmit(dep);
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
				selectedDep = MainDB.REF_Departments.FirstOrDefault(a => a.ID.Equals(dataGridView1.Rows[e.RowIndex].Cells["DEPID"].Value));
				if (selectedDep != null)
				{
					txtNotes.Text = selectedDep.Notes;
					txtName.Text = selectedDep.Name;
				}
			}
		}

		private void BtnEdit_Click(object sender, EventArgs e)
		{
			try
			{
				if (selectedDep != null)
				{
					if (tlpFields.AC_CheckRequiredFields(txtName))
					{
						selectedDep.Name = txtName.Text;
						selectedDep.Notes = txtNotes.Text;
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
					MessageBoxAdv.Show("برجاء اختيار قسم للتعديل");
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
				if(selectedDep != null)
				{
					if (selectedDep.REF_Degrees.Count == 0)
					{
						if (MessageBoxAdv.Show("هل تريد الحذف؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
						{
							MainDB.REF_Departments.DeleteOnSubmit(selectedDep);
							MainDB.SubmitChanges();
							selectedDep = null;
							RefreshDGV();
							MessageBoxAdv.Show("تمت عملية الحذف بنجاح");
						}
					}
					else
					{
						MessageBoxAdv.Show("لا يمكن حذف هذا القسم لاحتواءه على درجات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					MessageBoxAdv.Show("برجاء اختيار قسم لحذفه");
				}
			}
			catch (Exception ex)
			{
				MessageBoxAdv.Show("خطأ, برجاء التواصل مع الدعم الفني", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MainDB.AC_DiscardPendingChanges();
				DataBaseClass.SendExceptionToOfflineDB(ex);
			}
		}

		private void TxtSearch_Enter(object sender, EventArgs e)
		{
			if (txtSearch.Text.Trim() == "ادخل اسم القسم")
			{
				txtSearch.TextChanged -= TxtSearch_TextChanged;
				txtSearch.Text = "";
				txtSearch.ForeColor = Color.Black;
				txtSearch.TextChanged += TxtSearch_TextChanged;
			}
		}

		private void TxtSearch_Leave(object sender, EventArgs e)
		{
			if (txtSearch.Text.Trim() == "")
			{
				txtSearch.TextChanged -= TxtSearch_TextChanged;
				txtSearch.Text = "ادخل اسم القسم";
				txtSearch.ForeColor = Color.Silver;
				txtSearch.TextChanged += TxtSearch_TextChanged;
			}
		}

		private void TxtSearch_TextChanged(object sender, EventArgs e)
		{
			if(txtSearch.Text.Trim() != "")
			{
				RefreshDGV(txtSearch.Text);
			}
		}
	}
}

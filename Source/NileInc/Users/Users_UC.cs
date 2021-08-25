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
	public partial class Users_UC : UserControl
	{
		public DBDataContext MainDB = new DBDataContext(DataBaseClass.LocalDB);
		public USR_LoginData selectedUser;
		Dictionary<int, string> permission = new Dictionary<int, string>();

		public Users_UC()
		{
			InitializeComponent();
			permission.Add(1, "مدير عام");
			permission.Add(2, "مدخل بيانات");
			cbPermissions.DataSource = permission.AC_AsDataTable();
			cbPermissions.ValueMember = "key";
			cbPermissions.DisplayMember = "value";
		}


		public void Users_UC_Load(object sender, EventArgs e)
		{
			RefreshDGV("");
		}

		public string GetPermissionText(int id)
		{
			return permission[id];
		}

		public void RefreshDGV(string SearchQuery)
		{
			if (SearchQuery.Trim() == "")
			{
				dgvUsers.DataSource = MainDB.USR_LoginDatas.Select(a => new
				{
					UserID = a.ID,
					UserName = a.Username,
					Permission = GetPermissionText(a.Permission.Value),
					Answer1 = a.Answer1,
					Answer2 = a.Answer2,
					Answer3 = a.Answer3,
					Answer4 = a.Answer4
				}).AC_AsDataTable();
			}
			else
			{
				dgvUsers.DataSource = MainDB.USR_LoginDatas.ToList().Where(b => b.Username.ToLower().StartsWith(SearchQuery.ToLower())).Select(a => new
				{
					UserID = a.ID,
					UserName = a.Username,
					Permission = a.Permission.Value,
					Answer1 = a.Answer1,
					Answer2 = a.Answer2,
					Answer3 = a.Answer3,
					Answer4 = a.Answer4
				}).AC_AsDataTable();
			}
		}

		private void txtSearch_Enter(object sender, EventArgs e)
		{
			txtSearch.Text = "";
			txtSearch.ForeColor = Color.Black;
		}

		private void txtSearch_Leave(object sender, EventArgs e)
		{
			txtSearch.TextChanged -= txtSearch_TextChanged;
			txtSearch.Text = "ادخل اسم المستخدم";
			txtSearch.ForeColor = Color.Silver;
			txtSearch.TextChanged += txtSearch_TextChanged;
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			RefreshDGV(txtSearch.Text);
		}


		private void chShowPassword_CheckedChanged(object sender, EventArgs e)
		{
			if (chShowPassword.Checked)
			{
				txtPassword.UseSystemPasswordChar = false;
			}
			else
			{
				txtPassword.UseSystemPasswordChar = true;
			}
		}

		private void txtUsername_TextChanged(object sender, EventArgs e)
		{
			if (txtUsername.Text.Trim() != "")
			{
				if (txtUsername.Text.Length > 3)
				{
					USR_LoginData user = MainDB.USR_LoginDatas.FirstOrDefault(a => a.Username.ToLower() == txtUsername.Text.ToLower());
					if (user != null)
					{
						lblUserNameStatus.Text = "Taken";
						lblUserNameStatus.ForeColor = Color.Red;
					}
					else
					{
						lblUserNameStatus.Text = "Valid";
						lblUserNameStatus.ForeColor = Color.Green;
					}
				}
				else
				{
					lblUserNameStatus.Text = "Minimum 4 digits";
					lblUserNameStatus.ForeColor = Color.Red;
				}
			}
			else
			{
				lblUserNameStatus.Text = "";
				lblUserNameStatus.ForeColor = Color.Black;
			}
		}

		private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
		{
			if (txtPassword.Text.Trim() != "")
			{
				if (txtConfirmPassword.Text.Trim() != "")
				{
					if (txtConfirmPassword.Text == txtPassword.Text)
					{
						lblPasswordStatus.Text = "Valid";
						lblPasswordStatus.ForeColor = Color.Green;
					}
					else
					{
						lblPasswordStatus.Text = "Doesn't match";
						lblPasswordStatus.ForeColor = Color.Red;
					}
				}
				else
				{
					lblPasswordStatus.Text = "";
					lblPasswordStatus.ForeColor = Color.Black;
				}
			}
			else
			{
				lblPasswordStatus.Text = "";
				lblPasswordStatus.ForeColor = Color.Black;
			}
		}

		public void ClearFields()
		{
			txtUsername.Text = "";
			txtPassword.Text = "";
			txtConfirmPassword.Text = "";
			cbPermissions.SelectedIndex = -1;
			txtAnswer1.Text = "";
			txtAnswer2.Text = "";
			txtAnswer3.Text = "";
			txtAnswer4.Text = "";
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			if (cbPermissions.SelectedIndex > -1 && lblPasswordStatus.ForeColor == Color.Green && lblUserNameStatus.ForeColor == Color.Green)
			{
				if (cbPermissions.SelectedIndex > -1)
				{
					USR_LoginData user = new USR_LoginData();
					user.Username = txtUsername.Text;
					Guid g = Guid.NewGuid();
					user.Password = AC_Extensions.HashSHA1(txtPassword.Text + g.ToString().ToLower());
					user.UserGuid = g.ToString().ToLower();
					user.IsActive = false;
					user.Permission = (int)cbPermissions.SelectedValue;
					user.Answer1 = txtAnswer1.Text;
					user.Answer2 = txtAnswer2.Text;
					user.Answer3 = txtAnswer3.Text;
					user.Answer4 = txtAnswer4.Text;
					MainDB.USR_LoginDatas.InsertOnSubmit(user);
					MainDB.SubmitChanges();
					btnConfig.PerformClick();
					RefreshDGV("");
					MessageBox.Show("تمت الاضافة بنجاح");
				}
				else
				{
					MessageBoxAdv.Show("برجاء ادخل كل العناصر المرمزه برمز (*) لاتمام عملية التعديل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBoxAdv.Show("برجاء التاكد من اسم المستخدم و كلمة المرور للمتابعة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BtnConfig_Click(object sender, EventArgs e)
		{
			ClearFields();
			tlpButtons.AC_ConfigButtons(true, dgvUsers);
		}

		private void DgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				txtUsername.TextChanged -= txtUsername_TextChanged;
				txtConfirmPassword.TextChanged -= txtConfirmPassword_TextChanged;
				selectedUser = MainDB.USR_LoginDatas.FirstOrDefault(a => a.ID.Equals(dgvUsers.Rows[e.RowIndex].Cells["UserID"].Value));
				txtUsername.Text = selectedUser.Username;
				cbPermissions.SelectedValue = selectedUser.Permission.Value;
				txtAnswer1.Text = selectedUser.Answer1;
				txtAnswer2.Text = selectedUser.Answer2;
				txtAnswer3.Text = selectedUser.Answer3;
				txtAnswer4.Text = selectedUser.Answer4;
				txtUsername.TextChanged += txtUsername_TextChanged;
				txtConfirmPassword.TextChanged += txtConfirmPassword_TextChanged;
			}
		}

		private void BtnEdit_Click(object sender, EventArgs e)
		{

			if (cbPermissions.SelectedIndex > -1)
			{
				
				if(txtUsername.Text != selectedUser.Username && lblUserNameStatus.ForeColor == Color.Green)
					selectedUser.Username = txtUsername.Text;

				if (txtPassword.Text.Trim() != "" && lblPasswordStatus.ForeColor == Color.Green)
				{
					Guid g = Guid.NewGuid();
					selectedUser.Password = AC_Extensions.HashSHA1(txtPassword.Text + g.ToString().ToLower());
					selectedUser.UserGuid = g.ToString().ToLower();
				}
				selectedUser.IsActive = false;
				selectedUser.Permission = (int)cbPermissions.SelectedValue;
				selectedUser.Answer1 = txtAnswer1.Text;
				selectedUser.Answer2 = txtAnswer2.Text;
				selectedUser.Answer3 = txtAnswer3.Text;
				selectedUser.Answer4 = txtAnswer4.Text;
				MainDB.SubmitChanges();
				RefreshDGV("");
				MessageBoxAdv.Show("تم التعديل بنجاح");
			}
			else
			{
				MessageBoxAdv.Show("برجاء ادخل كل العناصر المرمزه برمز (*) لاتمام عملية التعديل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void BtnDelete_Click(object sender, EventArgs e)
		{
			if (selectedUser != null)
			{
				MainDB.USR_LoginDatas.DeleteOnSubmit(selectedUser);
				MainDB.SubmitChanges();
				selectedUser = null;
				RefreshDGV("");
				MessageBoxAdv.Show("تمت عملية الحذف بنجاح");
			}
			else
			{
				MessageBoxAdv.Show("برجاء اختيار مستخدم للمسح");
			}
		}

		private void TxtPassword_TextChanged(object sender, EventArgs e)
		{
		}
	}
}

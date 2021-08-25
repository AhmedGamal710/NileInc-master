using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NileInc
{
	public partial class ResetPassword_Form : Form
	{
		string[] Ques = new string[4];
		int q1, q2;
		public string showedUserName = "";

		public ResetPassword_Form()
		{
			InitializeComponent();

		}

		public ResetPassword_Form(string username)
		{
			InitializeComponent();
			showedUserName = username;

		}

		private void btnCloseApp_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void ResetPassword_Form_Load(object sender, EventArgs e)
		{
			if (showedUserName.Trim() != "")
			{
				txtUsername.Enabled = false;
				txtUsername.Text = showedUserName;
			}
			Ques[0] = "اسم صديق طفولتك ؟";
			Ques[1] = "اسم فيلمك المفضل ؟";
			Ques[2] = "بطل طفولتك المفضل ؟";
			Ques[3] = "اسم سيارتك المفضلة ؟";
			Random rand1 = new Random();
			q1 = rand1.Next(3);
			q2 = rand1.Next(3);

			while (q2 == q1)
			{
				q2 = rand1.Next(3);
			}

			lblQues1.Text = Ques[q1];
			lblQues2.Text = Ques[q2];
		}

		private void btnChangePassword_Click(object sender, EventArgs e)
		{
			if (txtNewPW.Text.Trim() != "" || txtNewPWCon.Text.Trim() != "")
			{
				if (txtNewPW.Text == txtNewPWCon.Text)
				{
					if (UsersClass.ChangeUserPassword(txtUsername.Text, txtNewPW.Text))
					{
						MessageBoxAdv.Show("تم تغيير كلمة السر بنجاح");
						this.Close();
					}
				}
				else
				{
					MessageBoxAdv.Show("كلمتنان غير متطابقتين");
				}
			}
			else
			{
				MessageBoxAdv.Show("يجب ملئ كل الخانات");
			}
		}

		private void txtAnswer1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnCheck.PerformClick();
			}
		}

		private void txtNewPW_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnChangePassword.PerformClick();
			}
		}

		private void btnCheck_Click(object sender, EventArgs e)
		{
			if (txtUsername.Text.ToLower() != "ava")
			{
				if (UsersClass.CheckSecurityQuestions(txtUsername.Text, txtAnswer1.Text, txtAnswer2.Text, q1, q2))
				{

					tlpChangePWMain.Visible = true;
					tlpChangePWMain.Dock = DockStyle.Fill;
				}
				else
				{
					MessageBoxAdv.Show("بيانات غير صحيحة");

					tlpChangePWMain.Visible = false;
				}
			}
			else
			{
				MessageBoxAdv.Show("لا يمكن تعديل بيانات المطور");
			}
		}
	}
}

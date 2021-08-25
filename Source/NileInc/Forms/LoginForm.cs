using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NileInc
{
	public partial class LoginForm : Form
	{
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;
		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();

		DBDataContext MainDB = new DBDataContext(DataBaseClass.LocalDB);

		public static LoginForm _obj;
		public LoginForm()
		{
			InitializeComponent();
			_obj = this;
			var year = DateTime.Now.Date.Year.ToString();
			lblRights.Text = $"© {year} AVA Codes -  All Rights Reserved";
		}

		public static LoginForm Instance
		{
			get
			{
				if (_obj == null)
					_obj = new LoginForm();
				return _obj;
			}
		}

		public static bool AnotherInstanceExists()
		{
			Process currentRunningProcess = Process.GetCurrentProcess();
			Process[] listOfProcs = Process.GetProcesses(".");

			foreach (Process proc in listOfProcs)
			{
				try
				{
					if ((proc.MainModule.FileVersionInfo.InternalName == currentRunningProcess.MainModule.FileVersionInfo.InternalName || proc.MainModule.FileVersionInfo.FileDescription == currentRunningProcess.MainModule.FileVersionInfo.FileDescription) && (proc.Id != currentRunningProcess.Id))

						return true;
				}
				catch
				{
					continue;
				}
			}
			return false;
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{
			Font capFont = new Font(new FontFamily("Questv1"), 10f, FontStyle.Regular);
			Font msgFont = new Font(new FontFamily("Questv1"), 12f, FontStyle.Regular);
			StylesClass.MsgBoxConfig(msgFont, capFont, Color.White, Color.FromArgb(1, 60, 155));

			try
			{
				if (AnotherInstanceExists())
				{
					MessageBoxAdv.Show("لا يمكن تشغيل التطبيق اكثر من مرة.", "التطبيق يعمل بالفعل", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

					Application.Exit();
				}
			}
			catch (Exception ex)
			{
				DataBaseClass.SendExceptionToOfflineDB(ex);
			}
		}


		private void btnLogin_Click(object sender, EventArgs e)
		{
			try
			{

				USR_LoginData user = MainDB.USR_LoginDatas.FirstOrDefault(a => a.Username.ToLower() == txtUsername.Text.ToLower());
				if (user != null)
				{
					if (UsersClass.UserLogged(txtUsername.Text, txtPassword.Text))
					{
						MainDashboard mdb = new MainDashboard(user);
						//mdb.LoggedUser = user;
						mdb.Show();
						this.Hide();
					}
					else
					{
						if (MessageBoxAdv.Show("بيانات غير صحيحة, هل تريد استعادة كلمة السر؟", "خطأ", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
						{
							ResetPassword_Form rs = new ResetPassword_Form(txtUsername.Text);
							rs.ShowDialog();
						}
					}

				}
				else
				{
					MessageBoxAdv.Show("بيانات غير صحيحة");
				}
			}catch(Exception ex)
			{
				DataBaseClass.SendExceptionToOfflineDB(ex);
			}
		}

		private void btnCloseApp_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnRestart_Click(object sender, EventArgs e)
		{
			Application.Restart();
		}

		private void btnMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void txtUsername_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnLogin.PerformClick();
			}
		}

		private void txtPassword_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnLogin.PerformClick();
			}
		}

	
		

	

		private void panel3_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void BtnForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ResetPassword_Form rs = new ResetPassword_Form();
			rs.ShowDialog();
		}

		private void PnlMain_Paint(object sender, PaintEventArgs e)
		{

		}

		private void TxtPassword_TextChanged(object sender, EventArgs e)
		{

		}

		private void TxtUsername_TextChanged(object sender, EventArgs e)
		{

		}

		private void LblRights_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			About_Form af = new About_Form();
			af.ShowDialog();
		}
	}
}

using NileInc.Properties;
using Syncfusion.Windows.Forms;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NileInc
{
	public partial class MainDashboard : Form
	{
		#region Public Properties

		public static MainDashboard Instance { get; set; } 

		public bool IsMaximized { get; set; }

		public UserControl OpenedUC { get; set; }

		public USR_LoginData LoggedUser { get; set; }

		#endregion

		#region Form Dragging Stuff

		public static bool maximied = true;
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();

		#endregion

		#region UserControls Declare and Initialize

		EMP_Home_UC empHome { get; set; } = new EMP_Home_UC();

		EMP_MainData_UC empMainData { get; set; } = new EMP_MainData_UC();

		Settings_UC settingUC{ get; set; } = new Settings_UC();

		Users_UC usersUC = new Users_UC();

		#endregion

		#region Helper Methods

		/// <summary>
		/// Add user control in panel if not exists
		/// else will bring it to front
		/// </summary>
		/// <param name="uc">The user control to show</param>
		/// <param name="pnl">The panel container</param>
		public void ShowUserControl(UserControl uc, Panel pnl)
		{
			if (!pnl.Controls.ContainsKey(uc.Name))
			{
				uc.Dock = DockStyle.Fill;
				pnl.Controls.Add(uc);
				pnl.Controls[uc.Name].BringToFront();
			}
			else
			{
				pnl.Controls[uc.Name].BringToFront();
			}
		}

		/// <summary>
		/// To move little panel that is beside buttons
		/// </summary>
		/// <param name="btn">The button that we want to move panel to</param>
		private void MoveSidePanel(Button btn)
		{
			SidePanel.Top = btn.Top;
			SidePanel.Height = btn.Height;
		}

		/// <summary>
		/// Navigates to user control and set button panel using another helper methods
		/// </summary>
		/// <param name="uc">The user control to navigate to</param>
		/// <param name="senderButton">The button we set panel to</param>
		private void NavigateTo(UserControl uc, Button senderButton)
		{
			ShowUserControl(uc, pnlUserControls);
			MoveSidePanel(senderButton);
			VisualizeButtonsOnClick(senderButton, SlidePanel);
			OpenedUC = uc;
		}

		/// <summary>
		/// To visualize selected button as different back-color
		/// </summary>
		/// <param name="selectedButton">The button to change background</param>
		/// <param name="container">The container panel</param>
		public void VisualizeButtonsOnClick(Button selectedButton,Panel container)
		{
			foreach(Control control in container.Controls) 
			{
				if (control is Button btn)
					if (btn != selectedButton)
						btn.BackColor = Color.Transparent;
			}
			selectedButton.BackColor = Color.FromArgb(2, 116, 190);
		}

		public void CreatePhotoFolder()
		{
			try
			{
				string path = Directory.GetCurrentDirectory() + "\\Photos";
				Directory.CreateDirectory(path);
			}
			catch { }
			try
			{
				string path = Directory.GetCurrentDirectory() + "\\Docs";
				Directory.CreateDirectory(path);
			}
			catch { }
		}

		#endregion

		#region Header Buttons Event

		private void BtnCloseApp_Click(object sender, EventArgs e)
		{
			if (MessageBoxAdv.Show("هل تريد الخروج؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void BtnChangeSize_Click(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Maximized)
			{
				IsMaximized = false;
				this.WindowState = FormWindowState.Normal;
				btnChangeSize.Image = Resources.MinimizedPhoto;
				btnChangeSize.ImageHover = Resources.MinimizedPhoto;
				btnChangeSize.ImageNormal = Resources.MinimizedPhoto;
			}
			else
			{
				IsMaximized = true;
				this.WindowState = FormWindowState.Maximized;
				btnChangeSize.Image = Resources.MaxmiziedPhoto;
				btnChangeSize.ImageHover = Resources.MaxmiziedPhoto;
				btnChangeSize.ImageNormal = Resources.MaxmiziedPhoto;
			}
		}

		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		#endregion
		
		#region Constructor

		/// <summary>
		/// Default Constructor
		/// </summary>
		public MainDashboard(USR_LoginData user)
		{
			InitializeComponent();
			Instance = this;
			LoggedUser = user;
			var year = DateTime.Now.Date.Year.ToString();
			lblRights.Text = $"© {year} AVA Codes -  All Rights Reserved";
			timerTime.Start();
			CreatePhotoFolder();
			//sfButton1.Style.GradientBrush = new BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(2, 116, 190), Color.FromArgb(1, 60, 155));
			//sfButton1.Style.HoverGradientBrush = new Syncfusion.WinForms.Core.BrushInfo(Syncfusion.WinForms.Core.Enums.GradientStyle.Horizontal, Color.FromArgb(2, 116, 190), Color.FromArgb(1, 60, 155));

		}

		#endregion

		#region Main Buttons Event Handlers

		private void BtnHome_Click(object sender, EventArgs e)
		{
			NavigateTo(empHome, (Button)sender);
			empHome.EMP_Home_UC_Load(empHome, new EventArgs());
		}

		private void BtnLogout_Click(object sender, EventArgs e)
		{
			Application.Restart();
		}

		private void BtnUsersSection_Click(object sender, EventArgs e)
		{
			NavigateTo(usersUC, btnUsersSection);
			usersUC.Users_UC_Load(usersUC, new EventArgs());
		}

		private void BtnSettings_Click(object sender, EventArgs e)
		{
			NavigateTo(settingUC, (Button)sender);
			settingUC.Settings_UC_Load(settingUC, new EventArgs());
		}

		private void BtnEMPs_Click(object sender, EventArgs e)
		{
			NavigateTo(empMainData, (Button)sender);
			empMainData.EMP_MainData_UC_Load(empMainData, new EventArgs());
		}

		#endregion

		private void TimerTime_Tick(object sender, EventArgs e)
		{
			lblTime.Text = "Date: " + DateTime.Now.ToString("dd/MM/yyyy - hh:mm:ss tt");
		}

		private void PnlHeader_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void PictureBox1_Click(object sender, EventArgs e)
		{
			if(SlidePanel.Width > 55)
			{
				SlidePanel.Width = 55;
			}
			else
			{
				SlidePanel.Width = 224;
			}
		}

		private void MainDashboard_Load(object sender, EventArgs e)
		{
			lblPermission.Text = "الدرجة: " + ( LoggedUser.Permission == 1 ? "مدير عام" : "مدخل بيانات");
			lblHello.Text = $"مرحبا: {LoggedUser.Username}";
			if(LoggedUser.Permission != 1)
			{
				btnUsersSection.Visible = false;
				btnSettings.Location = btnUsersSection.Location;
			}
			NavigateTo(empHome, btnHome);
		}

		private void Panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void LblRights_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			About_Form af = new About_Form();
			af.ShowDialog();
		}
	}
}

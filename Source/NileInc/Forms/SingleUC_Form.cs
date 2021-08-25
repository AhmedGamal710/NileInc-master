using NileInc.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NileInc
{
	public partial class SingleUC_Form : Form
	{
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;
		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();

		Button senderBtn = new Button();
		public SingleUC_Form()
		{
			InitializeComponent();
		}

		public SingleUC_Form(bool sizeable)
		{
			InitializeComponent();
			if (!sizeable)
				btnChangeSize.Visible = false;
			this.RightToLeft = RightToLeft.Yes;
		}

		private void btnCloseApp_Click(object sender, EventArgs e)
		{
			senderBtn.Enabled = true;
			this.Close();
		}

		private void btnChangeSize_Click(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Maximized)
			{
				this.WindowState = FormWindowState.Normal;
			}
			else
			{
				this.WindowState = FormWindowState.Maximized;
			}
		}

		private void btnMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void SingleUC_Form_SizeChanged(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Maximized)
			{
				btnChangeSize.Image = Resources.MaxmiziedPhoto;
				btnChangeSize.ImageHover = Resources.MaxmiziedPhoto;
				btnChangeSize.ImageNormal = Resources.MaxmiziedPhoto;
			}
			else
			{
				btnChangeSize.Image = Resources.MinimizedPhoto;
				btnChangeSize.ImageHover = Resources.MinimizedPhoto;
				btnChangeSize.ImageNormal = Resources.MinimizedPhoto;
			}
		}

		public static void AddUserControlInputToPanel(Panel panel, UserControl uc)
		{
			uc.Dock = DockStyle.Fill;
			panel.Controls.Clear();
			panel.Controls.Add(uc);
		}

		private void ChnageSize(UserControl uc)
		{
			this.Height = uc.Height + 45;
			this.Width = uc.Width + 20;
		}

		private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		public void DataSource(UserControl uc, string ucname, Button sBtn)
		{
			senderBtn = sBtn;
			senderBtn.Enabled = false;
			pnlMain.Controls.Clear();
			ChnageSize(uc);
			AddUserControlInputToPanel(pnlMain, uc);
			lblTitle.Text = ucname;
			//OpenedUC = uc.Name;
			this.Text = ucname;
			this.Show();
		}
	}
}

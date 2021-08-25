namespace NileInc
{
	partial class LoginForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.label3 = new System.Windows.Forms.Label();
			this.btnForgotPassword = new System.Windows.Forms.LinkLabel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlHeader = new Syncfusion.Windows.Forms.Tools.GradientPanel();
			this.btnMinimize = new AVACustomImage.CustomImageButton();
			this.btnCloseApp = new AVACustomImage.CustomImageButton();
			this.pnlFooter = new Syncfusion.Windows.Forms.Tools.GradientPanel();
			this.lblRights = new System.Windows.Forms.LinkLabel();
			this.pnlMain = new Syncfusion.Windows.Forms.Tools.GradientPanel();
			this.label6 = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pnlHeader)).BeginInit();
			this.pnlHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCloseApp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlFooter)).BeginInit();
			this.pnlFooter.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
			this.pnlMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Dock = System.Windows.Forms.DockStyle.Left;
			this.label3.Font = new System.Drawing.Font("VIP Rawy Regular", 12F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 22);
			this.label3.TabIndex = 17;
			this.label3.Text = "Login";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnForgotPassword
			// 
			this.btnForgotPassword.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(48)))), ((int)(((byte)(81)))));
			this.btnForgotPassword.AutoSize = true;
			this.btnForgotPassword.BackColor = System.Drawing.Color.Transparent;
			this.btnForgotPassword.Font = new System.Drawing.Font("Questv1", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnForgotPassword.ForeColor = System.Drawing.Color.White;
			this.btnForgotPassword.LinkColor = System.Drawing.Color.White;
			this.btnForgotPassword.Location = new System.Drawing.Point(224, 272);
			this.btnForgotPassword.Name = "btnForgotPassword";
			this.btnForgotPassword.Size = new System.Drawing.Size(91, 15);
			this.btnForgotPassword.TabIndex = 4;
			this.btnForgotPassword.TabStop = true;
			this.btnForgotPassword.Text = "نسيت كلمة السر؟";
			this.btnForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BtnForgotPassword_LinkClicked);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("VIP Rawy Regular", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(332, 167);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "كلمة المرور";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("VIP Rawy Regular", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(332, 121);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "اسم المستخدم";
			// 
			// pnlHeader
			// 
			this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(52)))), ((int)(((byte)(79)))));
			this.pnlHeader.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(116)))), ((int)(((byte)(190))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(155))))));
			this.pnlHeader.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
			this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlHeader.Controls.Add(this.label3);
			this.pnlHeader.Controls.Add(this.btnMinimize);
			this.pnlHeader.Controls.Add(this.btnCloseApp);
			this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlHeader.Location = new System.Drawing.Point(0, 0);
			this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new System.Drawing.Size(501, 24);
			this.pnlHeader.TabIndex = 0;
			this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
			// 
			// btnMinimize
			// 
			this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
			this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnMinimize.Image = global::NileInc.Properties.Resources.MinimizeStart;
			this.btnMinimize.ImageHover = global::NileInc.Properties.Resources.MinimizeGIF;
			this.btnMinimize.ImageNormal = global::NileInc.Properties.Resources.MinimizeStart;
			this.btnMinimize.Location = new System.Drawing.Point(447, 0);
			this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(26, 22);
			this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnMinimize.TabIndex = 14;
			this.btnMinimize.TabStop = false;
			this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
			// 
			// btnCloseApp
			// 
			this.btnCloseApp.BackColor = System.Drawing.Color.Transparent;
			this.btnCloseApp.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCloseApp.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnCloseApp.Image = global::NileInc.Properties.Resources.CloseNormal;
			this.btnCloseApp.ImageHover = global::NileInc.Properties.Resources.CloseHover;
			this.btnCloseApp.ImageNormal = global::NileInc.Properties.Resources.CloseNormal;
			this.btnCloseApp.InitialImage = global::NileInc.Properties.Resources.CloseNormal;
			this.btnCloseApp.Location = new System.Drawing.Point(473, 0);
			this.btnCloseApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCloseApp.Name = "btnCloseApp";
			this.btnCloseApp.Size = new System.Drawing.Size(26, 22);
			this.btnCloseApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnCloseApp.TabIndex = 16;
			this.btnCloseApp.TabStop = false;
			this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
			// 
			// pnlFooter
			// 
			this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(52)))), ((int)(((byte)(79)))));
			this.pnlFooter.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(116)))), ((int)(((byte)(190))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(155))))));
			this.pnlFooter.BorderSides = System.Windows.Forms.Border3DSide.Top;
			this.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlFooter.Controls.Add(this.lblRights);
			this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlFooter.Location = new System.Drawing.Point(0, 326);
			this.pnlFooter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pnlFooter.Name = "pnlFooter";
			this.pnlFooter.Size = new System.Drawing.Size(501, 16);
			this.pnlFooter.TabIndex = 0;
			// 
			// lblRights
			// 
			this.lblRights.BackColor = System.Drawing.Color.Transparent;
			this.lblRights.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblRights.Font = new System.Drawing.Font("Trebuchet MS", 9F);
			this.lblRights.LinkColor = System.Drawing.Color.White;
			this.lblRights.Location = new System.Drawing.Point(0, 0);
			this.lblRights.Name = "lblRights";
			this.lblRights.Size = new System.Drawing.Size(411, 14);
			this.lblRights.TabIndex = 1;
			this.lblRights.TabStop = true;
			this.lblRights.Text = "© {year} AVA Codes -  All Rights Reserved";
			this.lblRights.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblRights.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblRights_LinkClicked);
			// 
			// pnlMain
			// 
			this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(52)))), ((int)(((byte)(79)))));
			this.pnlMain.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(116)))), ((int)(((byte)(190))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(155))))));
			this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.pnlMain.Controls.Add(this.label6);
			this.pnlMain.Controls.Add(this.btnForgotPassword);
			this.pnlMain.Controls.Add(this.btnLogin);
			this.pnlMain.Controls.Add(this.txtUsername);
			this.pnlMain.Controls.Add(this.txtPassword);
			this.pnlMain.Controls.Add(this.label2);
			this.pnlMain.Controls.Add(this.label1);
			this.pnlMain.Controls.Add(this.pnlHeader);
			this.pnlMain.Controls.Add(this.pnlFooter);
			this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.pnlMain.Location = new System.Drawing.Point(0, 0);
			this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Size = new System.Drawing.Size(501, 342);
			this.pnlMain.TabIndex = 2;
			this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlMain_Paint);
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Dock = System.Windows.Forms.DockStyle.Top;
			this.label6.Font = new System.Drawing.Font("Monadi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(0, 24);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(501, 87);
			this.label6.TabIndex = 14;
			this.label6.Text = "شركة النيل";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Questv1", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.Image = global::NileInc.Properties.Resources.Login32px;
			this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnLogin.Location = new System.Drawing.Point(56, 216);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(259, 41);
			this.btnLogin.TabIndex = 3;
			this.btnLogin.Text = "تسجيل دخول";
			this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// txtUsername
			// 
			this.txtUsername.BackColor = System.Drawing.Color.White;
			this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtUsername.Font = new System.Drawing.Font("VIP Rawy Regular", 14F, System.Drawing.FontStyle.Bold);
			this.txtUsername.ForeColor = System.Drawing.Color.Black;
			this.txtUsername.Location = new System.Drawing.Point(56, 124);
			this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(259, 27);
			this.txtUsername.TabIndex = 2;
			this.txtUsername.TextChanged += new System.EventHandler(this.TxtUsername_TextChanged);
			this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
			// 
			// txtPassword
			// 
			this.txtPassword.BackColor = System.Drawing.Color.White;
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPassword.Font = new System.Drawing.Font("VIP Rawy Regular", 14F, System.Drawing.FontStyle.Bold);
			this.txtPassword.ForeColor = System.Drawing.Color.Black;
			this.txtPassword.Location = new System.Drawing.Point(56, 170);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(259, 27);
			this.txtPassword.TabIndex = 2;
			this.txtPassword.UseSystemPasswordChar = true;
			this.txtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
			this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(501, 342);
			this.Controls.Add(this.pnlMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.LoginForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pnlHeader)).EndInit();
			this.pnlHeader.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCloseApp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlFooter)).EndInit();
			this.pnlFooter.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
			this.pnlMain.ResumeLayout(false);
			this.pnlMain.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private AVACustomImage.CustomImageButton btnCloseApp;
		private System.Windows.Forms.Label label3;
		private AVACustomImage.CustomImageButton btnMinimize;
		private System.Windows.Forms.LinkLabel btnForgotPassword;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private Syncfusion.Windows.Forms.Tools.GradientPanel pnlHeader;
		private Syncfusion.Windows.Forms.Tools.GradientPanel pnlFooter;
		private Syncfusion.Windows.Forms.Tools.GradientPanel pnlMain;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.LinkLabel lblRights;
	}
}
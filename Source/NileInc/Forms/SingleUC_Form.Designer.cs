namespace NileInc
{
	partial class SingleUC_Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleUC_Form));
			this.pnlHeader = new Syncfusion.Windows.Forms.Tools.GradientPanel();
			this.btnMinimize = new AVACustomImage.CustomImageButton();
			this.btnChangeSize = new AVACustomImage.CustomImageButton();
			this.btnCloseApp = new AVACustomImage.CustomImageButton();
			this.lblTitle = new System.Windows.Forms.Label();
			this.pnlDown = new Syncfusion.Windows.Forms.Tools.GradientPanel();
			this.pnlLeft = new Syncfusion.Windows.Forms.Tools.GradientPanel();
			this.pnlRight = new Syncfusion.Windows.Forms.Tools.GradientPanel();
			this.pnlMain = new Syncfusion.Windows.Forms.Tools.GradientPanel();
			((System.ComponentModel.ISupportInitialize)(this.pnlHeader)).BeginInit();
			this.pnlHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnChangeSize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCloseApp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlRight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlHeader
			// 
			this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(52)))), ((int)(((byte)(79)))));
			this.pnlHeader.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(116)))), ((int)(((byte)(190))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(155))))));
			this.pnlHeader.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
			this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.pnlHeader.Controls.Add(this.btnMinimize);
			this.pnlHeader.Controls.Add(this.btnChangeSize);
			this.pnlHeader.Controls.Add(this.btnCloseApp);
			this.pnlHeader.Controls.Add(this.lblTitle);
			this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlHeader.Location = new System.Drawing.Point(10, 0);
			this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new System.Drawing.Size(1340, 35);
			this.pnlHeader.TabIndex = 10;
			this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
			// 
			// btnMinimize
			// 
			this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
			this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnMinimize.Image = global::NileInc.Properties.Resources.MinimizeStart;
			this.btnMinimize.ImageHover = global::NileInc.Properties.Resources.MinimizeGIF;
			this.btnMinimize.ImageNormal = global::NileInc.Properties.Resources.MinimizeStart;
			this.btnMinimize.Location = new System.Drawing.Point(1262, 0);
			this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(26, 35);
			this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnMinimize.TabIndex = 11;
			this.btnMinimize.TabStop = false;
			this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
			// 
			// btnChangeSize
			// 
			this.btnChangeSize.BackColor = System.Drawing.Color.Transparent;
			this.btnChangeSize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnChangeSize.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnChangeSize.Image = global::NileInc.Properties.Resources.MaxmiziedPhoto;
			this.btnChangeSize.ImageHover = global::NileInc.Properties.Resources.MaxmiziedPhoto;
			this.btnChangeSize.ImageNormal = global::NileInc.Properties.Resources.MaxmiziedPhoto;
			this.btnChangeSize.Location = new System.Drawing.Point(1288, 0);
			this.btnChangeSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnChangeSize.Name = "btnChangeSize";
			this.btnChangeSize.Size = new System.Drawing.Size(26, 35);
			this.btnChangeSize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnChangeSize.TabIndex = 12;
			this.btnChangeSize.TabStop = false;
			this.btnChangeSize.Click += new System.EventHandler(this.btnChangeSize_Click);
			// 
			// btnCloseApp
			// 
			this.btnCloseApp.BackColor = System.Drawing.Color.Transparent;
			this.btnCloseApp.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCloseApp.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnCloseApp.Image = global::NileInc.Properties.Resources.CloseNormal;
			this.btnCloseApp.ImageHover = global::NileInc.Properties.Resources.CloseHover;
			this.btnCloseApp.ImageNormal = global::NileInc.Properties.Resources.CloseNormal;
			this.btnCloseApp.Location = new System.Drawing.Point(1314, 0);
			this.btnCloseApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCloseApp.Name = "btnCloseApp";
			this.btnCloseApp.Size = new System.Drawing.Size(26, 35);
			this.btnCloseApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnCloseApp.TabIndex = 13;
			this.btnCloseApp.TabStop = false;
			this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.BackColor = System.Drawing.Color.Transparent;
			this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblTitle.Font = new System.Drawing.Font("VIP Rawy Regular", 14F, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(0, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(99, 27);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "UC_NAME";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnlDown
			// 
			this.pnlDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(52)))), ((int)(((byte)(79)))));
			this.pnlDown.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(116)))), ((int)(((byte)(190))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(155))))));
			this.pnlDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.pnlDown.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlDown.Location = new System.Drawing.Point(10, 758);
			this.pnlDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pnlDown.Name = "pnlDown";
			this.pnlDown.Size = new System.Drawing.Size(1340, 10);
			this.pnlDown.TabIndex = 8;
			// 
			// pnlLeft
			// 
			this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(52)))), ((int)(((byte)(79)))));
			this.pnlLeft.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(155))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(116)))), ((int)(((byte)(190))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(155)))))});
			this.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlLeft.Location = new System.Drawing.Point(0, 0);
			this.pnlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pnlLeft.Name = "pnlLeft";
			this.pnlLeft.Size = new System.Drawing.Size(10, 768);
			this.pnlLeft.TabIndex = 11;
			// 
			// pnlRight
			// 
			this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(52)))), ((int)(((byte)(79)))));
			this.pnlRight.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(155))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(116)))), ((int)(((byte)(190))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(155)))))});
			this.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlRight.Location = new System.Drawing.Point(1350, 0);
			this.pnlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pnlRight.Name = "pnlRight";
			this.pnlRight.Size = new System.Drawing.Size(10, 768);
			this.pnlRight.TabIndex = 9;
			// 
			// pnlMain
			// 
			this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMain.Location = new System.Drawing.Point(10, 35);
			this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Size = new System.Drawing.Size(1340, 723);
			this.pnlMain.TabIndex = 12;
			// 
			// SingleUC_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1360, 768);
			this.Controls.Add(this.pnlMain);
			this.Controls.Add(this.pnlHeader);
			this.Controls.Add(this.pnlDown);
			this.Controls.Add(this.pnlLeft);
			this.Controls.Add(this.pnlRight);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SingleUC_Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SingleUC_Form";
			this.SizeChanged += new System.EventHandler(this.SingleUC_Form_SizeChanged);
			((System.ComponentModel.ISupportInitialize)(this.pnlHeader)).EndInit();
			this.pnlHeader.ResumeLayout(false);
			this.pnlHeader.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnChangeSize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCloseApp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlRight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Syncfusion.Windows.Forms.Tools.GradientPanel pnlHeader;
		private AVACustomImage.CustomImageButton btnMinimize;
		private AVACustomImage.CustomImageButton btnChangeSize;
		private AVACustomImage.CustomImageButton btnCloseApp;
		private System.Windows.Forms.Label lblTitle;
		private Syncfusion.Windows.Forms.Tools.GradientPanel pnlDown;
		private Syncfusion.Windows.Forms.Tools.GradientPanel pnlLeft;
		private Syncfusion.Windows.Forms.Tools.GradientPanel pnlRight;
		private Syncfusion.Windows.Forms.Tools.GradientPanel pnlMain;
	}
}
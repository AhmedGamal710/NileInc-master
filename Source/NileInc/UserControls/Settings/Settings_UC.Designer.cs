namespace NileInc
{
	partial class Settings_UC
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
			this.btnDegrees = new System.Windows.Forms.Button();
			this.btnDepartments = new System.Windows.Forms.Button();
			this.btnSalaries = new System.Windows.Forms.Button();
			this.tlpMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpMain
			// 
			this.tlpMain.ColumnCount = 7;
			this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.000999F));
			this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.66533F));
			this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.001F));
			this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.66533F));
			this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.001F));
			this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.66533F));
			this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.001F));
			this.tlpMain.Controls.Add(this.btnSalaries, 1, 1);
			this.tlpMain.Controls.Add(this.btnDegrees, 3, 1);
			this.tlpMain.Controls.Add(this.btnDepartments, 5, 1);
			this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpMain.Location = new System.Drawing.Point(0, 0);
			this.tlpMain.Name = "tlpMain";
			this.tlpMain.RowCount = 9;
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.25F));
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.25F));
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.25F));
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.25F));
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
			this.tlpMain.Size = new System.Drawing.Size(1135, 655);
			this.tlpMain.TabIndex = 1;
			// 
			// btnDegrees
			// 
			this.btnDegrees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
			this.btnDegrees.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnDegrees.FlatAppearance.BorderSize = 0;
			this.btnDegrees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDegrees.Font = new System.Drawing.Font("Questv1", 18F);
			this.btnDegrees.ForeColor = System.Drawing.Color.White;
			this.btnDegrees.Image = global::NileInc.Properties.Resources.Degree100px;
			this.btnDegrees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDegrees.Location = new System.Drawing.Point(417, 21);
			this.btnDegrees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDegrees.Name = "btnDegrees";
			this.btnDegrees.Size = new System.Drawing.Size(296, 135);
			this.btnDegrees.TabIndex = 10;
			this.btnDegrees.Text = "ادارة الدرجات";
			this.btnDegrees.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnDegrees.UseVisualStyleBackColor = false;
			this.btnDegrees.Click += new System.EventHandler(this.BtnDegrees_Click);
			// 
			// btnDepartments
			// 
			this.btnDepartments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
			this.btnDepartments.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnDepartments.FlatAppearance.BorderSize = 0;
			this.btnDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDepartments.Font = new System.Drawing.Font("Questv1", 18F);
			this.btnDepartments.ForeColor = System.Drawing.Color.White;
			this.btnDepartments.Image = global::NileInc.Properties.Resources.Department100px;
			this.btnDepartments.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDepartments.Location = new System.Drawing.Point(775, 21);
			this.btnDepartments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDepartments.Name = "btnDepartments";
			this.btnDepartments.Size = new System.Drawing.Size(296, 135);
			this.btnDepartments.TabIndex = 9;
			this.btnDepartments.Text = "ادارة الاقسام";
			this.btnDepartments.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnDepartments.UseVisualStyleBackColor = false;
			this.btnDepartments.Click += new System.EventHandler(this.BtnDepartments_Click);
			// 
			// btnSalaries
			// 
			this.btnSalaries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
			this.btnSalaries.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnSalaries.FlatAppearance.BorderSize = 0;
			this.btnSalaries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalaries.Font = new System.Drawing.Font("Questv1", 18F);
			this.btnSalaries.ForeColor = System.Drawing.Color.White;
			this.btnSalaries.Image = global::NileInc.Properties.Resources.Salary100px;
			this.btnSalaries.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalaries.Location = new System.Drawing.Point(59, 21);
			this.btnSalaries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSalaries.Name = "btnSalaries";
			this.btnSalaries.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
			this.btnSalaries.Size = new System.Drawing.Size(296, 135);
			this.btnSalaries.TabIndex = 11;
			this.btnSalaries.Text = "كشف المرتبات";
			this.btnSalaries.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnSalaries.UseVisualStyleBackColor = false;
			this.btnSalaries.Click += new System.EventHandler(this.BtnSalaries_Click);
			// 
			// Settings_UC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tlpMain);
			this.Name = "Settings_UC";
			this.Size = new System.Drawing.Size(1135, 655);
			this.Load += new System.EventHandler(this.Settings_UC_Load);
			this.tlpMain.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlpMain;
		private System.Windows.Forms.Button btnDepartments;
		private System.Windows.Forms.Button btnDegrees;
		private System.Windows.Forms.Button btnSalaries;
	}
}

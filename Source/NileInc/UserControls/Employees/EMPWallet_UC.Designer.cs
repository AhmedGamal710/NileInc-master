namespace NileInc
{
	partial class EMPWallet_UC
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DocName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DocPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tlpFields = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.lblDocPath = new System.Windows.Forms.Label();
			this.txtDocName = new System.Windows.Forms.TextBox();
			this.tlpMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.tlpFields.SuspendLayout();
			this.tlpButtons.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpMain
			// 
			this.tlpMain.ColumnCount = 2;
			this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpMain.Controls.Add(this.dataGridView1, 0, 1);
			this.tlpMain.Controls.Add(this.groupBox1, 0, 0);
			this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpMain.Location = new System.Drawing.Point(0, 0);
			this.tlpMain.Name = "tlpMain";
			this.tlpMain.RowCount = 2;
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpMain.Size = new System.Drawing.Size(515, 652);
			this.tlpMain.TabIndex = 1;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(155)))));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(155)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Questv1", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DocName,
            this.DocPath});
			this.tlpMain.SetColumnSpan(this.dataGridView1, 2);
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(49)))), ((int)(((byte)(80)))));
			this.dataGridView1.Location = new System.Drawing.Point(3, 197);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Questv1", 12F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RoyalBlue;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView1.RowTemplate.Height = 40;
			this.dataGridView1.RowTemplate.ReadOnly = true;
			this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.Size = new System.Drawing.Size(509, 453);
			this.dataGridView1.TabIndex = 4;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			this.ID.Width = 65;
			// 
			// DocName
			// 
			this.DocName.DataPropertyName = "DocName";
			this.DocName.HeaderText = "الاسم";
			this.DocName.Name = "DocName";
			this.DocName.ReadOnly = true;
			this.DocName.Width = 95;
			// 
			// DocPath
			// 
			this.DocPath.DataPropertyName = "DocPath";
			this.DocPath.HeaderText = "DocPath";
			this.DocPath.Name = "DocPath";
			this.DocPath.ReadOnly = true;
			this.DocPath.Visible = false;
			this.DocPath.Width = 124;
			// 
			// groupBox1
			// 
			this.tlpMain.SetColumnSpan(this.groupBox1, 2);
			this.groupBox1.Controls.Add(this.tlpFields);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Font = new System.Drawing.Font("Questv1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.groupBox1.Size = new System.Drawing.Size(509, 189);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "بيانات الملف";
			// 
			// tlpFields
			// 
			this.tlpFields.ColumnCount = 3;
			this.tlpFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tlpFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
			this.tlpFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpFields.Controls.Add(this.label1, 0, 0);
			this.tlpFields.Controls.Add(this.btnBrowse, 0, 1);
			this.tlpFields.Controls.Add(this.tlpButtons, 2, 0);
			this.tlpFields.Controls.Add(this.lblDocPath, 1, 1);
			this.tlpFields.Controls.Add(this.txtDocName, 1, 0);
			this.tlpFields.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpFields.Location = new System.Drawing.Point(3, 36);
			this.tlpFields.Name = "tlpFields";
			this.tlpFields.RowCount = 2;
			this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
			this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpFields.Size = new System.Drawing.Size(503, 150);
			this.tlpFields.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(356, 3);
			this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 71);
			this.label1.TabIndex = 13;
			this.label1.Text = "اسم الملف*";
			// 
			// btnBrowse
			// 
			this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
			this.btnBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnBrowse.FlatAppearance.BorderSize = 0;
			this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBrowse.Font = new System.Drawing.Font("Questv1", 12F);
			this.btnBrowse.ForeColor = System.Drawing.Color.White;
			this.btnBrowse.Image = global::NileInc.Properties.Resources.Browse32px;
			this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBrowse.Location = new System.Drawing.Point(356, 76);
			this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(144, 72);
			this.btnBrowse.TabIndex = 12;
			this.btnBrowse.Text = "استعراض*";
			this.btnBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBrowse.UseVisualStyleBackColor = false;
			this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
			// 
			// tlpButtons
			// 
			this.tlpButtons.ColumnCount = 1;
			this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpButtons.Controls.Add(this.btnAdd, 0, 0);
			this.tlpButtons.Controls.Add(this.btnDelete, 0, 1);
			this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpButtons.Location = new System.Drawing.Point(3, 3);
			this.tlpButtons.Name = "tlpButtons";
			this.tlpButtons.RowCount = 1;
			this.tlpFields.SetRowSpan(this.tlpButtons, 2);
			this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpButtons.Size = new System.Drawing.Size(121, 144);
			this.tlpButtons.TabIndex = 2;
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
			this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Questv1", 12F);
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Image = global::NileInc.Properties.Resources.Add32px;
			this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdd.Location = new System.Drawing.Point(3, 2);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(115, 68);
			this.btnAdd.TabIndex = 10;
			this.btnAdd.Text = "اضافة";
			this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
			this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Questv1", 12F);
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Image = global::NileInc.Properties.Resources.Delete32px;
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDelete.Location = new System.Drawing.Point(3, 74);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(115, 68);
			this.btnDelete.TabIndex = 11;
			this.btnDelete.Text = "حذف";
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
			// 
			// lblDocPath
			// 
			this.lblDocPath.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblDocPath.Font = new System.Drawing.Font("Questv1", 10F);
			this.lblDocPath.Location = new System.Drawing.Point(130, 77);
			this.lblDocPath.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.lblDocPath.Name = "lblDocPath";
			this.lblDocPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDocPath.Size = new System.Drawing.Size(220, 73);
			this.lblDocPath.TabIndex = 3;
			this.lblDocPath.Text = "Path";
			// 
			// txtDocName
			// 
			this.txtDocName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtDocName.Location = new System.Drawing.Point(130, 3);
			this.txtDocName.Name = "txtDocName";
			this.txtDocName.Size = new System.Drawing.Size(220, 40);
			this.txtDocName.TabIndex = 14;
			this.txtDocName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDocName_KeyDown);
			// 
			// EMPWallet_UC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tlpMain);
			this.Name = "EMPWallet_UC";
			this.Size = new System.Drawing.Size(515, 652);
			this.tlpMain.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.tlpFields.ResumeLayout(false);
			this.tlpFields.PerformLayout();
			this.tlpButtons.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlpMain;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn DocName;
		private System.Windows.Forms.DataGridViewTextBoxColumn DocPath;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TableLayoutPanel tlpFields;
		private System.Windows.Forms.TableLayoutPanel tlpButtons;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.Label lblDocPath;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtDocName;
	}
}

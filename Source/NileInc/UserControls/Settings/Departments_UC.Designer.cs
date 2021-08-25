namespace NileInc
{
	partial class Departments_UC
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
			this.DEPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DEPName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DEPNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dbDepartmentsData = new System.Windows.Forms.GroupBox();
			this.tlpFields = new System.Windows.Forms.TableLayoutPanel();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnConfig = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.tlpMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.dbDepartmentsData.SuspendLayout();
			this.tlpFields.SuspendLayout();
			this.tlpButtons.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpMain
			// 
			this.tlpMain.ColumnCount = 2;
			this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpMain.Controls.Add(this.dataGridView1, 0, 2);
			this.tlpMain.Controls.Add(this.dbDepartmentsData, 0, 1);
			this.tlpMain.Controls.Add(this.groupBox1, 0, 0);
			this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpMain.Location = new System.Drawing.Point(0, 0);
			this.tlpMain.Name = "tlpMain";
			this.tlpMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.tlpMain.RowCount = 3;
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpMain.Size = new System.Drawing.Size(496, 641);
			this.tlpMain.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(155)))));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.DEPID,
            this.DEPName,
            this.DEPNotes});
			this.tlpMain.SetColumnSpan(this.dataGridView1, 2);
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(49)))), ((int)(((byte)(80)))));
			this.dataGridView1.Location = new System.Drawing.Point(3, 322);
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
			this.dataGridView1.Size = new System.Drawing.Size(490, 317);
			this.dataGridView1.TabIndex = 2;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
			// 
			// DEPID
			// 
			this.DEPID.DataPropertyName = "DEPID";
			this.DEPID.HeaderText = "EMPID";
			this.DEPID.Name = "DEPID";
			this.DEPID.ReadOnly = true;
			this.DEPID.Visible = false;
			this.DEPID.Width = 109;
			// 
			// DEPName
			// 
			this.DEPName.DataPropertyName = "DEPName";
			this.DEPName.HeaderText = "الاسم";
			this.DEPName.Name = "DEPName";
			this.DEPName.ReadOnly = true;
			this.DEPName.Width = 95;
			// 
			// DEPNotes
			// 
			this.DEPNotes.DataPropertyName = "DEPNotes";
			this.DEPNotes.HeaderText = "ملاحظات";
			this.DEPNotes.Name = "DEPNotes";
			this.DEPNotes.ReadOnly = true;
			// 
			// dbDepartmentsData
			// 
			this.tlpMain.SetColumnSpan(this.dbDepartmentsData, 2);
			this.dbDepartmentsData.Controls.Add(this.tlpFields);
			this.dbDepartmentsData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dbDepartmentsData.Font = new System.Drawing.Font("Questv1", 14F);
			this.dbDepartmentsData.Location = new System.Drawing.Point(3, 99);
			this.dbDepartmentsData.Name = "dbDepartmentsData";
			this.dbDepartmentsData.Size = new System.Drawing.Size(490, 218);
			this.dbDepartmentsData.TabIndex = 0;
			this.dbDepartmentsData.TabStop = false;
			this.dbDepartmentsData.Text = "بيانات القسم";
			// 
			// tlpFields
			// 
			this.tlpFields.ColumnCount = 3;
			this.tlpFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
			this.tlpFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.84615F));
			this.tlpFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
			this.tlpFields.Controls.Add(this.txtNotes, 1, 1);
			this.tlpFields.Controls.Add(this.tlpButtons, 2, 0);
			this.tlpFields.Controls.Add(this.label1, 0, 0);
			this.tlpFields.Controls.Add(this.label2, 0, 1);
			this.tlpFields.Controls.Add(this.txtName, 1, 0);
			this.tlpFields.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpFields.Location = new System.Drawing.Point(3, 35);
			this.tlpFields.Name = "tlpFields";
			this.tlpFields.RowCount = 3;
			this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpFields.Size = new System.Drawing.Size(484, 180);
			this.tlpFields.TabIndex = 0;
			// 
			// txtNotes
			// 
			this.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtNotes.Location = new System.Drawing.Point(116, 63);
			this.txtNotes.Multiline = true;
			this.txtNotes.Name = "txtNotes";
			this.tlpFields.SetRowSpan(this.txtNotes, 2);
			this.txtNotes.Size = new System.Drawing.Size(254, 114);
			this.txtNotes.TabIndex = 4;
			// 
			// tlpButtons
			// 
			this.tlpButtons.ColumnCount = 1;
			this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpButtons.Controls.Add(this.btnAdd, 0, 0);
			this.tlpButtons.Controls.Add(this.btnEdit, 0, 1);
			this.tlpButtons.Controls.Add(this.btnDelete, 0, 2);
			this.tlpButtons.Controls.Add(this.btnConfig, 0, 3);
			this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpButtons.Location = new System.Drawing.Point(3, 3);
			this.tlpButtons.Name = "tlpButtons";
			this.tlpButtons.RowCount = 4;
			this.tlpFields.SetRowSpan(this.tlpButtons, 3);
			this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpButtons.Size = new System.Drawing.Size(107, 174);
			this.tlpButtons.TabIndex = 0;
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
			this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnAdd.Enabled = false;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Questv1", 10F);
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Image = global::NileInc.Properties.Resources.AddBlack25px;
			this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdd.Location = new System.Drawing.Point(3, 2);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(101, 39);
			this.btnAdd.TabIndex = 10;
			this.btnAdd.Text = "اضافة";
			this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
			this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnEdit.FlatAppearance.BorderSize = 0;
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.Font = new System.Drawing.Font("Questv1", 10F);
			this.btnEdit.ForeColor = System.Drawing.Color.White;
			this.btnEdit.Image = global::NileInc.Properties.Resources.Edit25px;
			this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEdit.Location = new System.Drawing.Point(3, 45);
			this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(101, 39);
			this.btnEdit.TabIndex = 11;
			this.btnEdit.Text = "تعديل";
			this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
			this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Questv1", 10F);
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Image = global::NileInc.Properties.Resources.Delete25px;
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDelete.Location = new System.Drawing.Point(3, 88);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(101, 39);
			this.btnDelete.TabIndex = 11;
			this.btnDelete.Text = "حذف";
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
			// 
			// btnConfig
			// 
			this.btnConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
			this.btnConfig.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnConfig.FlatAppearance.BorderSize = 0;
			this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConfig.Font = new System.Drawing.Font("Questv1", 10F);
			this.btnConfig.ForeColor = System.Drawing.Color.White;
			this.btnConfig.Image = global::NileInc.Properties.Resources.Erase25px;
			this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnConfig.Location = new System.Drawing.Point(3, 131);
			this.btnConfig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnConfig.Name = "btnConfig";
			this.btnConfig.Size = new System.Drawing.Size(101, 41);
			this.btnConfig.TabIndex = 11;
			this.btnConfig.Text = "تهيئة";
			this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnConfig.UseVisualStyleBackColor = false;
			this.btnConfig.Click += new System.EventHandler(this.BtnConfig_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(376, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 60);
			this.label1.TabIndex = 1;
			this.label1.Text = "الاسم*";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(376, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 60);
			this.label2.TabIndex = 2;
			this.label2.Text = "ملاحظات";
			// 
			// txtName
			// 
			this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtName.Location = new System.Drawing.Point(116, 3);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(254, 39);
			this.txtName.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.tlpMain.SetColumnSpan(this.groupBox1, 2);
			this.groupBox1.Controls.Add(this.txtSearch);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Font = new System.Drawing.Font("Questv1", 14F);
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(490, 90);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "البحث";
			// 
			// txtSearch
			// 
			this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtSearch.ForeColor = System.Drawing.Color.Silver;
			this.txtSearch.Location = new System.Drawing.Point(3, 35);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(484, 39);
			this.txtSearch.TabIndex = 0;
			this.txtSearch.Text = "ادخل اسم القسم";
			this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
			this.txtSearch.Enter += new System.EventHandler(this.TxtSearch_Enter);
			this.txtSearch.Leave += new System.EventHandler(this.TxtSearch_Leave);
			// 
			// Departments_UC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.tlpMain);
			this.Name = "Departments_UC";
			this.Size = new System.Drawing.Size(496, 641);
			this.tlpMain.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.dbDepartmentsData.ResumeLayout(false);
			this.tlpFields.ResumeLayout(false);
			this.tlpFields.PerformLayout();
			this.tlpButtons.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlpMain;
		private System.Windows.Forms.GroupBox dbDepartmentsData;
		private System.Windows.Forms.TableLayoutPanel tlpFields;
		private System.Windows.Forms.TextBox txtNotes;
		private System.Windows.Forms.TableLayoutPanel tlpButtons;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnConfig;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn DEPID;
		private System.Windows.Forms.DataGridViewTextBoxColumn DEPName;
		private System.Windows.Forms.DataGridViewTextBoxColumn DEPNotes;
		private System.Windows.Forms.TextBox txtSearch;
	}
}

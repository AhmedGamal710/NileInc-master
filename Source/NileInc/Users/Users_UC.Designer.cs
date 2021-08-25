namespace NileInc
{
	partial class Users_UC
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
			this.dgvUsers = new System.Windows.Forms.DataGridView();
			this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Permissionn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Answer1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Answer2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Answer3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Answer4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tlpInstructions = new System.Windows.Forms.TableLayoutPanel();
			this.label13 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tlpEMPFields = new System.Windows.Forms.TableLayoutPanel();
			this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnConfig = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtConfirmPassword = new System.Windows.Forms.TextBox();
			this.txtAnswer1 = new System.Windows.Forms.TextBox();
			this.txtAnswer2 = new System.Windows.Forms.TextBox();
			this.txtAnswer3 = new System.Windows.Forms.TextBox();
			this.txtAnswer4 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.chShowPassword = new System.Windows.Forms.CheckBox();
			this.lblUserNameStatus = new System.Windows.Forms.Label();
			this.lblPasswordStatus = new System.Windows.Forms.Label();
			this.cbPermissions = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.tlpMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
			this.tlpInstructions.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tlpEMPFields.SuspendLayout();
			this.tlpButtons.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpMain
			// 
			this.tlpMain.ColumnCount = 2;
			this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tlpMain.Controls.Add(this.dgvUsers, 0, 2);
			this.tlpMain.Controls.Add(this.tlpInstructions, 1, 0);
			this.tlpMain.Controls.Add(this.groupBox2, 0, 1);
			this.tlpMain.Controls.Add(this.groupBox1, 0, 0);
			this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpMain.Location = new System.Drawing.Point(0, 0);
			this.tlpMain.Name = "tlpMain";
			this.tlpMain.RowCount = 3;
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47F));
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tlpMain.Size = new System.Drawing.Size(1092, 716);
			this.tlpMain.TabIndex = 1;
			// 
			// dgvUsers
			// 
			this.dgvUsers.AllowUserToAddRows = false;
			this.dgvUsers.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(155)))));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgvUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
			this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(155)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Questv1", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.UserName,
            this.Permissionn,
            this.Answer1,
            this.Answer2,
            this.Answer3,
            this.Answer4});
			this.tlpMain.SetColumnSpan(this.dgvUsers, 2);
			this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvUsers.EnableHeadersVisualStyles = false;
			this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(49)))), ((int)(((byte)(80)))));
			this.dgvUsers.Location = new System.Drawing.Point(3, 432);
			this.dgvUsers.MultiSelect = false;
			this.dgvUsers.Name = "dgvUsers";
			this.dgvUsers.ReadOnly = true;
			this.dgvUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(127)))), ((int)(((byte)(168)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("VIP Hakm Regular", 14F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(127)))), ((int)(((byte)(168)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Questv1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			this.dgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvUsers.RowTemplate.Height = 50;
			this.dgvUsers.Size = new System.Drawing.Size(1086, 281);
			this.dgvUsers.TabIndex = 2;
			this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsers_CellClick);
			// 
			// UserID
			// 
			this.UserID.DataPropertyName = "UserID";
			this.UserID.HeaderText = "UserID";
			this.UserID.Name = "UserID";
			this.UserID.ReadOnly = true;
			this.UserID.Visible = false;
			this.UserID.Width = 107;
			// 
			// UserName
			// 
			this.UserName.DataPropertyName = "UserName";
			this.UserName.HeaderText = "اسم المستخدم";
			this.UserName.Name = "UserName";
			this.UserName.ReadOnly = true;
			this.UserName.Width = 170;
			// 
			// Permissionn
			// 
			this.Permissionn.DataPropertyName = "Permission";
			this.Permissionn.HeaderText = "الصلاحية";
			this.Permissionn.Name = "Permissionn";
			this.Permissionn.ReadOnly = true;
			this.Permissionn.Width = 109;
			// 
			// Answer1
			// 
			this.Answer1.DataPropertyName = "Answer1";
			this.Answer1.HeaderText = "اجابة 1";
			this.Answer1.Name = "Answer1";
			this.Answer1.ReadOnly = true;
			this.Answer1.Width = 89;
			// 
			// Answer2
			// 
			this.Answer2.DataPropertyName = "Answer2";
			this.Answer2.HeaderText = "اجابة 2";
			this.Answer2.Name = "Answer2";
			this.Answer2.ReadOnly = true;
			this.Answer2.Width = 92;
			// 
			// Answer3
			// 
			this.Answer3.DataPropertyName = "Answer3";
			this.Answer3.HeaderText = "اجابة 3";
			this.Answer3.Name = "Answer3";
			this.Answer3.ReadOnly = true;
			this.Answer3.Width = 92;
			// 
			// Answer4
			// 
			this.Answer4.DataPropertyName = "Answer4";
			this.Answer4.HeaderText = "اجابة 4";
			this.Answer4.Name = "Answer4";
			this.Answer4.ReadOnly = true;
			this.Answer4.Width = 93;
			// 
			// tlpInstructions
			// 
			this.tlpInstructions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(162)))), ((int)(((byte)(219)))));
			this.tlpInstructions.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
			this.tlpInstructions.ColumnCount = 1;
			this.tlpInstructions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpInstructions.Controls.Add(this.label13, 0, 0);
			this.tlpInstructions.Controls.Add(this.label15, 0, 4);
			this.tlpInstructions.Controls.Add(this.label17, 0, 3);
			this.tlpInstructions.Controls.Add(this.label16, 0, 2);
			this.tlpInstructions.Controls.Add(this.label14, 0, 1);
			this.tlpInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpInstructions.Location = new System.Drawing.Point(3, 2);
			this.tlpInstructions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tlpInstructions.Name = "tlpInstructions";
			this.tlpInstructions.RowCount = 5;
			this.tlpMain.SetRowSpan(this.tlpInstructions, 2);
			this.tlpInstructions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.27719F));
			this.tlpInstructions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18116F));
			this.tlpInstructions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18116F));
			this.tlpInstructions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18116F));
			this.tlpInstructions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.17934F));
			this.tlpInstructions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpInstructions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpInstructions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpInstructions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpInstructions.Size = new System.Drawing.Size(322, 425);
			this.tlpInstructions.TabIndex = 5;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
			this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label13.Font = new System.Drawing.Font("Questv1", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.White;
			this.label13.Location = new System.Drawing.Point(6, 3);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(310, 111);
			this.label13.TabIndex = 2;
			this.label13.Text = "اسئلة الامان";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.White;
			this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label15.Font = new System.Drawing.Font("Questv1", 14F, System.Drawing.FontStyle.Bold);
			this.label15.ForeColor = System.Drawing.Color.Black;
			this.label15.Location = new System.Drawing.Point(6, 345);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(310, 77);
			this.label15.TabIndex = 6;
			this.label15.Text = "4- سيارتك المفضلة";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.White;
			this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label17.Font = new System.Drawing.Font("Questv1", 14F, System.Drawing.FontStyle.Bold);
			this.label17.ForeColor = System.Drawing.Color.Black;
			this.label17.Location = new System.Drawing.Point(6, 269);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(310, 73);
			this.label17.TabIndex = 5;
			this.label17.Text = "3- بطل الطفولة";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.White;
			this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label16.Font = new System.Drawing.Font("Questv1", 14F, System.Drawing.FontStyle.Bold);
			this.label16.ForeColor = System.Drawing.Color.Black;
			this.label16.Location = new System.Drawing.Point(6, 193);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(310, 73);
			this.label16.TabIndex = 4;
			this.label16.Text = "2- فيلمك المفضل";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.White;
			this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label14.Font = new System.Drawing.Font("Questv1", 14F, System.Drawing.FontStyle.Bold);
			this.label14.ForeColor = System.Drawing.Color.Black;
			this.label14.Location = new System.Drawing.Point(6, 117);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(310, 73);
			this.label14.TabIndex = 3;
			this.label14.Text = "1- اسم صديق الطفولة";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tlpEMPFields);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Font = new System.Drawing.Font("Questv1", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(331, 96);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(758, 330);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "بيانات المستخدم";
			// 
			// tlpEMPFields
			// 
			this.tlpEMPFields.ColumnCount = 4;
			this.tlpEMPFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tlpEMPFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
			this.tlpEMPFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tlpEMPFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlpEMPFields.Controls.Add(this.tlpButtons, 3, 0);
			this.tlpEMPFields.Controls.Add(this.label1, 0, 0);
			this.tlpEMPFields.Controls.Add(this.label2, 0, 1);
			this.tlpEMPFields.Controls.Add(this.txtUsername, 1, 0);
			this.tlpEMPFields.Controls.Add(this.txtPassword, 1, 1);
			this.tlpEMPFields.Controls.Add(this.label7, 0, 2);
			this.tlpEMPFields.Controls.Add(this.txtConfirmPassword, 1, 2);
			this.tlpEMPFields.Controls.Add(this.txtAnswer1, 1, 4);
			this.tlpEMPFields.Controls.Add(this.txtAnswer2, 1, 5);
			this.tlpEMPFields.Controls.Add(this.txtAnswer3, 1, 6);
			this.tlpEMPFields.Controls.Add(this.txtAnswer4, 1, 7);
			this.tlpEMPFields.Controls.Add(this.label3, 0, 3);
			this.tlpEMPFields.Controls.Add(this.label4, 0, 5);
			this.tlpEMPFields.Controls.Add(this.label5, 0, 4);
			this.tlpEMPFields.Controls.Add(this.label6, 0, 6);
			this.tlpEMPFields.Controls.Add(this.label8, 0, 7);
			this.tlpEMPFields.Controls.Add(this.chShowPassword, 2, 1);
			this.tlpEMPFields.Controls.Add(this.lblUserNameStatus, 2, 0);
			this.tlpEMPFields.Controls.Add(this.lblPasswordStatus, 2, 2);
			this.tlpEMPFields.Controls.Add(this.cbPermissions, 1, 3);
			this.tlpEMPFields.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpEMPFields.Location = new System.Drawing.Point(3, 36);
			this.tlpEMPFields.Name = "tlpEMPFields";
			this.tlpEMPFields.RowCount = 8;
			this.tlpEMPFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11069F));
			this.tlpEMPFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11069F));
			this.tlpEMPFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11069F));
			this.tlpEMPFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11069F));
			this.tlpEMPFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11069F));
			this.tlpEMPFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11069F));
			this.tlpEMPFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11069F));
			this.tlpEMPFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11403F));
			this.tlpEMPFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpEMPFields.Size = new System.Drawing.Size(752, 291);
			this.tlpEMPFields.TabIndex = 5;
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
			this.tlpEMPFields.SetRowSpan(this.tlpButtons, 8);
			this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpButtons.Size = new System.Drawing.Size(146, 285);
			this.tlpButtons.TabIndex = 4;
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
			this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnAdd.Enabled = false;
			this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(127)))), ((int)(((byte)(168)))));
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(127)))), ((int)(((byte)(168)))));
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Questv1", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Image = global::NileInc.Properties.Resources.Add32px;
			this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdd.Location = new System.Drawing.Point(3, 2);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(140, 67);
			this.btnAdd.TabIndex = 14;
			this.btnAdd.Text = "اضافة";
			this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
			this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(127)))), ((int)(((byte)(168)))));
			this.btnEdit.FlatAppearance.BorderSize = 0;
			this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(127)))), ((int)(((byte)(168)))));
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.Font = new System.Drawing.Font("Questv1", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.ForeColor = System.Drawing.Color.White;
			this.btnEdit.Image = global::NileInc.Properties.Resources.Edit32px;
			this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEdit.Location = new System.Drawing.Point(3, 73);
			this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(140, 67);
			this.btnEdit.TabIndex = 15;
			this.btnEdit.Text = "تعديل";
			this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
			this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(127)))), ((int)(((byte)(168)))));
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(127)))), ((int)(((byte)(168)))));
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Questv1", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Image = global::NileInc.Properties.Resources.Delete32px;
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDelete.Location = new System.Drawing.Point(3, 144);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(140, 67);
			this.btnDelete.TabIndex = 15;
			this.btnDelete.Text = "حذف";
			this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
			// 
			// btnConfig
			// 
			this.btnConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
			this.btnConfig.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnConfig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(127)))), ((int)(((byte)(168)))));
			this.btnConfig.FlatAppearance.BorderSize = 0;
			this.btnConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(127)))), ((int)(((byte)(168)))));
			this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConfig.Font = new System.Drawing.Font("Questv1", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConfig.ForeColor = System.Drawing.Color.White;
			this.btnConfig.Image = global::NileInc.Properties.Resources.Erase32px;
			this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnConfig.Location = new System.Drawing.Point(3, 215);
			this.btnConfig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnConfig.Name = "btnConfig";
			this.btnConfig.Size = new System.Drawing.Size(140, 68);
			this.btnConfig.TabIndex = 15;
			this.btnConfig.Text = "تهيئة";
			this.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnConfig.UseVisualStyleBackColor = false;
			this.btnConfig.Click += new System.EventHandler(this.BtnConfig_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Questv1", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(530, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(219, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "اسم المستخدم*";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Questv1", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(530, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(219, 36);
			this.label2.TabIndex = 0;
			this.label2.Text = "كلمة المرور*";
			// 
			// txtUsername
			// 
			this.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtUsername.Font = new System.Drawing.Font("Questv1", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsername.Location = new System.Drawing.Point(267, 3);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(257, 29);
			this.txtUsername.TabIndex = 1;
			this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
			// 
			// txtPassword
			// 
			this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtPassword.Font = new System.Drawing.Font("Questv1", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(267, 39);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(257, 29);
			this.txtPassword.TabIndex = 1;
			this.txtPassword.UseSystemPasswordChar = true;
			this.txtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Font = new System.Drawing.Font("Questv1", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(530, 72);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(219, 36);
			this.label7.TabIndex = 0;
			this.label7.Text = "تأكيد كلمة المرور*";
			// 
			// txtConfirmPassword
			// 
			this.txtConfirmPassword.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtConfirmPassword.Font = new System.Drawing.Font("Questv1", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtConfirmPassword.Location = new System.Drawing.Point(267, 75);
			this.txtConfirmPassword.Name = "txtConfirmPassword";
			this.txtConfirmPassword.Size = new System.Drawing.Size(257, 29);
			this.txtConfirmPassword.TabIndex = 1;
			this.txtConfirmPassword.UseSystemPasswordChar = true;
			this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
			// 
			// txtAnswer1
			// 
			this.txtAnswer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtAnswer1.Font = new System.Drawing.Font("Questv1", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAnswer1.Location = new System.Drawing.Point(267, 147);
			this.txtAnswer1.Name = "txtAnswer1";
			this.txtAnswer1.Size = new System.Drawing.Size(257, 29);
			this.txtAnswer1.TabIndex = 1;
			// 
			// txtAnswer2
			// 
			this.txtAnswer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtAnswer2.Font = new System.Drawing.Font("Questv1", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAnswer2.Location = new System.Drawing.Point(267, 183);
			this.txtAnswer2.Name = "txtAnswer2";
			this.txtAnswer2.Size = new System.Drawing.Size(257, 29);
			this.txtAnswer2.TabIndex = 1;
			// 
			// txtAnswer3
			// 
			this.txtAnswer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtAnswer3.Font = new System.Drawing.Font("Questv1", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAnswer3.Location = new System.Drawing.Point(267, 219);
			this.txtAnswer3.Name = "txtAnswer3";
			this.txtAnswer3.Size = new System.Drawing.Size(257, 29);
			this.txtAnswer3.TabIndex = 1;
			// 
			// txtAnswer4
			// 
			this.txtAnswer4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtAnswer4.Font = new System.Drawing.Font("Questv1", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAnswer4.Location = new System.Drawing.Point(267, 255);
			this.txtAnswer4.Name = "txtAnswer4";
			this.txtAnswer4.Size = new System.Drawing.Size(257, 29);
			this.txtAnswer4.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("Questv1", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(530, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(219, 36);
			this.label3.TabIndex = 0;
			this.label3.Text = "الصلاحية*";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Font = new System.Drawing.Font("Questv1", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(530, 180);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(219, 36);
			this.label4.TabIndex = 0;
			this.label4.Text = "اجابة الامان 2";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Questv1", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(530, 144);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(219, 36);
			this.label5.TabIndex = 0;
			this.label5.Text = "اجابة الامان 1";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Font = new System.Drawing.Font("Questv1", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(530, 216);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(219, 36);
			this.label6.TabIndex = 0;
			this.label6.Text = "اجابة الامان 3";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label8.Font = new System.Drawing.Font("Questv1", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(530, 252);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(219, 39);
			this.label8.TabIndex = 0;
			this.label8.Text = "اجابة الامان 4";
			// 
			// chShowPassword
			// 
			this.chShowPassword.AutoSize = true;
			this.chShowPassword.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chShowPassword.Font = new System.Drawing.Font("Questv1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chShowPassword.Location = new System.Drawing.Point(155, 39);
			this.chShowPassword.Name = "chShowPassword";
			this.chShowPassword.Size = new System.Drawing.Size(106, 30);
			this.chShowPassword.TabIndex = 5;
			this.chShowPassword.Text = "اظهار";
			this.chShowPassword.UseVisualStyleBackColor = true;
			this.chShowPassword.CheckedChanged += new System.EventHandler(this.chShowPassword_CheckedChanged);
			this.chShowPassword.TextChanged += new System.EventHandler(this.chShowPassword_CheckedChanged);
			// 
			// lblUserNameStatus
			// 
			this.lblUserNameStatus.AutoSize = true;
			this.lblUserNameStatus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblUserNameStatus.Font = new System.Drawing.Font("VIP Hakm Regular", 8F, System.Drawing.FontStyle.Bold);
			this.lblUserNameStatus.Location = new System.Drawing.Point(155, 0);
			this.lblUserNameStatus.Name = "lblUserNameStatus";
			this.lblUserNameStatus.Size = new System.Drawing.Size(106, 36);
			this.lblUserNameStatus.TabIndex = 6;
			// 
			// lblPasswordStatus
			// 
			this.lblPasswordStatus.AutoSize = true;
			this.lblPasswordStatus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblPasswordStatus.Font = new System.Drawing.Font("VIP Hakm Regular", 8F, System.Drawing.FontStyle.Bold);
			this.lblPasswordStatus.Location = new System.Drawing.Point(155, 72);
			this.lblPasswordStatus.Name = "lblPasswordStatus";
			this.lblPasswordStatus.Size = new System.Drawing.Size(106, 36);
			this.lblPasswordStatus.TabIndex = 6;
			// 
			// cbPermissions
			// 
			this.cbPermissions.BackColor = System.Drawing.Color.Silver;
			this.cbPermissions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbPermissions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPermissions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cbPermissions.Font = new System.Drawing.Font("VIP Hakm Regular", 12F, System.Drawing.FontStyle.Bold);
			this.cbPermissions.FormattingEnabled = true;
			this.cbPermissions.Location = new System.Drawing.Point(267, 111);
			this.cbPermissions.Name = "cbPermissions";
			this.cbPermissions.Size = new System.Drawing.Size(257, 38);
			this.cbPermissions.TabIndex = 10;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtSearch);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Font = new System.Drawing.Font("Questv1", 14.25F, System.Drawing.FontStyle.Bold);
			this.groupBox1.Location = new System.Drawing.Point(331, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(758, 87);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "البحث";
			// 
			// txtSearch
			// 
			this.txtSearch.Dock = System.Windows.Forms.DockStyle.Right;
			this.txtSearch.Font = new System.Drawing.Font("Questv1", 14.25F, System.Drawing.FontStyle.Bold);
			this.txtSearch.ForeColor = System.Drawing.Color.Silver;
			this.txtSearch.Location = new System.Drawing.Point(389, 36);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(366, 40);
			this.txtSearch.TabIndex = 0;
			this.txtSearch.Text = "بحث باسم المستخدم";
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
			this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
			// 
			// Users_UC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.tlpMain);
			this.Name = "Users_UC";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Size = new System.Drawing.Size(1092, 716);
			this.Load += new System.EventHandler(this.Users_UC_Load);
			this.tlpMain.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
			this.tlpInstructions.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.tlpEMPFields.ResumeLayout(false);
			this.tlpEMPFields.PerformLayout();
			this.tlpButtons.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlpMain;
		private System.Windows.Forms.TableLayoutPanel tlpInstructions;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TableLayoutPanel tlpEMPFields;
		private System.Windows.Forms.TableLayoutPanel tlpButtons;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnConfig;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtConfirmPassword;
		private System.Windows.Forms.TextBox txtAnswer1;
		private System.Windows.Forms.TextBox txtAnswer2;
		private System.Windows.Forms.TextBox txtAnswer3;
		private System.Windows.Forms.TextBox txtAnswer4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckBox chShowPassword;
		private System.Windows.Forms.Label lblUserNameStatus;
		private System.Windows.Forms.Label lblPasswordStatus;
		private System.Windows.Forms.ComboBox cbPermissions;
		private System.Windows.Forms.DataGridView dgvUsers;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Permissionn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Answer1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Answer2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Answer3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Answer4;
	}
}

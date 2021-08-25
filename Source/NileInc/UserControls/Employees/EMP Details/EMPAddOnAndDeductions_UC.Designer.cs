namespace NileInc
{
	partial class EMPAddOnAndDeductions_UC
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ValueFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RealValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tlpFields = new System.Windows.Forms.TableLayoutPanel();
			this.rbDiscount = new System.Windows.Forms.RadioButton();
			this.rbAdd = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.dtMonthDate = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.chPercentage = new System.Windows.Forms.CheckBox();
			this.numValue = new System.Windows.Forms.NumericUpDown();
			this.tlpValueOptions = new System.Windows.Forms.TableLayoutPanel();
			this.rbIncentives = new System.Windows.Forms.RadioButton();
			this.rbDaySalary = new System.Windows.Forms.RadioButton();
			this.rbMonSalary = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnCon = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tlpSearchMain = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.rbViewAll = new System.Windows.Forms.RadioButton();
			this.rbViewDeductions = new System.Windows.Forms.RadioButton();
			this.rbViewAdds = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.sfDateTimeEdit1 = new Syncfusion.WinForms.Input.SfDateTimeEdit();
			this.tlpMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.tlpFields.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numValue)).BeginInit();
			this.tlpValueOptions.SuspendLayout();
			this.tlpButtons.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tlpSearchMain.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpMain
			// 
			this.tlpMain.ColumnCount = 1;
			this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpMain.Controls.Add(this.dataGridView1, 0, 2);
			this.tlpMain.Controls.Add(this.groupBox1, 0, 1);
			this.tlpMain.Controls.Add(this.groupBox2, 0, 0);
			this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpMain.Location = new System.Drawing.Point(0, 0);
			this.tlpMain.Name = "tlpMain";
			this.tlpMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.tlpMain.RowCount = 3;
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.5F));
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.5F));
			this.tlpMain.Size = new System.Drawing.Size(733, 650);
			this.tlpMain.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(155)))));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(155)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Questv1", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Date,
            this.Type,
            this.Value,
            this.ValueFrom,
            this.RealValue,
            this.Notes});
			this.tlpMain.SetColumnSpan(this.dataGridView1, 2);
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(49)))), ((int)(((byte)(80)))));
			this.dataGridView1.Location = new System.Drawing.Point(3, 342);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Questv1", 12F);
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(2);
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.RoyalBlue;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
			this.dataGridView1.RowTemplate.Height = 40;
			this.dataGridView1.RowTemplate.ReadOnly = true;
			this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.Size = new System.Drawing.Size(727, 306);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			this.ID.Width = 109;
			// 
			// Date
			// 
			this.Date.DataPropertyName = "Date";
			this.Date.HeaderText = "التاريخ";
			this.Date.Name = "Date";
			this.Date.ReadOnly = true;
			this.Date.Width = 94;
			// 
			// Type
			// 
			this.Type.DataPropertyName = "Type";
			this.Type.HeaderText = "النوع";
			this.Type.Name = "Type";
			this.Type.ReadOnly = true;
			this.Type.Width = 85;
			// 
			// Value
			// 
			this.Value.DataPropertyName = "Value";
			this.Value.HeaderText = "القيمة";
			this.Value.Name = "Value";
			this.Value.ReadOnly = true;
			this.Value.Width = 96;
			// 
			// ValueFrom
			// 
			this.ValueFrom.DataPropertyName = "ValueFrom";
			this.ValueFrom.HeaderText = "القيمة من";
			this.ValueFrom.Name = "ValueFrom";
			this.ValueFrom.ReadOnly = true;
			this.ValueFrom.Width = 124;
			// 
			// RealValue
			// 
			this.RealValue.DataPropertyName = "RealValue";
			this.RealValue.HeaderText = "القيمة الفعلية";
			this.RealValue.Name = "RealValue";
			this.RealValue.ReadOnly = true;
			this.RealValue.Width = 157;
			// 
			// Notes
			// 
			this.Notes.DataPropertyName = "Notes";
			this.Notes.HeaderText = "ملاحظات";
			this.Notes.Name = "Notes";
			this.Notes.ReadOnly = true;
			this.Notes.Width = 118;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tlpFields);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Font = new System.Drawing.Font("Questv1", 14F);
			this.groupBox1.Location = new System.Drawing.Point(3, 116);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(727, 221);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "بيانات العلاوات و الخصومات";
			// 
			// tlpFields
			// 
			this.tlpFields.ColumnCount = 6;
			this.tlpFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.15913F));
			this.tlpFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.21217F));
			this.tlpFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.15913F));
			this.tlpFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.15913F));
			this.tlpFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.60597F));
			this.tlpFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.70448F));
			this.tlpFields.Controls.Add(this.rbDiscount, 2, 0);
			this.tlpFields.Controls.Add(this.rbAdd, 1, 0);
			this.tlpFields.Controls.Add(this.label4, 0, 0);
			this.tlpFields.Controls.Add(this.dtMonthDate, 1, 1);
			this.tlpFields.Controls.Add(this.label1, 0, 1);
			this.tlpFields.Controls.Add(this.label2, 0, 2);
			this.tlpFields.Controls.Add(this.label3, 0, 3);
			this.tlpFields.Controls.Add(this.chPercentage, 2, 2);
			this.tlpFields.Controls.Add(this.numValue, 1, 2);
			this.tlpFields.Controls.Add(this.tlpValueOptions, 1, 3);
			this.tlpFields.Controls.Add(this.label5, 3, 0);
			this.tlpFields.Controls.Add(this.txtNotes, 4, 0);
			this.tlpFields.Controls.Add(this.tlpButtons, 5, 0);
			this.tlpFields.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpFields.Font = new System.Drawing.Font("Questv1", 12F);
			this.tlpFields.Location = new System.Drawing.Point(3, 35);
			this.tlpFields.Name = "tlpFields";
			this.tlpFields.RowCount = 4;
			this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpFields.Size = new System.Drawing.Size(721, 183);
			this.tlpFields.TabIndex = 1;
			// 
			// rbDiscount
			// 
			this.rbDiscount.AutoSize = true;
			this.rbDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rbDiscount.Location = new System.Drawing.Point(360, 2);
			this.rbDiscount.Margin = new System.Windows.Forms.Padding(2);
			this.rbDiscount.Name = "rbDiscount";
			this.rbDiscount.Size = new System.Drawing.Size(105, 32);
			this.rbDiscount.TabIndex = 26;
			this.rbDiscount.TabStop = true;
			this.rbDiscount.Text = "خصم";
			this.rbDiscount.UseVisualStyleBackColor = true;
			// 
			// rbAdd
			// 
			this.rbAdd.AutoSize = true;
			this.rbAdd.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rbAdd.Location = new System.Drawing.Point(469, 2);
			this.rbAdd.Margin = new System.Windows.Forms.Padding(2);
			this.rbAdd.Name = "rbAdd";
			this.rbAdd.Size = new System.Drawing.Size(141, 32);
			this.rbAdd.TabIndex = 25;
			this.rbAdd.TabStop = true;
			this.rbAdd.Text = "علاوة";
			this.rbAdd.UseVisualStyleBackColor = true;
			this.rbAdd.CheckedChanged += new System.EventHandler(this.RbAdd_CheckedChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(617, 5);
			this.label4.Margin = new System.Windows.Forms.Padding(5);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(99, 26);
			this.label4.TabIndex = 24;
			this.label4.Text = "النوع*";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dtMonthDate
			// 
			this.tlpFields.SetColumnSpan(this.dtMonthDate, 2);
			this.dtMonthDate.CustomFormat = " dd/MM/yyyy";
			this.dtMonthDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtMonthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.dtMonthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtMonthDate.Location = new System.Drawing.Point(363, 41);
			this.dtMonthDate.Margin = new System.Windows.Forms.Padding(5);
			this.dtMonthDate.Name = "dtMonthDate";
			this.dtMonthDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dtMonthDate.Size = new System.Drawing.Size(244, 29);
			this.dtMonthDate.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(617, 41);
			this.label1.Margin = new System.Windows.Forms.Padding(5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 26);
			this.label1.TabIndex = 14;
			this.label1.Text = "التاريخ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(617, 77);
			this.label2.Margin = new System.Windows.Forms.Padding(5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 26);
			this.label2.TabIndex = 14;
			this.label2.Text = "القيمة*";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("Questv1", 12F);
			this.label3.Location = new System.Drawing.Point(617, 113);
			this.label3.Margin = new System.Windows.Forms.Padding(5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 65);
			this.label3.TabIndex = 14;
			this.label3.Text = "القيمة من*";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// chPercentage
			// 
			this.chPercentage.AutoSize = true;
			this.tlpFields.SetColumnSpan(this.chPercentage, 2);
			this.chPercentage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chPercentage.Location = new System.Drawing.Point(254, 77);
			this.chPercentage.Margin = new System.Windows.Forms.Padding(5);
			this.chPercentage.Name = "chPercentage";
			this.chPercentage.Size = new System.Drawing.Size(208, 26);
			this.chPercentage.TabIndex = 15;
			this.chPercentage.Text = "% نسبة مئوية";
			this.chPercentage.UseVisualStyleBackColor = true;
			this.chPercentage.CheckedChanged += new System.EventHandler(this.ChPercentage_CheckedChanged);
			// 
			// numValue
			// 
			this.numValue.DecimalPlaces = 2;
			this.numValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.numValue.Location = new System.Drawing.Point(467, 72);
			this.numValue.Margin = new System.Windows.Forms.Padding(0);
			this.numValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.numValue.Name = "numValue";
			this.numValue.Size = new System.Drawing.Size(145, 35);
			this.numValue.TabIndex = 16;
			this.numValue.Enter += new System.EventHandler(this.NumValue_Enter);
			this.numValue.Leave += new System.EventHandler(this.NumValue_Leave);
			// 
			// tlpValueOptions
			// 
			this.tlpValueOptions.ColumnCount = 2;
			this.tlpFields.SetColumnSpan(this.tlpValueOptions, 3);
			this.tlpValueOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpValueOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpValueOptions.Controls.Add(this.rbIncentives, 0, 1);
			this.tlpValueOptions.Controls.Add(this.rbDaySalary, 0, 0);
			this.tlpValueOptions.Controls.Add(this.rbMonSalary, 1, 0);
			this.tlpValueOptions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpValueOptions.Location = new System.Drawing.Point(252, 111);
			this.tlpValueOptions.Name = "tlpValueOptions";
			this.tlpValueOptions.RowCount = 2;
			this.tlpValueOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpValueOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpValueOptions.Size = new System.Drawing.Size(357, 69);
			this.tlpValueOptions.TabIndex = 18;
			// 
			// rbIncentives
			// 
			this.rbIncentives.AutoSize = true;
			this.rbIncentives.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rbIncentives.Location = new System.Drawing.Point(179, 34);
			this.rbIncentives.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
			this.rbIncentives.Name = "rbIncentives";
			this.rbIncentives.Size = new System.Drawing.Size(176, 35);
			this.rbIncentives.TabIndex = 19;
			this.rbIncentives.TabStop = true;
			this.rbIncentives.Text = "الحوافز";
			this.rbIncentives.UseVisualStyleBackColor = true;
			// 
			// rbDaySalary
			// 
			this.rbDaySalary.AutoSize = true;
			this.rbDaySalary.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rbDaySalary.Enabled = false;
			this.rbDaySalary.Location = new System.Drawing.Point(179, 0);
			this.rbDaySalary.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
			this.rbDaySalary.Name = "rbDaySalary";
			this.rbDaySalary.Size = new System.Drawing.Size(176, 34);
			this.rbDaySalary.TabIndex = 18;
			this.rbDaySalary.TabStop = true;
			this.rbDaySalary.Text = "مرتب اليوم";
			this.rbDaySalary.UseVisualStyleBackColor = true;
			// 
			// rbMonSalary
			// 
			this.rbMonSalary.AutoSize = true;
			this.rbMonSalary.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rbMonSalary.Location = new System.Drawing.Point(0, 0);
			this.rbMonSalary.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
			this.rbMonSalary.Name = "rbMonSalary";
			this.rbMonSalary.Size = new System.Drawing.Size(177, 34);
			this.rbMonSalary.TabIndex = 18;
			this.rbMonSalary.TabStop = true;
			this.rbMonSalary.Text = "مرتب الشهر";
			this.rbMonSalary.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Location = new System.Drawing.Point(254, 5);
			this.label5.Margin = new System.Windows.Forms.Padding(5);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(99, 26);
			this.label5.TabIndex = 21;
			this.label5.Text = "ملاحظات";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNotes
			// 
			this.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtNotes.Location = new System.Drawing.Point(111, 3);
			this.txtNotes.Multiline = true;
			this.txtNotes.Name = "txtNotes";
			this.tlpFields.SetRowSpan(this.txtNotes, 4);
			this.txtNotes.Size = new System.Drawing.Size(135, 177);
			this.txtNotes.TabIndex = 22;
			// 
			// tlpButtons
			// 
			this.tlpButtons.ColumnCount = 1;
			this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpButtons.Controls.Add(this.btnAdd, 0, 0);
			this.tlpButtons.Controls.Add(this.btnEdit, 0, 1);
			this.tlpButtons.Controls.Add(this.btnDel, 0, 2);
			this.tlpButtons.Controls.Add(this.btnCon, 0, 3);
			this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpButtons.Location = new System.Drawing.Point(3, 3);
			this.tlpButtons.Name = "tlpButtons";
			this.tlpButtons.RowCount = 4;
			this.tlpFields.SetRowSpan(this.tlpButtons, 4);
			this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpButtons.Size = new System.Drawing.Size(102, 177);
			this.tlpButtons.TabIndex = 23;
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
			this.btnAdd.Font = new System.Drawing.Font("VIP Hakm Regular", 10F, System.Drawing.FontStyle.Bold);
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Image = global::NileInc.Properties.Resources.AddBlack25px;
			this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdd.Location = new System.Drawing.Point(3, 2);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(96, 40);
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
			this.btnEdit.Font = new System.Drawing.Font("VIP Hakm Regular", 10F, System.Drawing.FontStyle.Bold);
			this.btnEdit.ForeColor = System.Drawing.Color.White;
			this.btnEdit.Image = global::NileInc.Properties.Resources.Edit25px;
			this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEdit.Location = new System.Drawing.Point(3, 46);
			this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(96, 40);
			this.btnEdit.TabIndex = 15;
			this.btnEdit.Text = "تعديل";
			this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
			// 
			// btnDel
			// 
			this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
			this.btnDel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(127)))), ((int)(((byte)(168)))));
			this.btnDel.FlatAppearance.BorderSize = 0;
			this.btnDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(127)))), ((int)(((byte)(168)))));
			this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDel.Font = new System.Drawing.Font("VIP Hakm Regular", 10F, System.Drawing.FontStyle.Bold);
			this.btnDel.ForeColor = System.Drawing.Color.White;
			this.btnDel.Image = global::NileInc.Properties.Resources.Delete25px;
			this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDel.Location = new System.Drawing.Point(3, 90);
			this.btnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(96, 40);
			this.btnDel.TabIndex = 15;
			this.btnDel.Text = "حذف";
			this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDel.UseVisualStyleBackColor = false;
			this.btnDel.Click += new System.EventHandler(this.BtnDel_Click);
			// 
			// btnCon
			// 
			this.btnCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
			this.btnCon.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(127)))), ((int)(((byte)(168)))));
			this.btnCon.FlatAppearance.BorderSize = 0;
			this.btnCon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(127)))), ((int)(((byte)(168)))));
			this.btnCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCon.Font = new System.Drawing.Font("VIP Hakm Regular", 10F, System.Drawing.FontStyle.Bold);
			this.btnCon.ForeColor = System.Drawing.Color.White;
			this.btnCon.Image = global::NileInc.Properties.Resources.Erase25px;
			this.btnCon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCon.Location = new System.Drawing.Point(3, 134);
			this.btnCon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCon.Name = "btnCon";
			this.btnCon.Size = new System.Drawing.Size(96, 41);
			this.btnCon.TabIndex = 15;
			this.btnCon.Text = "تهيئة";
			this.btnCon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCon.UseVisualStyleBackColor = false;
			this.btnCon.Click += new System.EventHandler(this.BtnCon_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tlpSearchMain);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Font = new System.Drawing.Font("Questv1", 14F);
			this.groupBox2.Location = new System.Drawing.Point(3, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(727, 107);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "البحث";
			// 
			// tlpSearchMain
			// 
			this.tlpSearchMain.ColumnCount = 3;
			this.tlpSearchMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlpSearchMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
			this.tlpSearchMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
			this.tlpSearchMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpSearchMain.Controls.Add(this.label6, 0, 0);
			this.tlpSearchMain.Controls.Add(this.groupBox3, 2, 0);
			this.tlpSearchMain.Controls.Add(this.sfDateTimeEdit1, 1, 0);
			this.tlpSearchMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpSearchMain.Location = new System.Drawing.Point(3, 35);
			this.tlpSearchMain.Name = "tlpSearchMain";
			this.tlpSearchMain.RowCount = 1;
			this.tlpSearchMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpSearchMain.Size = new System.Drawing.Size(721, 69);
			this.tlpSearchMain.TabIndex = 0;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.rbViewAll);
			this.groupBox3.Controls.Add(this.rbViewDeductions);
			this.groupBox3.Controls.Add(this.rbViewAdds);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Font = new System.Drawing.Font("Questv1", 12F);
			this.groupBox3.Location = new System.Drawing.Point(3, 3);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(247, 63);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "الرؤية";
			// 
			// rbViewAll
			// 
			this.rbViewAll.AutoSize = true;
			this.rbViewAll.Checked = true;
			this.rbViewAll.Dock = System.Windows.Forms.DockStyle.Right;
			this.rbViewAll.Font = new System.Drawing.Font("Questv1", 10F);
			this.rbViewAll.Location = new System.Drawing.Point(32, 31);
			this.rbViewAll.Margin = new System.Windows.Forms.Padding(5);
			this.rbViewAll.Name = "rbViewAll";
			this.rbViewAll.Size = new System.Drawing.Size(52, 29);
			this.rbViewAll.TabIndex = 28;
			this.rbViewAll.TabStop = true;
			this.rbViewAll.Text = "الكل";
			this.rbViewAll.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.rbViewAll.UseVisualStyleBackColor = true;
			this.rbViewAll.CheckedChanged += new System.EventHandler(this.RbViewAdds_CheckedChanged);
			// 
			// rbViewDeductions
			// 
			this.rbViewDeductions.AutoSize = true;
			this.rbViewDeductions.Dock = System.Windows.Forms.DockStyle.Right;
			this.rbViewDeductions.Font = new System.Drawing.Font("Questv1", 10F);
			this.rbViewDeductions.Location = new System.Drawing.Point(84, 31);
			this.rbViewDeductions.Margin = new System.Windows.Forms.Padding(5);
			this.rbViewDeductions.Name = "rbViewDeductions";
			this.rbViewDeductions.Size = new System.Drawing.Size(86, 29);
			this.rbViewDeductions.TabIndex = 27;
			this.rbViewDeductions.Text = "الخصومات";
			this.rbViewDeductions.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.rbViewDeductions.UseVisualStyleBackColor = true;
			this.rbViewDeductions.CheckedChanged += new System.EventHandler(this.RbViewAdds_CheckedChanged);
			// 
			// rbViewAdds
			// 
			this.rbViewAdds.AutoSize = true;
			this.rbViewAdds.Dock = System.Windows.Forms.DockStyle.Right;
			this.rbViewAdds.Font = new System.Drawing.Font("Questv1", 10F);
			this.rbViewAdds.Location = new System.Drawing.Point(170, 31);
			this.rbViewAdds.Margin = new System.Windows.Forms.Padding(5);
			this.rbViewAdds.Name = "rbViewAdds";
			this.rbViewAdds.Size = new System.Drawing.Size(74, 29);
			this.rbViewAdds.TabIndex = 26;
			this.rbViewAdds.Text = "العلاوات";
			this.rbViewAdds.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.rbViewAdds.UseVisualStyleBackColor = true;
			this.rbViewAdds.CheckedChanged += new System.EventHandler(this.RbViewAdds_CheckedChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Font = new System.Drawing.Font("Questv1", 14F);
			this.label6.Location = new System.Drawing.Point(582, 5);
			this.label6.Margin = new System.Windows.Forms.Padding(5);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(134, 59);
			this.label6.TabIndex = 15;
			this.label6.Text = "تاريخ الشهر";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// sfDateTimeEdit1
			// 
			this.sfDateTimeEdit1.AllowNull = true;
			this.sfDateTimeEdit1.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
			this.sfDateTimeEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sfDateTimeEdit1.DropDownPopupAlignment = Syncfusion.WinForms.Input.Enums.DropDownPopupAlignment.Right;
			this.sfDateTimeEdit1.Format = "MM-yyyy";
			this.sfDateTimeEdit1.Location = new System.Drawing.Point(256, 10);
			this.sfDateTimeEdit1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
			this.sfDateTimeEdit1.Name = "sfDateTimeEdit1";
			this.sfDateTimeEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.sfDateTimeEdit1.Size = new System.Drawing.Size(318, 49);
			this.sfDateTimeEdit1.TabIndex = 16;
			this.sfDateTimeEdit1.Value = new System.DateTime(2019, 7, 1, 0, 0, 0, 0);
			this.sfDateTimeEdit1.ValueChanged += new Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventHandler(this.SfDateTimeEdit1_ValueChanged);
			// 
			// EMPAddOnAndDeductions_UC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.tlpMain);
			this.Name = "EMPAddOnAndDeductions_UC";
			this.Size = new System.Drawing.Size(733, 650);
			this.tlpMain.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.tlpFields.ResumeLayout(false);
			this.tlpFields.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numValue)).EndInit();
			this.tlpValueOptions.ResumeLayout(false);
			this.tlpValueOptions.PerformLayout();
			this.tlpButtons.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.tlpSearchMain.ResumeLayout(false);
			this.tlpSearchMain.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlpMain;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TableLayoutPanel tlpFields;
		private System.Windows.Forms.DateTimePicker dtMonthDate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox chPercentage;
		private System.Windows.Forms.NumericUpDown numValue;
		private System.Windows.Forms.TableLayoutPanel tlpValueOptions;
		private System.Windows.Forms.RadioButton rbIncentives;
		private System.Windows.Forms.RadioButton rbDaySalary;
		private System.Windows.Forms.RadioButton rbMonSalary;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtNotes;
		private System.Windows.Forms.RadioButton rbDiscount;
		private System.Windows.Forms.RadioButton rbAdd;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TableLayoutPanel tlpButtons;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Button btnCon;
		private System.Windows.Forms.TableLayoutPanel tlpSearchMain;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton rbViewAll;
		private System.Windows.Forms.RadioButton rbViewDeductions;
		private System.Windows.Forms.RadioButton rbViewAdds;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Date;
		private System.Windows.Forms.DataGridViewTextBoxColumn Type;
		private System.Windows.Forms.DataGridViewTextBoxColumn Value;
		private System.Windows.Forms.DataGridViewTextBoxColumn ValueFrom;
		private System.Windows.Forms.DataGridViewTextBoxColumn RealValue;
		private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
		private System.Windows.Forms.Label label6;
		private Syncfusion.WinForms.Input.SfDateTimeEdit sfDateTimeEdit1;
	}
}

﻿namespace iccBvsProject1.Views
{
    partial class UserControlRental
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.textBoxSearchValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownOverdueDayCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTotalPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownOverduePrice = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxRentalId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePickerReturnDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerRentalDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonRetrieveSpecific = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonRetrieveAll = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRent = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxCustomerName = new System.Windows.Forms.ComboBox();
            this.textBoxCustomerId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBoxVideoTitle = new System.Windows.Forms.ComboBox();
            this.textBoxVideoId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxVideoFormat = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDownRentPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRentLimit = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewRental = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOverdueDayCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOverduePrice)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRentPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRentLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRental)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Items.AddRange(new object[] {
            "by Rental ID",
            "by Video Title",
            "by Customer Name"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(129, 21);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(250, 36);
            this.comboBoxSearchBy.TabIndex = 41;
            // 
            // textBoxSearchValue
            // 
            this.textBoxSearchValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearchValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchValue.Location = new System.Drawing.Point(385, 23);
            this.textBoxSearchValue.Name = "textBoxSearchValue";
            this.textBoxSearchValue.Size = new System.Drawing.Size(485, 34);
            this.textBoxSearchValue.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(684, 326);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 50);
            this.label5.TabIndex = 39;
            this.label5.Text = "Note/s";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNotes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNotes.Location = new System.Drawing.Point(684, 384);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(399, 154);
            this.textBoxNotes.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 34);
            this.label2.TabIndex = 28;
            this.label2.Text = "ID";
            // 
            // numericUpDownOverdueDayCount
            // 
            this.numericUpDownOverdueDayCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownOverdueDayCount.Enabled = false;
            this.numericUpDownOverdueDayCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownOverdueDayCount.Location = new System.Drawing.Point(244, 464);
            this.numericUpDownOverdueDayCount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownOverdueDayCount.Name = "numericUpDownOverdueDayCount";
            this.numericUpDownOverdueDayCount.Size = new System.Drawing.Size(134, 34);
            this.numericUpDownOverdueDayCount.TabIndex = 56;
            // 
            // numericUpDownTotalPrice
            // 
            this.numericUpDownTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownTotalPrice.Enabled = false;
            this.numericUpDownTotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownTotalPrice.Location = new System.Drawing.Point(490, 464);
            this.numericUpDownTotalPrice.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDownTotalPrice.Name = "numericUpDownTotalPrice";
            this.numericUpDownTotalPrice.Size = new System.Drawing.Size(150, 34);
            this.numericUpDownTotalPrice.TabIndex = 55;
            // 
            // numericUpDownOverduePrice
            // 
            this.numericUpDownOverduePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownOverduePrice.Enabled = false;
            this.numericUpDownOverduePrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownOverduePrice.Location = new System.Drawing.Point(244, 504);
            this.numericUpDownOverduePrice.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownOverduePrice.Name = "numericUpDownOverduePrice";
            this.numericUpDownOverduePrice.Size = new System.Drawing.Size(134, 34);
            this.numericUpDownOverduePrice.TabIndex = 43;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 504);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(230, 34);
            this.label16.TabIndex = 54;
            this.label16.Text = "Overdue Price (₱5/ Day)";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(384, 504);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 34);
            this.label13.TabIndex = 53;
            this.label13.Text = "Status";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStatus.Enabled = false;
            this.textBoxStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStatus.Location = new System.Drawing.Point(490, 504);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(150, 34);
            this.textBoxStatus.TabIndex = 51;
            this.textBoxStatus.TextChanged += new System.EventHandler(this.textBoxStatus_TextChanged);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 463);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 34);
            this.label12.TabIndex = 50;
            this.label12.Text = "Overdue Day/s";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(384, 464);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 34);
            this.label10.TabIndex = 49;
            this.label10.Text = "Total";
            // 
            // textBoxRentalId
            // 
            this.textBoxRentalId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRentalId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRentalId.Location = new System.Drawing.Point(126, 54);
            this.textBoxRentalId.Name = "textBoxRentalId";
            this.textBoxRentalId.ReadOnly = true;
            this.textBoxRentalId.Size = new System.Drawing.Size(1079, 34);
            this.textBoxRentalId.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 424);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(250, 34);
            this.label9.TabIndex = 47;
            this.label9.Text = "Expected Return Date";
            // 
            // dateTimePickerReturnDate
            // 
            this.dateTimePickerReturnDate.Enabled = false;
            this.dateTimePickerReturnDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerReturnDate.Location = new System.Drawing.Point(264, 424);
            this.dateTimePickerReturnDate.Name = "dateTimePickerReturnDate";
            this.dateTimePickerReturnDate.Size = new System.Drawing.Size(376, 34);
            this.dateTimePickerReturnDate.TabIndex = 46;
            // 
            // dateTimePickerRentalDate
            // 
            this.dateTimePickerRentalDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerRentalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerRentalDate.Location = new System.Drawing.Point(264, 384);
            this.dateTimePickerRentalDate.Name = "dateTimePickerRentalDate";
            this.dateTimePickerRentalDate.Size = new System.Drawing.Size(376, 34);
            this.dateTimePickerRentalDate.TabIndex = 45;
            this.dateTimePickerRentalDate.ValueChanged += new System.EventHandler(this.dateTimePickerRentalDate_ValueChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 386);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 34);
            this.label8.TabIndex = 44;
            this.label8.Text = "Rental Date";
            // 
            // buttonRetrieveSpecific
            // 
            this.buttonRetrieveSpecific.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.buttonRetrieveSpecific.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetrieveSpecific.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetrieveSpecific.ForeColor = System.Drawing.Color.White;
            this.buttonRetrieveSpecific.Location = new System.Drawing.Point(876, 20);
            this.buttonRetrieveSpecific.Name = "buttonRetrieveSpecific";
            this.buttonRetrieveSpecific.Size = new System.Drawing.Size(150, 36);
            this.buttonRetrieveSpecific.TabIndex = 40;
            this.buttonRetrieveSpecific.Text = "Find";
            this.buttonRetrieveSpecific.UseVisualStyleBackColor = false;
            this.buttonRetrieveSpecific.Click += new System.EventHandler(this.buttonRetrieveSpecific_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 36);
            this.label11.TabIndex = 43;
            this.label11.Text = "Search";
            // 
            // buttonRetrieveAll
            // 
            this.buttonRetrieveAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.buttonRetrieveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetrieveAll.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetrieveAll.ForeColor = System.Drawing.Color.White;
            this.buttonRetrieveAll.Location = new System.Drawing.Point(1038, 20);
            this.buttonRetrieveAll.Name = "buttonRetrieveAll";
            this.buttonRetrieveAll.Size = new System.Drawing.Size(200, 36);
            this.buttonRetrieveAll.TabIndex = 39;
            this.buttonRetrieveAll.Text = "Display All";
            this.buttonRetrieveAll.UseVisualStyleBackColor = false;
            this.buttonRetrieveAll.Click += new System.EventHandler(this.buttonRetrieveAll_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonRent);
            this.panel1.Controls.Add(this.buttonReturn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxNotes);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.numericUpDownOverdueDayCount);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.numericUpDownTotalPrice);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.numericUpDownOverduePrice);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.textBoxRentalId);
            this.panel1.Controls.Add(this.textBoxStatus);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.dateTimePickerRentalDate);
            this.panel1.Controls.Add(this.dateTimePickerReturnDate);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(23, 586);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1215, 548);
            this.panel1.TabIndex = 45;
            // 
            // buttonRent
            // 
            this.buttonRent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.buttonRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRent.ForeColor = System.Drawing.Color.White;
            this.buttonRent.Location = new System.Drawing.Point(1089, 384);
            this.buttonRent.Name = "buttonRent";
            this.buttonRent.Size = new System.Drawing.Size(116, 50);
            this.buttonRent.TabIndex = 57;
            this.buttonRent.Text = "Rent";
            this.buttonRent.UseVisualStyleBackColor = false;
            this.buttonRent.Click += new System.EventHandler(this.buttonRent_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.ForeColor = System.Drawing.Color.White;
            this.buttonReturn.Location = new System.Drawing.Point(1089, 488);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(116, 50);
            this.buttonReturn.TabIndex = 58;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.comboBoxCustomerName);
            this.groupBox3.Controls.Add(this.textBoxCustomerId);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(673, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox3.Size = new System.Drawing.Size(532, 158);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer";
            // 
            // comboBoxCustomerName
            // 
            this.comboBoxCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCustomerName.FormattingEnabled = true;
            this.comboBoxCustomerName.Location = new System.Drawing.Point(119, 82);
            this.comboBoxCustomerName.Name = "comboBoxCustomerName";
            this.comboBoxCustomerName.Size = new System.Drawing.Size(400, 36);
            this.comboBoxCustomerName.TabIndex = 42;
            this.comboBoxCustomerName.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomerName_SelectedIndexChanged);
            // 
            // textBoxCustomerId
            // 
            this.textBoxCustomerId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCustomerId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerId.Location = new System.Drawing.Point(119, 42);
            this.textBoxCustomerId.Name = "textBoxCustomerId";
            this.textBoxCustomerId.ReadOnly = true;
            this.textBoxCustomerId.Size = new System.Drawing.Size(400, 34);
            this.textBoxCustomerId.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 34);
            this.label4.TabIndex = 38;
            this.label4.Text = "Name";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 34);
            this.label7.TabIndex = 37;
            this.label7.Text = "ID";
            // 
            // groupBox5
            // 
            this.groupBox5.AutoSize = true;
            this.groupBox5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox5.Controls.Add(this.comboBoxVideoTitle);
            this.groupBox5.Controls.Add(this.textBoxVideoId);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.textBoxVideoFormat);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.numericUpDownRentPrice);
            this.groupBox5.Controls.Add(this.numericUpDownRentLimit);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(8, 94);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox5.Size = new System.Drawing.Size(632, 277);
            this.groupBox5.TabIndex = 41;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Video";
            // 
            // comboBoxVideoTitle
            // 
            this.comboBoxVideoTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVideoTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVideoTitle.FormattingEnabled = true;
            this.comboBoxVideoTitle.Location = new System.Drawing.Point(219, 81);
            this.comboBoxVideoTitle.Name = "comboBoxVideoTitle";
            this.comboBoxVideoTitle.Size = new System.Drawing.Size(400, 36);
            this.comboBoxVideoTitle.TabIndex = 42;
            this.comboBoxVideoTitle.SelectedIndexChanged += new System.EventHandler(this.comboBoxVideoTitle_SelectedIndexChanged);
            this.comboBoxVideoTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxVideoTitle_KeyDown);
            this.comboBoxVideoTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxVideoTitle_KeyPress);
            this.comboBoxVideoTitle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBoxVideoTitle_KeyUp);
            // 
            // textBoxVideoId
            // 
            this.textBoxVideoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxVideoId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVideoId.Location = new System.Drawing.Point(219, 41);
            this.textBoxVideoId.Name = "textBoxVideoId";
            this.textBoxVideoId.ReadOnly = true;
            this.textBoxVideoId.Size = new System.Drawing.Size(400, 34);
            this.textBoxVideoId.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 34);
            this.label3.TabIndex = 38;
            this.label3.Text = "Title";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 34);
            this.label1.TabIndex = 37;
            this.label1.Text = "ID";
            // 
            // textBoxVideoFormat
            // 
            this.textBoxVideoFormat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxVideoFormat.Enabled = false;
            this.textBoxVideoFormat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVideoFormat.Location = new System.Drawing.Point(219, 123);
            this.textBoxVideoFormat.Name = "textBoxVideoFormat";
            this.textBoxVideoFormat.Size = new System.Drawing.Size(400, 34);
            this.textBoxVideoFormat.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 163);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(200, 34);
            this.label15.TabIndex = 34;
            this.label15.Text = "Rent Limit (Day/s)";
            // 
            // numericUpDownRentPrice
            // 
            this.numericUpDownRentPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownRentPrice.Enabled = false;
            this.numericUpDownRentPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownRentPrice.Location = new System.Drawing.Point(219, 203);
            this.numericUpDownRentPrice.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDownRentPrice.Name = "numericUpDownRentPrice";
            this.numericUpDownRentPrice.Size = new System.Drawing.Size(400, 34);
            this.numericUpDownRentPrice.TabIndex = 33;
            // 
            // numericUpDownRentLimit
            // 
            this.numericUpDownRentLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownRentLimit.Enabled = false;
            this.numericUpDownRentLimit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownRentLimit.Location = new System.Drawing.Point(219, 163);
            this.numericUpDownRentLimit.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownRentLimit.Name = "numericUpDownRentLimit";
            this.numericUpDownRentLimit.Size = new System.Drawing.Size(400, 34);
            this.numericUpDownRentLimit.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 203);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(200, 34);
            this.label14.TabIndex = 26;
            this.label14.Text = "Price";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 34);
            this.label6.TabIndex = 19;
            this.label6.Text = "Format";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(8, 5);
            this.label17.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(150, 36);
            this.label17.TabIndex = 1;
            this.label17.Text = "DETAILS";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(23, 1147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1215, 10);
            this.panel2.TabIndex = 46;
            // 
            // dataGridViewRental
            // 
            this.dataGridViewRental.AllowUserToAddRows = false;
            this.dataGridViewRental.AllowUserToDeleteRows = false;
            this.dataGridViewRental.AllowUserToOrderColumns = true;
            this.dataGridViewRental.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewRental.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewRental.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.dataGridViewRental.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewRental.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRental.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewRental.ColumnHeadersHeight = 50;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRental.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewRental.EnableHeadersVisualStyles = false;
            this.dataGridViewRental.Location = new System.Drawing.Point(23, 63);
            this.dataGridViewRental.MultiSelect = false;
            this.dataGridViewRental.Name = "dataGridViewRental";
            this.dataGridViewRental.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRental.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewRental.RowHeadersVisible = false;
            this.dataGridViewRental.RowHeadersWidth = 51;
            this.dataGridViewRental.RowTemplate.Height = 24;
            this.dataGridViewRental.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRental.Size = new System.Drawing.Size(1215, 500);
            this.dataGridViewRental.TabIndex = 47;
            this.dataGridViewRental.SelectionChanged += new System.EventHandler(this.dataGridViewRental_SelectionChanged);
            // 
            // UserControlRental
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.dataGridViewRental);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxSearchBy);
            this.Controls.Add(this.textBoxSearchValue);
            this.Controls.Add(this.buttonRetrieveSpecific);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonRetrieveAll);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlRental";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1219, 732);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOverdueDayCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOverduePrice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRentPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRentLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRental)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private System.Windows.Forms.TextBox textBoxSearchValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownOverdueDayCount;
        private System.Windows.Forms.NumericUpDown numericUpDownTotalPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownOverduePrice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxRentalId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturnDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerRentalDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Button buttonRetrieveSpecific;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonRetrieveAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBoxVideoTitle;
        private System.Windows.Forms.TextBox textBoxVideoId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxVideoFormat;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericUpDownRentPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownRentLimit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxCustomerName;
        private System.Windows.Forms.TextBox textBoxCustomerId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonRent;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewRental;
    }
}

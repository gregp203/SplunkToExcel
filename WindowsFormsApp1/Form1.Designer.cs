using ScintillaNET;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
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
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.serverLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.earliestDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.earliestLabel = new System.Windows.Forms.Label();
            this.lastestLabel = new System.Windows.Forms.Label();
            this.latestDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.submitButton = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.dispatchstateLabel = new System.Windows.Forms.Label();
            this.doneProgressLabel = new System.Windows.Forms.Label();
            this.writeToExcelStatLabel = new System.Windows.Forms.Label();
            this.indexlabel = new System.Windows.Forms.Label();
            this.indexTextBox = new System.Windows.Forms.TextBox();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.loadXMLButton = new System.Windows.Forms.Button();
            this.maxLineTextBox = new System.Windows.Forms.TextBox();
            this.maxLineLlabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clearButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.satatusGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveToXMLbutton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openExcelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.exisitingExcelTextBox = new System.Windows.Forms.TextBox();
            this.openExistingExcelFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.searchEditor = new ScintillaNET.Scintilla();
            this.fullSearchTextBox = new ScintillaNET.Scintilla();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.satatusGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverTextBox
            // 
            this.serverTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverTextBox.Location = new System.Drawing.Point(10, 25);
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.Size = new System.Drawing.Size(121, 20);
            this.serverTextBox.TabIndex = 0;
            this.serverTextBox.TextChanged += new System.EventHandler(this.serverTextBox_TextChanged);
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Location = new System.Drawing.Point(7, 9);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(117, 13);
            this.serverLabel.TabIndex = 10;
            this.serverLabel.Text = "Server Host name or IP";
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(7, 89);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(71, 13);
            this.searchLabel.TabIndex = 9;
            this.searchLabel.Text = "Search String";
            // 
            // earliestDateTimePicker
            // 
            this.earliestDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.earliestDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.earliestDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.earliestDateTimePicker.Location = new System.Drawing.Point(10, 407);
            this.earliestDateTimePicker.Name = "earliestDateTimePicker";
            this.earliestDateTimePicker.Size = new System.Drawing.Size(136, 20);
            this.earliestDateTimePicker.TabIndex = 4;
            this.earliestDateTimePicker.ValueChanged += new System.EventHandler(this.earliestTimePicker_Changed);
            // 
            // earliestLabel
            // 
            this.earliestLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.earliestLabel.AutoSize = true;
            this.earliestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earliestLabel.Location = new System.Drawing.Point(7, 389);
            this.earliestLabel.Name = "earliestLabel";
            this.earliestLabel.Size = new System.Drawing.Size(48, 15);
            this.earliestLabel.TabIndex = 8;
            this.earliestLabel.Text = "Earliest";
            // 
            // lastestLabel
            // 
            this.lastestLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lastestLabel.AutoSize = true;
            this.lastestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastestLabel.Location = new System.Drawing.Point(150, 389);
            this.lastestLabel.Name = "lastestLabel";
            this.lastestLabel.Size = new System.Drawing.Size(40, 15);
            this.lastestLabel.TabIndex = 7;
            this.lastestLabel.Text = "Latest";
            // 
            // latestDateTimePicker
            // 
            this.latestDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.latestDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.latestDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.latestDateTimePicker.Location = new System.Drawing.Point(153, 407);
            this.latestDateTimePicker.Name = "latestDateTimePicker";
            this.latestDateTimePicker.Size = new System.Drawing.Size(137, 20);
            this.latestDateTimePicker.TabIndex = 5;
            this.latestDateTimePicker.ValueChanged += new System.EventHandler(this.latestTimePicker_Changed);
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.submitButton.Enabled = false;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.submitButton.Location = new System.Drawing.Point(10, 477);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(134, 9);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(29, 13);
            this.userLabel.TabIndex = 6;
            this.userLabel.Text = "User";
            // 
            // userTextBox
            // 
            this.userTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userTextBox.Location = new System.Drawing.Point(137, 25);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(121, 20);
            this.userTextBox.TabIndex = 1;
            this.userTextBox.TextChanged += new System.EventHandler(this.userTextBox_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(261, 9);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Location = new System.Drawing.Point(264, 25);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // statusTextBox
            // 
            this.statusTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTextBox.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.statusTextBox.Location = new System.Drawing.Point(6, 32);
            this.statusTextBox.Multiline = true;
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.statusTextBox.Size = new System.Drawing.Size(582, 91);
            this.statusTextBox.TabIndex = 4;
            // 
            // dispatchstateLabel
            // 
            this.dispatchstateLabel.AutoSize = true;
            this.dispatchstateLabel.Location = new System.Drawing.Point(3, 16);
            this.dispatchstateLabel.Name = "dispatchstateLabel";
            this.dispatchstateLabel.Size = new System.Drawing.Size(81, 13);
            this.dispatchstateLabel.TabIndex = 2;
            this.dispatchstateLabel.Text = "waiting for input";
            // 
            // doneProgressLabel
            // 
            this.doneProgressLabel.AutoSize = true;
            this.doneProgressLabel.Location = new System.Drawing.Point(90, 16);
            this.doneProgressLabel.Name = "doneProgressLabel";
            this.doneProgressLabel.Size = new System.Drawing.Size(21, 13);
            this.doneProgressLabel.TabIndex = 1;
            this.doneProgressLabel.Text = "0%";
            this.doneProgressLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // writeToExcelStatLabel
            // 
            this.writeToExcelStatLabel.AutoSize = true;
            this.writeToExcelStatLabel.Location = new System.Drawing.Point(3, 126);
            this.writeToExcelStatLabel.Name = "writeToExcelStatLabel";
            this.writeToExcelStatLabel.Size = new System.Drawing.Size(114, 13);
            this.writeToExcelStatLabel.TabIndex = 0;
            this.writeToExcelStatLabel.Text = "no lines writen to excel";
            // 
            // indexlabel
            // 
            this.indexlabel.AutoSize = true;
            this.indexlabel.Location = new System.Drawing.Point(7, 47);
            this.indexlabel.Name = "indexlabel";
            this.indexlabel.Size = new System.Drawing.Size(33, 13);
            this.indexlabel.TabIndex = 12;
            this.indexlabel.Text = "Index";
            // 
            // indexTextBox
            // 
            this.indexTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.indexTextBox.Location = new System.Drawing.Point(10, 63);
            this.indexTextBox.Name = "indexTextBox";
            this.indexTextBox.Size = new System.Drawing.Size(121, 20);
            this.indexTextBox.TabIndex = 11;
            this.indexTextBox.TextChanged += new System.EventHandler(this.indexTextBox_TextChanged);
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Location = new System.Drawing.Point(134, 47);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(41, 13);
            this.sourceLabel.TabIndex = 14;
            this.sourceLabel.Text = "Source";
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sourceTextBox.Location = new System.Drawing.Point(137, 63);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(121, 20);
            this.sourceTextBox.TabIndex = 13;
            this.sourceTextBox.TextChanged += new System.EventHandler(this.sourceTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(296, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Earliest can not be \r\nlater than latest";
            this.label1.Visible = false;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.DefaultExt = "xml";
            this.OpenFileDialog.Filter = "XML files (*.xml)|*.xml";
            // 
            // loadXMLButton
            // 
            this.loadXMLButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.loadXMLButton.Location = new System.Drawing.Point(493, 63);
            this.loadXMLButton.Name = "loadXMLButton";
            this.loadXMLButton.Size = new System.Drawing.Size(111, 23);
            this.loadXMLButton.TabIndex = 16;
            this.loadXMLButton.Text = "Load from XML file";
            this.loadXMLButton.UseVisualStyleBackColor = true;
            this.loadXMLButton.Click += new System.EventHandler(this.loadXMLButton_Click);
            // 
            // maxLineTextBox
            // 
            this.maxLineTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxLineTextBox.Location = new System.Drawing.Point(264, 63);
            this.maxLineTextBox.Name = "maxLineTextBox";
            this.maxLineTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxLineTextBox.TabIndex = 17;
            this.maxLineTextBox.TextChanged += new System.EventHandler(this.MaxLineTextBox_TextChanged);
            // 
            // maxLineLlabel
            // 
            this.maxLineLlabel.AutoSize = true;
            this.maxLineLlabel.Location = new System.Drawing.Point(261, 47);
            this.maxLineLlabel.Name = "maxLineLlabel";
            this.maxLineLlabel.Size = new System.Drawing.Size(55, 13);
            this.maxLineLlabel.TabIndex = 18;
            this.maxLineLlabel.Text = "Max Lines";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column,
            this.ColumnName});
            this.dataGridView1.Location = new System.Drawing.Point(616, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(253, 625);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellValueChanged);
            // 
            // Column
            // 
            this.Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column.HeaderText = "Splunk Table Fields";
            this.Column.Name = "Column";
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.HeaderText = "Excel Column Name";
            this.ColumnName.Name = "ColumnName";
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.clearButton.Location = new System.Drawing.Point(91, 477);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 20;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButton.Enabled = false;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CancelButton.Location = new System.Drawing.Point(172, 477);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 21;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // satatusGroupBox
            // 
            this.satatusGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.satatusGroupBox.Controls.Add(this.dispatchstateLabel);
            this.satatusGroupBox.Controls.Add(this.writeToExcelStatLabel);
            this.satatusGroupBox.Controls.Add(this.doneProgressLabel);
            this.satatusGroupBox.Controls.Add(this.statusTextBox);
            this.satatusGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.satatusGroupBox.Location = new System.Drawing.Point(10, 506);
            this.satatusGroupBox.Name = "satatusGroupBox";
            this.satatusGroupBox.Size = new System.Drawing.Size(594, 144);
            this.satatusGroupBox.TabIndex = 22;
            this.satatusGroupBox.TabStop = false;
            this.satatusGroupBox.Text = "Status";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(613, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Splunk Table to Excel Columns";
            // 
            // saveToXMLbutton
            // 
            this.saveToXMLbutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.saveToXMLbutton.Location = new System.Drawing.Point(376, 63);
            this.saveToXMLbutton.Name = "saveToXMLbutton";
            this.saveToXMLbutton.Size = new System.Drawing.Size(111, 23);
            this.saveToXMLbutton.TabIndex = 24;
            this.saveToXMLbutton.Text = "Save to XML file";
            this.saveToXMLbutton.UseVisualStyleBackColor = true;
            this.saveToXMLbutton.Click += new System.EventHandler(this.saveToXMLbutton_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "xml";
            this.saveFileDialog.Filter = "XML files (*.xml)|*.xml";
            // 
            // openExcelButton
            // 
            this.openExcelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openExcelButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.openExcelButton.Location = new System.Drawing.Point(253, 477);
            this.openExcelButton.Name = "openExcelButton";
            this.openExcelButton.Size = new System.Drawing.Size(135, 23);
            this.openExcelButton.TabIndex = 25;
            this.openExcelButton.Text = "Open Existisng Excel File";
            this.openExcelButton.UseVisualStyleBackColor = true;
            this.openExcelButton.Click += new System.EventHandler(this.openExcelButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Full Splunk Search String";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Existing Excel File (Optional)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // exisitingExcelTextBox
            // 
            this.exisitingExcelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exisitingExcelTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.exisitingExcelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exisitingExcelTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exisitingExcelTextBox.Location = new System.Drawing.Point(10, 451);
            this.exisitingExcelTextBox.Name = "exisitingExcelTextBox";
            this.exisitingExcelTextBox.ReadOnly = true;
            this.exisitingExcelTextBox.Size = new System.Drawing.Size(594, 20);
            this.exisitingExcelTextBox.TabIndex = 28;
            // 
            // openExistingExcelFileDialog
            // 
            this.openExistingExcelFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            // 
            // searchEditor
            // 
            this.searchEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchEditor.FontQuality = ScintillaNET.FontQuality.LcdOptimized;
            this.searchEditor.ImeMode = System.Windows.Forms.ImeMode.On;
            this.searchEditor.IndentationGuides = ScintillaNET.IndentView.LookBoth;
            this.searchEditor.Lexer = ScintillaNET.Lexer.Sql;
            this.searchEditor.Location = new System.Drawing.Point(10, 105);
            this.searchEditor.Name = "searchEditor";
            this.searchEditor.Size = new System.Drawing.Size(594, 157);
            //this.searchEditor.Styler = null;
            this.searchEditor.TabIndex = 30;
            this.searchEditor.TextChanged += new System.EventHandler(this.searchEditor_TextChanged);
            // 
            // fullSearchTextBox
            // 
            this.fullSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullSearchTextBox.FontQuality = ScintillaNET.FontQuality.LcdOptimized;
            this.fullSearchTextBox.HScrollBar = false;
            this.fullSearchTextBox.Lexer = ScintillaNET.Lexer.Sql;
            this.fullSearchTextBox.Location = new System.Drawing.Point(10, 295);
            this.fullSearchTextBox.Name = "fullSearchTextBox";
            this.fullSearchTextBox.Size = new System.Drawing.Size(594, 91);
            this.fullSearchTextBox.TabIndex = 31;
            this.fullSearchTextBox.VScrollBar = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 662);
            this.Controls.Add(this.fullSearchTextBox);
            this.Controls.Add(this.searchEditor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exisitingExcelTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.openExcelButton);
            this.Controls.Add(this.saveToXMLbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.maxLineLlabel);
            this.Controls.Add(this.maxLineTextBox);
            this.Controls.Add(this.loadXMLButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sourceLabel);
            this.Controls.Add(this.sourceTextBox);
            this.Controls.Add(this.indexlabel);
            this.Controls.Add(this.indexTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.latestDateTimePicker);
            this.Controls.Add(this.lastestLabel);
            this.Controls.Add(this.earliestLabel);
            this.Controls.Add(this.earliestDateTimePicker);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.serverLabel);
            this.Controls.Add(this.serverTextBox);
            this.Controls.Add(this.satatusGroupBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "Form1";
            this.Text = "Splunk 2 Excel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.satatusGroupBox.ResumeLayout(false);
            this.satatusGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox serverTextBox;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.Label searchLabel;
        public System.Windows.Forms.DateTimePicker earliestDateTimePicker;
        private System.Windows.Forms.Label earliestLabel;
        private System.Windows.Forms.Label lastestLabel;
        public System.Windows.Forms.DateTimePicker latestDateTimePicker;
        public System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label userLabel;
        public System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label passwordLabel;
        public System.Windows.Forms.TextBox passwordTextBox;
        public System.Windows.Forms.TextBox statusTextBox;
        public System.Windows.Forms.Label dispatchstateLabel;
        public System.Windows.Forms.Label doneProgressLabel;
        public System.Windows.Forms.Label writeToExcelStatLabel;
        private Label indexlabel;
        public TextBox indexTextBox;
        private Label sourceLabel;
        public TextBox sourceTextBox;
        private Label label1;
        private OpenFileDialog OpenFileDialog;
        private Button loadXMLButton;
        private TextBox maxLineTextBox;
        private Label maxLineLlabel;
        private DataGridView dataGridView1;
        public Button clearButton;
        public Button CancelButton;
        private GroupBox satatusGroupBox;
        private Label label2;
        private Button saveToXMLbutton;
        private SaveFileDialog saveFileDialog;
        public Button openExcelButton;
        private Label label3;
        private Label label4;
        public TextBox exisitingExcelTextBox;
        private OpenFileDialog openExistingExcelFileDialog;
        private DataGridViewTextBoxColumn Column;
        private DataGridViewTextBoxColumn ColumnName;
        //private EasyScintilla.SimpleEditor searchEditor;
        private Scintilla searchEditor;
        private Scintilla fullSearchTextBox;
    }
}


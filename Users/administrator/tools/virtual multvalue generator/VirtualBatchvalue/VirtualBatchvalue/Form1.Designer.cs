namespace VirtualBatchvalue
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.txtQTY = new System.Windows.Forms.TextBox();
            this.txtMaxValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lvValues = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGen = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dlgFileSave = new System.Windows.Forms.SaveFileDialog();
            this.chkDouble = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chkCountDown = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start time";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(122, 23);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(32, 21);
            this.txtYear.TabIndex = 1;
            this.txtYear.Text = "2012";
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(176, 23);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(24, 21);
            this.txtMonth.TabIndex = 2;
            this.txtMonth.Text = "04";
            this.txtMonth.TextChanged += new System.EventHandler(this.txtMonth_TextChanged);
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(223, 23);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(24, 21);
            this.txtDay.TabIndex = 3;
            this.txtDay.Text = "02";
            this.txtDay.TextChanged += new System.EventHandler(this.txtDay_TextChanged);
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(271, 23);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(24, 21);
            this.txtHour.TabIndex = 4;
            this.txtHour.Text = "16";
            this.txtHour.TextChanged += new System.EventHandler(this.txtHour_TextChanged);
            // 
            // txtMinute
            // 
            this.txtMinute.Location = new System.Drawing.Point(319, 23);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(24, 21);
            this.txtMinute.TabIndex = 5;
            this.txtMinute.Text = "22";
            this.txtMinute.TextChanged += new System.EventHandler(this.txtMinute_TextChanged);
            // 
            // txtSeconds
            // 
            this.txtSeconds.Location = new System.Drawing.Point(366, 23);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(24, 21);
            this.txtSeconds.TabIndex = 6;
            this.txtSeconds.Text = "00";
            this.txtSeconds.TextChanged += new System.EventHandler(this.txtSeconds_TextChanged);
            // 
            // txtStep
            // 
            this.txtStep.Location = new System.Drawing.Point(122, 77);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(32, 21);
            this.txtStep.TabIndex = 7;
            this.txtStep.Text = "20";
            this.txtStep.TextChanged += new System.EventHandler(this.txtStep_TextChanged);
            // 
            // txtQTY
            // 
            this.txtQTY.Location = new System.Drawing.Point(366, 77);
            this.txtQTY.Name = "txtQTY";
            this.txtQTY.Size = new System.Drawing.Size(24, 21);
            this.txtQTY.TabIndex = 8;
            this.txtQTY.Text = "10";
            this.txtQTY.TextChanged += new System.EventHandler(this.txtQTY_TextChanged);
            // 
            // txtMaxValue
            // 
            this.txtMaxValue.Location = new System.Drawing.Point(122, 107);
            this.txtMaxValue.Name = "txtMaxValue";
            this.txtMaxValue.Size = new System.Drawing.Size(32, 21);
            this.txtMaxValue.TabIndex = 9;
            this.txtMaxValue.Text = "100";
            this.txtMaxValue.TextChanged += new System.EventHandler(this.txtMaxValue_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "Seconds step";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "Qty";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "Rnage(0- )";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lvValues
            // 
            this.lvValues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.lvValues.GridLines = true;
            this.lvValues.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvValues.Location = new System.Drawing.Point(108, 207);
            this.lvValues.Name = "lvValues";
            this.lvValues.Size = new System.Drawing.Size(432, 234);
            this.lvValues.TabIndex = 15;
            this.lvValues.UseCompatibleStateImageBehavior = false;
            this.lvValues.View = System.Windows.Forms.View.Details;
            this.lvValues.SelectedIndexChanged += new System.EventHandler(this.lvValues_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "No";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "timestamp";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "value";
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(349, 163);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(75, 24);
            this.btnGen.TabIndex = 16;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(29, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 10);
            this.label5.TabIndex = 17;
            this.label5.Text = "(YYYY-MM-DD HH:MM:SS)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(440, 163);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 24);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save...";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dlgFileSave
            // 
            this.dlgFileSave.DefaultExt = "csv file|*.csv";
            this.dlgFileSave.Filter = "csv file|*.csv";
            // 
            // chkDouble
            // 
            this.chkDouble.AutoSize = true;
            this.chkDouble.Location = new System.Drawing.Point(161, 109);
            this.chkDouble.Name = "chkDouble";
            this.chkDouble.Size = new System.Drawing.Size(90, 16);
            this.chkDouble.TabIndex = 19;
            this.chkDouble.Text = "Double type";
            this.chkDouble.UseVisualStyleBackColor = true;
            this.chkDouble.CheckedChanged += new System.EventHandler(this.chkDouble_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "a";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(158, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "-";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(203, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "-";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(298, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = ":";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(346, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = ":";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // chkCountDown
            // 
            this.chkCountDown.AutoSize = true;
            this.chkCountDown.Checked = true;
            this.chkCountDown.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCountDown.Location = new System.Drawing.Point(160, 79);
            this.chkCountDown.Name = "chkCountDown";
            this.chkCountDown.Size = new System.Drawing.Size(84, 16);
            this.chkCountDown.TabIndex = 25;
            this.chkCountDown.Text = "Count down";
            this.chkCountDown.UseVisualStyleBackColor = true;
            this.chkCountDown.CheckedChanged += new System.EventHandler(this.chkCountDown_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 478);
            this.Controls.Add(this.chkCountDown);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkDouble);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.lvValues);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaxValue);
            this.Controls.Add(this.txtQTY);
            this.Controls.Add(this.txtStep);
            this.Controls.Add(this.txtSeconds);
            this.Controls.Add(this.txtMinute);
            this.Controls.Add(this.txtHour);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Virtual Multivalue Generator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.TextBox txtQTY;
        private System.Windows.Forms.TextBox txtMaxValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvValues;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog dlgFileSave;
        private System.Windows.Forms.CheckBox chkDouble;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkCountDown;
    }
}


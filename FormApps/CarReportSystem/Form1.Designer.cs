namespace CarReportSystem {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            dtpDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            cbAuther = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            cbCarname = new ComboBox();
            groupBox1 = new GroupBox();
            rbOther = new RadioButton();
            rbImport = new RadioButton();
            rbSubaru = new RadioButton();
            rbHonda = new RadioButton();
            rbNissan = new RadioButton();
            rbToyota = new RadioButton();
            tbReport = new TextBox();
            label6 = new Label();
            brModifyreport = new Button();
            btPickOpen = new Button();
            pbPicture = new PictureBox();
            btAddreport = new Button();
            btDeleteReport = new Button();
            label8 = new Label();
            dgvCarReport = new DataGridView();
            btReportOpen = new Button();
            btReportSave = new Button();
            btPickDelete = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarReport).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(39, 36);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 0;
            label1.Text = "日付";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Location = new Point(124, 28);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 33);
            dtpDate.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.Location = new Point(39, 136);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 0;
            label2.Text = "メーカー";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.Location = new Point(33, 88);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 0;
            label3.Text = "記録者";
            // 
            // cbAuther
            // 
            cbAuther.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbAuther.FormattingEnabled = true;
            cbAuther.Location = new Point(124, 80);
            cbAuther.Name = "cbAuther";
            cbAuther.Size = new Size(241, 33);
            cbAuther.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label4.Location = new Point(39, 186);
            label4.Name = "label4";
            label4.Size = new Size(50, 25);
            label4.TabIndex = 0;
            label4.Text = "車名";
            label4.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label5.Location = new Point(33, 234);
            label5.Name = "label5";
            label5.Size = new Size(67, 25);
            label5.TabIndex = 0;
            label5.Text = "レポート";
            label5.Click += label2_Click;
            // 
            // cbCarname
            // 
            cbCarname.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbCarname.FormattingEnabled = true;
            cbCarname.Location = new Point(124, 178);
            cbCarname.Name = "cbCarname";
            cbCarname.Size = new Size(235, 33);
            cbCarname.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbOther);
            groupBox1.Controls.Add(rbImport);
            groupBox1.Controls.Add(rbSubaru);
            groupBox1.Controls.Add(rbHonda);
            groupBox1.Controls.Add(rbNissan);
            groupBox1.Controls.Add(rbToyota);
            groupBox1.Location = new Point(124, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(418, 40);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.Location = new Point(300, 15);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(56, 19);
            rbOther.TabIndex = 0;
            rbOther.TabStop = true;
            rbOther.Text = "その他";
            rbOther.UseVisualStyleBackColor = true;
            // 
            // rbImport
            // 
            rbImport.AutoSize = true;
            rbImport.Location = new Point(233, 15);
            rbImport.Name = "rbImport";
            rbImport.Size = new Size(61, 19);
            rbImport.TabIndex = 0;
            rbImport.TabStop = true;
            rbImport.Text = "輸入車";
            rbImport.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            rbSubaru.AutoSize = true;
            rbSubaru.Location = new Point(173, 15);
            rbSubaru.Name = "rbSubaru";
            rbSubaru.Size = new Size(54, 19);
            rbSubaru.TabIndex = 0;
            rbSubaru.TabStop = true;
            rbSubaru.Text = "スバル";
            rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            rbHonda.AutoSize = true;
            rbHonda.Location = new Point(114, 15);
            rbHonda.Name = "rbHonda";
            rbHonda.Size = new Size(53, 19);
            rbHonda.TabIndex = 0;
            rbHonda.TabStop = true;
            rbHonda.Text = "ホンダ";
            rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            rbNissan.AutoSize = true;
            rbNissan.Location = new Point(59, 15);
            rbNissan.Name = "rbNissan";
            rbNissan.Size = new Size(49, 19);
            rbNissan.TabIndex = 0;
            rbNissan.TabStop = true;
            rbNissan.Text = "日産";
            rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbToyota
            // 
            rbToyota.AutoSize = true;
            rbToyota.Location = new Point(6, 15);
            rbToyota.Name = "rbToyota";
            rbToyota.Size = new Size(50, 19);
            rbToyota.TabIndex = 0;
            rbToyota.TabStop = true;
            rbToyota.Text = "トヨタ";
            rbToyota.UseVisualStyleBackColor = true;
            // 
            // tbReport
            // 
            tbReport.Location = new Point(124, 234);
            tbReport.Multiline = true;
            tbReport.Name = "tbReport";
            tbReport.Size = new Size(431, 151);
            tbReport.TabIndex = 5;
            tbReport.TextChanged += tbReport_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label6.Location = new Point(600, 34);
            label6.Name = "label6";
            label6.Size = new Size(50, 25);
            label6.TabIndex = 0;
            label6.Text = "画像";
            label6.Click += label2_Click;
            // 
            // brModifyreport
            // 
            brModifyreport.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            brModifyreport.Location = new Point(770, 348);
            brModifyreport.Name = "brModifyreport";
            brModifyreport.Size = new Size(77, 37);
            brModifyreport.TabIndex = 6;
            brModifyreport.Text = "修正";
            brModifyreport.UseVisualStyleBackColor = true;
            // 
            // btPickOpen
            // 
            btPickOpen.Location = new Point(808, 34);
            btPickOpen.Name = "btPickOpen";
            btPickOpen.Size = new Size(75, 23);
            btPickOpen.TabIndex = 6;
            btPickOpen.Text = "開く…";
            btPickOpen.UseVisualStyleBackColor = true;
            // 
            // pbPicture
            // 
            pbPicture.BackColor = Color.FromArgb(192, 255, 255);
            pbPicture.Location = new Point(635, 80);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(356, 237);
            pbPicture.TabIndex = 7;
            pbPicture.TabStop = false;
            // 
            // btAddreport
            // 
            btAddreport.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btAddreport.Location = new Point(635, 348);
            btAddreport.Name = "btAddreport";
            btAddreport.Size = new Size(78, 37);
            btAddreport.TabIndex = 6;
            btAddreport.Text = "追加";
            btAddreport.UseVisualStyleBackColor = true;
            btAddreport.Click += btAddreport_Click;
            // 
            // btDeleteReport
            // 
            btDeleteReport.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btDeleteReport.Location = new Point(904, 348);
            btDeleteReport.Name = "btDeleteReport";
            btDeleteReport.Size = new Size(86, 37);
            btDeleteReport.TabIndex = 6;
            btDeleteReport.Text = "削除";
            btDeleteReport.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label8.Location = new Point(33, 406);
            label8.Name = "label8";
            label8.Size = new Size(50, 25);
            label8.TabIndex = 0;
            label8.Text = "一覧";
            label8.Click += label2_Click;
            // 
            // dgvCarReport
            // 
            dgvCarReport.AllowUserToAddRows = false;
            dgvCarReport.AllowUserToDeleteRows = false;
            dgvCarReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarReport.Location = new Point(123, 416);
            dgvCarReport.Name = "dgvCarReport";
            dgvCarReport.ReadOnly = true;
            dgvCarReport.Size = new Size(885, 194);
            dgvCarReport.TabIndex = 8;
            dgvCarReport.CellContentClick += dgvCarReport_CellContentClick;
            // 
            // btReportOpen
            // 
            btReportOpen.AutoSize = true;
            btReportOpen.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btReportOpen.Location = new Point(25, 512);
            btReportOpen.Name = "btReportOpen";
            btReportOpen.Size = new Size(75, 38);
            btReportOpen.TabIndex = 9;
            btReportOpen.Text = "開く…";
            btReportOpen.UseVisualStyleBackColor = true;
            // 
            // btReportSave
            // 
            btReportSave.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btReportSave.Location = new Point(25, 568);
            btReportSave.Name = "btReportSave";
            btReportSave.Size = new Size(75, 42);
            btReportSave.TabIndex = 10;
            btReportSave.Text = "保存…";
            btReportSave.UseVisualStyleBackColor = true;
            // 
            // btPickDelete
            // 
            btPickDelete.Location = new Point(916, 34);
            btPickDelete.Name = "btPickDelete";
            btPickDelete.Size = new Size(75, 23);
            btPickDelete.TabIndex = 6;
            btPickDelete.Text = "削除";
            btPickDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 629);
            Controls.Add(btReportSave);
            Controls.Add(btReportOpen);
            Controls.Add(dgvCarReport);
            Controls.Add(pbPicture);
            Controls.Add(btPickDelete);
            Controls.Add(btPickOpen);
            Controls.Add(btDeleteReport);
            Controls.Add(btAddreport);
            Controls.Add(brModifyreport);
            Controls.Add(tbReport);
            Controls.Add(groupBox1);
            Controls.Add(cbCarname);
            Controls.Add(cbAuther);
            Controls.Add(dtpDate);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "レポート";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDate;
        private Label label2;
        private Label label3;
        private ComboBox cbAuther;
        private Label label4;
        private Label label5;
        private ComboBox cbCarname;
        private GroupBox groupBox1;
        private RadioButton rbOther;
        private RadioButton rbImport;
        private RadioButton rbSubaru;
        private RadioButton rbHonda;
        private RadioButton rbNissan;
        private RadioButton rbToyota;
        private TextBox tbReport;
        private Label label6;
        private Button brModifyreport;
        private Button btPickOpen;
        private PictureBox pbPicture;
        private Button btAddreport;
        private Button btDeleteReport;
        private Label label8;
        private DataGridView dgvCarReport;
        private Button btReportOpen;
        private Button btReportSave;
        private Button btPickDelete;
    }
}

namespace DateTimeApp {
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
            dtpBirthday = new DateTimePicker();
            btDateCount = new Button();
            tbDisp = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(21, 49);
            label1.Name = "label1";
            label1.Size = new Size(110, 32);
            label1.TabIndex = 0;
            label1.Text = "生年月日";
            // 
            // dtpBirthday
            // 
            dtpBirthday.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpBirthday.Location = new Point(137, 44);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(198, 39);
            dtpBirthday.TabIndex = 1;
            // 
            // btDateCount
            // 
            btDateCount.Location = new Point(196, 121);
            btDateCount.Name = "btDateCount";
            btDateCount.Size = new Size(139, 54);
            btDateCount.TabIndex = 2;
            btDateCount.Text = "今日までの日数";
            btDateCount.UseVisualStyleBackColor = true;
            btDateCount.Click += btDateCount_Click;
            // 
            // tbDisp
            // 
            tbDisp.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbDisp.Location = new Point(21, 215);
            tbDisp.Name = "tbDisp";
            tbDisp.Size = new Size(322, 43);
            tbDisp.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 299);
            Controls.Add(tbDisp);
            Controls.Add(btDateCount);
            Controls.Add(dtpBirthday);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpBirthday;
        private Button btDateCount;
        private TextBox tbDisp;
    }
}

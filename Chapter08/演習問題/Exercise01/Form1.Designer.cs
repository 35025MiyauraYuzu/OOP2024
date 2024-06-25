namespace Exercise01 {
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
            Btex81 = new Button();
            tbDisp = new TextBox();
            BtEx82 = new Button();
            SuspendLayout();
            // 
            // Btex81
            // 
            Btex81.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Btex81.Location = new Point(78, 52);
            Btex81.Name = "Btex81";
            Btex81.Size = new Size(199, 67);
            Btex81.TabIndex = 0;
            Btex81.Text = "問題8.1";
            Btex81.UseVisualStyleBackColor = true;
            Btex81.Click += Btex81_Click;
            // 
            // tbDisp
            // 
            tbDisp.Location = new Point(78, 296);
            tbDisp.Multiline = true;
            tbDisp.Name = "tbDisp";
            tbDisp.Size = new Size(199, 142);
            tbDisp.TabIndex = 1;
            // 
            // BtEx82
            // 
            BtEx82.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            BtEx82.Location = new Point(78, 140);
            BtEx82.Name = "BtEx82";
            BtEx82.Size = new Size(199, 70);
            BtEx82.TabIndex = 2;
            BtEx82.Text = "問題8.2";
            BtEx82.UseVisualStyleBackColor = true;
            BtEx82.Click += BtEx82_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtEx82);
            Controls.Add(tbDisp);
            Controls.Add(Btex81);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btex81;
        private TextBox tbDisp;
        private Button BtEx82;
    }
}

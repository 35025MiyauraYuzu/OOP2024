namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.btGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUrl = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btRecord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(190, 67);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(243, 19);
            this.tbAuthor.TabIndex = 0;
            this.tbAuthor.Click += new System.EventHandler(this.tbAuthor_Click);
            this.tbAuthor.TextChanged += new System.EventHandler(this.tbRssUrl_TextChanged);
            // 
            // btGet
            // 
            this.btGet.Location = new System.Drawing.Point(838, 26);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(75, 23);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.tbGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(26, 125);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(232, 520);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.SelectedIndexChanged += new System.EventHandler(this.lbRssTitle_SelectedIndexChanged);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(280, 125);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(692, 520);
            this.webView21.TabIndex = 3;
            this.webView21.ZoomFactor = 1D;
            this.webView21.Click += new System.EventHandler(this.tbGet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "URLまたはお気に入りを入力";
            // 
            // cbUrl
            // 
            this.cbUrl.FormattingEnabled = true;
            this.cbUrl.Location = new System.Drawing.Point(190, 26);
            this.cbUrl.Name = "cbUrl";
            this.cbUrl.Size = new System.Drawing.Size(642, 20);
            this.cbUrl.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "お気に入り名称";
            // 
            // btRecord
            // 
            this.btRecord.Location = new System.Drawing.Point(454, 63);
            this.btRecord.Name = "btRecord";
            this.btRecord.Size = new System.Drawing.Size(75, 26);
            this.btRecord.TabIndex = 7;
            this.btRecord.Text = "登録";
            this.btRecord.UseVisualStyleBackColor = true;
            this.btRecord.Click += new System.EventHandler(this.btRecord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 686);
            this.Controls.Add(this.btRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.tbAuthor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUrl;
        private System.Windows.Forms.Button btRecord;
        private System.Windows.Forms.Label label2;
    }
}


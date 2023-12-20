namespace QuickProxySwitcher
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ProxyListBox = new System.Windows.Forms.ListBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.AddProxyButton = new System.Windows.Forms.Button();
            this.DeleteProxyButton = new System.Windows.Forms.Button();
            this.DisableButton = new System.Windows.Forms.Button();
            this.ProxyStatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProxyListBox
            // 
            this.ProxyListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ProxyListBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ProxyListBox.FormattingEnabled = true;
            this.ProxyListBox.ItemHeight = 24;
            this.ProxyListBox.Location = new System.Drawing.Point(12, 12);
            this.ProxyListBox.Name = "ProxyListBox";
            this.ProxyListBox.Size = new System.Drawing.Size(517, 364);
            this.ProxyListBox.TabIndex = 0;
            this.ProxyListBox.DoubleClick += new System.EventHandler(this.ProxyListBox_DoubleClick);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ApplyButton.Location = new System.Drawing.Point(551, 12);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(215, 37);
            this.ApplyButton.TabIndex = 1;
            this.ApplyButton.Text = "Apply Proxy";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // AddProxyButton
            // 
            this.AddProxyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddProxyButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AddProxyButton.Location = new System.Drawing.Point(551, 267);
            this.AddProxyButton.Name = "AddProxyButton";
            this.AddProxyButton.Size = new System.Drawing.Size(215, 37);
            this.AddProxyButton.TabIndex = 2;
            this.AddProxyButton.Text = "Add Proxy";
            this.AddProxyButton.UseVisualStyleBackColor = true;
            this.AddProxyButton.Click += new System.EventHandler(this.AddProxyButton_Click);
            // 
            // DeleteProxyButton
            // 
            this.DeleteProxyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteProxyButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DeleteProxyButton.Location = new System.Drawing.Point(551, 339);
            this.DeleteProxyButton.Name = "DeleteProxyButton";
            this.DeleteProxyButton.Size = new System.Drawing.Size(215, 37);
            this.DeleteProxyButton.TabIndex = 3;
            this.DeleteProxyButton.Text = "Delete Proxy";
            this.DeleteProxyButton.UseVisualStyleBackColor = true;
            this.DeleteProxyButton.Click += new System.EventHandler(this.DeleteProxyButton_Click);
            // 
            // DisableButton
            // 
            this.DisableButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DisableButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DisableButton.Location = new System.Drawing.Point(551, 89);
            this.DisableButton.Name = "DisableButton";
            this.DisableButton.Size = new System.Drawing.Size(215, 37);
            this.DisableButton.TabIndex = 4;
            this.DisableButton.Text = "Disable Proxy";
            this.DisableButton.UseVisualStyleBackColor = true;
            this.DisableButton.Click += new System.EventHandler(this.DisableButton_Click);
            // 
            // ProxyStatusLabel
            // 
            this.ProxyStatusLabel.AutoSize = true;
            this.ProxyStatusLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ProxyStatusLabel.Location = new System.Drawing.Point(12, 379);
            this.ProxyStatusLabel.Name = "ProxyStatusLabel";
            this.ProxyStatusLabel.Size = new System.Drawing.Size(58, 24);
            this.ProxyStatusLabel.TabIndex = 5;
            this.ProxyStatusLabel.Text = "----";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.Controls.Add(this.ProxyStatusLabel);
            this.Controls.Add(this.DisableButton);
            this.Controls.Add(this.DeleteProxyButton);
            this.Controls.Add(this.AddProxyButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.ProxyListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quick Proxy Switcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProxyListBox;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button AddProxyButton;
        private System.Windows.Forms.Button DeleteProxyButton;
        private System.Windows.Forms.Button DisableButton;
        private System.Windows.Forms.Label ProxyStatusLabel;
    }
}


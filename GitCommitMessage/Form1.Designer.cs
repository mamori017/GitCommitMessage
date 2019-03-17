namespace GitCommitMessage
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.HotFix = new System.Windows.Forms.ToolStripMenuItem();
            this.Fix = new System.Windows.Forms.ToolStripMenuItem();
            this.Remove = new System.Windows.Forms.ToolStripMenuItem();
            this.Disable = new System.Windows.Forms.ToolStripMenuItem();
            this.Revert = new System.Windows.Forms.ToolStripMenuItem();
            this.Upgrade = new System.Windows.Forms.ToolStripMenuItem();
            this.Change = new System.Windows.Forms.ToolStripMenuItem();
            this.Add = new System.Windows.Forms.ToolStripMenuItem();
            this.Update = new System.Windows.Forms.ToolStripMenuItem();
            this.Clean = new System.Windows.Forms.ToolStripMenuItem();
            this.Close = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "GitCommitMessage";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HotFix,
            this.Fix,
            this.Remove,
            this.Disable,
            this.Revert,
            this.Upgrade,
            this.Change,
            this.Add,
            this.Update,
            this.Clean,
            this.Close});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(244, 246);
            // 
            // HotFix
            // 
            this.HotFix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.HotFix.Name = "HotFix";
            this.HotFix.Size = new System.Drawing.Size(243, 22);
            this.HotFix.Text = "HotFix：バグ修正(クリティカル)";
            this.HotFix.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Fix
            // 
            this.Fix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Fix.Name = "Fix";
            this.Fix.Size = new System.Drawing.Size(243, 22);
            this.Fix.Text = "Fix：バグ修正";
            this.Fix.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(243, 22);
            this.Remove.Text = "Remove：ファイル削除";
            this.Remove.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Disable
            // 
            this.Disable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Disable.Name = "Disable";
            this.Disable.Size = new System.Drawing.Size(243, 22);
            this.Disable.Text = "Disable：機能無効化";
            this.Disable.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Revert
            // 
            this.Revert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Revert.Name = "Revert";
            this.Revert.Size = new System.Drawing.Size(243, 22);
            this.Revert.Text = "Revert：変更取り消し";
            this.Revert.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Upgrade
            // 
            this.Upgrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Upgrade.Name = "Upgrade";
            this.Upgrade.Size = new System.Drawing.Size(243, 22);
            this.Upgrade.Text = "Upgrade：バージョンアップ";
            this.Upgrade.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Change
            // 
            this.Change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(243, 22);
            this.Change.Text = "Change：仕様変更";
            this.Change.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(243, 22);
            this.Add.Text = "Add：新規機能ファイル追加";
            this.Add.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(243, 22);
            this.Update.Text = "Update：バグではない機能修正";
            this.Update.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Clean
            // 
            this.Clean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(243, 22);
            this.Clean.Text = "Clean：リファクタリング,ファイル整理";
            this.Clean.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Close
            // 
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(243, 22);
            this.Close.Text = "Close";
            this.Close.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Disable;
        private System.Windows.Forms.ToolStripMenuItem Remove;
        private System.Windows.Forms.ToolStripMenuItem Fix;
        private System.Windows.Forms.ToolStripMenuItem Revert;
        private System.Windows.Forms.ToolStripMenuItem Upgrade;
        private System.Windows.Forms.ToolStripMenuItem Change;
        private System.Windows.Forms.ToolStripMenuItem Add;
        private System.Windows.Forms.ToolStripMenuItem Update;
        private System.Windows.Forms.ToolStripMenuItem Clean;
        private System.Windows.Forms.ToolStripMenuItem HotFix;
        private System.Windows.Forms.ToolStripMenuItem Close;
    }
}


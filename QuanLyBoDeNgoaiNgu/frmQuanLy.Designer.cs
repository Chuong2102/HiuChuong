namespace QuanLyBoDeNgoaiNgu
{
    partial class frmQuanLy
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.câuHỏiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.câuHỏiToolStripMenuItem,
            this.thiToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1172, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // câuHỏiToolStripMenuItem
            // 
            this.câuHỏiToolStripMenuItem.Name = "câuHỏiToolStripMenuItem";
            this.câuHỏiToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.câuHỏiToolStripMenuItem.Text = "Câu hỏi";
            // 
            // thiToolStripMenuItem
            // 
            this.thiToolStripMenuItem.Name = "thiToolStripMenuItem";
            this.thiToolStripMenuItem.Size = new System.Drawing.Size(43, 24);
            this.thiToolStripMenuItem.Text = "Thi";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngKýToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // đăngKýToolStripMenuItem
            // 
            this.đăngKýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.sinhViênToolStripMenuItem});
            this.đăngKýToolStripMenuItem.Name = "đăngKýToolStripMenuItem";
            this.đăngKýToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngKýToolStripMenuItem.Text = "Đăng ký";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // sinhViênToolStripMenuItem
            // 
            this.sinhViênToolStripMenuItem.Name = "sinhViênToolStripMenuItem";
            this.sinhViênToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sinhViênToolStripMenuItem.Text = "Sinh viên";
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 595);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmQuanLy";
            this.Text = "frmQuanLy";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem câuHỏiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhViênToolStripMenuItem;
    }
}
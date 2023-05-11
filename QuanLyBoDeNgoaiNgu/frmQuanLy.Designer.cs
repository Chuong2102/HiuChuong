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
            this.mnsQlCauHoi = new System.Windows.Forms.ToolStripMenuItem();
            this.thiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmQuanLySuatThi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmQuanLyDeThi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDangXuat = new System.Windows.Forms.ToolStripMenuItem();
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
            this.câuHỏiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsQlCauHoi});
            this.câuHỏiToolStripMenuItem.Name = "câuHỏiToolStripMenuItem";
            this.câuHỏiToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.câuHỏiToolStripMenuItem.Text = "Câu hỏi";
            // 
            // mnsQlCauHoi
            // 
            this.mnsQlCauHoi.Name = "mnsQlCauHoi";
            this.mnsQlCauHoi.Size = new System.Drawing.Size(194, 26);
            this.mnsQlCauHoi.Text = "Quản lý câu hỏi";
            this.mnsQlCauHoi.Click += new System.EventHandler(this.mnsQlCauHoi_Click);
            // 
            // thiToolStripMenuItem
            // 
            this.thiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmQuanLySuatThi,
            this.tsmQuanLyDeThi});
            this.thiToolStripMenuItem.Name = "thiToolStripMenuItem";
            this.thiToolStripMenuItem.Size = new System.Drawing.Size(43, 26);
            this.thiToolStripMenuItem.Text = "Thi";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(84, 26);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngKýToolStripMenuItem,
            this.tsmDangXuat});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(85, 26);
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
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // sinhViênToolStripMenuItem
            // 
            this.sinhViênToolStripMenuItem.Name = "sinhViênToolStripMenuItem";
            this.sinhViênToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.sinhViênToolStripMenuItem.Text = "Sinh viên";
            // 
            // tsmQuanLySuatThi
            // 
            this.tsmQuanLySuatThi.Name = "tsmQuanLySuatThi";
            this.tsmQuanLySuatThi.Size = new System.Drawing.Size(224, 26);
            this.tsmQuanLySuatThi.Text = "Quản lý suất thi";
            this.tsmQuanLySuatThi.Click += new System.EventHandler(this.tsmQuanLySuatThi_Click);
            // 
            // tsmQuanLyDeThi
            // 
            this.tsmQuanLyDeThi.Name = "tsmQuanLyDeThi";
            this.tsmQuanLyDeThi.Size = new System.Drawing.Size(224, 26);
            this.tsmQuanLyDeThi.Text = "Quản lý đề thi";
            // 
            // tsmDangXuat
            // 
            this.tsmDangXuat.Name = "tsmDangXuat";
            this.tsmDangXuat.Size = new System.Drawing.Size(224, 26);
            this.tsmDangXuat.Text = "Đăng Xuất";
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
        private System.Windows.Forms.ToolStripMenuItem mnsQlCauHoi;
        private System.Windows.Forms.ToolStripMenuItem tsmQuanLySuatThi;
        private System.Windows.Forms.ToolStripMenuItem tsmQuanLyDeThi;
        private System.Windows.Forms.ToolStripMenuItem tsmDangXuat;
    }
}
﻿namespace QuanLyBoDeNgoaiNgu
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTiengHan = new System.Windows.Forms.Button();
            this.btnTiengTrung = new System.Windows.Forms.Button();
            this.btnTiengNhat = new System.Windows.Forms.Button();
            this.btnTiengAnh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1081, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1078, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ADMIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1032, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nguyễn Thị Hiếu";
            // 
            // btnTiengHan
            // 
            this.btnTiengHan.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnTiengHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiengHan.Location = new System.Drawing.Point(286, 314);
            this.btnTiengHan.Name = "btnTiengHan";
            this.btnTiengHan.Size = new System.Drawing.Size(281, 157);
            this.btnTiengHan.TabIndex = 5;
            this.btnTiengHan.Text = "Tiếng Hàn";
            this.btnTiengHan.UseVisualStyleBackColor = false;
            // 
            // btnTiengTrung
            // 
            this.btnTiengTrung.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnTiengTrung.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiengTrung.Location = new System.Drawing.Point(582, 314);
            this.btnTiengTrung.Name = "btnTiengTrung";
            this.btnTiengTrung.Size = new System.Drawing.Size(281, 157);
            this.btnTiengTrung.TabIndex = 6;
            this.btnTiengTrung.Text = "Tiếng Trung";
            this.btnTiengTrung.UseVisualStyleBackColor = false;
            // 
            // btnTiengNhat
            // 
            this.btnTiengNhat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnTiengNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiengNhat.Location = new System.Drawing.Point(582, 126);
            this.btnTiengNhat.Name = "btnTiengNhat";
            this.btnTiengNhat.Size = new System.Drawing.Size(281, 157);
            this.btnTiengNhat.TabIndex = 7;
            this.btnTiengNhat.Text = "Tiếng Nhật";
            this.btnTiengNhat.UseVisualStyleBackColor = false;
            // 
            // btnTiengAnh
            // 
            this.btnTiengAnh.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnTiengAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiengAnh.Location = new System.Drawing.Point(286, 126);
            this.btnTiengAnh.Name = "btnTiengAnh";
            this.btnTiengAnh.Size = new System.Drawing.Size(281, 157);
            this.btnTiengAnh.TabIndex = 8;
            this.btnTiengAnh.Text = "Tiếng Anh";
            this.btnTiengAnh.UseVisualStyleBackColor = false;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 587);
            this.Controls.Add(this.btnTiengHan);
            this.Controls.Add(this.btnTiengTrung);
            this.Controls.Add(this.btnTiengNhat);
            this.Controls.Add(this.btnTiengAnh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTiengHan;
        private System.Windows.Forms.Button btnTiengTrung;
        private System.Windows.Forms.Button btnTiengNhat;
        private System.Windows.Forms.Button btnTiengAnh;
    }
}
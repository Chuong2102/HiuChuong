namespace QuanLyBoDeNgoaiNgu
{
    partial class ThemSuatThi
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
            this.btnThem = new System.Windows.Forms.Button();
            this.cmbBacST = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ddtNgayThi = new System.Windows.Forms.DateTimePicker();
            this.ddtStartime = new System.Windows.Forms.DateTimePicker();
            this.ddtEndtime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnThem.Location = new System.Drawing.Point(265, 347);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(198, 38);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "ADD";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cmbBacST
            // 
            this.cmbBacST.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbBacST.FormattingEnabled = true;
            this.cmbBacST.Location = new System.Drawing.Point(565, 196);
            this.cmbBacST.Name = "cmbBacST";
            this.cmbBacST.Size = new System.Drawing.Size(132, 24);
            this.cmbBacST.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(586, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bậc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thời gian bắt đầu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ngày thi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(206, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thời gian kết thúc";
            // 
            // ddtNgayThi
            // 
            this.ddtNgayThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddtNgayThi.Location = new System.Drawing.Point(201, 110);
            this.ddtNgayThi.Name = "ddtNgayThi";
            this.ddtNgayThi.Size = new System.Drawing.Size(496, 30);
            this.ddtNgayThi.TabIndex = 11;
            this.ddtNgayThi.Value = new System.DateTime(2023, 5, 18, 0, 0, 0, 0);
            // 
            // ddtStartime
            // 
            this.ddtStartime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddtStartime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ddtStartime.Location = new System.Drawing.Point(241, 196);
            this.ddtStartime.Name = "ddtStartime";
            this.ddtStartime.ShowUpDown = true;
            this.ddtStartime.Size = new System.Drawing.Size(252, 30);
            this.ddtStartime.TabIndex = 12;
            // 
            // ddtEndtime
            // 
            this.ddtEndtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddtEndtime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ddtEndtime.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ddtEndtime.Location = new System.Drawing.Point(241, 286);
            this.ddtEndtime.Name = "ddtEndtime";
            this.ddtEndtime.ShowUpDown = true;
            this.ddtEndtime.Size = new System.Drawing.Size(252, 30);
            this.ddtEndtime.TabIndex = 20;
            // 
            // ThemSuatThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ddtEndtime);
            this.Controls.Add(this.ddtStartime);
            this.Controls.Add(this.ddtNgayThi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cmbBacST);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemSuatThi";
            this.Text = "ThemSuatThi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cmbBacST;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker ddtNgayThi;
        private System.Windows.Forms.DateTimePicker ddtStartime;
        private System.Windows.Forms.DateTimePicker ddtEndtime;
    }
}
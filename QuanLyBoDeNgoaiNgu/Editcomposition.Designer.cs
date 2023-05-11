namespace QuanLyBoDeNgoaiNgu
{
    partial class Editcomposition
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
            this.ddtEndtime = new System.Windows.Forms.DateTimePicker();
            this.ddtStartime = new System.Windows.Forms.DateTimePicker();
            this.ddtNgayThi = new System.Windows.Forms.DateTimePicker();
            this.cmbBacST = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ddtEndtime
            // 
            this.ddtEndtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddtEndtime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ddtEndtime.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ddtEndtime.Location = new System.Drawing.Point(185, 296);
            this.ddtEndtime.Name = "ddtEndtime";
            this.ddtEndtime.Size = new System.Drawing.Size(213, 30);
            this.ddtEndtime.TabIndex = 28;
            this.ddtEndtime.ValueChanged += new System.EventHandler(this.ddtEndtime_ValueChanged);
            // 
            // ddtStartime
            // 
            this.ddtStartime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddtStartime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ddtStartime.Location = new System.Drawing.Point(185, 216);
            this.ddtStartime.Name = "ddtStartime";
            this.ddtStartime.Size = new System.Drawing.Size(213, 30);
            this.ddtStartime.TabIndex = 27;
            // 
            // ddtNgayThi
            // 
            this.ddtNgayThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddtNgayThi.Location = new System.Drawing.Point(185, 130);
            this.ddtNgayThi.Name = "ddtNgayThi";
            this.ddtNgayThi.Size = new System.Drawing.Size(328, 30);
            this.ddtNgayThi.TabIndex = 26;
            this.ddtNgayThi.Value = new System.DateTime(2023, 5, 5, 9, 33, 59, 0);
            // 
            // cmbBacST
            // 
            this.cmbBacST.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbBacST.FormattingEnabled = true;
            this.cmbBacST.Location = new System.Drawing.Point(185, 373);
            this.cmbBacST.Name = "cmbBacST";
            this.cmbBacST.Size = new System.Drawing.Size(111, 24);
            this.cmbBacST.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Bậc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(190, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 29);
            this.label4.TabIndex = 22;
            this.label4.Text = "Thời gian kết thúc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Thời gian bắt đầu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ngày thi";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button2.Location = new System.Drawing.Point(522, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 40);
            this.button2.TabIndex = 40;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Location = new System.Drawing.Point(522, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 40;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Editcomposition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ddtEndtime);
            this.Controls.Add(this.ddtStartime);
            this.Controls.Add(this.ddtNgayThi);
            this.Controls.Add(this.cmbBacST);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Editcomposition";
            this.Text = "Editcomposition";
            this.Load += new System.EventHandler(this.Editcomposition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker ddtEndtime;
        private System.Windows.Forms.DateTimePicker ddtStartime;
        private System.Windows.Forms.DateTimePicker ddtNgayThi;
        private System.Windows.Forms.ComboBox cmbBacST;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
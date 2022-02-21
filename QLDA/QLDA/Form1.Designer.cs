namespace QLDA
{
    partial class Form1
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
            this.txt_maphong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tenphong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_dbprev = new System.Windows.Forms.Button();
            this.txt_pos = new System.Windows.Forms.TextBox();
            this.btn_dbnext = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_luudl = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_maphong
            // 
            this.txt_maphong.Enabled = false;
            this.txt_maphong.Location = new System.Drawing.Point(108, 40);
            this.txt_maphong.Name = "txt_maphong";
            this.txt_maphong.Size = new System.Drawing.Size(195, 20);
            this.txt_maphong.TabIndex = 0;
            this.txt_maphong.TextChanged += new System.EventHandler(this.txt_maphong_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Phòng";
            // 
            // txt_tenphong
            // 
            this.txt_tenphong.Location = new System.Drawing.Point(108, 76);
            this.txt_tenphong.Name = "txt_tenphong";
            this.txt_tenphong.Size = new System.Drawing.Size(195, 20);
            this.txt_tenphong.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số điện thoại";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(108, 112);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(195, 20);
            this.txt_sdt.TabIndex = 5;
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Location = new System.Drawing.Point(129, 163);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(75, 23);
            this.btn_capnhat.TabIndex = 7;
            this.btn_capnhat.Text = "Cập Nhật";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(228, 163);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 8;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_dbprev
            // 
            this.btn_dbprev.Location = new System.Drawing.Point(25, 225);
            this.btn_dbprev.Name = "btn_dbprev";
            this.btn_dbprev.Size = new System.Drawing.Size(38, 23);
            this.btn_dbprev.TabIndex = 9;
            this.btn_dbprev.Text = "|<";
            this.btn_dbprev.UseVisualStyleBackColor = true;
            this.btn_dbprev.Click += new System.EventHandler(this.btn_dbprev_Click);
            // 
            // txt_pos
            // 
            this.txt_pos.Location = new System.Drawing.Point(113, 227);
            this.txt_pos.Name = "txt_pos";
            this.txt_pos.Size = new System.Drawing.Size(111, 20);
            this.txt_pos.TabIndex = 10;
            this.txt_pos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pos.TextChanged += new System.EventHandler(this.txt_pos_TextChanged);
            // 
            // btn_dbnext
            // 
            this.btn_dbnext.Location = new System.Drawing.Point(274, 225);
            this.btn_dbnext.Name = "btn_dbnext";
            this.btn_dbnext.Size = new System.Drawing.Size(38, 23);
            this.btn_dbnext.TabIndex = 11;
            this.btn_dbnext.Text = ">|";
            this.btn_dbnext.UseVisualStyleBackColor = true;
            this.btn_dbnext.Click += new System.EventHandler(this.btn_dbnext_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(230, 225);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(38, 23);
            this.btn_next.TabIndex = 12;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(69, 225);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(38, 23);
            this.btn_prev.TabIndex = 13;
            this.btn_prev.Text = "<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_luudl
            // 
            this.btn_luudl.Location = new System.Drawing.Point(32, 163);
            this.btn_luudl.Name = "btn_luudl";
            this.btn_luudl.Size = new System.Drawing.Size(75, 23);
            this.btn_luudl.TabIndex = 14;
            this.btn_luudl.Text = "Lưu";
            this.btn_luudl.UseVisualStyleBackColor = true;
            this.btn_luudl.Click += new System.EventHandler(this.btn_luudl_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(32, 163);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 15;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 288);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_luudl);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_dbnext);
            this.Controls.Add(this.txt_pos);
            this.Controls.Add(this.btn_dbprev);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tenphong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_maphong);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_maphong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tenphong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_dbprev;
        private System.Windows.Forms.TextBox txt_pos;
        private System.Windows.Forms.Button btn_dbnext;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_luudl;
        private System.Windows.Forms.Button btn_them;
    }
}


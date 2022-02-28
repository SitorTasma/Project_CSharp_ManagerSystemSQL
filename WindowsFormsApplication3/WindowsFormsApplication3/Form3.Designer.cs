namespace WindowsFormsApplication3
{
    partial class Form3
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
            this.outdata_dgv = new System.Windows.Forms.DataGridView();
            this.listDAID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchID_txt = new System.Windows.Forms.TextBox();
            this.btn_find = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.outdata_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // outdata_dgv
            // 
            this.outdata_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outdata_dgv.Location = new System.Drawing.Point(12, 52);
            this.outdata_dgv.Name = "outdata_dgv";
            this.outdata_dgv.Size = new System.Drawing.Size(445, 227);
            this.outdata_dgv.TabIndex = 0;
            // 
            // listDAID
            // 
            this.listDAID.FormattingEnabled = true;
            this.listDAID.Location = new System.Drawing.Point(79, 12);
            this.listDAID.Name = "listDAID";
            this.listDAID.Size = new System.Drawing.Size(121, 21);
            this.listDAID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Dự Án";
            // 
            // searchID_txt
            // 
            this.searchID_txt.Location = new System.Drawing.Point(257, 13);
            this.searchID_txt.Name = "searchID_txt";
            this.searchID_txt.Size = new System.Drawing.Size(79, 20);
            this.searchID_txt.TabIndex = 3;
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(359, 11);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(75, 23);
            this.btn_find.TabIndex = 4;
            this.btn_find.Text = "Tìm Theo";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 291);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.searchID_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listDAID);
            this.Controls.Add(this.outdata_dgv);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outdata_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView outdata_dgv;
        private System.Windows.Forms.ComboBox listDAID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchID_txt;
        private System.Windows.Forms.Button btn_find;
    }
}
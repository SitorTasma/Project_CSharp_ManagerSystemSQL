namespace WindowsFormsApplication3
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
            this.label1 = new System.Windows.Forms.Label();
            this.listDA = new System.Windows.Forms.ComboBox();
            this.outData_gridv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.outData_gridv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Dự Án";
            // 
            // listDA
            // 
            this.listDA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listDA.FormattingEnabled = true;
            this.listDA.Location = new System.Drawing.Point(111, 26);
            this.listDA.Name = "listDA";
            this.listDA.Size = new System.Drawing.Size(121, 21);
            this.listDA.TabIndex = 1;
            this.listDA.SelectedIndexChanged += new System.EventHandler(this.listDA_SelectedIndexChanged);
            // 
            // outData_gridv
            // 
            this.outData_gridv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outData_gridv.Location = new System.Drawing.Point(25, 77);
            this.outData_gridv.Name = "outData_gridv";
            this.outData_gridv.Size = new System.Drawing.Size(240, 150);
            this.outData_gridv.TabIndex = 2;
            this.outData_gridv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.outData_gridv_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.outData_gridv);
            this.Controls.Add(this.listDA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outData_gridv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView outData_gridv;
        public System.Windows.Forms.ComboBox listDA;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLDA
{
    public partial class Form1 : Form
    {
        string kn = @"Server=C203-25;Database=qlda;Integrated Security=True";
        CurrencyManager ct;
        public Form1()
        {
            InitializeComponent();
        }

        private void activeDataSQL()
        {
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM PHONGBAN", kn);
            DataSet ds = new DataSet();
            SDA.Fill(ds, "pb");
            // clear
            txt_maphong.DataBindings.Clear();
            txt_tenphong.DataBindings.Clear();
            txt_sdt.DataBindings.Clear();
            // add 
            txt_maphong.DataBindings.Add("Text", ds, "pb.MAPHONG");
            txt_tenphong.DataBindings.Add("Text", ds, "pb.TENPHONG");
            txt_sdt.DataBindings.Add("Text", ds, "pb.SODIENTHOAI");
            ct = (CurrencyManager)this.BindingContext[ds, "pb"];
        }

        private void txt_maphong_TextChanged(object sender, EventArgs e)
        {

        }
  
     

        private void Form1_Load(object sender, EventArgs e)
        {
            activeDataSQL();
            this.txt_pos.Text = ct.Position + 1 + "/" + ct.Count;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            this.btn_them.Visible = false;
            this.btn_luudl.Focus();
            this.txt_tenphong.Text = "";
            this.txt_maphong.Text = "";
            this.txt_sdt.Text = "";
            this.txt_maphong.Focus();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            ct.Position--;
            this.txt_pos.Text = Convert.ToString(ct.Position + 1 + "/" + ct.Count);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            ct.Position++;
            this.txt_pos.Text = Convert.ToString(ct.Position + 1 + "/" + ct.Count);
        }

        private void txt_pos_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_dbprev_Click(object sender, EventArgs e)
        {
            ct.Position = 0;
            this.txt_pos.Text = Convert.ToString(ct.Position + 1 + "/" + ct.Count);
        }

        private void btn_dbnext_Click(object sender, EventArgs e)
        {
            ct.Position = ct.Count;
            this.txt_pos.Text = Convert.ToString(ct.Position + 1 + "/" + ct.Count);
        }

     
    }
}

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
       public static SqlConnection kn = new SqlConnection(@"Server=.;Database=qlda;Integrated Security=True");
       public static SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM PHONGBAN", kn);
        CurrencyManager ct;
        DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void activeDataSQL()
        {
           
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
            this.txt_pos.Text = ct.Position + 1 + "/" + ct.Count;
        }
        private void insertDataSQL()
        {
            string query = String.Format("CHEN_PHONGBAN '{0}','{1}','{2}'", 
                this.txt_maphong.Text, this.txt_tenphong.Text, this.txt_sdt.Text);
            SqlCommand SQ = new SqlCommand(query, kn);
            try
            {
                SQ.Connection.Open();
                SQ.ExecuteNonQuery();
                MessageBox.Show(String.Format("Dữ liệu {0} đã được thêm.", this.txt_tenphong.Text));
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
            SQ.Connection.Close();
        }
        private void updateDataSQL()
        {
            string query = String.Format("CAPNHAT_PHONGBAN N'{0}','{1}','{2}'",
                this.txt_tenphong.Text, this.txt_sdt.Text, this.txt_maphong.Text);
            SqlCommand SQ = new SqlCommand(query, kn);
            SQ.Connection.Open();
            try
            { 
                SQ.ExecuteNonQuery();
                MessageBox.Show(String.Format("Dữ liệu {0} đã được thay đổi.", this.txt_maphong.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SQ.Connection.Close();
        }
        private void deleteDataSQL()
        {
            if (MessageBox.Show("Bạn thực sự muốn xóa mẫu tin này?", "Xác nhận", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                kn.Open();
                string query = String.Format("XOA_PHONGBAN '{0}'", this.txt_maphong.Text);
                SqlCommand SQ = new SqlCommand(query, kn);
                SQ.ExecuteNonQuery();
                MessageBox.Show(String.Format("Dữ liệu {0} đã xóa.", this.txt_maphong.Text));
                kn.Close();
            }else{
                MessageBox.Show("Mẫu tin chưa được xóa", "Thông báo");
                kn.Close();
            }
            
        }

        private void txt_maphong_TextChanged(object sender, EventArgs e)
        {

        }
  
     

        private void Form1_Load(object sender, EventArgs e)
        {
            activeDataSQL();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            this.btn_them.Visible = false;
            this.btn_luudl.Focus();
            this.txt_tenphong.Text = "";
            this.txt_maphong.Text = "";
            this.txt_sdt.Text = "";
            this.txt_maphong.Enabled = true;
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

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            deleteDataSQL();
            activeDataSQL();
        }

        private void btn_luudl_Click(object sender, EventArgs e)
        {
            if (this.txt_maphong.Text != "" && this.txt_tenphong.Text != "" && this.txt_sdt.Text != "")
            {
                insertDataSQL();
                activeDataSQL();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ");
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            updateDataSQL();
        }

     
    }
}

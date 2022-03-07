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
namespace WindowsFormsApplication3
{
    public partial class Form3 : Form
    {
        public static SqlConnection sc = new SqlConnection(@"Server=C203-25;Database=qlda;Integrated Security=true");
        public static SqlDataReader dr;
        public static SqlCommand cmd = new SqlCommand("SELECT * FROM DUAN", sc);
        private void activeDataSQL()
        {
            cmd.Connection.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listDA.Items.Add(dr.GetValue(0));
            }
            cmd.Connection.Close();
        }
        private void buoc_luoi()
        {
            string query = "SELECT * FROM THAMGIA WHERE MADA='" + this.listDA.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, sc);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataView dv = new DataView(dt);
            dv.Sort = "SOGIOLAMVIEC";
            this.outdata_dgv.DataSource = dv;
        }
        private void timtheo_manv()
        {
            string query = "SELECT * FROM THAMGIA WHERE MADA='" + this.listDA.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, sc);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataView dv = new DataView(dt);
            string manv = this.searchID_txt.Text;
            outdata_dgv.DataSource = dv.FindRows(manv);
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            activeDataSQL();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            timtheo_manv();
        }

        private void outdata_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listDA_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            buoc_luoi();
        }

        private void searchID_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form2 : Form
    {
        SqlConnection sq = new SqlConnection("Server=C203-25;Database=qlda;Integrated Security=true");
        BindingSource bs = new BindingSource();
        private void activeDataSQL(string type)
        {
            string query = "SELECT * FROM THAMGIA";
            switch (type)
            {
                case "dt":
                    {
                        SqlDataAdapter da = new SqlDataAdapter(query, sq);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        this.gridOutData.DataSource = dt;
                        break;
                    }
                case "ds":
                    {
                        SqlDataAdapter da = new SqlDataAdapter(query, sq);
                        DataSet dt = new DataSet();
                        da.Fill(dt);
                        this.gridOutData.DataSource = dt.Tables[0];
                        break;
                    }
                case "dv":
                    {
                        SqlDataAdapter da = new SqlDataAdapter(query, sq);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DataView dv = new DataView(dt);
                        this.gridOutData.DataSource = dv;
                        break;
                    }
                case "bs":
                    {
                        SqlDataAdapter da = new SqlDataAdapter(query, sq);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        bs.DataSource = dt;
                        controlbar_BN.BindingSource = bs;
                        this.gridOutData.DataSource = bs;
                        break;
                    }
            }
          
           
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
               
        }

        private void controlbar_BN_RefreshItems(object sender, EventArgs e)
        {

        }

        private void gridOutData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_dt_Click(object sender, EventArgs e)
        {
            activeDataSQL("dt");
        }

        private void btn_binds_Click(object sender, EventArgs e)
        {
            activeDataSQL("bs");
        }

        private void btn_ds_Click(object sender, EventArgs e)
        {
            activeDataSQL("ds");
        }

        private void btn_dv_Click(object sender, EventArgs e)
        {
            activeDataSQL("dv");
        }
    }
}

﻿using System;
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
    public partial class Form1 : Form
    {
        public static SqlConnection sq = new SqlConnection(@"Server=.;Database=qlda; Integrated Security=true");
        public static SqlDataReader dr;
        public static SqlCommand cmd = new SqlCommand("SELECT * FROM DUAN", sq);
        private void buoc_cbo_mada()
        {
            cmd.Connection.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listDA.Items.Add(dr.GetValue(0));
            }
            cmd.Connection.Close();
        }
//Phương thức buộc dữ liệu lên điều khiển DataGridView
        public Form1()
        {
            InitializeComponent();
            string chuoi = "Select * from thamgia where mada ='" + this.listDA.Text + "'";

            SqlDataAdapter da = new SqlDataAdapter(chuoi, sq);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.outData_gridv.DataSource = dt;
        }
   
        private void Form1_Load(object sender, EventArgs e)
        {
            buoc_cbo_mada();
        }

        private void listDA_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void outData_gridv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

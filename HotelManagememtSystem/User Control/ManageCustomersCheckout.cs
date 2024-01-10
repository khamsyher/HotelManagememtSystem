using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagememtSystem.User_Control
{
    public partial class ManageCustomersCheckout : UserControl
    {
        SqlConnection con;
        SqlCommand cmd;
        DataTable dtb;
        SqlDataAdapter da;
        public ManageCustomersCheckout()
        {
            InitializeComponent();
        }

        private void ManageCustomersCheckout_Load(object sender, EventArgs e)
        {
            show();
        }
        void show()
        {
            con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("SELECT * FROM Tb_CustomersCheckout;", con);
            da = new SqlDataAdapter(cmd);
            dtb = new DataTable();
            da.Fill(dtb);
            ShowCustomerCheckout.DataSource = dtb;
            con.Close();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                show();
            }
            else
            {
                con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                string sql = "SELECT * FROM Tb_CustomersCheckout WHERE o_name='" + txt_search.Text + "'";
                con.Open();
                da = new SqlDataAdapter(sql, con);
                dtb = new DataTable();
                da.Fill(dtb);
                ShowCustomerCheckout.DataSource = dtb;
                con.Close();
            }
        }
    }
}

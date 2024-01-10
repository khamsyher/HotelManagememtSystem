using HotelManagememtSystem.User_Control;
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

namespace HotelManagememtSystem
{
    public partial class LoginFrm : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dr;
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void btn_log_Click(object sender, EventArgs e)
        {

            if (txt_username.Text != string.Empty || txt_password.Text != string.Empty)
            {
                cmd = new SqlCommand("SELECT * FROM Tb_Employees WHERE e_name= '" + txt_username.Text + "'AND e_password='" + txt_password.Text + "'", con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string employeeName = dr["e_name"].ToString(); // Assuming the column name is "e_name"
                    string employeeRole = dr["e_role"].ToString(); // Assuming the column name is "e_role"
                    dr.Close();
                    this.Hide();

                    HomeFrm hf = new HomeFrm();
                    hf.SetEmployeeName(employeeName); // Pass the employee name to HomeFrm
                    hf.SetEmployeeRole(employeeRole);
                    hf.ShowDialog();
        
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No User Permission", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_username.Text = "";
                    txt_password.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please Enter valid User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
            con.Open();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            RegisterFrm registerFrm = new RegisterFrm();
            registerFrm.ShowDialog();
        }
    }
}

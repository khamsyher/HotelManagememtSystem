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
    public partial class ManageHome : UserControl
    {
        SqlConnection con;
        SqlCommand cmd;
        DataTable dtb;
        SqlDataAdapter da;
        public ManageHome()
        {
            InitializeComponent();
        }

        private void ManageHome_Load(object sender, EventArgs e)
        {
            show();
            showBusyRoom();
            showTotalEmployee();
            showTotalCustomer();
        }
        void show()
        {
            con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
            con.Open();

            cmd = new SqlCommand("SELECT count(r.r_number) FROM Tb_Room r Left JOIN Tb_Customers c ON c.room = r.r_number WHERE c.room IS NULL;", con);
            da = new SqlDataAdapter(cmd);
            dtb = new DataTable();
            da.Fill(dtb);

            // Assuming ChartRoom is your Guna2CircleProgressBar control
            int bookingCount = int.Parse(dtb.Rows[0][0].ToString());
            SetProgressBarValue(bookingCount);

            con.Close();
        }


        // Function to update the Guna2CircleProgressBar value
        private void SetProgressBarValue(int value)
        {
            // Assuming ChartRoom is your Guna2CircleProgressBar control
            ChartRoom.Value = value;

            txt_freeRoom.Text= value.ToString();
            txt_room.Text= value.ToString();
            ChartRoom.Maximum = 20; 
            ChartRoom.Minimum = 0;  
        }
        void showBusyRoom()
        {
            con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
            con.Open();

            cmd = new SqlCommand("SELECT count(r.r_number) FROM Tb_Room r Left JOIN Tb_Customers c ON c.room = r.r_number WHERE c.room IS NOT NULL;", con);
            da = new SqlDataAdapter(cmd);
            dtb = new DataTable();
            da.Fill(dtb);

            // Assuming ChartRoom is your Guna2CircleProgressBar control
            int bookingRoom = int.Parse(dtb.Rows[0][0].ToString());
            txt_BusyRoom.Text = bookingRoom.ToString();

            con.Close();
        }
        void showTotalEmployee()
        {
            con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
            con.Open();

            cmd = new SqlCommand("SELECT count(*) FROM Tb_Employees;", con);
            da = new SqlDataAdapter(cmd);
            dtb = new DataTable();
            da.Fill(dtb);

            // Assuming ChartRoom is your Guna2CircleProgressBar control
            int totalEmployee = int.Parse(dtb.Rows[0][0].ToString());
            txt_totalemployee.Text = totalEmployee.ToString();

            con.Close();
        }
        void showTotalCustomer()
        {
            con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
            con.Open();

            cmd = new SqlCommand("SELECT count(*) FROM Tb_Customers;", con);
            da = new SqlDataAdapter(cmd);
            dtb = new DataTable();
            da.Fill(dtb);

            // Assuming ChartRoom is your Guna2CircleProgressBar control
            int totalEmployee = int.Parse(dtb.Rows[0][0].ToString());
            txt_totalcustomer.Text = totalEmployee.ToString();

            con.Close();
        }
    }
}

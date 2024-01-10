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
    public partial class ManageRooms : UserControl
    {
        SqlConnection con;
        SqlCommand cmd;
        DataTable dtb;
        SqlDataAdapter da;
        public event EventHandler<int> RoomSelected;
        public ManageRooms()
        {
            InitializeComponent();
        }

        private void room1_Click(object sender, EventArgs e)
        {
            
            if (this.ParentForm is HomeFrm homeForm)
            {

                ManageCustomer manageRoomsControl = new ManageCustomer();
                homeForm.addUserControl(manageRoomsControl);
            }

        }

        private void Room1_Paint(object sender, PaintEventArgs e)
        {
           
        }

      

        private void room1_Paint_2(object sender, PaintEventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM Tb_Customers WHERE room = 101;", con);

                int customerCount = (int)cmd.ExecuteScalar();

                if (customerCount > 0)
                {
                    txt_room1.Text = "ເຕັມ";
                    txt_room1.ForeColor = Color.White;
                    bg_room1.FillColor = Color.FromArgb(255, 177, 152);
                }
                else
                {
                    // No customers in the room
                    txt_room1.Text = "ວ່າງ";
                    bg_room1.FillColor = Color.FromArgb(212, 230, 241);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void room1_Click_2(object sender, EventArgs e)
        {

        }

        private void room2_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM Tb_Customers WHERE room = 102;", con);

                int customerCount = (int)cmd.ExecuteScalar();

                if (customerCount > 0)
                {
                    txt_room2.Text = "ເຕັມ";
                    txt_room2.ForeColor = Color.White;
                    bg_room2.FillColor = Color.FromArgb(255, 177, 152);
                }
                else
                {
                    // No customers in the room
                    txt_room2.Text = "ວ່າງ";
                    bg_room2.FillColor = Color.FromArgb(212, 230, 241);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void room3_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM Tb_Customers WHERE room = 103;", con);

                int customerCount = (int)cmd.ExecuteScalar();

                if (customerCount > 0)
                {
                    txt_room3.Text = "ເຕັມ";
                    txt_room3.ForeColor = Color.White;
                    bg_room3.FillColor = Color.FromArgb(255, 177, 152);
                }
                else
                {
                    // No customers in the room
                    txt_room3.Text = "ວ່າງ";
                    bg_room3.FillColor = Color.FromArgb(212, 230, 241);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void room4_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM Tb_Customers WHERE room = 104;", con);

                int customerCount = (int)cmd.ExecuteScalar();

                if (customerCount > 0)
                {
                    txt_room4.Text = "ເຕັມ";
                    txt_room4.ForeColor = Color.White;
                    bg_room4.FillColor = Color.FromArgb(255, 177, 152);
                }
                else
                {
                    // No customers in the room
                    txt_room4.Text = "ວ່າງ";
                    bg_room4.FillColor = Color.FromArgb(212, 230, 241);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void room5_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM Tb_Customers WHERE room = 105;", con);

                int customerCount = (int)cmd.ExecuteScalar();

                if (customerCount > 0)
                {
                    txt_room5.Text = "ເຕັມ";
                    txt_room5.ForeColor = Color.White;
                    bg_room5.FillColor = Color.FromArgb(255, 177, 152);
                }
                else
                {
                    // No customers in the room
                    txt_room5.Text = "ວ່າງ";
                    bg_room5.FillColor = Color.FromArgb(212, 230, 241);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void room6_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM Tb_Customers WHERE room = 106;", con);

                int customerCount = (int)cmd.ExecuteScalar();

                if (customerCount > 0)
                {
                    txt_room6.Text = "ເຕັມ";
                    txt_room6.ForeColor = Color.White;
                    bg_room6.FillColor = Color.FromArgb(255, 177, 152);
                }
                else
                {
                    // No customers in the room
                    txt_room6.Text = "ວ່າງ";
                    bg_room6.FillColor = Color.FromArgb(212, 230, 241);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void room7_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM Tb_Customers WHERE room = 107;", con);

                int customerCount = (int)cmd.ExecuteScalar();

                if (customerCount > 0)
                {
                    txt_room7.Text = "ເຕັມ";
                    txt_room7.ForeColor = Color.White;
                    bg_room7.FillColor = Color.FromArgb(255, 177, 152);
                }
                else
                {
                    // No customers in the room
                    txt_room7.Text = "ວ່າງ";
                    bg_room7.FillColor = Color.FromArgb(212, 230, 241);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void room8_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM Tb_Customers WHERE room = 108;", con);

                int customerCount = (int)cmd.ExecuteScalar();

                if (customerCount > 0)
                {
                    txt_room8.Text = "ເຕັມ";
                    txt_room8.ForeColor = Color.White;
                    bg_room8.FillColor = Color.FromArgb(255, 177, 152);
                }
                else
                {
                    // No customers in the room
                    txt_room8.Text = "ວ່າງ";
                    bg_room8.FillColor = Color.FromArgb(212, 230, 241);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void room9_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM Tb_Customers WHERE room = 109;", con);

                int customerCount = (int)cmd.ExecuteScalar();

                if (customerCount > 0)
                {
                    txt_room9.Text = "ເຕັມ";
                    txt_room9.ForeColor = Color.White;
                    bg_room9.FillColor = Color.FromArgb(255, 177, 152);
                }
                else
                {
                    // No customers in the room
                    txt_room9.Text = "ວ່າງ";
                    bg_room9.FillColor = Color.FromArgb(212, 230, 241);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void room10_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM Tb_Customers WHERE room = 110;", con);

                int customerCount = (int)cmd.ExecuteScalar();

                if (customerCount > 0)
                {
                    txt_room10.Text = "ເຕັມ";
                    txt_room10.ForeColor = Color.White;
                    bg_room10.FillColor = Color.FromArgb(255, 177, 152);
                }
                else
                {
                    // No customers in the room
                    txt_room10.Text = "ວ່າງ";
                    bg_room10.FillColor = Color.FromArgb(212, 230, 241);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void room11_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM Tb_Customers WHERE room = 111;", con);

                int customerCount = (int)cmd.ExecuteScalar();

                if (customerCount > 0)
                {
                    txt_room11.Text = "ເຕັມ";
                    txt_room11.ForeColor = Color.White;
                    bg_room11.FillColor = Color.FromArgb(255, 177, 152);
                }
                else
                {
                    // No customers in the room
                    txt_room11.Text = "ວ່າງ";
                    bg_room11.FillColor = Color.FromArgb(212, 230, 241);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void room12_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM Tb_Customers WHERE room = 112;", con);

                int customerCount = (int)cmd.ExecuteScalar();

                if (customerCount > 0)
                {
                    txt_room12.Text = "ເຕັມ";
                    txt_room12.ForeColor = Color.White;
                    bg_room12.FillColor = Color.FromArgb(255, 177, 152);
                }
                else
                {
                    // No customers in the room
                    txt_room12.Text = "ວ່າງ";
                    bg_room12.FillColor = Color.FromArgb(212, 230, 241);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void room13_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM Tb_Customers WHERE room = 113;", con);

                int customerCount = (int)cmd.ExecuteScalar();

                if (customerCount > 0)
                {
                    txt_room13.Text = "ເຕັມ";
                    txt_room13.ForeColor = Color.White;
                    bg_room13.FillColor = Color.FromArgb(255, 177, 152);
                }
                else
                {
                    // No customers in the room
                    txt_room13.Text = "ວ່າງ";
                    bg_room13.FillColor = Color.FromArgb(212, 230, 241);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void room14_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM Tb_Customers WHERE room = 114;", con);

                int customerCount = (int)cmd.ExecuteScalar();

                if (customerCount > 0)
                {
                    txt_room14.Text = "ເຕັມ";
                    txt_room14.ForeColor = Color.White;
                    bg_room14.FillColor = Color.FromArgb(255, 177, 152);
                }
                else
                {
                    // No customers in the room
                    txt_room14.Text = "ວ່າງ";
                    bg_room14.FillColor = Color.FromArgb(212, 230, 241);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void room15_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM Tb_Customers WHERE room = 115;", con);

                int customerCount = (int)cmd.ExecuteScalar();

                if (customerCount > 0)
                {
                    txt_room15.Text = "ເຕັມ";
                    txt_room15.ForeColor = Color.White;
                    bg_room15.FillColor = Color.FromArgb(255, 177, 152);
                }
                else
                {
                    // No customers in the room
                    txt_room15.Text = "ວ່າງ";
                    bg_room15.FillColor = Color.FromArgb(212, 230, 241);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void room16_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM Tb_Customers WHERE room = 116;", con);

                int customerCount = (int)cmd.ExecuteScalar();

                if (customerCount > 0)
                {
                    txt_room16.Text = "ເຕັມ";
                    txt_room16.ForeColor = Color.White;
                    bg_room16.FillColor = Color.FromArgb(255, 177, 152);
                }
                else
                {
                    // No customers in the room
                    txt_room16.Text = "ວ່າງ";
                    bg_room16.FillColor = Color.FromArgb(212, 230, 241);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void room17_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM Tb_Customers WHERE room = 117;", con);

                int customerCount = (int)cmd.ExecuteScalar();

                if (customerCount > 0)
                {
                    txt_room17.Text = "ເຕັມ";
                    txt_room17.ForeColor = Color.White;
                    bg_room17.FillColor = Color.FromArgb(255, 177, 152);
                }
                else
                {
                    // No customers in the room
                    txt_room17.Text = "ວ່າງ";
                    bg_room17.FillColor = Color.FromArgb(212, 230, 241);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void room18_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM Tb_Customers WHERE room = 118;", con);

                int customerCount = (int)cmd.ExecuteScalar();

                if (customerCount > 0)
                {
                    txt_room18.Text = "ເຕັມ";
                    txt_room18.ForeColor = Color.White;
                    bg_room18.FillColor = Color.FromArgb(255, 177, 152);
                }
                else
                {
                    // No customers in the room
                    txt_room18.Text = "ວ່າງ";
                    bg_room18.FillColor = Color.FromArgb(212, 230, 241);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void room19_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM Tb_Customers WHERE room = 119;", con);

                int customerCount = (int)cmd.ExecuteScalar();

                if (customerCount > 0)
                {
                    txt_room19.Text = "ເຕັມ";
                    txt_room19.ForeColor = Color.White;
                    bg_room19.FillColor = Color.FromArgb(255, 177, 152);
                }
                else
                {
                    // No customers in the room
                    txt_room19.Text = "ວ່າງ";
                    bg_room19.FillColor = Color.FromArgb(212, 230, 241);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void room20_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM Tb_Customers WHERE room = 120;", con);

                int customerCount = (int)cmd.ExecuteScalar();

                if (customerCount > 0)
                {
                    txt_room20.Text = "ເຕັມ";
                    txt_room20.ForeColor = Color.White;
                    bg_room20.FillColor = Color.FromArgb(255, 177, 152);
                }
                else
                {
                    // No customers in the room
                    txt_room20.Text = "ວ່າງ";
                    bg_room20.FillColor = Color.FromArgb(212, 230, 241);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManageRooms_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagememtSystem.User_Control
{
    public partial class ManageCustomer : UserControl
    {
        SqlConnection con;
        SqlCommand cmd;
        DataTable dtb;
        SqlDataAdapter da;
        public ManageCustomer()
        {
            InitializeComponent();
        }
        void show()
        {
            con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("SELECT c.c_id,c.c_name, c.c_age, c.c_gender, c.c_phone, c.checkin, c.checkout, c.room, FORMAT(c.price, 'N2', 'de-DE') as price, c.paystatus FROM Tb_Customers c;", con);
            //cmd = new SqlCommand("SELECT c.c_id,c.c_name, c.c_age, c.c_gender, c.c_phone, c.checkin, c.checkout, r.r_number as room, FORMAT(c.price, 'N2', 'de-DE') as price FROM Tb_Customers c JOIN Tb_Room r ON c.room = r.id;", con);
            da = new SqlDataAdapter(cmd);
            dtb = new DataTable();
            da.Fill(dtb);
            ShowCustomer.DataSource = dtb;
            ShowCustomer.AutoGenerateColumns = true;
            con.Close();

        }
        void Roominfo()
        {
            con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("SELECT r.r_number FROM Tb_Room r Left JOIN Tb_Customers c ON c.room = r.r_number WHERE c.room IS NULL;", con);
            da = new SqlDataAdapter(cmd);
            dtb = new DataTable();
            da.Fill(dtb);
            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                cb_room.Items.Add(dtb.Rows[i]["r_number"]);
            }
            cb_room.DisplayMember = "r_number";
            cb_room.ValueMember = "id";

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cname.Text) || string.IsNullOrEmpty(txt_cage.Text))
            {
                MessageBox.Show("ຂໍ້ມູນບໍ່ຄົບ, ກະລຸນາປ້ອນຂໍ້ມູນໃຫ້ຄົບ!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                con.Open();

                // Check if customer with the same name already exists
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Tb_Customers WHERE c_name = @customername", con);
                checkCmd.Parameters.AddWithValue("@customername", txt_cname.Text);

                int customerCount = (int)checkCmd.ExecuteScalar();

                if (customerCount > 0)
                {
                    MessageBox.Show("ຊື່ພະນັກງານນັ້ນມີແລ້ວ, ກະລຸນາປ້ອນຊື່ໃໝ່!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Validate checkout date
                    DateTime checkinDate = dt_checkin.Value;
                    DateTime checkoutDate = dt_checkout.Value;

                    if (checkoutDate <= checkinDate)
                    {
                        MessageBox.Show("ວັນທີເຂົ້າມາບໍ່ສາມາດຫຼັກຂໍ້ມູນໄດ້, ກະລຸນາເລືອກວັນທີໃຫ້ຖືກຕ້ອງ!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Insert data
                    string gender = rb_male.Checked ? "ຊາຍ" : (rb_female.Checked ? "ຍິງ" : "ອື່ນໆ");

                    cmd = new SqlCommand("INSERT INTO Tb_Customers(c_name, c_age, c_gender, c_phone, checkin, checkout, room, price, paystatus)  values(@customername, @age, @gender, @phone, @checkin, @checkout, @room, @price, @paystatus)", con);
                    cmd.Parameters.AddWithValue("@customername", txt_cname.Text);
                    cmd.Parameters.AddWithValue("@age", int.Parse(txt_cage.Text));
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@phone", txt_cphone.Text);
                    cmd.Parameters.AddWithValue("@checkin", checkinDate);
                    cmd.Parameters.AddWithValue("@checkout", checkoutDate);
                    cmd.Parameters.AddWithValue("@room", cb_room.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@price", decimal.Parse(txt_price.Text));
                    cmd.Parameters.AddWithValue("@paystatus", cb_Paystatus.SelectedItem);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("ເພີ່ມຂໍ້ມູນພະນັກງານສຳເລັດ!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    show();
                    txt_cid.Text = "";
                    txt_cname.Text = "";
                    txt_cage.Text = "";
                    rb_male.Checked = false;
                    rb_female.Checked = false;
                    rb_other.Checked = false;
                    txt_cphone.Text = "";
                    txt_price.Text = "";
                    cb_room.SelectedIndex = 0;
                    cb_Paystatus.SelectedItem = "";
                }
            }
        }

        private void ManageCustomer_Load(object sender, EventArgs e)
        {
            show();
            Roominfo();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                string gender = rb_male.Checked ? "ຊາຍ" : (rb_female.Checked ? "ຍິງ" : "ອື່ນໆ");
                // Validate checkout date
                DateTime checkinDate = dt_checkin.Value;
                DateTime checkoutDate = dt_checkout.Value;

                cmd = new SqlCommand("UPDATE Tb_Customers SET c_name=@customername, c_age=@age, c_gender=@gender, c_phone=@phone, checkin=@checkin, checkout=@checkout, room=@room, price=@price, paystatus=@paystatus WHERE c_id=@cid", con);
                cmd.Parameters.AddWithValue("@cid", txt_cid.Text);
                cmd.Parameters.AddWithValue("@customername", txt_cname.Text);
                cmd.Parameters.AddWithValue("@age", int.Parse(txt_cage.Text));
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@phone", txt_cphone.Text);
                cmd.Parameters.AddWithValue("@checkin", checkinDate);
                cmd.Parameters.AddWithValue("@checkout", checkoutDate);
                cmd.Parameters.AddWithValue("@room", cb_room.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@price", decimal.Parse(txt_price.Text));
                cmd.Parameters.AddWithValue("@paystatus", cb_Paystatus.SelectedItem?.ToString() ?? "");
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("ແກ້ໄຂຂໍ້ມູນພະນັກງານສຳເລັດ!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                show();
                txt_cid.Text = "";
                txt_cname.Text = "";
                txt_cage.Text = "";
                rb_male.Checked = false;
                rb_female.Checked = false;
                rb_other.Checked = false;
                txt_cphone.Text = "";
                dt_checkin.Value = DateTime.Now;
                dt_checkout.Value = DateTime.Now;
                txt_price.Text = "";
                cb_Paystatus.SelectedItem = "";
            }
            catch (System.Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ShowCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow SelectedRow = ShowCustomer.Rows[index];

            txt_cid.Text = SelectedRow.Cells[0].Value.ToString();
            txt_cname.Text = SelectedRow.Cells[1].Value.ToString();
            txt_cage.Text = SelectedRow.Cells[2].Value.ToString();
            txt_cphone.Text = SelectedRow.Cells[4].Value.ToString();
            dt_checkin.Value = Convert.ToDateTime(SelectedRow.Cells[5].Value);
            dt_checkout.Value = Convert.ToDateTime(SelectedRow.Cells[6].Value);
            cb_room.Text = SelectedRow.Cells[7].Value?.ToString();
            cb_Paystatus.Text = SelectedRow.Cells[9].Value?.ToString();
            //cb_pay.Text = SelectedRow?.Cells[9].ToString();

            if (SelectedRow.Cells[8].Value != null && decimal.TryParse(SelectedRow.Cells[8].Value.ToString(), out decimal price))
            {
                txt_price.Text = price.ToString("#,###,##0.00"); // Format price with commas
            }
            else
            {
                // Handle the case where the price is not a valid decimal or is null
                txt_price.Text = "0.00"; // Set a default value
                MessageBox.Show("Invalid or null price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string gender = SelectedRow.Cells[3].Value.ToString();

            switch (gender)
            {
                case "ຊາຍ":
                    rb_male.Checked = true;
                    break;
                case "ຍິງ":
                    rb_female.Checked = true;
                    break;
                case "ອື່ນໆ":
                    rb_other.Checked = true;
                    break;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                String sql = "DELETE FROM Tb_Customers WHERE c_id=@cid;";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@cid", txt_cid.Text);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("ລືບຂໍ້ມູນພະນັກງານສຳເລັດ!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                show();
                txt_cid.Text = "";
                txt_cname.Text = "";
                txt_cage.Text = "";
                rb_male.Checked = false;
                rb_female.Checked = false;
                rb_other.Checked = false;
                txt_cphone.Text = "";
                dt_checkin.Value = DateTime.Now;
                dt_checkout.Value = DateTime.Now;
                cb_Paystatus.SelectedItem = "";

            }
            catch (System.Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_cid.Text = "";
            txt_cname.Text = "";
            txt_cage.Text = "";
            rb_male.Checked = false;
            rb_female.Checked = false;
            rb_other.Checked = false;
            txt_cphone.Text = "";
            dt_checkin.Value = DateTime.Now;
            dt_checkout.Value = DateTime.Now;
            cb_Paystatus.SelectedItem = "";
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
                string sql = "SELECT * FROM Tb_Customers WHERE c_name='" + txt_search.Text + "'";
                con.Open();
                da = new SqlDataAdapter(sql, con);
                dtb = new DataTable();
                da.Fill(dtb);
                ShowCustomer.DataSource = dtb;
                con.Close();
            }
        }


        // choose room from ManageRoom
        private void btn_chooseRoom_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is HomeFrm homeForm)
            {
               
                ManageRooms manageRoomsControl = new ManageRooms();
                homeForm.addUserControl(manageRoomsControl);
            }
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                string gender = rb_male.Checked ? "ຊາຍ" : (rb_female.Checked ? "ຍິງ" : "ອື່ນໆ");

                // Validate checkout date
                DateTime checkinDate = dt_checkin.Value;
                DateTime checkoutDate = dt_checkout.Value;

                // Insert into Tb_CustomersCheckout
                cmd = new SqlCommand("INSERT INTO Tb_CustomersCheckout(o_id, o_name, o_age, o_gender, o_phone, o_checkin, o_checkout, o_room, price, o_paystatus)  VALUES(@cid, @customername, @age, @gender, @phone, @checkin, @checkout, @room, @price, @paystatus);", con);
                cmd.Parameters.AddWithValue("@cid", int.Parse(txt_cid.Text));
                cmd.Parameters.AddWithValue("@customername", txt_cname.Text);
                cmd.Parameters.AddWithValue("@age", int.Parse(txt_cage.Text));
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@phone", txt_cphone.Text);
                cmd.Parameters.AddWithValue("@checkin", checkinDate);
                cmd.Parameters.AddWithValue("@checkout", checkoutDate);
                cmd.Parameters.AddWithValue("@price", decimal.Parse(txt_price.Text));
                cmd.Parameters.AddWithValue("@room", cb_room.SelectedItem?.ToString() ?? "");
                cmd.Parameters.AddWithValue("@paystatus", cb_Paystatus.SelectedItem?.ToString() ?? "");

                con.Open();
                cmd.ExecuteNonQuery();

                // Delete from Tb_Customers
                SqlCommand deleteCmd = new SqlCommand("DELETE FROM Tb_Customers WHERE c_id = @cid;", con);
                deleteCmd.Parameters.AddWithValue("@cid", int.Parse(txt_cid.Text));
                deleteCmd.ExecuteNonQuery();

                MessageBox.Show("CHECKOUT CUSTOMER SUCCESS!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                show();

                // Clear the form fields
                txt_cid.Text = "";
                txt_cname.Text = "";
                txt_cage.Text = "";
                rb_male.Checked = false;
                rb_female.Checked = false;
                rb_other.Checked = false;
                txt_cphone.Text = "";
                dt_checkin.Value = DateTime.Now;
                dt_checkout.Value = DateTime.Now;
                txt_price.Text = "";
                cb_room.SelectedIndex = 0;
                cb_Paystatus.SelectedItem = 0;
            }
            catch (System.Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

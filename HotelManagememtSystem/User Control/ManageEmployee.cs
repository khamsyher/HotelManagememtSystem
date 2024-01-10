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
    public partial class ManageEmployee : UserControl
    {
        SqlConnection con;
        SqlCommand cmd;
        DataTable dtb;
        SqlDataAdapter da;
        public ManageEmployee()
        {
            InitializeComponent();
        }
        void show()
        {
            con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("SELECT e.e_id, e.e_name, e.e_password, e.e_age, e.e_gender, e.e_phone, p.position, e.e_role FROM Tb_Employees e JOIN Tb_Position p ON e.e_position = p.id;", con);
            da = new SqlDataAdapter(cmd);
            dtb = new DataTable();
            da.Fill(dtb);
            ShowEmployee.DataSource = dtb;
            ShowEmployee.AutoGenerateColumns = true;
            con.Close();

        }
        void positioninfo()
        {
            con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("SELECT position FROM Tb_Position", con);
            da = new SqlDataAdapter(cmd);
            dtb = new DataTable();
            da.Fill(dtb);
            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                cb_position.Items.Add(dtb.Rows[i]["position"]);
            }
            cb_position.DisplayMember = "position";
            cb_position.ValueMember = "id";

        }

        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            show();
            positioninfo();
            //ShowEmployee.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        /*Add data*/
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ename.Text) || string.IsNullOrEmpty(txt_eage.Text) || string.IsNullOrEmpty(txt_epassword.Text))
            {
                MessageBox.Show("ຂໍ້ມູນບໍ່ຄົບ, ກະລຸນາປ້ອນຂໍ້ມູນໃຫ້ຄົບ!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                con.Open();

                // Check if employee with the same name already exists
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Tb_Employees WHERE e_name = @employeename", con);
                checkCmd.Parameters.AddWithValue("@employeename", txt_ename.Text);

                int employeeCount = (int)checkCmd.ExecuteScalar();

                if (employeeCount > 0)
                {
                    MessageBox.Show("ຊື່ພະນັກງານນັ້ນມີແລ້ວ, ກະລຸນາປ້ອນຊື່ໃໝ່!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Insert data
                    string gender = rb_male.Checked ? "ຊາຍ" : (rb_female.Checked ? "ຍິງ" : "ອື່ນໆ");

                    cmd = new SqlCommand("INSERT INTO Tb_Employees (e_name, e_password, e_age, e_gender, e_phone, e_position, e_role )  values(@employeename, @password, @age, @gender, @phone, @position, @role )", con);
                    cmd.Parameters.AddWithValue("@employeename", txt_ename.Text);
                    cmd.Parameters.AddWithValue("@password", txt_epassword.Text);
                    cmd.Parameters.AddWithValue("@age", int.Parse(txt_eage.Text));
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@phone", txt_ephone.Text);
                    cmd.Parameters.AddWithValue("@position", cb_position.SelectedIndex+1);
                    cmd.Parameters.AddWithValue("@role", cb_EmployeeRole.SelectedItem);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ເພີ່ມຂໍ້ມູນພະນັກງານສຳເລັດ!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    show();
                    txt_eid.Text = "";
                    txt_ename.Text = "";
                    txt_eage.Text = "";
                    rb_male.Checked = false;
                    rb_female.Checked = false;
                    rb_other.Checked = false;
                    txt_ephone.Text = "";
                    txt_epassword.Text = "";
                    cb_position.SelectedIndex = -1;
                    cb_EmployeeRole.SelectedIndex = -1;
                }
            }
        }


        /*Update data*/

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try {
                con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                string gender = rb_male.Checked ? "ຊາຍ" : (rb_female.Checked ? "ຍິງ" : "ອື່ນໆ");

                cmd = new SqlCommand("UPDATE Tb_Employees SET e_name=@employeename, e_password=@password, e_age=@age, e_gender=@gender, e_phone=@phone, e_position=@position, e_role=@role WHERE e_id=@eid", con);
                cmd.Parameters.AddWithValue("@eid", txt_eid.Text);
                cmd.Parameters.AddWithValue("@employeename", txt_ename.Text);
                cmd.Parameters.AddWithValue("@password", txt_epassword.Text);
                cmd.Parameters.AddWithValue("@age", int.Parse(txt_eage.Text));
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@phone", txt_ephone.Text);
                cmd.Parameters.AddWithValue("@position", cb_position.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@role", cb_EmployeeRole.SelectedItem);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("ແກ້ໄຂຂໍ້ມູນພະນັກງານສຳເລັດ!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                show();
                txt_eid.Text = "";
                txt_ename.Text = "";
                txt_eage.Text = "";
                rb_male.Checked = false;
                rb_female.Checked = false;
                rb_other.Checked = false;
                txt_ephone.Text = "";
                txt_epassword.Text = "";
                cb_position.SelectedIndex = -1;
                cb_EmployeeRole.SelectedIndex = -1;
            }
            catch (System.Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        

        /*Delete data*/
        private void btn_delete_Click(object sender, EventArgs e)
        {
            Delete(txt_eid.Text);
        }
        void Delete(string eid)
        {
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
                String sql = "DELETE FROM Tb_Employees WHERE e_id='" + eid + "';";
                cmd = new SqlCommand(sql, con);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("ລືບຂໍ້ມູນພະນັກງານສຳເລັດ!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                show();
                txt_eid.Text = "";
                txt_ename.Text = "";
                txt_eage.Text = "";
                rb_male.Checked = false;
                rb_female.Checked = false;
                rb_other.Checked = false;
                txt_ephone.Text = "";
                txt_epassword.Text = "";
                cb_position.SelectedIndex = -1;
            }
            catch (System.Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /*clear data*/
        private void btn_clear_Click(object sender, EventArgs e)
        {

            txt_eid.Text = "";
            txt_ename.Text = "";
            txt_eage.Text = "";
            rb_male.Checked = false;
            rb_female.Checked = false;
            rb_other.Checked = false;
            txt_ephone.Text = "";
            txt_epassword.Text = "";
            cb_position.SelectedIndex = -1;
            cb_EmployeeRole.SelectedIndex = -1;
        }
        /*canel data*/
        private void btn_canel_Click(object sender, EventArgs e)
        {
             
        }

        private void ShowEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < ShowEmployee.Rows.Count)
            {
                DataGridViewRow selectedRow = ShowEmployee.Rows[e.RowIndex];

                if (selectedRow != null && selectedRow.Cells.Count >= 7) // Assuming you have at least 7 cells in a row
                {
                    txt_eid.Text = selectedRow.Cells[0].Value?.ToString();
                    txt_ename.Text = selectedRow.Cells[1].Value?.ToString();
                    txt_epassword.Text = selectedRow.Cells[2].Value?.ToString();
                    txt_eage.Text = selectedRow.Cells[3].Value?.ToString();
                    txt_ephone.Text = selectedRow.Cells[5].Value?.ToString();
                    cb_position.Text = selectedRow.Cells[6].Value?.ToString();
                    cb_EmployeeRole.Text = selectedRow.Cells[7].Value?.ToString();
                    string gender = selectedRow.Cells[4].Value?.ToString();

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
                        default:
                            // Handle the case where gender is not recognized
                            rb_male.Checked = false;
                            rb_female.Checked = false;
                            rb_other.Checked = false;
                            break;
                    }
                }
            }
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
                string sql = "SELECT * FROM Tb_Employees WHERE e_name='" + txt_search.Text + "'";
                con.Open();
                da = new SqlDataAdapter(sql, con); 
                dtb = new DataTable();
                da.Fill(dtb);
                ShowEmployee.DataSource = dtb;
                con.Close();
            }
        }

      
    } 
}

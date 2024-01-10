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
    public partial class RegisterFrm : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        DataTable dtb;
        SqlDataAdapter da;
        public RegisterFrm()
        {
            InitializeComponent();
        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ename.Text) || string.IsNullOrEmpty(txt_eage.Text) || string.IsNullOrEmpty(txt_epassword.Text ) || string.IsNullOrEmpty(cb_position.Text))
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
                    cmd.Parameters.AddWithValue("@position", cb_position.SelectedIndex + 1);
                    cmd.Parameters.AddWithValue("@role", "Employee");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ເພີ່ມຂໍ້ມູນພະນັກງານສຳເລັດ!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    txt_ename.Text = "";
                    txt_eage.Text = "";
                    rb_male.Checked = false;
                    rb_female.Checked = false;
                    rb_other.Checked = false;
                    txt_ephone.Text = "";
                    txt_epassword.Text = "";
                    cb_position.SelectedIndex = -1;

                    this.Hide();
                    LoginFrm loginfrm = new LoginFrm();
                    loginfrm.ShowDialog();
                }
                
            }
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

        private void RegisterFrm_Load(object sender, EventArgs e)
        {
            positioninfo();
        }

        private void btn_canel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginFrm loginfrm = new LoginFrm();
            loginfrm.Show();
        }
    }
}

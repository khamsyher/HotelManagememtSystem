using HotelManagememtSystem.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace HotelManagememtSystem
{
    public partial class HomeFrm : Form
    {
        private string employeeRole;
        public HomeFrm()
        {
            InitializeComponent();
            ManageHome MH = new ManageHome();
            addUserControl(MH);
        }
        public void SetEmployeeName(string employeeName)
        {
            txt_employeename.Text = employeeName;
        }
        public void SetEmployeeRole(string role)
        {
            employeeRole = role;
            // set permission 
            if (employeeRole == "Admin")
            {
                btn_employee.Visible = true; 
            }
            else if( employeeRole == "Employee")
            {
                btn_employee.Visible = false;  
            }
            else
            {
                btn_employee.Visible = false;
            }
        }
        

        private void HomeFrm_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            ManageHome mh = new ManageHome();
            addUserControl(mh);

        }

        private void btn_room_Click(object sender, EventArgs e)
        {
            ManageRooms mr = new ManageRooms();
            addUserControl(mr);

        }
        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pShowData.Controls.Clear();
            pShowData.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            ManageCustomer mc = new ManageCustomer();
            addUserControl(mc);
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            if (employeeRole != "Employee")
            {
                ManageEmployee me = new ManageEmployee();
                addUserControl(me);
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btn_customerCheckout_Click(object sender, EventArgs e)
        {
            ManageCustomersCheckout mcc = new ManageCustomersCheckout();
            addUserControl(mcc);
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            CustomerReport cr = new CustomerReport();
            addUserControl(cr);
        }
    }
}

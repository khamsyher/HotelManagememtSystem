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
        private ManageRooms manageRoomsControl;
        private ManageCustomer manageCustomerControl;
        public HomeFrm()
        {
            InitializeComponent();
            ManageHome MH = new ManageHome();
            addUserControl(MH);
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
            ManageEmployee me = new ManageEmployee();
            addUserControl(me);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_dashboard_MouseEnter(object sender, EventArgs e)
        {
            btn_dashboard.FillColor = Color.White; 
        }

        private void btn_dashboard_MouseLeave(object sender, EventArgs e)
        { 
            btn_dashboard.BackColor = Color.Blue; 
        }

    }
}

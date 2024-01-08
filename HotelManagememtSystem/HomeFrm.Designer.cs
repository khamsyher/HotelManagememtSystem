namespace HotelManagememtSystem
{
    partial class HomeFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pSidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_employee = new Guna.UI2.WinForms.Guna2Button();
            this.btn_customer = new Guna.UI2.WinForms.Guna2Button();
            this.btn_logout = new Guna.UI2.WinForms.Guna2Button();
            this.btn_room = new Guna.UI2.WinForms.Guna2Button();
            this.btn_dashboard = new Guna.UI2.WinForms.Guna2Button();
            this.pHeader = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pShowData = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pSidebar.SuspendLayout();
            this.pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pSidebar
            // 
            this.pSidebar.Controls.Add(this.label1);
            this.pSidebar.Controls.Add(this.guna2PictureBox1);
            this.pSidebar.Controls.Add(this.btn_employee);
            this.pSidebar.Controls.Add(this.btn_customer);
            this.pSidebar.Controls.Add(this.btn_logout);
            this.pSidebar.Controls.Add(this.btn_room);
            this.pSidebar.Controls.Add(this.btn_dashboard);
            this.pSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSidebar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(143)))), ((int)(((byte)(231)))));
            this.pSidebar.Location = new System.Drawing.Point(0, 0);
            this.pSidebar.Name = "pSidebar";
            this.pSidebar.Size = new System.Drawing.Size(256, 825);
            this.pSidebar.TabIndex = 1;
            // 
            // btn_employee
            // 
            this.btn_employee.BackColor = System.Drawing.Color.Transparent;
            this.btn_employee.BorderColor = System.Drawing.Color.Transparent;
            this.btn_employee.BorderRadius = 4;
            this.btn_employee.BorderThickness = 1;
            this.btn_employee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_employee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_employee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_employee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_employee.FillColor = System.Drawing.Color.White;
            this.btn_employee.Font = new System.Drawing.Font("Phetsarath OT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(143)))), ((int)(((byte)(231)))));
            this.btn_employee.Location = new System.Drawing.Point(19, 397);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(219, 45);
            this.btn_employee.TabIndex = 4;
            this.btn_employee.Text = "ຈັດການຂໍ້ມູນພະນັກງານ";
            this.btn_employee.Click += new System.EventHandler(this.btn_employee_Click);
            // 
            // btn_customer
            // 
            this.btn_customer.BackColor = System.Drawing.Color.Transparent;
            this.btn_customer.BorderColor = System.Drawing.Color.Transparent;
            this.btn_customer.BorderRadius = 4;
            this.btn_customer.BorderThickness = 1;
            this.btn_customer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_customer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_customer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_customer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_customer.FillColor = System.Drawing.Color.White;
            this.btn_customer.Font = new System.Drawing.Font("Phetsarath OT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(143)))), ((int)(((byte)(231)))));
            this.btn_customer.Location = new System.Drawing.Point(19, 331);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Size = new System.Drawing.Size(219, 45);
            this.btn_customer.TabIndex = 3;
            this.btn_customer.Text = "ຈັດການຂໍ້ມູນລູກຄ້າ";
            this.btn_customer.Click += new System.EventHandler(this.btn_customer_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.BorderColor = System.Drawing.Color.Transparent;
            this.btn_logout.BorderRadius = 4;
            this.btn_logout.BorderThickness = 1;
            this.btn_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_logout.FillColor = System.Drawing.Color.White;
            this.btn_logout.Font = new System.Drawing.Font("Phetsarath OT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.Red;
            this.btn_logout.Location = new System.Drawing.Point(19, 728);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(219, 45);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "ອອກຈາກລະບົບ";
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_room
            // 
            this.btn_room.BackColor = System.Drawing.Color.Transparent;
            this.btn_room.BorderColor = System.Drawing.Color.Transparent;
            this.btn_room.BorderRadius = 4;
            this.btn_room.BorderThickness = 1;
            this.btn_room.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_room.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_room.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_room.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_room.FillColor = System.Drawing.Color.White;
            this.btn_room.Font = new System.Drawing.Font("Phetsarath OT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_room.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(143)))), ((int)(((byte)(231)))));
            this.btn_room.Location = new System.Drawing.Point(19, 264);
            this.btn_room.Name = "btn_room";
            this.btn_room.Size = new System.Drawing.Size(219, 45);
            this.btn_room.TabIndex = 1;
            this.btn_room.Text = "ຈັດການຂໍ້ມູນຫ້ອງ";
            this.btn_room.Click += new System.EventHandler(this.btn_room_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.Transparent;
            this.btn_dashboard.BorderColor = System.Drawing.Color.Transparent;
            this.btn_dashboard.BorderRadius = 4;
            this.btn_dashboard.BorderThickness = 1;
            this.btn_dashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_dashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_dashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_dashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_dashboard.FillColor = System.Drawing.Color.White;
            this.btn_dashboard.Font = new System.Drawing.Font("Phetsarath OT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(143)))), ((int)(((byte)(231)))));
            this.btn_dashboard.Location = new System.Drawing.Point(19, 199);
            this.btn_dashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(219, 45);
            this.btn_dashboard.TabIndex = 0;
            this.btn_dashboard.Text = "ໝ້າຫຼັກ";
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.Transparent;
            this.pHeader.Controls.Add(this.guna2CirclePictureBox1);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.FillColor = System.Drawing.Color.White;
            this.pHeader.Location = new System.Drawing.Point(256, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.ShadowColor = System.Drawing.Color.Black;
            this.pHeader.ShadowDepth = 10;
            this.pHeader.ShadowShift = 2;
            this.pHeader.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.pHeader.Size = new System.Drawing.Size(1264, 60);
            this.pHeader.TabIndex = 2;
            // 
            // pShowData
            // 
            this.pShowData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pShowData.Location = new System.Drawing.Point(256, 60);
            this.pShowData.Name = "pShowData";
            this.pShowData.Size = new System.Drawing.Size(1264, 765);
            this.pShowData.TabIndex = 3;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::HotelManagememtSystem.Properties.Resources.users;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(1189, 3);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(53, 54);
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::HotelManagememtSystem.Properties.Resources.icons8_hotel_100;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(69, 41);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(103, 116);
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "KP-HOTEL";
            // 
            // HomeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 825);
            this.Controls.Add(this.pShowData);
            this.Controls.Add(this.pHeader);
            this.Controls.Add(this.pSidebar);
            this.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HomeFrm";
            this.Text = "HomeFrm";
            this.Load += new System.EventHandler(this.HomeFrm_Load);
            this.pSidebar.ResumeLayout(false);
            this.pSidebar.PerformLayout();
            this.pHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pSidebar;
        private Guna.UI2.WinForms.Guna2Button btn_room;
        private Guna.UI2.WinForms.Guna2Button btn_dashboard;
        private Guna.UI2.WinForms.Guna2ShadowPanel pHeader;
        private System.Windows.Forms.Panel pShowData;
        private Guna.UI2.WinForms.Guna2Button btn_employee;
        private Guna.UI2.WinForms.Guna2Button btn_customer;
        private Guna.UI2.WinForms.Guna2Button btn_logout;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
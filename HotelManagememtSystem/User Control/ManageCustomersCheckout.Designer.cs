namespace HotelManagememtSystem.User_Control
{
    partial class ManageCustomersCheckout
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ShowCustomerCheckout = new Guna.UI2.WinForms.Guna2DataGridView();
            this.hotelManagementSystemDataSet4 = new HotelManagememtSystem.HotelManagementSystemDataSet4();
            this.tbCustomersCheckoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_CustomersCheckoutTableAdapter = new HotelManagememtSystem.HotelManagementSystemDataSet4TableAdapters.Tb_CustomersCheckoutTableAdapter();
            this.oidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ophoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocheckinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocheckoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oroomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opaystatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowCustomerCheckout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementSystemDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCustomersCheckoutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.guna2Panel1.Controls.Add(this.txt_search);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.btn_search);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1283, 97);
            this.guna2Panel1.TabIndex = 0;
            // 
            // ShowCustomerCheckout
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ShowCustomerCheckout.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ShowCustomerCheckout.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ShowCustomerCheckout.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ShowCustomerCheckout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowCustomerCheckout.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oidDataGridViewTextBoxColumn,
            this.onameDataGridViewTextBoxColumn,
            this.oageDataGridViewTextBoxColumn,
            this.ogenderDataGridViewTextBoxColumn,
            this.ophoneDataGridViewTextBoxColumn,
            this.ocheckinDataGridViewTextBoxColumn,
            this.ocheckoutDataGridViewTextBoxColumn,
            this.oroomDataGridViewTextBoxColumn,
            this.opaystatusDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.ShowCustomerCheckout.DataSource = this.tbCustomersCheckoutBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ShowCustomerCheckout.DefaultCellStyle = dataGridViewCellStyle3;
            this.ShowCustomerCheckout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowCustomerCheckout.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ShowCustomerCheckout.Location = new System.Drawing.Point(0, 97);
            this.ShowCustomerCheckout.Name = "ShowCustomerCheckout";
            this.ShowCustomerCheckout.RowHeadersVisible = false;
            this.ShowCustomerCheckout.RowHeadersWidth = 51;
            this.ShowCustomerCheckout.RowTemplate.Height = 24;
            this.ShowCustomerCheckout.Size = new System.Drawing.Size(1283, 689);
            this.ShowCustomerCheckout.TabIndex = 1;
            this.ShowCustomerCheckout.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ShowCustomerCheckout.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ShowCustomerCheckout.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ShowCustomerCheckout.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ShowCustomerCheckout.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ShowCustomerCheckout.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ShowCustomerCheckout.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ShowCustomerCheckout.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ShowCustomerCheckout.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ShowCustomerCheckout.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCustomerCheckout.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ShowCustomerCheckout.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowCustomerCheckout.ThemeStyle.HeaderStyle.Height = 31;
            this.ShowCustomerCheckout.ThemeStyle.ReadOnly = false;
            this.ShowCustomerCheckout.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ShowCustomerCheckout.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ShowCustomerCheckout.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCustomerCheckout.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ShowCustomerCheckout.ThemeStyle.RowsStyle.Height = 24;
            this.ShowCustomerCheckout.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ShowCustomerCheckout.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // hotelManagementSystemDataSet4
            // 
            this.hotelManagementSystemDataSet4.DataSetName = "HotelManagementSystemDataSet4";
            this.hotelManagementSystemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbCustomersCheckoutBindingSource
            // 
            this.tbCustomersCheckoutBindingSource.DataMember = "Tb_CustomersCheckout";
            this.tbCustomersCheckoutBindingSource.DataSource = this.hotelManagementSystemDataSet4;
            // 
            // tb_CustomersCheckoutTableAdapter
            // 
            this.tb_CustomersCheckoutTableAdapter.ClearBeforeFill = true;
            // 
            // oidDataGridViewTextBoxColumn
            // 
            this.oidDataGridViewTextBoxColumn.DataPropertyName = "o_id";
            this.oidDataGridViewTextBoxColumn.HeaderText = "ໄອດີ";
            this.oidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oidDataGridViewTextBoxColumn.Name = "oidDataGridViewTextBoxColumn";
            // 
            // onameDataGridViewTextBoxColumn
            // 
            this.onameDataGridViewTextBoxColumn.DataPropertyName = "o_name";
            this.onameDataGridViewTextBoxColumn.HeaderText = "ຊື່ແລະນາມສະກຸນ";
            this.onameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.onameDataGridViewTextBoxColumn.Name = "onameDataGridViewTextBoxColumn";
            // 
            // oageDataGridViewTextBoxColumn
            // 
            this.oageDataGridViewTextBoxColumn.DataPropertyName = "o_age";
            this.oageDataGridViewTextBoxColumn.HeaderText = "ອາຍຸ";
            this.oageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oageDataGridViewTextBoxColumn.Name = "oageDataGridViewTextBoxColumn";
            // 
            // ogenderDataGridViewTextBoxColumn
            // 
            this.ogenderDataGridViewTextBoxColumn.DataPropertyName = "o_gender";
            this.ogenderDataGridViewTextBoxColumn.HeaderText = "ອາຍຸ";
            this.ogenderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogenderDataGridViewTextBoxColumn.Name = "ogenderDataGridViewTextBoxColumn";
            // 
            // ophoneDataGridViewTextBoxColumn
            // 
            this.ophoneDataGridViewTextBoxColumn.DataPropertyName = "o_phone";
            this.ophoneDataGridViewTextBoxColumn.HeaderText = "ເບີໂທຕິດຕໍ່";
            this.ophoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ophoneDataGridViewTextBoxColumn.Name = "ophoneDataGridViewTextBoxColumn";
            // 
            // ocheckinDataGridViewTextBoxColumn
            // 
            this.ocheckinDataGridViewTextBoxColumn.DataPropertyName = "o_checkin";
            this.ocheckinDataGridViewTextBoxColumn.HeaderText = "ວັນທີ່ເຂົ້າ";
            this.ocheckinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ocheckinDataGridViewTextBoxColumn.Name = "ocheckinDataGridViewTextBoxColumn";
            // 
            // ocheckoutDataGridViewTextBoxColumn
            // 
            this.ocheckoutDataGridViewTextBoxColumn.DataPropertyName = "o_checkout";
            this.ocheckoutDataGridViewTextBoxColumn.HeaderText = "ວັນທີ່ອອກ";
            this.ocheckoutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ocheckoutDataGridViewTextBoxColumn.Name = "ocheckoutDataGridViewTextBoxColumn";
            // 
            // oroomDataGridViewTextBoxColumn
            // 
            this.oroomDataGridViewTextBoxColumn.DataPropertyName = "o_room";
            this.oroomDataGridViewTextBoxColumn.HeaderText = "ເບີຫ້ອງ";
            this.oroomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oroomDataGridViewTextBoxColumn.Name = "oroomDataGridViewTextBoxColumn";
            // 
            // opaystatusDataGridViewTextBoxColumn
            // 
            this.opaystatusDataGridViewTextBoxColumn.DataPropertyName = "o_paystatus";
            this.opaystatusDataGridViewTextBoxColumn.HeaderText = "ປະເພດຈ່າຍ";
            this.opaystatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.opaystatusDataGridViewTextBoxColumn.Name = "opaystatusDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "ລາຄາລວມ";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // txt_search
            // 
            this.txt_search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.BorderRadius = 4;
            this.txt_search.BorderThickness = 2;
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.DefaultText = "";
            this.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Location = new System.Drawing.Point(941, 39);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderText = "";
            this.txt_search.SelectedText = "";
            this.txt_search.Size = new System.Drawing.Size(221, 40);
            this.txt_search.TabIndex = 107;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 29);
            this.label7.TabIndex = 106;
            this.label7.Text = "ຂໍ້ມູນລູກຄ້າ";
            // 
            // btn_search
            // 
            this.btn_search.BorderRadius = 4;
            this.btn_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_search.FillColor = System.Drawing.Color.Blue;
            this.btn_search.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(1183, 39);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(80, 40);
            this.btn_search.TabIndex = 105;
            this.btn_search.Text = "ຄົ້ນຫາ";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // ManageCustomersCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ShowCustomerCheckout);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageCustomersCheckout";
            this.Size = new System.Drawing.Size(1283, 786);
            this.Load += new System.EventHandler(this.ManageCustomersCheckout_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowCustomerCheckout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementSystemDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCustomersCheckoutBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView ShowCustomerCheckout;
        private System.Windows.Forms.BindingSource tbCustomersCheckoutBindingSource;
        private HotelManagementSystemDataSet4 hotelManagementSystemDataSet4;
        private HotelManagementSystemDataSet4TableAdapters.Tb_CustomersCheckoutTableAdapter tb_CustomersCheckoutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn onameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ophoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocheckinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocheckoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oroomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opaystatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btn_search;
    }
}

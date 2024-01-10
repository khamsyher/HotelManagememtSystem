namespace HotelManagememtSystem.User_Control
{
    partial class CustomerReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_report = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Export = new Guna.UI2.WinForms.Guna2Button();
            this.date_RePort = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ShowDataReport = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cgenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paystatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelManagementSystemDataSet5 = new HotelManagememtSystem.HotelManagementSystemDataSet5();
            this.tb_CustomersTableAdapter = new HotelManagememtSystem.HotelManagementSystemDataSet5TableAdapters.Tb_CustomersTableAdapter();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowDataReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementSystemDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Panel1.Controls.Add(this.btn_report);
            this.guna2Panel1.Controls.Add(this.btn_Export);
            this.guna2Panel1.Controls.Add(this.date_RePort);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1283, 100);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btn_report
            // 
            this.btn_report.BorderRadius = 4;
            this.btn_report.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_report.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_report.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_report.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_report.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_report.ForeColor = System.Drawing.Color.White;
            this.btn_report.Location = new System.Drawing.Point(863, 29);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(180, 45);
            this.btn_report.TabIndex = 2;
            this.btn_report.Text = "REPORT";
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.BorderRadius = 4;
            this.btn_Export.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Export.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Export.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Export.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Export.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.btn_Export.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Export.ForeColor = System.Drawing.Color.White;
            this.btn_Export.Location = new System.Drawing.Point(1078, 29);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(180, 45);
            this.btn_Export.TabIndex = 1;
            this.btn_Export.Text = "EXPORT";
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // date_RePort
            // 
            this.date_RePort.BorderRadius = 4;
            this.date_RePort.Checked = true;
            this.date_RePort.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_RePort.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_RePort.Location = new System.Drawing.Point(636, 30);
            this.date_RePort.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_RePort.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_RePort.Name = "date_RePort";
            this.date_RePort.Size = new System.Drawing.Size(200, 45);
            this.date_RePort.TabIndex = 0;
            this.date_RePort.Value = new System.DateTime(2024, 1, 9, 23, 21, 57, 239);
            // 
            // ShowDataReport
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.ShowDataReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.ShowDataReport.AutoGenerateColumns = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ShowDataReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ShowDataReport.ColumnHeadersHeight = 31;
            this.ShowDataReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ShowDataReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cidDataGridViewTextBoxColumn,
            this.cnameDataGridViewTextBoxColumn,
            this.cageDataGridViewTextBoxColumn,
            this.cgenderDataGridViewTextBoxColumn,
            this.cphoneDataGridViewTextBoxColumn,
            this.checkinDataGridViewTextBoxColumn,
            this.checkoutDataGridViewTextBoxColumn,
            this.roomDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.paystatusDataGridViewTextBoxColumn});
            this.ShowDataReport.DataSource = this.tbCustomersBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ShowDataReport.DefaultCellStyle = dataGridViewCellStyle9;
            this.ShowDataReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowDataReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ShowDataReport.Location = new System.Drawing.Point(0, 100);
            this.ShowDataReport.Name = "ShowDataReport";
            this.ShowDataReport.RowHeadersVisible = false;
            this.ShowDataReport.RowHeadersWidth = 51;
            this.ShowDataReport.RowTemplate.Height = 24;
            this.ShowDataReport.Size = new System.Drawing.Size(1283, 686);
            this.ShowDataReport.TabIndex = 1;
            this.ShowDataReport.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ShowDataReport.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ShowDataReport.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ShowDataReport.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ShowDataReport.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ShowDataReport.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ShowDataReport.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ShowDataReport.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ShowDataReport.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ShowDataReport.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowDataReport.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ShowDataReport.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ShowDataReport.ThemeStyle.HeaderStyle.Height = 31;
            this.ShowDataReport.ThemeStyle.ReadOnly = false;
            this.ShowDataReport.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ShowDataReport.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ShowDataReport.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowDataReport.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ShowDataReport.ThemeStyle.RowsStyle.Height = 24;
            this.ShowDataReport.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ShowDataReport.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // cidDataGridViewTextBoxColumn
            // 
            this.cidDataGridViewTextBoxColumn.DataPropertyName = "c_id";
            this.cidDataGridViewTextBoxColumn.HeaderText = "ໄອດີ";
            this.cidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cidDataGridViewTextBoxColumn.Name = "cidDataGridViewTextBoxColumn";
            this.cidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cnameDataGridViewTextBoxColumn
            // 
            this.cnameDataGridViewTextBoxColumn.DataPropertyName = "c_name";
            this.cnameDataGridViewTextBoxColumn.HeaderText = "ຊື່ແລະນາມສະກຸມ";
            this.cnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cnameDataGridViewTextBoxColumn.Name = "cnameDataGridViewTextBoxColumn";
            // 
            // cageDataGridViewTextBoxColumn
            // 
            this.cageDataGridViewTextBoxColumn.DataPropertyName = "c_age";
            this.cageDataGridViewTextBoxColumn.HeaderText = "ອາຍຸ";
            this.cageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cageDataGridViewTextBoxColumn.Name = "cageDataGridViewTextBoxColumn";
            // 
            // cgenderDataGridViewTextBoxColumn
            // 
            this.cgenderDataGridViewTextBoxColumn.DataPropertyName = "c_gender";
            this.cgenderDataGridViewTextBoxColumn.HeaderText = "ເພດ";
            this.cgenderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cgenderDataGridViewTextBoxColumn.Name = "cgenderDataGridViewTextBoxColumn";
            // 
            // cphoneDataGridViewTextBoxColumn
            // 
            this.cphoneDataGridViewTextBoxColumn.DataPropertyName = "c_phone";
            this.cphoneDataGridViewTextBoxColumn.HeaderText = "ເບີໂທຕິດຕໍ່";
            this.cphoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cphoneDataGridViewTextBoxColumn.Name = "cphoneDataGridViewTextBoxColumn";
            // 
            // checkinDataGridViewTextBoxColumn
            // 
            this.checkinDataGridViewTextBoxColumn.DataPropertyName = "checkin";
            this.checkinDataGridViewTextBoxColumn.HeaderText = "ວັນເຂົ້າຫ້ອງ";
            this.checkinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.checkinDataGridViewTextBoxColumn.Name = "checkinDataGridViewTextBoxColumn";
            // 
            // checkoutDataGridViewTextBoxColumn
            // 
            this.checkoutDataGridViewTextBoxColumn.DataPropertyName = "checkout";
            this.checkoutDataGridViewTextBoxColumn.HeaderText = "ວັນທີ່ອອກ";
            this.checkoutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.checkoutDataGridViewTextBoxColumn.Name = "checkoutDataGridViewTextBoxColumn";
            // 
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "room";
            this.roomDataGridViewTextBoxColumn.HeaderText = "ເບີຫ້ອງ";
            this.roomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "ລາຄາ/ກີບ";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // paystatusDataGridViewTextBoxColumn
            // 
            this.paystatusDataGridViewTextBoxColumn.DataPropertyName = "paystatus";
            this.paystatusDataGridViewTextBoxColumn.HeaderText = "ສະຖານະ";
            this.paystatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paystatusDataGridViewTextBoxColumn.Name = "paystatusDataGridViewTextBoxColumn";
            // 
            // tbCustomersBindingSource
            // 
            this.tbCustomersBindingSource.DataMember = "Tb_Customers";
            this.tbCustomersBindingSource.DataSource = this.hotelManagementSystemDataSet5;
            // 
            // hotelManagementSystemDataSet5
            // 
            this.hotelManagementSystemDataSet5.DataSetName = "HotelManagementSystemDataSet5";
            this.hotelManagementSystemDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_CustomersTableAdapter
            // 
            this.tb_CustomersTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ShowDataReport);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomerReport";
            this.Size = new System.Drawing.Size(1283, 786);
            this.Load += new System.EventHandler(this.CustomerReport_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShowDataReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementSystemDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_report;
        private Guna.UI2.WinForms.Guna2Button btn_Export;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_RePort;
        private Guna.UI2.WinForms.Guna2DataGridView ShowDataReport;
        private System.Windows.Forms.BindingSource tbCustomersBindingSource;
        private HotelManagementSystemDataSet5 hotelManagementSystemDataSet5;
        private HotelManagementSystemDataSet5TableAdapters.Tb_CustomersTableAdapter tb_CustomersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cgenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paystatusDataGridViewTextBoxColumn;
    }
}

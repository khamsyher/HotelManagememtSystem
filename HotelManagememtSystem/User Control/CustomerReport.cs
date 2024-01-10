using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using iText.Kernel.Pdf;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Layout.Element;
using iText.Layout;

namespace HotelManagememtSystem.User_Control
{
    public partial class CustomerReport : UserControl
    {
        SqlConnection con;
        SqlCommand cmd;
        DataTable dtb;
        SqlDataAdapter da;
        public CustomerReport()
        {
            InitializeComponent();
        }

        private void CustomerReport_Load(object sender, EventArgs e)
        {

        }
     

        private void btn_report_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-MCN7P17D\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
            con.Open();

            // Assuming date_RePort is a DateTimePicker or similar control
            string formattedDate = date_RePort.Value.ToString("yyyy-MM-dd");

            cmd = new SqlCommand("SELECT c_id, c_name, c_age, c_gender, c_phone, checkin, checkout, room, FORMAT(price, 'N2', 'de-DE') as price, paystatus FROM Tb_Customers WHERE checkin= @datecheckin or checkout= @datecheckin UNION ALL SELECT  NULL AS c_id, 'Total =' AS c_name,  NULL AS c_age,  NULL AS c_gender,  NULL AS c_phone,   NULL AS checkin,   NULL AS checkout, COUNT(room),  FORMAT(SUM(price), 'N2', 'de-DE') AS price,  NULL AS paystatus FROM  Tb_Customers WHERE  checkin = @datecheckin OR checkout = @datecheckin;", con);

            cmd.Parameters.AddWithValue("@datecheckin", formattedDate);

            da = new SqlDataAdapter(cmd);
            dtb = new DataTable();
            da.Fill(dtb);

            ShowDataReport.DataSource = dtb;
            ShowDataReport.AutoGenerateColumns = true;

            ShowDataReport.Rows[ShowDataReport.Rows.Count - 2].DefaultCellStyle.BackColor = Color.Red;
            ShowDataReport.Rows[ShowDataReport.Rows.Count - 2].DefaultCellStyle.ForeColor = Color.White;

            con.Close();
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Export to PDF";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string pdfFilePath = saveFileDialog.FileName;

                // Create a PDF document
                using (PdfWriter writer = new PdfWriter(pdfFilePath))
                using (PdfDocument pdf = new PdfDocument(writer))
                using (Document document = new Document(pdf))
                {
                    // Add a title to the PDF
                    document.Add(new Paragraph("Customer Report"));

                    // Add a table to the PDF and set column headers
                    Table table = new Table(dtb.Columns.Count);
                    foreach (DataColumn column in dtb.Columns)
                    {
                        table.AddHeaderCell(column.ColumnName);
                    }

                    // Add rows to the PDF table
                    foreach (DataRow row in dtb.Rows)
                    {
                        foreach (object item in row.ItemArray)
                        {
                            table.AddCell(item.ToString());
                        }
                    }

                    // Add the table to the PDF document
                    document.Add(table);
                }

                MessageBox.Show("Exported to PDF successfully!");
            }
        }
    }
}

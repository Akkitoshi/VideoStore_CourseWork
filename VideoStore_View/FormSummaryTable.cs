using iTextSharp.text;
using iTextSharp.text.pdf;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace VideoStore_View
{
    public partial class FormSummaryTable : MaterialForm
    {
        public FormSummaryTable()
        {
            InitializeComponent();
            LoadData();

        }
        public void LoadData()
        {
            materialLabelError.ForeColor = Color.White;
            SqlConnection con = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=DBCourseWorkContext;Integrated Security=true");
            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("Select Type, SummaryPrice, DateOfConclusion FROM Services, ClientContracts, Products", con);
            adapt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);

                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    pdfTable.AddCell(new Phrase(dataGridView1.Columns[j].HeaderText));
                }
                pdfTable.HeaderRows = 1;


                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int k = 0; k < dataGridView1.Columns.Count; k++)
                    {
                        if (dataGridView1[k, i].Value != null)
                        {
                            pdfTable.AddCell(new Phrase(dataGridView1[k, i].Value.ToString()));
                        }
                    }
                }

                string folderPath = @"C:\Users\Lenovo\";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                using (FileStream stream = new FileStream(folderPath + "Стоимость_договоров.pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                }
            }
            catch
            {
                materialLabelError.ForeColor = Color.Red;
                materialLabelError.Text = "Ошибка при сохранении";
            }
            materialLabelError.ForeColor = Color.Green;
            materialLabelError.Text = "Успешное сохранение";
        }
    }
}



using MaterialSkin.Controls;
using System;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Unity;
using Image = iTextSharp.text.Image;
using VideoStore_Controller;
using System.Data.SqlClient;
using System.Data;

namespace VideoStore_View
{
    public partial class FormDiagramm : MaterialForm
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ClientContractController clientContractController;
        public FormDiagramm(ClientContractController clientContractController)
        {
            InitializeComponent();
            this.clientContractController = clientContractController;
        }

        private void materialRaisedButtonSave_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            chart1.Series[0].XValueMember = "ProductId";
            chart1.DataBind();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string title = "Кол-во принятых и выписанных пациентов на " + dateTimePicker1.Value.ToString();
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "pdf|*.pdf"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string FONT_LOCATION = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.TTF"); //определяем В СИСТЕМЕ(чтобы не копировать файл) расположение шрифта arial.ttf
                    BaseFont baseFont = BaseFont.CreateFont(FONT_LOCATION, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED); //создаем шрифт
                    iTextSharp.text.Font fontParagraph = new iTextSharp.text.Font(baseFont, 17, iTextSharp.text.Font.NORMAL); //регистрируем + можно задать параметры для него(17 - размер, последний параметр - стиль)

                    var phraseTitle = new Phrase(title,
            new iTextSharp.text.Font(baseFont, 18, iTextSharp.text.Font.BOLD));
                    iTextSharp.text.Paragraph paragraph = new
                   iTextSharp.text.Paragraph(phraseTitle)
                    {
                        Alignment = Element.ALIGN_CENTER,
                        SpacingAfter = 12
                    };

                    chart1.SaveImage(sfd.FileName + ".png", System.Drawing.Imaging.ImageFormat.Png);

                    Document document = new Document();
                    using (var stream = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        PdfWriter.GetInstance(document, stream);
                        document.Open();
                        using (var imageStream = new FileStream(sfd.FileName + ".png", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        {
                            var image = Image.GetInstance(imageStream);
                            document.Add(paragraph);
                            document.Add(image);
                        }
                        document.Close();
                        File.Delete(sfd.FileName + ".png");
                    }
                }
                catch
                {
                    MessageBox.Show("ERROR");
                }
            }
        }

        private void FormDiagramm_Load(object sender, EventArgs e)
        {

        }
    }
}

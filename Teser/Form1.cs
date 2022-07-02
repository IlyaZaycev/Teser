using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Emgu.CV.OCR;
using Emgu.CV;
using Emgu.CV.Structure;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace Teser
{
    public partial class Form1 : Form
    {
        private string filePath = string.Empty;
        private string lang = "rus";
        private string pdfFilePath = string.Empty;

        public Form1()
        {
            InitializeComponent();
            DataBase db = new DataBase();
            db.OpenConnection();
            db.CloseConnection();
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = ImageDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                filePath = ImageDialog.FileName;
                pictureBox.Image = Image.FromFile(filePath);
            }
            else
            {
                MessageBox.Show("Картинка не выбрана.", "Пожалуйста выберите картинку", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void открытьPDFфайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = PDFdialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pdfFilePath = PDFdialog.FileName;
            }
            else
                MessageBox.Show("Файл не выбран.", "Пожалуйста выберите PDF-файл", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(pdfFilePath) || string.IsNullOrEmpty(pdfFilePath))
                {
                    throw new Exception("Картинка не выбрана");
                }

                Tesseract tesseract = new Tesseract(@"C:\Users\zayce\Desktop\testData", lang,
                    OcrEngineMode.TesseractLstmCombined);
                tesseract.SetImage(new Image<Bgr, byte>(pdfFilePath));
                tesseract.Recognize();
                TextBox.Text = tesseract.GetUTF8Text();
                tesseract.Dispose();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(pdfFilePath) || string.IsNullOrEmpty(pdfFilePath))
                {
                    throw new Exception("Файл не выбран");
                }

                using (PdfReader reader = new PdfReader(pdfFilePath))
                {
                    for (int pageNumber = 1; pageNumber <= reader.NumberOfPages; pageNumber++)
                    {
                        ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                        string text = PdfTextExtractor.GetTextFromPage(reader, pageNumber, strategy);
                        text = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8,
                            Encoding.Default.GetBytes(text)));
                        TextBox.Text += text;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
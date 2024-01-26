
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

using Aspose.Pdf.Optimization;
using Aspose.Pdf.Text;

namespace DEBreader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UploadButton_Click(object sender, RoutedEventArgs e)
        {
            string sFilename = UploadTxt.Text;

            PdfReader pdf_Reader = new PdfReader(sFilename);
            string sText = "";

            for (int i = 1; i <= pdf_Reader.NumberOfPages; i++)
            {
                sText = sText + PdfTextExtractor.GetTextFromPage(pdf_Reader, i);
            }

            lblPDF_Output.Text = sText;
        }


    }
}
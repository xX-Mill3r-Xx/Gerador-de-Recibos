using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace Recibo_Marcenaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Exportar_Click(object sender, EventArgs e)
        {
            GerarPdf();
        }

        private void GerarPdf()
        {
            var arquivo = @"C:\dev\recibo.pdf";

            var texto = $"Nós da Vasco Marcenaria declaramos que.:\n" +
                $" Recebemos de {txt_Nome.Text}, portador do Rg:{txt_Rg.Text}\n" +
                $" e residente no endereço: {txt_Endereco.Text} a quantia de R${txt_Valor.Text}\n" +
                $"referente a Serviços de {txt_Referente.Text} prestados por nossa Empresa.";
            var data = $"Sorocaba, {DateTime.Now.ToString("D")}";
            var assinatura = "__________________________________";

            using (PdfWriter wPdf = new PdfWriter(arquivo, new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
            {
                var pdfDocument = new PdfDocument(wPdf);
                var document = new Document(pdfDocument, PageSize.A4);

                document.SetFontSize(12);
                document.SetMargins(50, 50, 50, 50);
                document.SetCharacterSpacing((float)0.5);

                var corrier = PdfFontFactory.CreateFont(StandardFonts.COURIER);
                var p1 = new Paragraph();
                p1.SetFont(corrier);
                p1.SetFontSize(30);
                p1.SetTextAlignment(TextAlignment.CENTER);
                p1.SetFontColor(ColorConstants.WHITE);
                p1.SetBackgroundColor(ColorConstants.BLACK);
                p1.Add("Recibo");
                document.Add(p1);

                document.Add(new Paragraph("\n\n"));
                document.Add(new Paragraph(texto).SetFirstLineIndent(20).SetFixedLeading(26).SetFont(corrier));
                document.Add(new Paragraph("\n\n\n"));
                document.Add(new Paragraph(data).SetFont(corrier).SetTextAlignment(TextAlignment.CENTER));
                document.Add(new Paragraph(assinatura).SetFont(corrier).SetTextAlignment(TextAlignment.CENTER));
                document.Add(new Paragraph("VascoMarcenaria - CNPJ 36.252.712/0001-45").SetFont(corrier).SetTextAlignment(TextAlignment.CENTER));
                document.Close();
                pdfDocument.Close();

                MessageBox.Show($"Arquivo PDF gerado em - {arquivo}");
            }
        }

        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
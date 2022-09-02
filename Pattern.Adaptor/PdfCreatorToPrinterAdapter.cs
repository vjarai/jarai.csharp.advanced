namespace Jarai.CSharp.Pattern.Adapter
{
    public class PdfCreatorToPrinterAdapter : Printer
    {
        private readonly PdfCreator _pdfCreator;

        public PdfCreatorToPrinterAdapter(PdfCreator pdfCreator)
        {
            _pdfCreator = pdfCreator;
        }

        public override void Print(string text)
        {
            _pdfCreator.CreatePdfFile(text);
        }
    }
}
using System;

namespace Jarai.CSharp.Pattern.Adapter
{
    public class PdfCreator
    {
        private readonly string _pdfFilename;

        public PdfCreator(string pdfFilename)
        {
            _pdfFilename = pdfFilename;
        }

        public void CreatePdfFile(string text)
        {
            Console.WriteLine("Pdf erstellt: {0}", text);
        }
    }
}
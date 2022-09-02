using System;

namespace Jarai.CSharp.Pattern.Adapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var brief = new Letter("Sehr geehrter Herr XY, ...");

            var drucker = new Printer();
            brief.SendTo(drucker);

            var pdfFilename = @"c:\temp\testpdf.txt";
            var pdfCreator = new PdfCreator(pdfFilename);

            var pdfDruckerAdapter = new PdfCreatorToPrinterAdapter(pdfCreator);
            brief.SendTo(pdfDruckerAdapter);

            Console.Read();
        }
    }
}
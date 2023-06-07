using IronOcr;
using System;

namespace OcrTryout
{
    class Program
    {
        static void Main(string[] args)
        {
            var ocr = new IronTesseract();

            // Load image
            var image = "img_path.jpg";

            // Perform OCR
            var result = ocr.Read(image);

            // Access extracted text
            string extractedText = result.Text;

            // Display the extracted text
            Console.WriteLine(extractedText);

            // Wait for the user input to exit
            Console.ReadLine();
        }
    }
}

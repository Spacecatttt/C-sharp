using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing;
using System.Xml.Linq;
using JobDatabase.Advertisement;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace JobDatabase
{
    public class PdfAdvertisement : IAdvertisement {
        public void GenerateAdvertisement(Position position) {
            string directoryPath = String.Empty;
            while (String.IsNullOrWhiteSpace(directoryPath)) {
                Console.Write("Введіть шлях до директорії: ");
                directoryPath = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(directoryPath)) {
                    Console.WriteLine("Шлях не може бути порожнім.\n");
                    break;
                }
                if (!Directory.Exists(directoryPath)) {
                    Console.WriteLine("Директорія не існує.\n");
                    return;
                }
            }
            int i = 1;
            string fileName = String.Empty;
            while (File.Exists(fileName)) {
                fileName = directoryPath + i.ToString();
                i++;
            }
            string text = position.GetDescription();
            // Створення нового PDF документу
            PdfDocument document = new PdfDocument();

            // Додавання нової сторінки
            PdfPage page = document.AddPage();

            // Створення графіки для малювання на сторінці
            XGraphics graphics = XGraphics.FromPdfPage(page);

            // Налаштування шрифту і розміру тексту
            XFont font = new XFont("Arial", 16, XFontStyle.Regular);

            // Малювання тексту на сторінці
            graphics.DrawString(text, font, XBrushes.Black, new XRect(50, 50, page.Width, page.Height), XStringFormats.TopLeft);

            // Збереження документу у файл
            document.Save(fileName);
        }
    }
    
}
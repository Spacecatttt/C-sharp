using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobDatabase.Advertisement;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace JobDatabase
{
    public class WordAdvertisement : IAdvertisement {
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
            string filePath = directoryPath + "Вакансія" + i.ToString()+".docx";
            while (File.Exists(filePath)) {
                i++;
                filePath = directoryPath + "Вакансія" + i.ToString() + ".docx";
            }
            string text = position.GetDescription();
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document)) {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();

                // Створення документу і його вмісту
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());

                // Створення абзацу і його стилів
                Paragraph paragraph = body.AppendChild(new Paragraph());
                ParagraphProperties paragraphProperties = paragraph.AppendChild(new ParagraphProperties());
                paragraphProperties.AppendChild(new Justification() { Val = JustificationValues.Center }); // Центрування тексту

                // Створення стилів шрифту
                Run run = paragraph.AppendChild(new Run());
                RunProperties runProperties = run.AppendChild(new RunProperties());
                runProperties.AppendChild(new FontSize() { Val = "32" }); // Розмір шрифту 16

                // Додавання тексту до абзацу
                run.AppendChild(new Text(text));

                // Збереження документу
                wordDocument.Save();
            }
        }
    }
}

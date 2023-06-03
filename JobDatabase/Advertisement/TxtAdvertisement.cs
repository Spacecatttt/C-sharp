using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing;
using System.Xml.Linq;
using JobDatabase.Advertisement;

namespace JobDatabase
{
    public class TxtAdvertisement : IAdvertisement {
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
            string filePath = directoryPath + "Вакансія" + i.ToString() + ".txt";
            while (File.Exists(filePath)) {
                i++;
                filePath = directoryPath + "Вакансія" + i.ToString() + ".txt";
            }
            string text = position.GetDescription();
            File.WriteAllText(filePath, text);
        }
    }
    
}
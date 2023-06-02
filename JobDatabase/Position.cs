using JobDatabase.Expert_requirements;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDatabase {
    public class Position {
        public Guid UniqueId { get; init; }
        string title;
        string description;
        string salary;
        bool isProvidesHousing;
        List<IExpertRequirements> requirements;

        public string GetTitleAndSalary() {
            return $"{title}    Зарплата:{salary}";
        }
        public Position(string title, string description, string terms, bool isProvidesHousing) {
            UniqueId = Guid.NewGuid();
            this.title = title;
            this.description = description;
            salary = terms;
            this.isProvidesHousing = isProvidesHousing;
            requirements = new List<IExpertRequirements>();
        }
        public void AddRequirements(IExpertRequirements requirement) {
            requirements.Add(requirement);
        }
        public void DeleteRequirements(IExpertRequirements requirement) {
            requirements.Remove(requirement);
        }
        public void SetRequirements() {
            while (true) {
                Console.WriteLine("\nВиберіть скіл для встановлення:");
                Console.WriteLine("1. Досвід");
                Console.WriteLine("2. Освіта");
                Console.WriteLine("3. Технічні навички");
                Console.WriteLine("4. Комунікаційні навички");
                Console.WriteLine("0. Вихід");
                Console.Write("Ваш вибір: ");
                string input = Console.ReadLine();

                switch (input) {
                    case "1":
                        requirements.Add(Experience.Create());
                        break;
                    case "2":
                        requirements.Add(Education.Create());
                        break;
                    case "3":
                        requirements.Add(TechnicalSkills.Create());
                        break;
                    case "4":
                        requirements.Add(CommunicationSkills.Create());
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Неправильний вибір. Спробуйте ще раз.");
                        break;
                }
            }
        }

    }
}

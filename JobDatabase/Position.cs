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
        public string Title { get; set; }
        public string Description { get; set; }
        public string Salary { get; set; }
        bool isProvidesHousing;
        List<IExpertRequirements> requirements;
        public Firm Firm { get; set; }
        public Position(string title, string description, string terms, bool isProvidesHousing) {
            UniqueId = Guid.NewGuid();
            this.Title = title;
            this.Description = description;
            Salary = terms;
            this.isProvidesHousing = isProvidesHousing;
            requirements = new List<IExpertRequirements>();
        }
        public string GetTitleAndSalary() {
            return $"Посада: {Title}    Зарплата: {Salary}";
        }
        public string GetDescription() {
            return $"Посада: {Title}    Зарплата: {Salary}\n" +
                   $"Контактна інформація: {Firm.ContactInfo}\n" +
                   $"Опис: {Description}\n" + GetRequirements();                   
        }
        string GetRequirements() {
            string text = string.Empty;
            text += "Досвід: " + String.Join(", ",requirements.Where(x => x is Experience).Select(x => x.Name))+ "\n";
            text += "Комунікаційні навички: " + String.Join(", ", requirements.Where(x => x is CommunicationSkills).Select(x => x.Name)) + "\n";
            text += "Техніні навички: " + String.Join(", ", requirements.Where(x => x is TechnicalSkills).Select(x => x.Name)) + "\n";
            foreach (var requirement in requirements.Where(x => x is Education)) {
                text += $"{requirement.Name}\n";
            }
            return text;
        }
        public void AddRequirements(IExpertRequirements requirement) {
            requirements.Add(requirement);
        }
        public void DeleteRequirements(IExpertRequirements requirement) {
            requirements.Remove(requirement);
        }
        public void SetRequirements() {
            while (true) {
                Console.WriteLine("\nОберіть запропоновані критерії:");
                Console.WriteLine("1 - Досвід");
                Console.WriteLine("2 - Освіта");
                Console.WriteLine("3 - Технічні навички");
                Console.WriteLine("4 - Комунікаційні навички");
                Console.WriteLine("0 - Вихід");
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

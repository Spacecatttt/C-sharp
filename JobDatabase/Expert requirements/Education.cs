using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDatabase {
    public enum EducationLevel {
        NoEducation = 1,
        SecondaryCompleted,
        HigherIncomplete,
        BachelorDegree,
        MasterDegree,
    }
    public class Education : IExpertRequirements {
        public string Name { 
            get {
                if (InstitutionName != null)
                    return $"Рівень освіти: {Level}; Закінчив(ла) {InstitutionName}; ";
                else
                    return $"Рівень освіти: {Level}; ";
            } }
                
        public string? InstitutionName { get; set; }
        public EducationLevel Level { get; set; }

        public Education(string? institutionName, EducationLevel level) {
            InstitutionName = institutionName;
            Level = level;
        }
        public static Education Create() {
            string? name = null;
            string input = string.Empty;
            EducationLevel level;

            while (!IsValidEducationLevel(input)) {
                Console.WriteLine("Оберіть ступінь освіти:");
                Console.WriteLine("1 - Відсутній");
                Console.WriteLine("2 - Загальна середня.");
                Console.WriteLine("3 - Здобуття бакалавра");
                Console.WriteLine("4 - Ступінь бакалавра");
                Console.WriteLine("5 - Магістратура");
                Console.Write("Ваш вибір: ");
                input = Console.ReadLine();
            }

            level = (EducationLevel)Enum.Parse(typeof(EducationLevel), input);
            if (level != EducationLevel.NoEducation)
                while (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name)) {
                    Console.Write("Введіть назву навчального закладу: ");
                    name = Console.ReadLine();
                }

            return new Education(name, level);
        }

        private static bool IsValidEducationLevel(string input) {
            return Enum.TryParse(input, out EducationLevel _);
        }
    }
}

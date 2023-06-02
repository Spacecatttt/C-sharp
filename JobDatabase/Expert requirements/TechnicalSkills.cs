using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDatabase.Expert_requirements {
    public class TechnicalSkills : IExpertRequirements {
        public string Name { get { return "Техніні навички: " + Skill + ";"; } }
        public string Skill { get; set; }
        public TechnicalSkills(string name) {
            Skill = name;
        }
        public static TechnicalSkills Create() {
            string name = string.Empty;

            while (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name)) {
                Console.Write("Введіть назву технічного навичку: ");
                name = Console.ReadLine();
            }

            return new TechnicalSkills(name);
        }
    }
}

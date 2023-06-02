using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDatabase.Expert_requirements {
    public class CommunicationSkills : IExpertRequirements {
        public string Name { get { return "Комунікаційні навички: " + Skill + ";"; } }
        public string Skill { get; set; }
        public CommunicationSkills(string name) {
            Skill = name;
        }
        public static CommunicationSkills Create() {
            string name = string.Empty;
            while (String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name)) {
                Console.Write("Введіть назву комунікаційного навичку: ");
                name = Console.ReadLine();
            }
            return new CommunicationSkills(name);
        }
    }
}

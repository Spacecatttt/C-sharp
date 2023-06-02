using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDatabase {
    public class Firm {
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public List<Position> Vacancies { get; set; }

        public Firm(string name, string contactInfo) {
            Name = name;
            ContactInfo = contactInfo;
            Vacancies = new List<Position>();
        }

        public void AddVacancy(Position position) {
            Vacancies.Add(position);
        }

        public void RemoveVacancy(Position position) {
            Vacancies.Remove(position);
        }
    }
}

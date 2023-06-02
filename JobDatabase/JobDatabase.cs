using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDatabase {
    public class JobDatabase {
        private List<Firm> firms;

        public JobDatabase() {
            firms = new List<Firm>();
        }
        public bool TryGetFirm(string name, out Firm? firm) {
            firm = firms.FirstOrDefault(n => n.Name == name);
            if (firm == null)
                return false;
            return true;
        }
        public void AddFirm(Firm firm) {
            firms.Add(firm);
        }
        public Position? GetPosition(string id) {
            List<Position> positions = new List<Position>();
            foreach (var firm in firms)
                positions.AddRange(firm.Vacancies);
            return positions.FirstOrDefault(x => x.UniqueId.ToString() == id);
        }
        public void PrintPosition(int start) {
            List<Position> positions = new List<Position>();
            foreach (var firm in firms)
                positions.AddRange(firm.Vacancies);

            if (positions.Count == 0)
                Console.WriteLine("Вакансій немає\n");
            else {
                int end = Math.Min(start + 5, positions.Count);
                for (int i = start; i < end; i++) {
                    Console.WriteLine($"Id: {positions[i].UniqueId}");
                    Console.WriteLine(positions[i].GetTitleAndSalary());
                    Console.WriteLine();
                }
            }
        }
    }
}


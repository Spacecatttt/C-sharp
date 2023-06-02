using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDatabase {
    public class JobDatabase {
        public List<Firm> Firms { get; set; }

        public JobDatabase() {
            Firms = new List<Firm>();
        }

        public void AddFirm(Firm firm) {
            Firms.Add(firm);
        }

        public void RemoveFirm(Firm firm) {
            Firms.Remove(firm);
        }

        public List<Position> SearchPositionsByRequirements(ExpertRequirements requirements) {
            List<Position> matchingPositions = new List<Position>();

            foreach (var firm in Firms) {
                foreach (var vacancy in firm.Vacancies) {
                    if (vacancy.Requirements.Education == requirements.Education && vacancy.Requirements.Experience >= requirements.Experience) {
                        matchingPositions.Add(vacancy);
                    }
                }
            }

            return matchingPositions;
        }
    }
}

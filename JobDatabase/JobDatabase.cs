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
        public bool TryGetFirm(string name,out Firm? firm) {
            firm = firms.FirstOrDefault(n => n.Name == name);
            if(firm == null) 
                return false;
            return true;
        }
        public void AddFirm(Firm firm) {
            firms.Add(firm);
        }

        public void RemoveFirm(Firm firm) {
            firms.Remove(firm);
        }

        public List<Position> SearchPositionsByRequirements(IExpertRequirements requirements) {
            List<Position> matchingPositions = new List<Position>();

            foreach (var firm in firms) {
                
            }

            return matchingPositions;
        }
    }
}

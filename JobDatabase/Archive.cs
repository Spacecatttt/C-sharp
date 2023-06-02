using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDatabase {
    public class Archive {
        private List<Position> archivedPositions;

        public Archive() {
            archivedPositions = new List<Position>();
        }

        public void AddArchive(Position position) {
            archivedPositions.Add(position);
        }

        public void DeleteArchived(Position position) {
            archivedPositions.Remove(position);
        }
    }
}

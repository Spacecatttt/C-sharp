using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDatabase {
    public class Archive {
        private List<Firm> archivedFirms;

        public Archive() {
            archivedFirms = new List<Firm>();
        }

        public void ArchiveFirm(Firm firm) {
            archivedFirms.Add(firm);
        }

        public void DeleteArchivedFirm(Firm firm) {
            archivedFirms.Remove(firm);
        }
    }
}

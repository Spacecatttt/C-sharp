using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDatabase {
    public class ExpertRequirements {
        public string Education { get; set; }
        public int Experience { get; set; }

        public ExpertRequirements(string education, int experience) {
            Education = education;
            Experience = experience;
        }
    }
}

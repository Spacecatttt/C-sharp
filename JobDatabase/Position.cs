using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDatabase {
    public class Position {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Salary { get; set; }
        public bool IsProvidesHousing { get; set; }
        public List<IExpertRequirements> Requirements { get; set; }

        public Position(string title, string description, string terms, bool isProvidesHousing) {
            Title = title;
            Description = description;
            Salary = terms;
            IsProvidesHousing = isProvidesHousing;
            Requirements = new List<IExpertRequirements>();
        }

    }
}

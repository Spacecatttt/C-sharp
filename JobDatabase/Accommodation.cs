using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDatabase {
    public class Accommodation {
        public string Type { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }

        public Accommodation(string type, string description, decimal cost) {
            Type = type;
            Description = description;
            Cost = cost;
        }
    }
}

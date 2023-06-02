using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDatabase {
    public class Position {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Terms { get; set; }
        public string PaymentConditions { get; set; }
        public List<IExpertRequirements> Requirements { get; set; }

        public Position(string title, string description, string terms, string paymentConditions, IExpertRequirements requirements) {
            Title = title;
            Description = description;
            Terms = terms;
            PaymentConditions = paymentConditions;
            Requirements = new List<IExpertRequirements>();
        }

    }
}

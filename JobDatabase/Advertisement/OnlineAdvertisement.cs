using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDatabase {
    public class OnlineAdvertisement : IAdvertisement {
        public string GenerateAdvertisement() {
            // Логіка генерації онлайн-оголошення
            return "Online advertisement";
        }
    }
}

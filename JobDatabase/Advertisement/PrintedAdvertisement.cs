using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobDatabase.Advertisement;

namespace JobDatabase
{
    public class PrintedAdvertisement : IAdvertisement {
        public string GenerateAdvertisement() {
            // Логіка генерації оголошення для друку
            return "Printed advertisement";

        }
    }
}
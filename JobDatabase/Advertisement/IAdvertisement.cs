using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDatabase.Advertisement
{
    public interface IAdvertisement
    {
        string GenerateAdvertisement();
    }

    public class PrintedAdvertisement : IAdvertisement
    {
        public string GenerateAdvertisement()
        {
            // Логіка генерації оголошення для друку
            return "Printed advertisement";
        }
    }
}

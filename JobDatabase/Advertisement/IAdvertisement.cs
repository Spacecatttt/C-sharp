using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDatabase.Advertisement
{
    public interface IAdvertisement
    {
        void GenerateAdvertisement(Position position);
    } 
}

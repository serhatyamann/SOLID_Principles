using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.DIP_Dependency_Inversion.ViolatingExample
{
    public class Store
    {
        BMW bmw = new BMW();
        AUDI audi = new AUDI();

        public string GetCarsPrice() => $"{bmw.GetBmwPrice()} and {audi.GetAudiPrice()}";
    }
}

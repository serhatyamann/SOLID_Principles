using _4.ISP_Interface_Segregation.ViolatingExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ISP_Interface_Segregation.ViolatingExample.Concrete
{
    public class Aeromobil : IVehicle
    {
        public bool Drive()
        {
            return true;
        }

        public bool Fly()
        {
            return true;
        }
    }
}

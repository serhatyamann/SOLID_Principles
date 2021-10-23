using _4.ISP_Interface_Segregation.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ISP_Interface_Segregation.GoodExample.Concrete
{
    public class Car : IDrive
    {
        public bool Drive()
        {
            return true;
        }
    }
}

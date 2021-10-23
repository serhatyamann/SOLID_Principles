using _5.DIP_Dependency_Inversion.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.DIP_Dependency_Inversion.GoodExample.Concrete
{
    public class AUDI : ICar
    {
        public string GetCarsPrice()
        {
            return "100000";
        }
    }
}

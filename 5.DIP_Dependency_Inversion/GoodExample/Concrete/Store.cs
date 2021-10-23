using _5.DIP_Dependency_Inversion.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.DIP_Dependency_Inversion.GoodExample.Concrete
{
    class Store
    {
        private ICar _car;
        public Store(ICar car)
        {
            this._car = car;
        }

        public string GetPrice()
        {
            return $"{_car.GetCarsPrice()}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.OCP_Open_Closed.ViolatingExample
{
    public enum PhoneBrands { Apple = 1, Samsung = 2, Nokia = 3 }
    public class PhoneStore
    {
        public string GetPhonePrice(PhoneBrands phoneBrand)
        {
            double price = 0;
            if (phoneBrand == PhoneBrands.Apple)
            {
                price = 1000;
            }
            else if (phoneBrand == PhoneBrands.Samsung)
            {
                price = 700;
            }
            else if (phoneBrand == PhoneBrands.Nokia)
            {
                price = 300;
            }

            return $"Price for {phoneBrand} is ${price}";
        }
    }
}

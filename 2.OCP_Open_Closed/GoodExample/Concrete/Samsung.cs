using _2.OCP_Open_Closed.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.OCP_Open_Closed.GoodExample.Concrete
{
    public class Samsung : IStore
    {
        public string GetPhonePrice()
        {
            return "$700";
        }
    }
}

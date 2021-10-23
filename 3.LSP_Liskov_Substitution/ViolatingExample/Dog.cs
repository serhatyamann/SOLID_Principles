using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LSP_Liskov_Substitution.ViolatingExample
{
    public class Dog
    {
        public virtual string GetSound() => "Woof woof..";
    }
}

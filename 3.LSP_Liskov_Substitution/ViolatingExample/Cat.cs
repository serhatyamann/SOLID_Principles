using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LSP_Liskov_Substitution.ViolatingExample
{
    public class Cat:Dog
    {
        public override string GetSound() => "Meow meow!";
    }
}

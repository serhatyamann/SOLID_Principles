﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LSP_Liskov_Substitution.GoodExample
{
    public class Cat : IAnimal
    {
        public string GetSound() => "Meow meow!";
    }
}

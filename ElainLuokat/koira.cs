﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;

namespace Elaimet
{
    public class Koira : Nisakkaat
    {
        public override void Ääntele()
        {
            Console.WriteLine("woof");
        }
       
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WorkModel;
using WorkService;

namespace SecondWork
{
    class Program
    {
        static void Main(string[] args)
        {

            EastSect eastSect=new EastSect();
            NorthScet northScet=new NorthScet();
            SouthSect southSect=new SouthSect();
            WestSect westSect=new WestSect();
            
            BasicService<EastSect>.Print();

            Console.ReadKey();
        }

        

    }
}
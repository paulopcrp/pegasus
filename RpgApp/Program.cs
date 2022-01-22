using RpgApp.src;
using RpgApp.src.Entities;
using System;


namespace pegasus

{
    class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Hero("Pegasus", 23, "Knigth");
            Hero wizard = new Wizard("Taurus", 99, "Killer");


            Console.WriteLine(arus);
            Console.WriteLine(wizard.Attack());

        }
    }
}
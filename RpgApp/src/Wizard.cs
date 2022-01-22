using RpgApp.src;
using RpgApp.src.Entities;
using System;


namespace RpgApp.src
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)         {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public string Name;
        public int Level;
        public string HeroType;

        public override string Attack()
        {


            return this.Name + "  Attack with thunder magic";
        }
    }
}

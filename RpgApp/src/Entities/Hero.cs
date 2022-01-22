using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgApp.src.Entities
{
    internal class Hero
    {

        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString() //sobre escrita de método com override
        {
            return this.Name +" "+ this.Level +" "+ this.HeroType;
        }

        public virtual string Attack()
        {
            return this.Name + " Attack with sword";
        }


    }
}

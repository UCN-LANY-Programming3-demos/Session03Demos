using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooModel
{
    public class Zebra : Animal, IHerbavore
    {
        public Zebra(string name) : base(500, name)
        {
            
        }

        public void EatGrass()
        {
            Console.WriteLine("Eat Grass");
            Eat();
        }
    }
}

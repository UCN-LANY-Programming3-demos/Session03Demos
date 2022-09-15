using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooModel
{
    public class Lion : Animal, ICarnivore
    {
        public Lion(string name) : base(350, name)
        {
        }

        public void EatMeat()
        {
            Console.WriteLine("Eat meat");
            base.Eat();
        }
    }
}

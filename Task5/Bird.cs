using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Bird : IFlyAble
    {
        string name;
        bool canFly;
        public Bird(string name, bool canFly)
        {
            this.name = name;
            this.canFly = canFly;
        }
        public void Fly()
        {
            Console.WriteLine("Bird {0} can fly: {1}", name, canFly);
        }
    }
}

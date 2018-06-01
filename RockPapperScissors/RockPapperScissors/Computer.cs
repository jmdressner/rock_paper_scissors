using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapperScissors
{
    class Person2 : Player
    {
        // member variables

        public Person2(string name)
        {
            this.name = name;
        }

        // member methods

        public override void DisplayName()
        {
            Console.WriteLine("Person2: "+ name);
            Console.ReadLine();
        }

    }
}

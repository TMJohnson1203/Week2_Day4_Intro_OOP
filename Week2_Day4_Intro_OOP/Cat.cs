using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day4_Intro_OOP
{
    class Cat
    {
        // STATES
                // different states
                        //fields
        private string name;

        // properties
        private string Name // properties
        {
            get { return this.name;
            }
            set { this.name = value; }
        }

        // BEHAVIOR

        // CONSTRUCTORS
        public Cat()
        {
            // default constructor because it takes NO 
            // parameters in the parentesis

        }

    }
}

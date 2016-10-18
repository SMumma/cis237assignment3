using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
   public abstract class Astromech: UI
    {
        protected bool fireExtinguisher;
        protected int numberOfShips;
        const int costPerShip = 2000;
        public int Ships
        {
            get
            {
                return numberOfShips;
            }

            set
            {
                numberOfShips = value;
            }
        }

        public override string ToString()
        {
            return firstName + " " + lastName;
        }
    } 
}

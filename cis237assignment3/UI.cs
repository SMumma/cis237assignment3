using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    public class UI : IDroid
    {
        protected string firstName;
        protected string lastName;
        protected decimal cost;
        protected int quantity;
        protected string number;
        protected string astromechNumber;
        protected int higherThanZero;
        protected int numberOfLanguages;
        const int costPerLanguage = 200;

        public string Firstname
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }
        public decimal Cost
        {
            get
            {
                return cost;
            }

            set
            {
                cost = value;
            }
        }
        public void Customers(string FirstName, string LastName, decimal Cost)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.cost = Cost;
        }
       
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
        public decimal TotalCost
        {
            get
            {
                return Cost;
            }

            set
            {
                Cost = value;
            }
        }

        public string Number
        {
         get
            {
                return number;
            }  
            set
            {
                number = value;
            }
         }
        public string AstromechNumber
        {
            get
            {
                return astromechNumber;
            }
            set
            {
                astromechNumber = value;
            }
        }

        public int NumberOfLanguages
        {
            get
            {
                return numberOfLanguages;
            }

            set
            {
                numberOfLanguages = value;
            }
        }

        public void CostPerLanguage()
        {
            Console.WriteLine("Here is the cost for the language implementation: " + costPerLanguage);
            Cost += costPerLanguage;
        }
        public void CalculateTotalCost()
        {
            TotalCost = Cost * quantity;
        }
        public void ConsoleMenuAstromech()
        {
            Console.WriteLine("What parts do you want to have for the astromech?");
            Console.WriteLine("1. Lasers: $500");
            Console.WriteLine("2. Bombs: $400");
            Console.WriteLine("3. Holographic Display Unit (HDU): $700");
            Console.WriteLine("4. Voice command: $200");
            Console.WriteLine("5. Aerial attack unit: $1000");
            Console.WriteLine();
            Console.WriteLine("Your cost so far: " + Cost);
            Console.WriteLine();
            AstromechNumber = Console.ReadLine();
            if (AstromechNumber == "1")
            {
                Cost += 500m;
                TotalCost = Cost;
                Console.WriteLine("Total cost: " + TotalCost);
            }
            else
                if (AstromechNumber == "2")
            {
                Cost += 400m;
                TotalCost = Cost;
                Console.WriteLine("Total cost: " + TotalCost);
            }
            else
                if (AstromechNumber == "3")
            {
                Cost += 700m;
                TotalCost = Cost;
                Console.WriteLine("Total cost: " + TotalCost);
            }
            else
                if (AstromechNumber == "4")
            {
                Cost += 200m;
                TotalCost = Cost;
                Console.WriteLine("Total cost: " + TotalCost);
            }
            else
                if (AstromechNumber == "5")
            {
                Cost += 1000m;
                TotalCost = Cost;
                Console.WriteLine("Total cost: " + TotalCost);
            }
            }
        public override string ToString()
        {
            return firstName + " " + lastName; 
        }
        }
    }
    

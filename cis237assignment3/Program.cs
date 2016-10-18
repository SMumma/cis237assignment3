using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Program : UI
    {
        static void Main(string[] args)
        {

            UI newUI = new UI();
            //Setting up the array to be used for the astromechs
            UI[] arrayUI = new UI[5];
            
            //Enters your first and last names as well as a welcome message

            Console.WriteLine("Welcome to Tatooine wares!");
            Console.WriteLine("Where your junk becomes our treasure!");
            Console.WriteLine("Please enter your first name:");
            newUI.Firstname = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            newUI.LastName = Console.ReadLine();
            Console.WriteLine("Welcome " + newUI.Firstname + " " + newUI.LastName);
            //This asks you on if you want either a droid or an astromech for your ship
            Console.WriteLine("Please select 1 for available astromechs or 2 for available droids: ");

            newUI.Number = Console.ReadLine();
            if (newUI.Number == "1")
            {
                //These are the lists of droids you can buy.
                Console.WriteLine("Thank you for accessing the astromech menu");
                Console.WriteLine("Please make a choice from the list below");
                Console.WriteLine("1. R2D2");
                Console.WriteLine("2. Styrocake");
                Console.WriteLine("3. Bob");
                Console.WriteLine("4. Jay's Droid");
                Console.WriteLine("5. The Punisher");
                Console.WriteLine();
                Console.WriteLine("Please enter a number");
                newUI.Number = Console.ReadLine();

                //Once you select R2D2, it will ask you on what parts you want.
                if (newUI.Number == "1")
                {
                    Console.WriteLine("What parts do you want to have for the astromech?");
                    Console.WriteLine("1. Lasers: $500");
                    Console.WriteLine("2. Bombs: $400");
                    Console.WriteLine("3. Holographic Display Unit (HDU): $700");
                    Console.WriteLine("4. Voice command: $200");
                    Console.WriteLine("5. Aerial attack unit: $1000");
                    Console.WriteLine();
                    newUI.AstromechNumber = Console.ReadLine();
                    //These are the costs of the different accessory costs you may have and adds them to the Cost variable.
                    if (newUI.AstromechNumber == "1")
                    {
                        newUI.Cost = 500m;
                    }

                    else
                        if (newUI.AstromechNumber == "2")
                    {
                        newUI.Cost = 400m;
                    }
                    else
                            if (newUI.AstromechNumber == "3")
                    {
                        newUI.Cost = 700m;
                    }
                    else
                        if (newUI.AstromechNumber == "4")
                    {
                        newUI.Cost = 200m;
                    }
                    else
                    if (newUI.AstromechNumber == "5")
                    {
                        newUI.Cost = 1000m;
                    }
                    //This is the updated cost and asks you again if you want to add anything else to the list.
                    Console.WriteLine("Thank you for your selection");
                    Console.WriteLine("Here is the current bill: " + newUI.Cost);
                    Console.WriteLine();
                    Console.WriteLine("Would you like to add more to your order?: 1. Yes and 2. No");
                    newUI.Number = Console.ReadLine();

                    //This allows to add anything else to the order
                    if (newUI.Number == "1")
                    {
                        newUI.ConsoleMenuAstromech();
                        newUI.AstromechNumber = Console.ReadLine();
                        Console.WriteLine("Please enter the quantity of the item: ");
                        newUI.AstromechNumber = Console.ReadLine();
                        newUI.Quantity = int.Parse(newUI.AstromechNumber);
                        if (newUI.Quantity > 0)
                        {
                            //This is for when you select an astromech and its parts.
                            newUI.CalculateTotalCost();
                            Console.WriteLine("Total Cost: " + newUI.TotalCost);
                            Console.WriteLine("Thank you for shopping with us!");
                            Console.WriteLine("Your lovely cashier: Jim Bob");
                        }
                        else
                        {
                            do
                            {
                                Console.WriteLine("Please enter a number greater than 0");
                                Console.WriteLine("Please enter the quantity of the item you wish to buy: ");
                                newUI.AstromechNumber = Console.ReadLine();
                                newUI.Quantity = int.Parse(newUI.AstromechNumber);


                            } while (newUI.Quantity < 1);

                            newUI.CalculateTotalCost();
                            Console.WriteLine("Total Cost: " + newUI.TotalCost);
                            Console.WriteLine("Thank you for shopping with us!");
                            Console.WriteLine("Your lovely cashier: Jim Bob");
                        }
                    }
                    else
                    {
                        Console.WriteLine("This is your total for your order: " + newUI.Cost);
                        Console.WriteLine("Thank you for shopping with us!");
                        Console.WriteLine("Your lovely cashier: Jim Bob");
                    }

                }

            }
            else
            {
                if (newUI.Number == "2")
                {
                    Console.WriteLine("Thank you for accessing the droid menu");
                    Console.WriteLine("Please make a choice from the list below");
                    Console.WriteLine("1. 3CPO");
                    Console.WriteLine("2. Hammerhead");
                    Console.WriteLine("3. Dungheap");
                    Console.WriteLine("4. Roly-poly");
                    Console.WriteLine("5. Hardy Boy");
                    Console.WriteLine();
                    Console.WriteLine("Please enter a number:");
                    newUI.Number = Console.ReadLine();
                    if (newUI.Number == "1")
                    {
                        Console.WriteLine("Please enter the accessory number");
                    }
                }

            }
        }
    }

    
}

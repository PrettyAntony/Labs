using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Lab_3;

class Program
{
    static void Main(string[] args)
    {
        //instantiating a list to store passengers
        List<Passenger> passengersList = new List<Passenger>();

        try
        {
            //Adding a default passenger 
            Passenger defaultPassenger = new Passenger("Pretty", "Antony", "(123) 456-7890", 4, 100.50);
            passengersList.Add(defaultPassenger);

            int index = 0;

            do
            {
                Console.WriteLine("\n\nWelcome to KITE AIRLINES!!!!");
                Console.WriteLine("==+==+==+==+==+==+==+==+==+==+");
                Console.WriteLine("==========Menu Options========");
                Console.WriteLine("1.Add a new Passenger");
                Console.WriteLine("2.List all Passengers");
                Console.WriteLine("3.Exit");

                var menuItem = int.Parse(Console.ReadLine()!);

                //checking the menu user entered
                //menu #1 is for adding a new passenger
                if (menuItem == 1)
                {
                    Passenger passenger = new Passenger();

                    Console.WriteLine("Enter your FirstName : ");
                    passenger.firstName = Console.ReadLine();

                    //for firstname validation
                    while (passenger.validateName(passenger.firstName))
                    {
                        Console.WriteLine("Re-enter a valid Firstname : ");
                        passenger.firstName = Console.ReadLine();
                    }

                    Console.WriteLine("Enter your LastName : ");
                    passenger.lastName = Console.ReadLine();

                    //for lastname validation
                    while (passenger.validateName(passenger.lastName))
                    {
                        Console.WriteLine("Re-enter a valid Lastname : ");
                        passenger.lastName = Console.ReadLine();
                    }

                    Console.WriteLine("Enter your PhoneNumber <format '(XXX) XXX-XXXX' >  : ");
                    passenger.phoneNumber = Console.ReadLine();

                    //for phonenumber validation
                    while (!passenger.validatePhoneNumber())
                    {
                        Console.WriteLine("Re-enter a valid PhoneNumber as in format '(XXX) XXX-XXXX' : ");
                        passenger.phoneNumber = Console.ReadLine();
                    }

                    //getting input for number of bags
                    Console.WriteLine("How many bags you are checking in?");
                    passenger.numberOfBags = int.Parse(Console.ReadLine()!);
                    
                    //getting input for total weight of bags
                    Console.WriteLine("Enter the total weight of your luggage(in kgs): ");
                    var totalWeightOfBags = int.Parse(Console.ReadLine()!);
                    passenger.getAverageWeightOfBags(totalWeightOfBags);

                    //adding the new passenger to the list.
                    passengersList.Add(passenger);
                    Console.WriteLine("New Passenger Added.");

                }
                //menu #2 is for showing the list of passengers added.
                else if (menuItem == 2)
                {
                    
                    //listing all added passengers.
                    Console.WriteLine("==========Passenger's List========\n");
                    foreach (Passenger passenger in passengersList)
                    {
                        Console.WriteLine($"Name: {passenger.firstName} {passenger.lastName}, Phone: {passenger.phoneNumber}, {passenger.numberOfBags} Bags, Average weight: {passenger.averageWeightOfBags}kgs");
                    }
                    Console.WriteLine("\n");


                }
                //menu #3 is for exiting the loop.
                //for all other inputs other than 1 & 2, the program will exit after showing a thanks message.
                else if (menuItem >= 3 || menuItem < 1)
                {
                    Console.Write("Thankyou & Have a nice day :)");
                    return;
                }

                index++;
            } while (index < 100);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }


    }


}

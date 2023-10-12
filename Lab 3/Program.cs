using System.Runtime.CompilerServices;

namespace Lab_3;

class Program
{
    static void Main(string[] args)
    {

        List<Passenger> passengersList = new List<Passenger>();

        try
        {

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

                if (menuItem == 1)
                {
                    Passenger passenger = new Passenger();

                    Console.WriteLine("Enter your FirstName : ");
                    passenger.firstName = Console.ReadLine();

                    Console.WriteLine("Enter your LastName : ");
                    passenger.lastName = Console.ReadLine();

                    Console.WriteLine("Enter your PhoneNumber <format '(XXX) XXX-XXXX' >  : ");
                    passenger.phoneNumber = Console.ReadLine();

                    while (!passenger.validatePhoneNumber())
                    {
                        Console.WriteLine("Re-enter a valid PhoneNumber as in format '(XXX) XXX-XXXX' : ");
                        passenger.phoneNumber = Console.ReadLine();
                    }

                    Console.WriteLine("How many bags you are checking in?");
                    passenger.numberOfBags = int.Parse(Console.ReadLine()!);

                    Console.WriteLine("Enter the total weight of your luggage(in kgs): ");
                    var totalWeightOfBags = int.Parse(Console.ReadLine()!);
                    passenger.getAverageWeightOfBags(totalWeightOfBags);


                    passengersList.Add(passenger);
                    Console.WriteLine("New Passenger Added.");

                }
                else if (menuItem == 2)
                {

                    Console.WriteLine("==========Passenger's List========\n");
                    foreach (Passenger passenger in passengersList)
                    {
                        Console.WriteLine($"Name: {passenger.firstName} {passenger.lastName}, Phone: {passenger.phoneNumber}, {passenger.numberOfBags} Bags, Average weight: {passenger.averageWeightOfBags}kgs");
                    }
                    Console.WriteLine("\n");


                }
                else if (menuItem >= 3 || menuItem < 1)
                {
                    Console.Write("Thankyou & Have a nice day :)");
                    return;
                }

                index++;
            } while (index < 2);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }


    }


}

namespace MidtermExam;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        try
        {
            Toystore toyStore = new Toystore();

            //Storing the static values for the Toy Store
            toyStore.storeName = "Kids World";
            toyStore.storeLocation = "Waterloo,Ontario";
            toyStore.storeManagerDetails = "Ms.Pretty Antony";
            var toysList = toyStore!.toys!;

            //Adding initial 3 toys to the list.
            Toy toy1 = new Toy("ToyCar", "2-4years", 10, 15.0);
            Toy toy2 = new Toy("BabyDoll", "1-3years", 13, 24.0);
            Toy toy3 = new Toy("Ball", "2-5years", 20, 10.0);

            toysList.Add(toy1);
            toysList.Add(toy2);
            toysList.Add(toy3);

            Console.WriteLine($"\n\n\t\tWelcome to {toyStore.storeName}");
            Console.WriteLine("======================================================");
            Console.WriteLine($"\tManger of the Store : {toyStore.storeManagerDetails}");

            do
            {
                //for displaying the menu
                Console.WriteLine("\nPlease select your choice from the below Menu Options:");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("1.Add a new Toy to the Inventory list");
                Console.WriteLine("2.List all Toys in the Inventory list");
                Console.WriteLine("3.Remove a Toy from the Inventory list");
                Console.WriteLine("4.Delete the whole Inventory list");
                Console.WriteLine("5.Shut down the Inventory System");

                //to read the menu option 
                var menuItem = int.Parse(Console.ReadLine()!);

                //for menu option #1
                if (menuItem == 1)
                {
                    //addNewToy() function is called here for adding a new toy.
                    toysList.Add(addNewToy());
                    Console.WriteLine("New Toy Added\n");

                }
                else if (menuItem == 2)
                {
                    //here checking if the list is empty or not.
                    if (toysList.Count > 0)
                    {
                        //listAllToys() function is called here for listing all Inventory toys.
                        listAllToys(toysList);
                    }
                    else
                    {
                        Console.WriteLine("Toy Inventory list is empty");
                    }
                }
                else if (menuItem == 3)
                {
                    //here checking if the list is empty or not.
                    if (toysList.Count > 0)
                    {
                        //removeToy function is called to get the index of the Toy item to be removed.
                        var removeIndex = removeToy(toysList);
                        
                        //checking if for invalid index
                        if (removeIndex >= toysList.Count)
                        {
                            Console.WriteLine("Invalid index value");
                        }
                        else
                        {
                            //for removing item at the #index.
                            toysList.RemoveAt(removeIndex);
                            Console.WriteLine($"Toy at {removeIndex + 1} is deleted.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Toy Inventory list is empty");
                    }

                }
                else if (menuItem == 4)
                {
                    //here checking if the list is empty or not.
                    if (toysList.Count > 0)
                    {
                        //this list function helps to clear the list.
                        toysList.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Toy Inventory list is empty");
                    }
                }
                else
                {
                    Console.WriteLine("Thankyou & Have a nice day!!!");
                    return;
                }

            } while (true);


        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }

    //function to add a new Toy
    public static Toy addNewToy()
    {

        Toy newToy = new Toy();

        Console.WriteLine("Enter new Toy's Details");
        Console.WriteLine("Toy Name :");
        newToy.toyName = Console.ReadLine()!.ToString();

        //to check for valid input
        while (newToy.validate(newToy.toyName))
        {
            Console.WriteLine("Re-enter Toy Name :");
            newToy.toyName = Console.ReadLine()!.ToString();
        }

        Console.WriteLine("Age Group (eg:2-3years) :");
        newToy.ageGroup = Console.ReadLine()!.ToString();

        //to check for valid input
        while (newToy.validate(newToy.ageGroup))
        {
            Console.WriteLine("Re-enter Age Group :");
            newToy.ageGroup = Console.ReadLine()!.ToString();
        }

        Console.WriteLine("Number of Units Available :");
        var _numberOfUnitsAvailable = Console.ReadLine()!.ToString();

        //if no input is entered, system will take it as zero.
        if (newToy.validate(_numberOfUnitsAvailable))
        {
            newToy.numberOfUnitsAvailable = 0;
        }
        else
        {
            newToy.numberOfUnitsAvailable = int.Parse(_numberOfUnitsAvailable);
        }

        Console.WriteLine("Price per Unit :");
        var _pricePerUnit = Console.ReadLine()!.ToString();

        //if no input is entered, system will take it as zero.
        if (newToy.validate(_pricePerUnit))
        {
            newToy.pricePerUnit = 0.0;
        }
        else
        {
            newToy.pricePerUnit = double.Parse(_pricePerUnit);
        }

        return newToy;

    }

    //function to list all Toys with Total worth
    public static void listAllToys(List<Toy> toys)
    {
        Console.WriteLine("\nList of All Toys in the Inventory");
        Console.WriteLine("Toy\t\tAge Group\t\tNo:of Units\t\tPrice per Unit\t\tTotal Worth");

        //for listing all toys in the list.
        foreach (var toy in toys)
        {
            var totalWorth = toy.numberOfUnitsAvailable * toy.pricePerUnit;
            Console.WriteLine($"{toy.toyName}\t\t{toy.ageGroup}\t\t{toy.numberOfUnitsAvailable}\t\t\t${toy.pricePerUnit:F2}\t\t\t${totalWorth:F2}");
        }
    }

    //function to list all Toys and get the index value of the Toy to be removed
    public static int removeToy(List<Toy> toys)
    {
        Console.WriteLine("\nList of All Toys in the Inventory");
        Console.WriteLine("Index\tToy\t\tAge Group\t\tNo:of Units\t\tPrice per Unit");

        //for listing all toys in the list.
        for (int index = 0; index < toys.Count; index++)
        {
            Console.WriteLine($"{index + 1}\t{toys[index].toyName}\t\t{toys[index].ageGroup}\t\t{toys[index].numberOfUnitsAvailable}\t\t\t${toys[index].pricePerUnit:F2}");

        }

        //to read the index which is selected by user and return its value. 
        Console.WriteLine("\nPlease enter the index of Toy to be removed");
        return (int.Parse(Console.ReadLine()!) - 1);
    }
}

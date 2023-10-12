// Pretty Antony -- 8935790 -- Section 2
namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        try{

            Console.WriteLine("Please enter a fruit or vegetable");
            var item = Console.ReadLine();

            //to check if an 's' is to added 
            if(item[item.Length-1] != 's'){
            item = item + "s";
            }

            Console.WriteLine($"How many {item} did you purchase?");

            var itemQuantity = int.Parse(Console.ReadLine());

            Console.WriteLine($"How much did the {item} weigh, in total(in lbs):");

            var itemWeight = double.Parse(Console.ReadLine());

            //to check if an 's' is to be added or not
            if(itemQuantity>1 && (item[item.Length-1] != 's')){
            item = item + "s";
            }

            Console.WriteLine($"Thank you for purchasing {itemQuantity} {item} with an average weight of {itemWeight/itemQuantity} lbs. \n Have a nice day!!!");


        }catch(Exception e){
            Console.WriteLine(e.Message);
        }
    }
}

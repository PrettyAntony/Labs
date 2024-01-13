
//Toy class is inherited by ToyStore class
public class Toystore : Toy  
{
    //Empty Constructor
    public Toystore(){

        toys = new List<Toy>();

    }

    public string? storeName{get; set;}

    public string? storeLocation{get; set;}

    public List<Toy>? toys {get; set;}

    public string? storeManagerDetails{get; set;}

}
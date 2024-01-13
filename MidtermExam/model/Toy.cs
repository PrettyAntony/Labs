public class Toy
{

    //Empty Constructor
    public Toy()
    {

    }

    public Toy(string _toyName, string _ageGroup, int _numberOfUnitsAvailable, double _pricePerUnit)
    {
        this.toyName = _toyName;
        this.ageGroup = _ageGroup;
        this.numberOfUnitsAvailable = _numberOfUnitsAvailable;
        this.pricePerUnit = _pricePerUnit;
    }

    public string? toyName { get; set; }

    public string? ageGroup { get; set; }

    public int? numberOfUnitsAvailable { get; set; }

    public double? pricePerUnit { get; set; }

    //Validate Strings
    public bool validate(string input)
    {
        return input!.Equals("");
    }
}
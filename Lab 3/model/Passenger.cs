public class Passenger : Person
{
    public Passenger()
    {

    }

    public Passenger(string _firstName, string _lastName, string _phoneNumber, int _numberOfBags, double _averageWeightOfBags)
    {
        this.firstName = _firstName;
        this.lastName = _lastName;
        this.phoneNumber = _phoneNumber;
        this.numberOfBags = _numberOfBags;
        this.averageWeightOfBags = _averageWeightOfBags;
    }

    public int? numberOfBags { get; set; }

    public double? averageWeightOfBags { get; set; }

    public double? getAverageWeightOfBags(double totalWeightOfBags)
    {
        this.averageWeightOfBags =  totalWeightOfBags / numberOfBags;
        return averageWeightOfBags;
    }
}
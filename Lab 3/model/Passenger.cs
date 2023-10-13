public class Passenger : Person  //'Passenger' class inherits all member variables and functions from 'Person' class
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

    //for getting the average weights
    public double? getAverageWeightOfBags(double totalWeightOfBags)
    {
        this.averageWeightOfBags =  totalWeightOfBags / numberOfBags;
        return averageWeightOfBags;
    }
}
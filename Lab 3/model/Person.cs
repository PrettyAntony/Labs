public class Person
{
    public Person()
    {

    }

    public Person(string _firstName, string _lastName, string _phoneNumber)
    {
        this.firstName = _firstName;
        this.lastName = _lastName;
        this.phoneNumber = _phoneNumber;
    }

    public string? firstName { get; set; }

    public string? lastName { get; set; }

    public string? phoneNumber { get; set; }

    //for validating firstname and lastname
    public bool validateName(string? _name)
    {
        return (_name!.Equals(""));
    }

    //for validating phonenumber
    //here the exact format is checking (XXX) XXX-XXXX
    public bool validatePhoneNumber()
    {
        try
        {
            string character;

            for (int index = 0; index < phoneNumber!.Length; index++)
            {
                character = phoneNumber.Substring(index, 1);

                if ((index == 0 && !character.Equals("(")))
                {
                    return false;
                }
                else if (index == 4 && !character.Equals(")"))
                {
                    return false;
                }
                else if (index == 5 && !character.Equals(" "))
                {
                    return false;
                }
                else if (index == 9 && !character.Equals("-"))
                {
                    return false;
                }
                else if ((index != 0 && index != 4 && index != 5 && index != 9) && !char.IsDigit(phoneNumber[index]))
                {
                    return false;
                }
                else if ((index != 0 && index != 4 && index != 5 && index != 9) && char.IsLetter(phoneNumber[index]))
                {
                    return false;
                }
            }

            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return false;

    }

}
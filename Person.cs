namespace TestSerialize
{
    public class Person
    {
        public string FirstName;
        public string ClanName;
        public Address Address;

        public Person[] Friends;

        public Person()
        {
            Friends = new Person[5];
        }
    }

    public class Address
    {
        public int HouseNum;
        public string StreetName;
        public string State;
        public string Country;
        public string Pincode;

    }
}
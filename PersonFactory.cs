using Newtonsoft.Json;

namespace TestSerialize
{
    public class PersonFactory
    {
        public Person Createperson()
        {            
            Person Abhi = new Person();
            Person Dhruva = new Person();
            Person Ankush = new Person();

            Dhruva.FirstName = "Dhruva";
            Dhruva.ClanName = "Deepak";

            Ankush.FirstName = "Ankush";
            Ankush.ClanName = "Achwani";

            Address AbhiAddress = new Address();

            Abhi.FirstName = "Abhinav";
            Abhi.ClanName = "Pradeep";

            AbhiAddress.Country = "Australia";
            AbhiAddress.State = "Queensland";
            AbhiAddress.StreetName = "Nyes Crescent";
            AbhiAddress.Pincode = "4556";
            AbhiAddress.HouseNum = 42;

            Abhi.Address = AbhiAddress;

            Abhi.Friends[0] = Dhruva;
            Abhi.Friends[1] = Ankush;

            return Abhi;
        }

        public void SavePerson(Person person)
        {
            string serializedperson = JsonConvert.SerializeObject(person);
            System.Console.WriteLine( "Serialized person is " + serializedperson);
        }

    }
}
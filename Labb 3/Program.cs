namespace Labb_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstname = "Ahmad ";
            string lastname = "Yazbek ";
            Gender gender = Gender.Man;
            Hair hair = new Hair { HairColour = "svart " + "och ", HairLength = "kort " };
            DateTime birthday = new DateTime(2003, 08, 10);
            string EyeColour = "brun ";

            Person person = new Person(firstname, lastname, gender, hair, birthday, EyeColour);
            
            Console.WriteLine(person.ToString());
            

        }
        

    }
}

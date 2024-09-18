namespace Persons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person Micke = new Person() { FName = "Mikael", LName = "Pros" };

            PersonHandler Handler = new PersonHandler();
            Person Micke = Handler.CreatePerson(35, "Leakim", "Sorp", 0, 0);
            Handler.SetAge(Micke, 39);
            Handler.SetFirstName(Micke, "Mikael");
            Handler.SetLastName(Micke, "Pros");
            Handler.SetHeight(Micke, 100);
            Handler.SetWeight(Micke, 100);

            Console.WriteLine(Micke.Age);
            Console.WriteLine(Micke.FName);
            Console.WriteLine(Micke.LName);
            Console.WriteLine(Micke.Height);
            Console.WriteLine(Micke.Weight);
            Console.ReadLine();
        }
    }
}

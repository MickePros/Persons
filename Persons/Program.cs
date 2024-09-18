namespace Persons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person Micke = new Person() { FName = "Mikael", LName = "Pros" };

            PersonHandler handler = new PersonHandler();
            Person micke = handler.CreatePerson(35, "Leakim", "Sorp", 0, 0);
            handler.SetAge(micke, 39);
            handler.SetFirstName(micke, "Mikael");
            handler.SetLastName(micke, "Pros");
            handler.SetHeight(micke, 100);
            handler.SetWeight(micke, 100);

            Console.WriteLine(micke.Age);
            Console.WriteLine(micke.FName);
            Console.WriteLine(micke.LName);
            Console.WriteLine(micke.Height);
            Console.WriteLine(micke.Weight);

            NumericInputError numError = new NumericInputError();
            TextInputError textError = new TextInputError();
            LengthInputError legthError = new LengthInputError();
            NegativeInputError negativeError = new NegativeInputError();
            StupidInputError stupidError = new StupidInputError();
            List<UserError> errors = new List<UserError>
            {
                numError,
                textError,
                legthError,
                negativeError,
                stupidError
            };

            foreach (UserError error in errors)
            {
                Console.WriteLine(error.UEMessage());
            }

            Horse horse = new Horse();
            Dog dog = new Dog();
            Hedgehog hedgehog = new Hedgehog();
            Worm worm = new Worm();
            Bird bird = new Bird();
            Wolf wolf = new Wolf();
            Pelican pelican = new Pelican();
            Flamingo flamingo = new Flamingo();
            Swan swan = new Swan();
            Wolfman wolfman = new Wolfman();
            List<Animal> animals = new List<Animal>
            {
                dog,
                bird,
                swan,
                wolf,
                wolfman
            };

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine(animal.DoSound());

                if (animal is IPerson)
                {
                    IPerson wolfperson = (IPerson) animal;
                    Console.WriteLine(wolfperson.Talk());
                }
            }

            List<Dog> dogs = new List<Dog>
            {
                dog,
                //horse //F: Polymorfism 9) horse är av typen Persons.Horse men listan accepterar bara objekt av Persons.Dog och den kan inte konverteras
                //F: Polymorfism 10) En lista med typen Animal kan lagra alla våra klasser, men ska listan kunna ta emot ALLA klasser så behöver den vara <object> då alla klasser ärver från object.
            };

            foreach (Animal animal in animals)
            {
                Console.WriteLine($"{animal.Stats()}");
                //F: Polymorfism 13) Vi skriver ut svaret från samtliga klassers stats metod, varje klass har en override av bas klassen Animal method stats,
                //                   med undantag av Pelican, Flamingo, Swan och Wolfman som alla saknar egen metod och därför använder sin ärvda metod.
            }

            foreach (Animal animal in animals)
            {
                if (animal is Dog)
                {
                    Dog hund = (Dog)animal;
                    Console.WriteLine(animal.Stats());
                    Console.WriteLine(hund.Sit());
                }
                //animal.Sit(); //F: Polymorfism 17) animal är av typen Animal och den klassen saknar metoden Sit(),
                //                   vill man använda metoden måste man först casta animal till en typ som har Sit() definierad.
            }
        }
    }
}

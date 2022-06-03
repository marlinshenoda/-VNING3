namespace ÖVNING3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            NumericInputError error = new NumericInputError();
            IPerson walfman = new Walfman("A", 20.0, 3);
            List<UserError> BaseList = new();
            BaseList.Add(new NumericInputError());
            BaseList.Add(new TextInputError());
            foreach (var item in BaseList)
            {
                Console.WriteLine(item.UEMessage());
            }
            List<Animal> animals = new();
            animals.Add(new Wolf("A", 20.0, 3));
            animals.Add(new Bird("A", 20.0, 3));
            animals.Add(new Swan("A", 20.0, 3));
            animals.Add(new Walfman("A", 20.0, 3));
            animals.Add(new Horse("Horseman", 200.0, 10, "Wheat"));

            foreach (var animal in animals)
            {
                Console.WriteLine();
                Console.WriteLine(animal.GetType());
                Console.WriteLine(animal.DoSound());
                Console.WriteLine(animal.Stats());

                if (animal is IPerson)
                {
                    IPerson tempPerson = (IPerson)animal;
                    tempPerson.Talk();
                }

                if (animal is Dog)
                {
                    // do dog stuff
                }

                Console.WriteLine("________________________");
            }

        }


    }
}

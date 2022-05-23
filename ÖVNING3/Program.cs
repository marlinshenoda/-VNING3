using System;

namespace ÖVNING3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            NumericInputError error=new NumericInputError();    
            IPerson walfman = new Walfman();    
            List<UserError> BaseList = new ();
            BaseList.Add(new NumericInputError());
            BaseList.Add(new TextInputError());
            foreach (var item in BaseList)
            {
                Console.WriteLine(item.UEMessage());
            }
       List<Animal> animals = new ();  
            animals.Add(new Wolf());  
            animals.Add(new Bird());
            animals.Add(new Swan());
            animals.Add(new Walfman());
            foreach (var item in animals)
            {
                Console.WriteLine(item.GetType());
                Console.WriteLine(item.DoSound());
                Console.WriteLine(item.Stats());

            }
            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog());  
            
            foreach (var item in dogs)
            {
                Console.WriteLine(item.Stats());
            }
        }


    }
}

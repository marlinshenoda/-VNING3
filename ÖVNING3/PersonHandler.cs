using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("PersonTest")]

namespace ÖVNING3
{
    public class PersonHandler
    {
        public List<Person> Persons;
        public PersonHandler()
        {
            Persons=new List<Person>(); 
        }
     //  Person per=new Person();
        
        public void SetAge(Person pers, int age)
        {
            pers.Age=age;
        }
        
        public void AddPerson( int age, string fname,string lname,double height,double weight)
        {
            Person person = new Person( age,fname,lname,height,weight);
            Persons.Add(person);
        }
        internal List<Person> GetPersons()
        {
            return Persons.ToList();
        }

        public void FullName(string fname , string lname) 
        {
            Console.WriteLine($"{fname} {lname}");
        }
    }
}

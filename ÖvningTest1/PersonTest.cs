using Microsoft.VisualStudio.TestTools.UnitTesting;
using ÖVNING3;

namespace ÖvningTest1
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void Should_Return_FullName()
        { 
            
            var newper = new Person(20,"marlin","shenoda",90,56);
            int age = 20;
           
            Assert.AreEqual(age,newper.Age);


        }
        [TestMethod]
        public void set_fname()
        {
            //array
            var newper = new Person(20, "marlin", "shenoda", 90, 56);
            newper.Fname = "marlin";
            string actual = newper.Fname;
            string expected = "marlin";

        }
    }
}
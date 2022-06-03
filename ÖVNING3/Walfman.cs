namespace ÖVNING3
{
    internal class Walfman : Wolf, IPerson
    {
        public Walfman(string namn, double vikt, int age) : base(namn, vikt, age)
        {

        }

        public void Talk()
        {
            Console.WriteLine("BLÄBLÄBLÄ");
        }
    }
}

namespace ÖVNING3
{
    public class Person
    {
        public Person(int age, string fname, string lname, double height, double weight)
        {
            Age = age;
            this.fname = fname;
            this.lname = lname;
            this.height = height;
            this.weight = weight;
        }
        //privata fält
        private int age;
        private string fname;
        private string lname;
        private double height;
        private double weight;



        //publika properties
        public int Age
        {
            get { return age; }
            set
            {
                if (age > 0)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("Age must be greater than 0");
                }

            }
        }
        public string Fname
        {
            get { return fname; }
            set
            {

                for (int i = 0; i < value.Length; i++)
                {
                    if (value.Length >= 2 && value.Length <= 10)
                    {
                        fname = value;
                    }
                    else
                    {
                        throw new ArgumentException("Name must be at least two letters and less than eleven letters");

                    }
                }

            }
        }
        public string Lname
        {
            get { return lname; }
            set
            {

                for (int i = 0; i < value.Length; i++)
                {
                    if (value.Length >= 3 && value.Length <= 15)
                    {
                        lname = value;
                    }
                    else
                    {
                        throw new ArgumentException("Name must be at least two letters and less than eleven letters");

                    }
                }
                ;
            }

        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Weight
        {
            get { return height; }
            set { weight = value; }
        }




    }


}


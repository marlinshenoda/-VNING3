using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖVNING3
{
    internal class Walfman: Wolf,IPerson
    {
       public  void Talk()
        {
            Console.WriteLine("BLÄBLÄBLÄ");
        }
    }
}

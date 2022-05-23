using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖVNING3
{
    internal class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return $"You tried to use a numeric input in a text only field. This fired an error";
        }
    }
    internal class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return $"You tried to use a numeric input in a text only field. This fired an error";
        }
    }  
    internal class Error : UserError
    {
        public override string UEMessage()
        {
            return $"Sorry,Your account cauld not be actived";
        }
    }
}

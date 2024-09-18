using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    abstract class UserError
    {
        public abstract string UEMessage();
    }
    internal class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }
    internal class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";
        }
    }
    internal class LengthInputError : UserError
    {
        public override string UEMessage()
        {
            return "The input string does not match the length requirements!";
        }
    }
    internal class NegativeInputError : UserError
    {
        public override string UEMessage()
        {
            return "The input value can not be a negative number!";
        }
    }
    internal class StupidInputError : UserError
    {
        public override string UEMessage()
        {
            return "This input is stupid, please submit a not stupid input!";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._11
{
    public class MyException : Exception
    {
        public override string Message { get { return "" + base.Message; } }
    }
}

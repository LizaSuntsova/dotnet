using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16.Animals
{
    interface IMove
    {
        int Live();
        string Color { get; set; }
    }
}

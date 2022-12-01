using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC_0101
{
    internal class Elf
    {
        public Elf(int totalCalories)
        {
            CarriedCalories = totalCalories;
        }
        public int CarriedCalories { get; set; }
    }
}

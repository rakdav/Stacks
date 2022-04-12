using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    public class Monitor
    {
        public string Name { get; set; }
        public double Diagonal { get; set; }
        public decimal Price { get; set; }

        public override string? ToString()
        {
            return $"Название:{Name}, " +
                $"Диагональ:{Diagonal}, " +
                $"Цена:{Price}";
        }
    }
}

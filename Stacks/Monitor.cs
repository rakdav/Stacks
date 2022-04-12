using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    internal class Monitor
    {
        public string Name { get; set; }
        public double Diagonal { get; set; }
        public decimal Price { get; set; }
        public Monitor(string name, double diagonal, decimal price)
        {
            Name = name;
            Diagonal = diagonal;
            Price = price;
        }

        public override string? ToString()
        {
            return $"Название:{Name}, " +
                $"Диагональ:{Diagonal}, " +
                $"Цена:{Price}";
        }
    }
}

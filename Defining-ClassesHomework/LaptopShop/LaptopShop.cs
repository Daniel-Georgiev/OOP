using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class LaptopShop
    {
        static void Main()
        {
            Battery lion = new Battery("Li-Ion, 4-cells, 2550 mAh",(double)4.5);
            Laptop lpt_first = new Laptop("Lenovo Yoga 2 Pro", (decimal)869.88, "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", 8, "128GB SSD", "Intel HD Graphics 4400",  "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display",lion);
            Console.WriteLine(lpt_first);

        }
    }
}

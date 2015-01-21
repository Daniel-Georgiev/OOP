using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCatalog
{
    class PCCatalog
    {
        static Component processor1 = new Component("intel i5", (decimal)55.43);
        static Component gpu = new Component("gt5500", (decimal)120.50, "mnogo slaba karta we");
        static Component mamaboard = new Component("asdasda", (decimal)125.55, "nqawe");
        static Computer nababamikompa = new Computer("Na baba kompa", processor1, gpu, mamaboard);
        Console.WriteLine(nababamikompa.ToString());
        
        
        
    }
}

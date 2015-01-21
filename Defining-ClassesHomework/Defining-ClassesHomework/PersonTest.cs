using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_ClassesHomework
{
    class PersonTest
    {
        static void Main()
        {
            Person bobkata = new Person("bobkata", 15, "bobara@abv.bg");
            Person peshkowe = new Person("pesho ciganina", 22, "pesho@filipovci.com");
            Person djordjano = new Person("djordji", 100);

            Console.WriteLine(bobkata);
            

        }
    }
}

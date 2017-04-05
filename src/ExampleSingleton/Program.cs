using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ExampleSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance1 = SingletonClass.Instance;
            var instance2 = SingletonClass.Instance;

            if (instance1.GetKey() != instance2.GetKey())
                WriteLine($"La clave {instance1.GetKey()} es distinta a {instance2.GetKey()} ");
            else
                WriteLine("Las claves son iguales");

            if (instance1 != instance2)
                WriteLine("Las instancias son distintas");
            else
                WriteLine("Las instancias son iguales");

            ReadKey();
        }
    }
}

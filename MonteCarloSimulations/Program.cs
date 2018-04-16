using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloSimulations
{
    class Program
    {
        static void Main(string[] args)
        {
            runMain();
            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }

        public static void runMain()
        {
            Console.WriteLine("Running Main Method");

            List<Ameba> initialAmebaList = new List<Ameba>();
            for(int i=0; i<1000; i++)
            {
                Ameba ameba = new Ameba();
                initialAmebaList.Add(ameba);
            }
            Console.WriteLine("The Number of Amebas in this list is: " + initialAmebaList.Count);
            Console.WriteLine("Starting the iterations of life cycles");

            List<Ameba> listAfterLifeCycles = LifeCycleIterator.IterateNumberOfLifeCylces(initialAmebaList, 1000);

            Console.WriteLine("The number of Amebas after 1000 life cycles is: " + listAfterLifeCycles.Count);


        }


    }
}

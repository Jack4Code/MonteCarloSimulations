using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloSimulations
{
    public static class LifeCycleIterator
    {
        //public static LifeCycleIterator() { }

        private static Random rnd1 = new Random();

        internal static List<Ameba> IterateNumberOfLifeCylces(List<Ameba> listOfAmebas, int numberOfYears)
        {
            List<Ameba> listOfAmebasToAdd = new List<Ameba>();
            for(int i = 0; i<numberOfYears; i++)
            {
                List<Ameba> tempList = LifeCycleIterator.TryToProcreate(listOfAmebas[i]);
                if(tempList.Count > 1) //get rid of this dead Ameba
                {
                    //listOfAmebas.RemoveAt(i); //can't remove it just yet. need to make sure it's dead and then at the end before adding them, remove the dead ones
                    for (int j = 0; j < tempList.Count; j++)
                    {
                        listOfAmebasToAdd.Add(tempList[j]);
                    }
                }
            }
            for(int y=0; y<listOfAmebas.Count; y++)
            {
                if(listOfAmebas[y].getLifeStatus() == false)
                {
                    listOfAmebas.RemoveAt(y);
                }
            }
            for(int x = 0; x<listOfAmebasToAdd.Count; x++)
            {
                listOfAmebas.Add(listOfAmebasToAdd[x]);
            }
            return listOfAmebas;
        }

        internal static List<Ameba> TryToProcreate(Ameba ameba1)
        {
            List<Ameba> listOfThree = new List<Ameba>();
            int numberWhichDetermines;
            numberWhichDetermines = rnd1.Next(1, 4); //inclusive 1 exclusive 4...so random number between 1 and 3
            //Console.WriteLine(numberWhichDetermines);
            if(numberWhichDetermines == 1) //dies
            {
                ameba1.die();
                listOfThree.Add(ameba1);
                return listOfThree;
            }else if(numberWhichDetermines == 2) //splits in two and ages...which i just now realized age is pointless
            {
                ameba1.ageYear();
                Ameba ameba2 = new Ameba();
                listOfThree.Add(ameba1);
                listOfThree.Add(ameba2);
                return listOfThree;
            }
            else //splits in three and ages the first one...which i just now realized age is pointless
            {
                ameba1.ageYear();
                Ameba ameba2 = new Ameba();
                Ameba ameba3 = new Ameba();
                listOfThree.Add(ameba1);
                listOfThree.Add(ameba2);
                listOfThree.Add(ameba3);
                return listOfThree;
            }
        }

        
    }
}

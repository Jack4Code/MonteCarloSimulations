using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloSimulations
{
    class Ameba
    {
        private int age;
        private bool isAlive;
        
        public Ameba()
        {
            age = 0;
            isAlive = true;
        }

        public void ageYear()
        {
            age++;
        }

        public int getAge()
        {
            return this.age;
        }

        public void die()
        {
            isAlive = false;
        }

        public bool getLifeStatus()
        {
            return this.isAlive;
        }

        
    }
}

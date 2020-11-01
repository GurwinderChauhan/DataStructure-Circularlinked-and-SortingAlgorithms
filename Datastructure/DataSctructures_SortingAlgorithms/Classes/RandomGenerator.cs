using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSctructures_SortingAlgorithms.Classes
{
    public class RandomGenerator: Random
    {
        private static RandomGenerator instance = null;

        private RandomGenerator() : base() { }

        public static RandomGenerator Get_Instance()
        {
            if(instance == null)
            {
                instance = new RandomGenerator();
            }
            return instance;
        }
    }
}

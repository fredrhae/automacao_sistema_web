using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoWeb
{
    public static class Extensions
    {
        private static Random randomSeed = new Random();

        public static int getRandomIndex(this int lengthVetor)
        {
            return randomSeed.Next(lengthVetor);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ExceptionOef
{
    class Cat
    {
        public static void checkAgeMethod()
        {
            IList<int> Age = new List<int>() { 2, 5, 3, 12 };

            if (Age <= 0)
            {
                throw new CustomCatError();
            }
            Console.WriteLine("Het door u ingevoerde getal is kleiner dan of gelijk aan nul");
        }
    }
}
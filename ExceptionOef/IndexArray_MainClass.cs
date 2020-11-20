using System;
using System.IO;

namespace ExceptionOef
{
    public class IndexArray_MainClass
    {
        static void Main(string[] args)
        {
            int[] simpleArray = new int[] { 420, 69, 21 };
            bool Keeplooping = true; //Boolean die aanduidt dat de loop verdergaat.
            while (Keeplooping == true) //Wanneer de user geen geldige index heeft ingevuld
            {
                Console.WriteLine("Select the index of one of the 3 arrays you want to review the contents of. (Note that '0' is the first index number and not '1')");
                try //Als dit faalt wilt dit zeggen dat de user input geen 'int' is of te groot/klein is om in te geven.
                {
                    int index = int.Parse(Console.ReadLine()); //Dit stukje code neemt de input op.
                    Console.WriteLine(simpleArray[index].ToString()); //In dit stukje code wordt de output weergegeven.
                    Keeplooping = false; //De loop zal eindigen na dit process.
                }
                catch (IndexOutOfRangeException e) //De IndexOutOfRangeException geeft aan dat het door de user ingevoerde index nummer 
                                                   // zich buiten de bestaande array index nummers bevind.
                {
                    Console.WriteLine(e.Message); //Dit geeft de standaard exception melding weer van IndexOutOfRangeException
                }
                catch (FormatException) // de FormatException geeft aan dat er geen correcte invoer was door de user bv letter a ipv nummer 1
                {
                    Console.WriteLine("Ongeldige input. Probeer het aub opnieuw en voer een geldig index getal in. "); //Dit is een door mij gecreëerde gepersonaliseerde Error message
                }



            }
        }
    }
}



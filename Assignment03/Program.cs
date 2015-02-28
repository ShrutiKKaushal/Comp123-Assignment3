 /*  Name     -    Shruti K. Kaushal
  * Student # -    300804023
  * Course    -    Comp 123(Assignment 3)
  * Professor -    Tom Tsiliopoulos
  * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            DesignSimple();
            // Implement GiantPlanet Class
            GiantPlanet Gplanet = new GiantPlanet("Gas", "Venus", 12100, 81);
            Console.WriteLine(Gplanet.ToString());

            DesignSimple();// Extract method for displaying output in a nice manner

            // Implement TerrestrialPlanet Class
            TerrestrialPlanet tPlanet = new TerrestrialPlanet(true, "Earth", 12756, 108);
            Console.WriteLine(tPlanet.ToString());

            DesignSimple();// Extract method for displaying output in a nice manner
            ReadKey(); // Waits for user entry
           
        }

        private static void ReadKey()// Method Extracted using Re-factoring
        {
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static void DesignSimple()// Method Extracted using Re-factoring
        {
            
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            
        }


    }
}

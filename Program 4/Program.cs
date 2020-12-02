//Grading ID:N4999
//Program 4
//Due 4/23/2019
//CIS 199-75
//Program displays all package information used for shipping including shipping costs, changes property data, and reprints the new package information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    class Program
    {
        //precondition: none
        //Postcondition: Groundpackages information is displayed, changed, and displayed again
        public static void Main(string[] args)
        {
            GroundPackage package1 = new GroundPackage(40216, 90216, 5, 8, 1, 10.5); //values for the 5 initial packages
            GroundPackage package2 = new GroundPackage(51846, 75036, 3.7, 7.6, 7.6, 5);
            GroundPackage package3 = new GroundPackage(16749, 45824, 4, 7, 3, 15);
            GroundPackage package4 = new GroundPackage(00054, 74125, 7.3, 5.8, 4, 13.8);
            GroundPackage package5 = new GroundPackage(40218, 82541, 4, 8, 2.5, 25);

            GroundPackage[] groundpackages = new GroundPackage[5]; //create array with 5 values

            groundpackages[0] = package1; //initialize array with values above
            groundpackages[1] = package2;
            groundpackages[2] = package3;
            groundpackages[3] = package4;
            groundpackages[4] = package5;

            foreach (GroundPackage package in groundpackages) //writes information for all packages
            {
                Console.WriteLine($"{package}"); //uses ToString
                Console.WriteLine($"package costs {package.CalcCost():C}");
                Console.WriteLine("");
                Console.WriteLine($"After package changes {Environment.NewLine}");
                

                package.Height += 5; //values properties are changed
                package.Weight += 3;
                package.Length -= 4;
                package.OriginZip += 437;
                package.Width -= 2;


                Console.WriteLine($"{package}"); //new information is displayed using changed properties
                Console.WriteLine($"package now costs {package.CalcCost():C}");
                Console.WriteLine("");
            }






        }


       
    }
}
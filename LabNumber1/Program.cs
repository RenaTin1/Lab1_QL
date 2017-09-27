using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber1
{
    class Program
    {
        static void Main(string[] args)
        {
            //LAB NUMBER 1 _QL 9/2017---- Serena Tindle

            bool ContinueProgram = true; //Boolean Expression

            while (ContinueProgram == true) //Insert While Loop
            {
                double RmLength, RmWidth; //Variables and Input needed
                double RmArea = RmLength * RmWidth;
                double RmPerimeter = 2 * (RmLength + RmWidth);

                Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!"); //User Input
                Console.WriteLine("Enter Length:");
                RmLength = double.Parse(Console.ReadLine()); //Processing

                Console.WriteLine("Enter Width:");
                RmWidth = double.Parse(Console.ReadLine());

                Console.WriteLine("Area:" + RmArea); //Output
                Console.WriteLine("Perimeter:" + RmPerimeter);

                string UserOption;
                Console.WriteLine("Continue? (Y/N)");
                UserOption = Console.ReadLine();
                
                if (UserOption == "N")
                {
                    ContinueProgram = false; //end loop
                }
       
                Console.ReadKey();
            }
  
        }
    }
}

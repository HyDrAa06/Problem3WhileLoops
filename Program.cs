using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_cycles2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            int overTheGoal;
            int steps = 0;
            int newSteps = 0;

            Console.WriteLine("Steps:");
            steps = int.Parse(Console.ReadLine());
            


            while (steps < 10000)
            {
 
                Console.WriteLine("Steps:");
                var end = Console.ReadLine();

                if(end=="Going home")
                {
                    Console.WriteLine("Steps to home: ");
                    newSteps = int.Parse(Console.ReadLine());
                    steps = steps + newSteps;

                    break;
                }

                else
                {                  
                    steps = steps + int.Parse(end);
                }
                
            }


            if (steps >= 10000)
            {
                overTheGoal = steps - 10000;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine("{0} steps over the goal.", overTheGoal);
            }

            else
            {
                overTheGoal = 10000 - steps;
                Console.WriteLine("{0} more steps to reach goal.",overTheGoal);
            }

                Console.ReadLine();
        }
    }
}

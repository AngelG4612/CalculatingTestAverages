using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingAverages4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("When done entering scores type 'done' to get average");
            unknownTests();
        }

        public static bool done { get; set; }


        
        public static void unknownTests()
        {
            done = false;
            do
            {
                double scoreSum = 0;
                for(double i = 1; ; i++)
                {
                    

                    Console.Write($"What is the score for test {i}? ");
                    string testScore = Console.ReadLine();
                    
                    if (double.Parse(testScore) < 0 || double.Parse(testScore) > 100)
                    {
                        Console.Write("invalid score please enter score again: ");
                        double testScrore = double.Parse(Console.ReadLine());

                        
                    }
                    else if (testScore != "Done")
                    {
                        scoreSum += double.Parse(testScore);
                        unknownTests();
                    }
                    else
                    {
                        done = true;
                    }
                    double Average = scoreSum / i;


                    Console.WriteLine(Average);


                }

                
                    

            } while (done == false);

                    

        }
        


    }
}

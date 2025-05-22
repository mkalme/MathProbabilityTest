using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProbabilityTest
{
    class Program
    {
        static int g = 1;
        static int loop = 100000;

        static void Main(string[] args)
        {
            Random rand = new Random();

            double probability = 0;

            for (int i = 0; i < loop; i++) {
                int g1 = 0;
                int g2 = 0;

                Console.WriteLine(g1 + ", " + g2);

                if (g1 == 1 && g2 == 1) {
                    probability++;
                }
            }

            probability /= loop;

            Console.WriteLine((probability * 100) + "%");

            Console.ReadLine();
        }
    }
}

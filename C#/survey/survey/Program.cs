using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace survey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y = 0;

            string answer = "d";
            Console.WriteLine("how old is mr clarke hint:less than 20\n" +
                " a.93\n" +
                " b.41\n" +
                " c.51\n" +
                " d.12");
            answer=Console.ReadLine();
            if (answer == "d")
            {
                y++;
            }

            Console.ReadLine();
            Console.WriteLine("what is mr clarke's favortie rapper? hint:c\n" +
                " a.youngboy\n" +
                " b.travis scott\n" +
                " c.goku\n" +
                " d.drake");
            answer = Console.ReadLine();
            if (answer == "c")
            {
                y++;
            }

            Console.ReadLine();
            Console.WriteLine("what is mr clarke's favorite game\n" +
                " a.fortnite (gokus in it)\n" +
                " b.pong\n" +
                " c.minecraft\n" +
                " d.reddit.com r/place");
            answer=Console.ReadLine();
            if (answer == "a")
            {
                y++;
            }
            Console.WriteLine("Amount correct: " + y);
            Console.ReadLine();


        }
    }
}

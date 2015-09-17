using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*StreamWriter writer = new StreamWriter("..\\..\\Answers.txt");
            using (writer)
            {
                writer.WriteLine("Hello World");
            }*/

            StreamWriter writer = new StreamWriter("..\\..\\Numbers.txt", true);
            using (writer)
            {
                
                // Loop from 1 - 20 and write the number to a line
                for (int i = 1; i <= 20; i++)
                {
                    writer.WriteLine(i);
                }
            }
        }
    }
}

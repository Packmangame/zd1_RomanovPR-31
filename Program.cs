using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Cats Cat1 = new Cats();
                Cats Cat2 = new Cats();
               
                Console.WriteLine("Write first cat name");
                Cat1.Name=Console.ReadLine();
                Console.WriteLine("Write second cat name");
                Cat2.Name= Console.ReadLine();
                Console.WriteLine("Write the weight of the first cat");
                Cat1.Ves = Console.ReadLine();
                Console.WriteLine("Write the weight of the second cat");
                Cat2.Ves = Console.ReadLine();
                

                Cat1.Meow();
                Cat2.Meow();
                
                Cat1.CatInfo();
                Cat2.CatInfo();

            }
            catch(Exception e)
            {
                Console.WriteLine("Error");
            }
            Console.Read();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._04._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kolko produkta shte vavedesh");
            int n = int.Parse(Console.ReadLine());
            List <string> producti = new List <string>  ();
            for(int i =0;i<=n;i++)
            {
                Console.WriteLine("vavedi product"); 
                List<string> product = Console.ReadLine().Split(' ').ToList();
            }
            Console.Write(producti);
            
        }
    }
}

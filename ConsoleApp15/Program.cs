using System;
using static System.Console;
using System.Collections.Generic;
using System.Threading;
using System.IO;
using System.Xml.Serialization;
namespace ConsoleApp12
{

    class Program
    {


        static void Main(string[] ages)
        {
            HashSet<int>set = new HashSet<int>();
            
            for(int i = 0; ; i++)
            { 
                WriteLine("введите число");
                int number = int.Parse(ReadLine());
               
                if (set.Contains(number)==false) { WriteLine("число добавлено"); set.Add(number); }

                else { WriteLine("это число уже есть"); }
                WriteLine("если хотите закончитиь нажмите '0'");
                int key = Convert.ToInt32(ReadLine());
                if (key == 0) { break; }
                else if (key != 0) { }
            }
        }
    }
}

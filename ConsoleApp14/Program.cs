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
            Dictionary<int,string> info = new Dictionary<int,string>();

            static Dictionary<int,string> NewInfo(Dictionary<int,string>info)
            {
                for (int i = 0; ; i++)
                {
                    WriteLine("введите номер");
                    int number = Convert.ToInt32(ReadLine());
                    WriteLine("введите имя");
                    string name = ReadLine();

                    info.Add(number, name);

                    WriteLine("если хотите закончитиь нажмите '0'");
                    int key = Convert.ToInt32(ReadLine());
                    if (key == 0) { break; }
                    else if (key != 0) { }
                    

                }
                return info;
            }
            static Dictionary<int,string> Qest(Dictionary<int,string>info)
            {
                for (int i = 0; ; i++)
                {
                    WriteLine("введите номер");
                    int number = Convert.ToInt32(ReadLine());
                    string value;
                    if (info.TryGetValue(number, out value))
                    {
                        WriteLine(info[number]);
                    }
                    else
                    {
                        Console.WriteLine("такого номера нет");
                       
                    }
                    
                    WriteLine("если хотите закончитиь нажмите '0'");
                    int key = Convert.ToInt32(ReadLine());
                    if (key == 0) { break; }
                    else if (key != 0) { }

                }
                return null;
            }
            
            NewInfo(info);
            Qest(info);
        }
    }
}
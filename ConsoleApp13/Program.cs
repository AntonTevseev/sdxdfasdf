using System;
using static System.Console;
using System.Collections.Generic;
using System.Threading;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;
namespace ConsoleApp12
{

    class Program
    {
        
        
        static void Main(string[] ages)
        {

            List<int> list1 = new List<int>();

            static List<int> NewList(List<int>list1 ) //заполняек колекцию 
            {   
                Random random = new Random();
                int e;
                
                //List<int> list1 = new List<int>();

                for (int i = 0; i < 101; i++)
                {
                    e = random.Next(0, 101);
                    list1.Add(e);
                    
                }
                return list1;

            }
            static List<int> Delete(List<int>list1) //удаляет числа от 25-50
            {
               foreach (int i in list1.ToList())
               { 
                    if(i>25 && i < 50)
                    {
                        list1.Remove(i);
                    }
               }
               return list1 ;

            }
            static List<int>Print(List<int> list1)//выводит на экран
            {
                foreach(int i in list1)
                {
                    Console.WriteLine(i);
                }
                return list1;
            }
            
            Print(Delete(NewList(list1)));
            

        }
    }
}
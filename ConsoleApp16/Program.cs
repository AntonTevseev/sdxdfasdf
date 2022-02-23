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
            List<string> list = new List<string>();
            string Name = ReadLine();
            string Strit = ReadLine();
            string NuberHouse = ReadLine();
            string NuberFlat = ReadLine();
            string PhoneNuber = ReadLine();
            string HouseNuber = ReadLine();
            list.Add(Name);
            list.Add(Strit);
            list.Add(NuberHouse);
            list.Add(NuberFlat);
            list.Add(PhoneNuber);
            list.Add(HouseNuber);
            string Pathh = "_bill.xml";

            XmlSerializer xmlS= new XmlSerializer(typeof(List<string>));
            Stream s = new FileStream(Pathh, FileMode.Create, FileAccess.Write);
            xmlS.Serialize(s, list);
            s.Close();

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    
    
    struct Class1
    {
        public string List { get; set; }
        DateTime data = DateTime.Now;
        public Class1(string List)
        {
            this.List = List;
            
        }
        public void Save()
        {

            string info1 = $"{ List } ";
            string info2 = $"{data} ";
            string [] sss = { info1,info2 };
            File.WriteAllLines(@"d:\data3.txt", sss);
        }
        public void NewList(string List)
        {
            this.List=List;
        }
        public string PrintList()
        {
            string liness = File.ReadAllText(@"d:\data3.txt"); //создание масива для вывода без #
            string[] sss = liness.Split(' ');

            return $"{sss[0]}";
        }
    }
}

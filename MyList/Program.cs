using System;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> listem = new MyList<string>();
            listem.Add("NAME1");
            Console.WriteLine(listem.Lenght());
            listem.Add("Name2");
            Console.WriteLine(listem.Lenght());
        }
    }
}

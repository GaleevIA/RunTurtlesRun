using System;
using System.Linq;

namespace TestovoeZadanie_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] strings = new String[]{ "din", "recede", "Success", "(( @" };
            String[] strings2 = new String[strings.Length];

            for(int i = 0; i < strings.Length; i++)
            {
                strings2[i] = String.Concat(strings[i].ToLower().Select(x => strings[i].Where(y => x == y).Count() == 1 ? "(" : ")"));
            }

            for (int i = 0; i < strings.Length; i++)
                Console.WriteLine($"{strings[i]} => {strings2[i]}");
            
            Console.ReadLine();
        }
    }
}

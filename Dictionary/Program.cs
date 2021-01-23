using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> bilgiler = new MyDictionary<int, string>();
            bilgiler.Add(1, "Ceyda");
            Console.WriteLine(bilgiler.Length);
            bilgiler.Add(2, "Baran");
            Console.WriteLine(bilgiler.Length);
        }
    }
}

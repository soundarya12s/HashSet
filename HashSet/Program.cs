using HashSet;
using System;
namespace HashSet
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write a Statement");
            string statement = Console.ReadLine();
            string[] sentence = statement.Split(" ");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(sentence.Length);
            for (int i = 0; i < sentence.Length; i++)
            {
                hash.Add(Convert.ToString(i), sentence[i]);
            }
            string hash1 = hash.get("5");
            Console.WriteLine("The index Value: " + hash1);
        }
    }
}
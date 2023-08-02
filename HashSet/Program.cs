using HashSet;
using System;
namespace HashAndTrees
{
    class Program
    {
        static void Main()
        {
            bool flag = true;
            Console.WriteLine("enter your choice:\n1.Hash\n2.BST");
            while(flag)
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the string:");
                        string statement = Console.ReadLine();

                        string[] sentence = statement.Split(" ");
                        MyMapNode<string, string> hash = new MyMapNode<string, string>(sentence.Length);
                        for (int i = 0; i < sentence.Length; i++)
                        {
                            hash.Add(Convert.ToString(i), sentence[i]);
                        }
                        string hash1 = hash.get("3");
                        Console.WriteLine("The index value is: "+hash1);
                        for (int i = 0; i < sentence.Length; i++)
                        {
                            int Count = 1;
                            for (int j = i + 1; j < sentence.Length; j++)
                            {
                                if (hash.get(Convert.ToString(i)) == hash.get(Convert.ToString(j)))
                                {
                                    Count++;
                                    sentence[j] = null;
                                }
                            }
                            if (sentence[i] != null)
                                Console.WriteLine("The Frequency of the Word " + sentence[i] + " is " + Count);
                        }
                        Console.WriteLine("Enter the word to delete:");
                        string word = Console.ReadLine();
                        int count = 0;
                        for (int i = 0; i < sentence.Length; i++)
                        {
                            if (hash.get(Convert.ToString(i)) == word)
                            {
                                hash.Remove(Convert.ToString(i));
                                count++;
                            }
                        }
                        Console.WriteLine(hash);
                        if (count == 0)
                            Console.WriteLine("You Entered the Wrong Word. Enter the correct word to Remove");
                        Console.WriteLine(string.Join(" ", sentence));
                        break;
                    case 2:
                        BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
                        binarySearch.Insert(30);
                        binarySearch.Insert(70);
                        binarySearch.Insert(22);
                        binarySearch.Insert(40);
                        binarySearch.Insert(60);
                        binarySearch.Insert(95);
                        binarySearch.Insert(11);
                        binarySearch.Insert(65);
                        binarySearch.Insert(3);
                        binarySearch.Insert(16);
                        binarySearch.Insert(63);
                        binarySearch.Insert(67);
                        binarySearch.Display();
                        binarySearch.GetSize();
                        bool result = binarySearch.IfExists(67, binarySearch);
                        Console.WriteLine(result);
                        break;
                }
            }
            
        }
    }
}
﻿namespace Lecture;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);

        int[] arr = new int[3] { 4, 5, 6 };
        list.AddRange(arr);
        
        list.RemoveAt(3); // Удаление 3 элемента списка

        list.Reverse();

        for (int i = 0; i < list.Count; i++)
        {
            list[i]++;
        }

        foreach (int l in list )
        {
            Console.WriteLine(l);
        }

        Console.ReadKey();
    }
}
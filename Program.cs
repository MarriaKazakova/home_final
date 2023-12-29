using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите элементы массива через запятую: ");
        string input = Console.ReadLine();
        string[] words = input.Split(',');

        int count = 0;
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Trim().Length <= 3)
            {
                count++;
            }
        }

        string[] result = new string[count];
        int index = 0;
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Trim().Length <= 3)
            {
                result[index] = words[i].Trim();
                index++;
            }
        }
        
        Console.WriteLine("Результат:");
        foreach (string word in result)
        {
            Console.Write(word + " ");
        }
    }
}

﻿namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ange mängden rader och kolumner i ditt schackbräde:");
            int index = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < index; i++)
            {
                for (int j = 0; j < index; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write("□ ");
                    }
                    else
                    {
                        Console.Write("■ ");
                    }
                }

                Console.WriteLine();

            }

        }
    }
}

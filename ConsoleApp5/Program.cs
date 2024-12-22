using System;

namespace TrianglePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Input Count : ");
                string count = Console.ReadLine();

                if (int.TryParse(count, out int totalRows))
                {
                    for (int i = 1; i <= totalRows; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                }

                else if (count.Contains(","))
                {
                    string[] num = count.Split(',');

                    if (num.Length == 2 && num[0] == "99" && int.TryParse(num[1], out int rows))
                    {
                        for (int i = rows; i > 0; i--)
                        {
                            for (int j = 0; j < i; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
            Console.ReadLine();
        }
    }
}

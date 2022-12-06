using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //read from a file
            StreamReader SR = new StreamReader("Input.txt");
            List<int> ElfFood = new List<int>();
            string line;

            int currCal = 0;

            while ((line = SR.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    ElfFood.Add(currCal);
                    currCal = 0;
                }
                else
                {
                    currCal += int.Parse(line);
                }
                Console.WriteLine(line);
            }

            Console.WriteLine("\n\n");

            foreach (var item in ElfFood)
            {
                Console.WriteLine(item);
            }
            
            for (int i = ElfFood.Count-1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (ElfFood[j] > ElfFood[j + 1])
                    {
                        int temp = ElfFood[j+1];
                        ElfFood[j + 1] = ElfFood[j];
                        ElfFood[j] = temp;
                    }
                }
            }

            foreach (var item in ElfFood)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(ElfFood[ElfFood.Count - 1] + " " + ElfFood[ElfFood.Count - 2] + " " + ElfFood[ElfFood.Count - 3]);
            Console.WriteLine(ElfFood[ElfFood.Count - 1] + ElfFood[ElfFood.Count - 2] + ElfFood[ElfFood.Count - 3]);
        }
    }
}
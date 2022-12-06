namespace AdventOfCodeD2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader SR = new StreamReader("Input.txt");
            
            string line;
            int score = 0;

            while ((line = SR.ReadLine()) != null)
            {
                String[] split = line.Split(' ');
                //Console.WriteLine(split[0]+split[1]);
                switch (split[1])
                {
                    case "X":
                        Console.WriteLine("Rock");
                        score += 1;
                        break;
                    case "Y":
                        Console.WriteLine("Paper");
                        score += 2;
                        break;
                    case "Z":
                        Console.WriteLine("Scissors");
                        score += 3;
                        break;
                }
                // convert XYZ to 123
                split[0] = split[0].Replace("A", "1");
                split[0] = split[0].Replace("B", "2");
                split[0] = split[0].Replace("C", "3");

                split[1] = split[1].Replace("X", "1");
                split[1] = split[1].Replace("Y", "2");
                split[1] = split[1].Replace("Z", "3");

                Console.WriteLine(split[0] + split[1]);

                // 1 = rock, 2 = paper, 3 = scissors

                //Win
                if ((split[0] == "1" && split[1] == "2") ||
                    (split[0] == "2" && split[1] == "3") ||
                    (split[0] == "3" && split[1] == "1"))
                {
                    Console.WriteLine("Win");
                    score += 6;
                }
                //Draw
                else if (split[0] == split[1])
                {
                    Console.WriteLine("Draw");
                    score += 3;
                }
                else
                {
                    Console.WriteLine("Lose");
                }
            }
            Console.WriteLine(score);
        }
    }
}
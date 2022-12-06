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
                        Console.WriteLine("Lose");
                        //score += 0;
                        break;
                    case "Y":
                        Console.WriteLine("Draw");
                        score += 3;
                        break;
                    case "Z":
                        Console.WriteLine("Win");
                        score += 6;
                        break;
                }
                // convert XYZ to 123
                split[0] = split[0].Replace("A", "1");
                split[0] = split[0].Replace("B", "2");
                split[0] = split[0].Replace("C", "3");

                split[1] = split[1].Replace("X", "L");
                split[1] = split[1].Replace("Y", "D");
                split[1] = split[1].Replace("Z", "W");

                Console.WriteLine(split[0] + split[1]);

                // 1 = rock, 2 = paper, 3 = scissors

                //Win
                if (split[1] == "W")
                {
                    switch (split[0])
                    {
                        case "1":
                            score += 2;
                            break;
                        case "2":
                            score += 3;
                            break;
                        case "3":
                            score += 1;
                            break;
                    }
                }
                
                //Draw
                else if (split[1] == "D")
                {
                    score += Convert.ToInt32(split[0]);
                }

                //Lose
                else if (split[1] == "L")
                {
                    switch (split[0])
                    {
                        case "1":
                            score += 3;
                            break;
                        case "2":
                            score += 1;
                            break;
                        case "3":
                            score += 2;
                            break;
                    }
                }
            }
            Console.WriteLine(score);
        }
    }
}
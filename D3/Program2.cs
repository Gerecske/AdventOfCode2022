




StreamReader SR = new StreamReader("Input.txt");
string line;
string ruck1="";
string ruck2="";
string ruck3="";
int counter = 0;
char sim = ' ';
int prio = 0;

while ((line = SR.ReadLine()) != null)
{
    Console.WriteLine(line);
    if (counter == 0)
    {
        ruck1 = line;
        counter++;
    }
    else if (counter == 1)
    {
        ruck2 = line;
        counter++;
    }
    else if (counter == 2)
    {
        ruck3 = line;

        Console.WriteLine(ruck1 + " " + ruck2 + " " + ruck3 + "\n");
        //get similar char in ruck1 and ruck2 and ruck3
        for (int i = 0; i < ruck1.Length; i++)
        {
            for (int j = 0; j < ruck2.Length; j++)
            {
                for (int k = 0; k < ruck3.Length; k++)
                {
                    if (ruck1[i] == ruck2[j] && ruck2[j] == ruck3[k])
                    {
                        sim = ruck1[i];
                        
                        
                    }
                }
            }
        }
        Console.WriteLine("The similar char is " + sim);

        if (char.IsLower(sim))
        {
            Console.WriteLine(Convert.ToInt32(sim) - 96);
            prio += Convert.ToInt32(sim) - 96;
        }
        else
        {
            Console.WriteLine(Convert.ToInt32(sim) - 38);
            prio += Convert.ToInt32(sim) - 38;
        }

        sim = ' ';
        counter = 0;
    }




}
Console.WriteLine(prio);
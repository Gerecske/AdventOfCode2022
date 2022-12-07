




StreamReader SR = new StreamReader("Input.txt");
string line;
string comp1;
string comp2;
char sim = ' ';
int prio = 0;

while ((line = SR.ReadLine()) != null)
{
    Console.WriteLine(line);
    comp1 = line.Substring(0, (line.Length / 2));
    comp2 = line.Substring((line.Length / 2), (line.Length / 2));
    Console.WriteLine(comp1 + " " + comp2);
    sim = ' ';
    for (int i = 0; i < comp1.Length; i++)
    {
        for (int j = 0; j < comp2.Length; j++)
        {
            if (comp1[i] == comp2[j])
            {
                sim = comp1[i];
            }
        }
    }
    Console.WriteLine(sim);
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
}
Console.WriteLine(prio);
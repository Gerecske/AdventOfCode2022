


StreamReader SR = new StreamReader("Input.txt");

string line;
string[] parts;
string[] range1 = new string[2];
string[] range2 = new string[2];
int[] irange1 = new int[2];
int[] irange2 = new int[2];

int count = 0;

while ((line = SR.ReadLine()) != null)
{
    Console.WriteLine(line);
    parts = line.Split(',');
    Console.WriteLine(parts[0] + " " + parts[1]);
    range1 = parts[0].Split('-');
    range2 = parts[1].Split('-');
    Console.WriteLine(range1[0] + " " + range1[1] + " " + range2[0] + " " + range2[1]);
    irange1[0] = Convert.ToInt32(range1[0]);
    irange1[1] = Convert.ToInt32(range1[1]);

    irange2[0] = Convert.ToInt32(range2[0]);
    irange2[1] = Convert.ToInt32(range2[1]);

    //part1
    //count how mani times irange1 contains irange2 or vice versa
    if (irange1[0] <= irange2[0] && irange1[1] >= irange2[1])
    {
        count++;
    }
    else if (irange2[0] <= irange1[0] && irange2[1] >= irange1[1])
    {
        count++;
    }

    //part2
    //count how many times irange1 overlaps irange2 or vice versa
    else if (irange1[0] <= irange2[0] && irange1[1] >= irange2[0])
    {
        count++;
    }
    else if (irange2[0] <= irange1[0] && irange2[1] >= irange1[0])
    {
        count++;
    }


}
Console.WriteLine(count);
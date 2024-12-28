using System;

class Program
{
    static void Main()
    {
        string[] Global_Ponix = new string[3];
        for (int i = 0; i < 3; i++)
        {
            Global_Ponix[i] = Console.ReadLine();
        }

        bool l = false, k = false, p = false;

        foreach (var i in Global_Ponix)
        {
            if (i[0] == 'l')
                l = true;
            else if (i[0] == 'k')
                k = true;
            else if (i[0] == 'p')
                p = true;
        }

        if (l && k && p)
            Console.WriteLine("GLOBAL");
        else
            Console.WriteLine("PONIX");
    }
}

for (int i = 0; i < 3; i++)
{
    string[] time = Console.ReadLine().Split();
    int sh = int.Parse(time[0]);
    int sm = int.Parse(time[1]);
    int ss = int.Parse(time[2]);

    int eh = int.Parse(time[3]);
    int em = int.Parse(time[4]);
    int es = int.Parse(time[5]);

    int start = (sh * 3600) + (sm * 60) + ss;
    int end = (eh * 3600) + (em * 60) + es;
    int t = end - start;
    int h = t / 3600;
    int m = (t % 3600) / 60;
    int s = (t % 3600) % 60;

    Console.WriteLine(h + " " + m + " " + s);
}
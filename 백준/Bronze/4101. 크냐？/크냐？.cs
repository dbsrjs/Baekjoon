while (true)
{
    string[] a = Console.ReadLine().Split();

    if (a[0] == "0" && a[1] == "0")
        break;

    Console.WriteLine(Convert.ToInt32(a[0]) > Convert.ToInt32(a[1]) ? "Yes" : "No");
}
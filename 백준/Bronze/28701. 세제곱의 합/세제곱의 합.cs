int n = int.Parse(Console.ReadLine());
int a = 0;
double b = 0;

for (int i = 1; i < n + 1; i++)
{
    a += i;
}
Console.WriteLine(a);
Console.WriteLine(Math.Pow(a, 2));

for (int i = 1; i < n + 1; i++)
{
    b += Math.Pow(i, 3);
}
Console.WriteLine(b);

/*
int n = sc.nextInt();

        int a = 0, b = 0;

        for (int i = 1; i < n+1; i++) {
            a += i;
        }
        System.out.println(a);

        System.out.printf("%.0f\n", Math.pow(a, 2));

        for (int i = 1; i < n + 1; i++) {
            b += Math.pow(i, 3);
        }
        System.out.println(b);
 */
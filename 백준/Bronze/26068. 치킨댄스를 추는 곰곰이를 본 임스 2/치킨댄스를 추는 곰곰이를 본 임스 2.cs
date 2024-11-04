int.TryParse(Console.ReadLine(), out int n);

int ans = 0;
for (int i = 0; i < n; i++) {
    string? input = Console.ReadLine();
    int.TryParse(input!.Substring(2), out int dayLeft);
    if (dayLeft <= 90) ans++;
}

Console.WriteLine(ans);
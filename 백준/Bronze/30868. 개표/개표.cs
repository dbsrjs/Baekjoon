 int T = int.Parse(Console.ReadLine()); 
        
for (int i = 0; i < T; i++)
{
    int n = int.Parse(Console.ReadLine()); 
    var result = new System.Text.StringBuilder(); 

    for (int j = 0; j < n / 5; j++)
    {
        result.Append("++++ ");
    }
    for (int j = 0; j < n % 5; j++)
    {
        result.Append("|");
    }

    Console.WriteLine(result.ToString().Trim()); 
}
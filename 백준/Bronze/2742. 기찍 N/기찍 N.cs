using System.Text;

int n = int.Parse(Console.ReadLine());

StringBuilder output = new StringBuilder();

while (n > 0)
{
    output.AppendLine(n.ToString());
    n--;
}

Console.Write(output.ToString());
string[] str = Console.ReadLine().Split(" ");
int ax = int.Parse(str[0]);
int ay = int.Parse(str[1]);
int az = int.Parse(str[2]);

str = Console.ReadLine().Split(" ");
int cx = int.Parse(str[0]);
int cy = int.Parse(str[1]);
int cz = int.Parse(str[2]);
Console.Write(cx - az + " ");
Console.Write(cy / ay + " ");
Console.Write(cz - ax + " ");
// (c.z - a.x, c.y / a.y, c.x - a.z)
//a 🍰 b = (a.z + b.x, a.y × b.y, a.x + b.z)
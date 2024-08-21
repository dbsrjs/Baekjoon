string[] inputs = Console.ReadLine().Split();

double R = double.Parse(inputs[0]);
double C = double.Parse(inputs[1]);
double N = double.Parse(inputs[2]);

long RCCTV = (long)Math.Ceiling(R / N);
long CCCTV = (long)Math.Ceiling(C / N);

long CCTV = RCCTV * CCCTV;

Console.WriteLine(CCTV);
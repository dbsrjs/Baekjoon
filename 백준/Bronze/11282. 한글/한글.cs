int N = int.Parse(Console.ReadLine());

int baseCode = 0xAC00;

int numSta = 19;
int numMid = 21;
int numEnd = 28;

int idx = N - 1;
int idxSta = idx / (numMid * numEnd);
idx = idx % (numMid * numEnd);
int idxMid = idx / numEnd;
int idxEnd = idx % numEnd;

int uniCode = baseCode + (idxSta * numMid * numEnd) + (idxMid * numEnd) + idxEnd;

Console.WriteLine((char)uniCode);
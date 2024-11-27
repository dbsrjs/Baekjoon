string S = Console.ReadLine();

if (S == "fdsajkl;" || S == "jkl;fdsa")
{
    Console.WriteLine("in-out");
}
else if (S == "asdf;lkj" || S == ";lkjasdf")
{
    Console.WriteLine("out-in");
}
else if (S == "asdfjkl;")
{
    Console.WriteLine("stairs");
}
else if (S == ";lkjfdsa")
{
    Console.WriteLine("reverse");
}
else
{
    Console.WriteLine("molu");
}
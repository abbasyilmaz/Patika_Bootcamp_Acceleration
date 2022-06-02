int N = Convert.ToInt32(Console.ReadLine());
int key = N % 2;
if (key == 1)
{
    Console.WriteLine("Weird");
}
else if (key == 0 && N <= 5)
{
    if (N >= 2)
    {
        Console.WriteLine("Not Weird");
    }
}
else if (key == 0 && N <= 20)
{
    if (N >= 6)
    {
        Console.WriteLine("Weird");
    }
}
else if (key == 0 && N > 20)
{
    Console.WriteLine("Not Weird");
}

    
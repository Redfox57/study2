Console.Write("Enter the number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number B: ");
int b = Convert.ToInt32(Console.ReadLine());

int AtoB(int ac, int bc)
{
    int result = 1;
    for (int i = 0; i < bc; i++)
    {
        result = result * ac;
    }
    return result;
}

int aToB = AtoB(a, b);

Console.WriteLine($"{a} to the power of {b} equals {aToB}.");
Console.Write("Please enter 3 digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

int ShowMidNum(int number)
{
    int remain = number % 100;
    return remain / 10;
}

Console.WriteLine(ShowMidNum(num));
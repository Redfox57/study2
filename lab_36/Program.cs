int[] array = {5, 2, 9, 7, 9, 6, 15, 8, 22, 13, 6, 5};

int OddIndexSum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}

int oddSum = OddIndexSum(array);
Console.WriteLine(oddSum);
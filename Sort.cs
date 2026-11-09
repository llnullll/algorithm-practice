using System;

int[] numbers = { 7, 3, 5, 1, 3 };

Console.WriteLine(string.Join(", ", BubbleSort(numbers)));
Console.WriteLine(string.Join(", ", InsertionSort(numbers)));

static int[] BubbleSort(int[] numbers)
{
    int[] result = (int[])numbers.Clone();

    for (int end = result.Length - 1; end > 0; end--)
    {
        for (int index = 0; index < end; index++)
        {
            if (result[index] > result[index + 1])
            {
                int temporary = result[index];
                result[index] = result[index + 1];
                result[index + 1] = temporary;
            }
        }
    }

    return result;
}

static int[] InsertionSort(int[] numbers)
{
    int[] result = (int[])numbers.Clone();

    for (int index = 1; index < result.Length; index++)
    {
        int value = result[index];
        int position = index - 1;

        while (position >= 0 && result[position] > value)
        {
            result[position + 1] = result[position];
            position--;
        }

        result[position + 1] = value;
    }

    return result;
}

using System.Collections;

namespace Assignment_01;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("===== Assignment 01 - Advanced C# =====");
        Console.WriteLine();

        RunOptimizedBubbleSort();
        RunRangeExample();
        RunArrayListReverse();
        RunEvenNumbersExample();
        RunFixedSizeListExample();
        RunFirstNonRepeatedExample();

        Console.WriteLine();
        Console.WriteLine("All assignment requirements have been demonstrated.");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static void RunOptimizedBubbleSort()
    {
        Console.WriteLine("1. Optimized Bubble Sort");

        int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine($"Before: {string.Join(", ", numbers)}");

        OptimizedBubbleSort(numbers);

        Console.WriteLine($"After:  {string.Join(", ", numbers)}");
        Console.WriteLine();
    }

    static void OptimizedBubbleSort(int[] numbers)
    {
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            bool swapped = false;

            for (int j = 0; j < numbers.Length - 1 - i; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    (numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]);
                    swapped = true;
                }
            }

            if (!swapped)
                break;
        }
    }

    static void RunRangeExample()
    {
        Console.WriteLine("2. Generic Range<T>");

        Range<int> range = new Range<int>(10, 50);

        Console.WriteLine($"Range: {range.Minimum} to {range.Maximum}");
        Console.WriteLine($"25 is in range: {range.IsInRange(25)}");
        Console.WriteLine($"70 is in range: {range.IsInRange(70)}");
        Console.WriteLine($"Range length: {range.Length()}");
        Console.WriteLine();
    }

    static void RunArrayListReverse()
    {
        Console.WriteLine("3. Reverse ArrayList In-Place");

        ArrayList values = new ArrayList { "One", "Two", "Three", "Four", "Five" };

        Console.WriteLine($"Before: {string.Join(", ", values.ToArray())}");

        ReverseArrayList(values);

        Console.WriteLine($"After:  {string.Join(", ", values.ToArray())}");
        Console.WriteLine();
    }

    static void ReverseArrayList(ArrayList values)
    {
        int left = 0;
        int right = values.Count - 1;

        while (left < right)
        {
            object? temp = values[left];
            values[left] = values[right];
            values[right] = temp;

            left++;
            right--;
        }
    }

    static void RunEvenNumbersExample()
    {
        Console.WriteLine("4. Even Numbers");

        List<int> numbers = new List<int> { 1, 4, 7, 10, 12, 15, 18, 21, 24 };

        List<int> evenNumbers = GetEvenNumbers(numbers);

        Console.WriteLine($"Original: {string.Join(", ", numbers)}");
        Console.WriteLine($"Even:    {string.Join(", ", evenNumbers)}");
        Console.WriteLine();
    }

    static List<int> GetEvenNumbers(List<int> numbers)
    {
        List<int> result = new List<int>();

        foreach (int number in numbers)
        {
            if (number % 2 == 0)
                result.Add(number);
        }

        return result;
    }

    static void RunFixedSizeListExample()
    {
        Console.WriteLine("5. FixedSizeList<T>");

        FixedSizeList<string> names = new FixedSizeList<string>(3);

        names.Add("Omar");
        names.Add("Youssef");
        names.Add("Ahmed");

        Console.WriteLine($"Capacity: {names.Capacity}");
        Console.WriteLine($"Item at index 1: {names.Get(1)}");

        try
        {
            names.Add("Ali");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Add error: {ex.Message}");
        }

        try
        {
            Console.WriteLine(names.Get(5));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Get error: {ex.Message}");
        }

        Console.WriteLine();
    }

    static void RunFirstNonRepeatedExample()
    {
        Console.WriteLine("6. First Non-Repeated Character");

        string firstText = "swiss";
        string secondText = "aabbcc";

        Console.WriteLine(
            $"Text: {firstText} -> Index: {FindFirstNonRepeatedCharacter(firstText)}");

        Console.WriteLine(
            $"Text: {secondText} -> Index: {FindFirstNonRepeatedCharacter(secondText)}");

        Console.WriteLine();
    }

    static int FindFirstNonRepeatedCharacter(string text)
    {
        Dictionary<char, int> frequencies = new Dictionary<char, int>();

        foreach (char character in text)
        {
            if (frequencies.ContainsKey(character))
                frequencies[character]++;
            else
                frequencies[character] = 1;
        }

        for (int i = 0; i < text.Length; i++)
        {
            if (frequencies[text[i]] == 1)
                return i;
        }

        return -1;
    }
}

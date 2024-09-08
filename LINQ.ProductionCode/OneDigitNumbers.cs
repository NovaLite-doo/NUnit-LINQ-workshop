namespace LINQ.ProductionCode;

public class OneDigitNumbers
{
    private static readonly IReadOnlyList<int> Numbers = [9, 5, 2, 7, 1, 3, 8, 6, 4];
    private static readonly IReadOnlyList<string> StringNumbers = ["Nine", "Five", "Two", "Seven", "One", "Three", "Eight", "Six", "Four"];

    // Where
    // 01
    public static IEnumerable<int> GetEvenNumbers()
    {
        var evenNumbers = new List<int>();
        foreach (var number in Numbers)
        {
            if (number % 2 == 0)
            {
                evenNumbers.Add(number);
            }
        }

        return evenNumbers;
    }

    // Where
    // 02
    // Get the numbers greater than the given number
    public static IEnumerable<int> GetGreaterThan(int number)
    {
        var greaterNumbers = new List<int>();
        foreach (var age in Numbers)
        {
            if (age > number)
            {
                greaterNumbers.Add(age);
            }
        }

        return greaterNumbers;
    }

    // Where
    // 03
    // Get the numbers with more characters than the given length
    public static IEnumerable<string> GetWithMoreCharactersThan(int length)
    {
        var longerNumbers = new List<string>();
        foreach (var stringNumber in StringNumbers)
        {
            if (stringNumber.Length > length)
            {
                longerNumbers.Add(stringNumber);
            }
        }

        return longerNumbers;
    }

    // Select
    // 04
    // Get the length of each string in the list
    public static IEnumerable<int> GetStringNumbersLength()
    {
        var numberLengths = new List<int>();
        foreach (var stringNumber in StringNumbers)
        {
            numberLengths.Add(stringNumber.Length);
        }

        return numberLengths;
    }

    // OrderBy
    // 05
    public static IEnumerable<int> GetOrderedNumbers()
    {
        var numbers = new List<int>(Numbers);
        numbers.Sort();
        return numbers;
    }

    // OrderByDescending
    // 06
    public static IEnumerable<int> GetDescendingOrderedNumbers()
    {
        var numbers = new List<int>(Numbers);
        numbers.Sort();
        numbers.Reverse();
        return numbers;
    }

    // Sum
    // 07
    public static int GetSum()
    {
        var sum = 0;
        foreach (var number in Numbers)
        {
            sum += number;
        }

        return sum;
    }

    // Average
    // 08
    public static double GetAverage()
    {
        var sum = 0;
        foreach (var number in Numbers)
        {
            sum += number;
        }

        return sum / Numbers.Count;
    }

    // Max
    // 09
    public static int GetMax()
    {
        var max = Numbers[0];
        foreach (int number in Numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        return max;
    }

    // Where + Sum
    public static int GetSumOfEvenNumbers()
    {
        var sum = 0;
        foreach (var number in Numbers)
        {
            if (number % 2 == 0)
            {
                sum += number;
            }
        }

        return sum;
    }
}

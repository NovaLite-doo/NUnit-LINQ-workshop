namespace LINQ.ProductionCode;

public class OneDigitNumbers
{
    private static readonly List<int> Numbers = [9, 5, 2, 7, 1, 3, 8, 6, 4];
    private static readonly List<string> StringNumbers = ["Nine", "Five", "Two", "Seven", "One", "Three", "Eight", "Six", "Four"];

    // 01
    public static List<int> GetEvenNumbers()
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

    // 02 (Get the numbers greater than the given number)
    public static List<int> GetGreaterThan(int number)
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

    // 03 (Get the numbers with more characters than the given length)
    public static List<string> GetWithMoreCharactersThan(int length)
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

    // 04 (Get the length of each string in the list)
    public static List<int> GetStringNumbersLength()
    {
        var numberLengths = new List<int>();
        foreach (var stringNumber in StringNumbers)
        {
            numberLengths.Add(stringNumber.Length);
        }

        return numberLengths;
    }

    // 05
    public static int GetSum()
    {
        var sum = 0;
        foreach (var number in Numbers)
        {
            sum += number;
        }

        return sum;
    }

    // 06
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

    /*
    // 07
    public static double GetAverage()
    {
        var sum = 0;
        foreach (var number in Numbers)
        {
            sum += number;
        }
    
        return sum / Numbers.Count;
    }

    // 08
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

    // 09
    public static List<int> GetOrderedNumbers()
    {
        var orderedNumbers = new List<int>();
        foreach (var number in Numbers)
        {
            var inserted = false;
            for (var i = 0; i < orderedNumbers.Count; i++)
            {
                if (number < orderedNumbers[i])
                {
                    orderedNumbers.Insert(i, number);
                    inserted = true;
                    break;
                }
            }
            if (!inserted)
            {
                orderedNumbers.Add(number);
            }
        }
        return orderedNumbers;
    }
    */
}

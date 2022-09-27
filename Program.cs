// This is one example of a exercise from Hackerhank, working in vscode
class Result
{
    public static int beautifulDays(int i, int j, int k)
    {
        var count = 0;
        for (; i <= j; i++)
        {
            if (IsBeautiful(i, k))
            {
                count++;
            }
        }
        return count; ;
    }

    private static bool IsBeautiful(int i, int k)
    {
        return (i - invert(i)) % k == 0;
    }

    private static int invert(int i)
    {
        return Convert.ToInt32(new string(i.ToString().Reverse().ToArray()));
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        var input = "20 23 6";
        var cleanInput = input.TrimEnd().Split(' ');
        var intInput = ConvertToIntegers(cleanInput);
        int result = Result.beautifulDays(intInput[0], intInput[1], intInput[2]);
        Console.WriteLine($"result {result}");
    }

    private static int[] ConvertToIntegers(string[] cleanInput)
    {
        try
        {
            return cleanInput.Select(i => Convert.ToInt32(i)).ToArray();
        }
        catch (System.Exception)
        {
            return new int[0];
        }
    }
}

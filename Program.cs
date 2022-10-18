// This is one example of a exercise from Hackerhank, working in vscode
class Result
{
    public static string appendAndDelete(string s, string t, int k)
    {
        var requiredOperations = 0;
        requiredOperations += Math.Abs(t.Length - s.Length);
        var min = Math.Min(t.Length, s.Length);
        for (int i = 0; i < min && requiredOperations <= k; i++)
        {
            if (t[i] != s[i])
            {
                requiredOperations+= (t.Length - i)*2;
                break;
            }
        }

        int excessOperations = k - requiredOperations;
        if (excessOperations >0 && excessOperations % 2 == 0)
        {
            requiredOperations+= excessOperations;
        }
        return requiredOperations == k ? "Yes" : "No";
    }

    public static string appendAndDelete2(string s, string t, int k)
    {
        var requiredOperations = 0;
        requiredOperations += Math.Abs(t.Length - s.Length);
        var min = Math.Min(t.Length, s.Length);
        for (int i = 0; i < min && requiredOperations <= k; i++)
        {
            if (t[i] != s[i])
            {
                requiredOperations += (t.Length - i) * 2;
                break;
            }
        }

        int excessOperations = k - requiredOperations;
        if (excessOperations > 0 && excessOperations % 2 == 0)
        {
            requiredOperations += excessOperations;
        }
        return requiredOperations == k ? "Yes" : "No";
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

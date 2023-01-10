namespace HackerRank.Prepare.Algorithms.Implementation;
//https://www.hackerrank.com/challenges/save-the-prisoner/problem

class SaveThePrisoner
{
    public static int saveThePrisoner(int n, int m, int s)
    {
        var netMoves = m % n - 1;
        var finalPosition = s + netMoves;
        var isOneAfterLastPrisoner = finalPosition > n;
        if (isOneAfterLastPrisoner) return finalPosition % n;
        var isOneBeforeFirstPrisoner = finalPosition == 0;
        if (isOneBeforeFirstPrisoner) return n;
        return finalPosition;
    }
}
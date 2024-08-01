namespace SamsungTestTask;

public static class WaysCounter
{
    public static int Count(uint n)
    {
        switch (n)
        {
            case 0:
                return 0;
            case 1:
                return 1;
            case 2:
                return 2;
        }

        var results = new int[n + 1];
        results[0] = 1;
        results[1] = 1;
        results[2] = 2;
 
        for (var i = 3; i <= n; i++)
            results[i] = results[i - 1] + results[i - 2] + results[i - 3];
 
        return results[n];
    }
}
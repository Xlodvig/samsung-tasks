using System.Text;

namespace SamsungTestTask;

public static class Compression
{
    public static string Compress(string sourceStr)
    {
        var counter = 1;
        var builder = new StringBuilder();
    
        for (var i = 0; i < sourceStr.Length; i++)
        {
            if (i + 1 < sourceStr.Length && sourceStr[i] == sourceStr[i + 1])
                counter++;
            else
            {
                builder.Append($"{sourceStr[i]}{counter}");
                counter = 1;
            }
        }

        return builder.Length >= sourceStr.Length 
            ? sourceStr 
            : builder.ToString();
    }
}
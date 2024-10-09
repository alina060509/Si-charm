
using System;
using System.Collections.Generic;
using System.Linq;

class Program1
{
    static void Main()
    {
        int K1 = 7;
        int K2 = 11;
        List<int> A = new List<int> { 1, 9, 3, 8, 7 };
        List<int> B = new List<int> { 13, 4, 2 };
        List<int> result = FilterAndSortSequences(K1, K2, A, B);
        Console.WriteLine(string.Join(", ", result));
    }
    static List<int> FilterAndSortSequences(int K1, int K2, List<int> A, List<int> B)
    {
        var filteredA = A.Where(x => x > K1);
        var filteredB = B.Where(x => x < K2);
        var combined = filteredA.Concat(filteredB);

        var sortedCombined = combined.OrderBy(x => x).ToList();

        return sortedCombined;
    }
}
class Program
{
    static void Main()
    {
        List<int> A = new List<int> { -1, 9, 3, 3, -8, 7, -9, 8, 12, -11, -20, 65 };
        List<int> uniqueLast = GetUniqueLastDigits(A);
        Console.WriteLine(string.Join(", ", uniqueLast));
    }

    static List<int> GetUniqueLastDigits(List<int> numbers)
    {
        HashSet<int> seenDigits = new HashSet<int>();
        List<int> res = new List<int>();

        foreach (int number in numbers){
            if (number > 0){
                int lastDig = number % 10;
                if (!seenDigits.Contains(lastDig))
                {
                    seenDigits.Add(lastDig);
                    res.Add(lastDig);
                }
            }
        }

        return res;
    }
}
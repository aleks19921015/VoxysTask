int[] num1 = new[] { 9, 9, 9, 9 };
int[] num2 = new[] { 9, 9, 9 };
Console.WriteLine(string.Join(' ', Reduce(num1, num2)));
return;

int[] Reduce(int[]num1, int[]num2 )
{
    var result = new List<int>();
    int nextRad = 0;
    for (int i = num1.Length - 1, j = num2.Length - 1; i >= 0 || j >= 0; i--, j--)
    {
        var rad1 = i >= 0 ? num1[i] : 0;
        var rad2 = j >= 0 ? num2[j] : 0;
        var resRad = rad1 + rad2 + nextRad;
        result.Add(resRad % 10);
        nextRad = resRad / 10;
    }
    if (nextRad > 0)
        result.Add(nextRad);
    result.Reverse();
    return result.ToArray();
}
string s = "MCMXCIV";
int result = Solution.RomanToInt(s);

Console.WriteLine(result);



public class Solution
{
    public static int RomanToInt(string s)
    {
        var allLetters = new Dictionary<char, int>() {
            { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 },
        };
        int result = 0;
        var chars = s.ToCharArray();

        for (int n = 0; n < chars.Length; n += 2)
        {
            if (n != chars.Length - 1)
            {
                int first = allLetters[chars[n]];
                int second = allLetters[chars[n + 1]];

                if (second > first)
                {
                    result += second - first;
                }
                else
                {
                    bool isThree = allLetters.TryGetValue(key: chars[n + 2], out int gfg);

                    gfg.CompareTo(2);
                    result += first + second;
                }
                Console.WriteLine($"first: {first}, second: {second}, result: {result}");
            }
            else
            {
                int last = allLetters[chars[n]];
                result += last;
                Console.WriteLine($"last: {last}");
            }
        }

        return result;
    }
}

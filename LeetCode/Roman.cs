using System.Text;

namespace LeetCode;

public class Roman
{
    public static int RomanToInt(string s)
    {
        Dictionary<char, int> roman = new()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        var number = 0;

        for (var i = 0; i < s.Length; i++)
        {
            if (i+1 < s.Length && roman[s[i]] < roman[s[i+1]])
            {
                number -= roman[s[i]];
            }
            else
            {
                number += roman[s[i]];
            }
        }

        return number;
    }
    
    public static string IntToRoman(int num)
    {
        var roman = new StringBuilder();
        var romanMap = new Dictionary<int, string>
        {
            {1, "I"},
            {4, "IV"},
            {5, "V"},
            {9, "IX"},
            {10, "X"},
            {40, "XL"},
            {50, "L"},
            {90, "XC"},
            {100, "C"},
            {400, "CD"},
            {500, "D"},
            {900, "CM"},
            {1000, "M"}
        };

        var keys = romanMap.Keys.OrderByDescending(x => x).ToList();

        while (num > 0)
        {
            foreach (var key in keys)
            {
                if (num >= key)
                {
                    roman.Append(romanMap[key]);
                    num -= key;
                    break;
                }
            }
        }

        return roman.ToString();
    }
}


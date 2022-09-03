﻿using System.Text;
using System.Linq;

namespace LeetCode;

public static class Class1
{
    public static int RomanToInt(string s){
        Dictionary<char, int> romanNumbersDictionary = new(){
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        var number = 0;
        for (var i = 0; i < s.Length; i++){
            if (i + 1 < s.Length
                &&
                romanNumbersDictionary[s[i]] < romanNumbersDictionary[s[i + 1]]){
                number = number - romanNumbersDictionary[s[i]];
            }
            else{
                number = number + romanNumbersDictionary[s[i]];
            }
        }

        return number;
    }


    public static string LongestCommonPrefix(string[] strs){
        if (strs.Length == 0) return string.Empty;

        Array.Sort(strs);

        var first = strs[0];
        var last = strs[^1];

        var stringBuilder = new StringBuilder();
        for (var i = 0; i < first.Length; i++){
            if (first[i] != last[i]) break;

            stringBuilder.Append(first[i]);
        }

        return stringBuilder.ToString();

    }

    public static string BoolToWord(bool word){
        return word ? "Yes" : "No";
    }

    public static int PositiveSum(int[] arr){
        return arr.Length == 0 ? 0 : arr.Where(item => item > 0).Sum();
    }

    public static string RepeatStr(int n, string s){

        //return string.Concat(Enumerable.Repeat(s, n));

        var builder = new StringBuilder("");
        for (var i = 0; i < n; i++){

            builder.Append(s);
        }

        return builder.ToString();
    }

    public static bool Hero(int bullets, int dragons){
        return bullets >= 2 * dragons;
    }

    public static int[] ReverseSeq(int n){
        var array = new int[n];
        for (var i = 0; i < n; i++){
            array[i] = n - i;
        }

        return array;
    }


    // Reverse the order of the words in a given string,
    public static string Solution(string? str){
        // if(string.IsNullOrEmpty(str)) return string.Empty;
        // var newString = string.Empty;
        // for (var i = str.Length; i > 0; i--){
        //     newString += str[i-1] ;
        // }
        // return newString;

        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public static int DescendingOrder(int num){
        char[] charArray = num.ToString().ToCharArray();
        Array.Sort(charArray);
        Array.Reverse(charArray);
        return int.Parse(charArray);
    }

    public static int FindShort(string s){
        var wordArr = s.Split(" ");

        var shortestLen = wordArr[0].Length;

        for (int i = 1; i < wordArr.Length; ++i){
            if (wordArr[i].Length < shortestLen){
                shortestLen = wordArr[i].Length;
            }
        }

        return shortestLen;

        //return s.Split(' ').Min(x => x.Length);
    }

    public class Kata
    {
        public static int StringToNumber(String str){
            return int.Parse(str);
        }
    }

    public static int MakeNegative(int number){
        return number < 0 ? number : -number;
    }

    public static string Greet(string name){
        //throw new NotImplementedException("Greet is not implemented.");
        return $"Hello, {name} how are you doing today?";
    }

    public static bool BetterThanAverage(int[] ClassPoints, int YourPoints){
        var average = ClassPoints.Average();
        return YourPoints > average;
    }

    public static string Bmi(double weight, double height){
        var bmi = weight / (height * height);
        return bmi switch{
            < 18.5 => "Underweight",
            < 25.0 => "Normal",
            < 30.0 => "Overweight",
            _ => "Obese"
        };
    }
    
    // An array times 2
    public static int[] Maps(int[] x){
        const int prod = 2;
        for (var i = 0; i < x.Length; i++){
            x[i] *= prod;
        }
        return x;
        //return x.Select(e => e*2).ToArray();
    }
    
    public static string OddOrEven(int[] array){
        if (array.Length == 0) return "even";
        return array.Sum() % 2 == 0 ? "even" : "odd";
    }
    
    // smashes the array into a single string
    public static string Smash(string[] words){
        var sentence = string.Empty;
        for (int i = 0; i < words.Length; i++){
            words[i] = words[i].ToLower();
            sentence += words[i] + " ";
        }
        return sentence.TrimEnd();
    }
    
    public static int Past(int h, int m, int s)
    {
        return  3600000 * h + 60000 * m + 1000 * s;
    }
    
    public static long FindNextSquare(long num)
    {
        if (num % Math.Sqrt(num) == 0) return (long)Math.Pow(Math.Sqrt(num) + 1, 2);
        return -1;
    }
    
    public static List<int> RemoveSmallest(List<int> numbers)
    {
        if (numbers.Count == 0) return numbers;
        var min = numbers.Min();
        numbers.Remove(min);
        return numbers;
    }
    
    public static bool LoveFunc(int flower1, int flower2){
        return (flower1 + flower2) % 2 == 1;
    }
    
    public static bool XO (string input){
        var lowerInput = input.ToLower();
        var xCount = lowerInput.Count(c => c == 'x');
        var oCount = lowerInput.Count(c => c == 'o');

        return xCount == oCount;
    }
    
    // No space in between the words
    public static string NoSpace(string input)
    {
        return input.Replace(" ", "");
    }

    public static int Multiply(int x){
        return x % 2 == 0 ? x * 8 : x * 9;
    }
    
    public static int TotalPoints(string[] games) {
        var total = 0;
        foreach (var game in games){
            var score = game.Split(':');
            var home = int.Parse(score[0]);
            var away = int.Parse(score[1]);
            if (home > away){
                total += 3;
            }
            else if (home == away){
                total += 1;
            }
        }
        return total;
    }
    
    public static int DoubleInteger(int n)
    {
        return 2 * n;
    }
    
    public static int FindSmallestInt(int[] args){
        return args.Min();
    }
    
    public static int Litres(double time)
    {
        var liters = time * 0.5;
        return (int)liters;
        //return (int)(time/2);
    }
    
    public static string CountSheep(int n)
    {
        var sheep = new StringBuilder();
        for (var i = 1; i < n + 1 ; i++){
            sheep.Append($"{i} sheep...");
        }

        return sheep.ToString();
    }
    
    public static IEnumerable<string> FriendOrFoe (string[] names) {
        return names.Where(name => name.Length == 4);
    }
    
    public static bool SetAlarm(bool employed, bool vacation){
        return employed && !vacation;
    }
    
    public static bool Check(object[] a, object x)
    {
        return a.Contains(x);

    }
    
    public static int Paperwork(int n, int m){
        return n <= 0 || m <= 0 ? 0 : m * n;
    }
}



























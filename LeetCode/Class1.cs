using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

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
    
    public static bool Xo (string input){
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
    
    public static string BreakCamelCase(string str)
    {
        
        // Make a break where there is a capital letter
        var camelCase = new StringBuilder();
        foreach (var c in str){
            if (char.IsUpper(c)){
                camelCase.Append(' ');
            }
            camelCase.Append(c);
        }
        return camelCase.ToString();
    }
    
    public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
    {
        //filter out strings from the list and return the integers
        return listOfItems.OfType<int>();

    }
    
    public static bool IsSquare(int n)  => (Math.Sqrt(n) % 1 == 0);
    
    public static string Rps(string p1, string p2)
    {
        //Rock paper scissors
        if (p1 == p2) return "Draw!";
        switch (p1)
        {
            case "rock" when p2 == "scissors":
            case "scissors" when p2 == "paper":
            case "paper" when p2 == "rock":
                return "Player 1 won!";
            default:
                return "Player 2 won!";
        }
    }
    
    public static int SquareSum(int[] numbers)
    { 
        // Sum of squares
        return numbers.Sum(n => n * n);
    }
    
    public static int DuplicateCount(string str)
    {
        // Count the number of duplicate characters in a string
        var duplicates = new HashSet<char>();
        var unique = new HashSet<char>();
        foreach (var c in str.ToLower())
        {
            if (!unique.Add(c)) duplicates.Add(c);
        }
        return duplicates.Count;
    }
    
    public static List<string> Number(List<string> lines) 
    {
        // Number the lines
        for (var i = 0; i < lines.Count; i++) lines[i] = $"{i + 1}: {lines[i]}";
        return lines;
    }
    
    public static int GetUnique(IEnumerable<int> numbers)
    {
        // Find the unique number
        return numbers.GroupBy(n => n).First(g => g.Count() == 1).Key;
        
    }
    
    public static string PigIt(string str)
    {
        var pigLatin = new StringBuilder();
        foreach (var word in str.Split(' '))
        {
            if (word.Length == 1)
            {
                pigLatin.Append($"{word} ");
                continue;
            }
            pigLatin.Append($"{word.Substring(1)}{word[0]}ay ");
        }
        return pigLatin.ToString().TrimEnd();
    }
    
    public static string WordCount(string str) {

        // Count the number of words in a string
        return str.Split(' ').Length.ToString();
    }
    
    public static string NumberAddition(string str) {

        // Add the numbers in a string even if they are separated by letters
        return Regex
            .Matches(str, @"\d+")
            .Sum(m => int.Parse(m.Value))
            .ToString();
    }
    
    public static int LargestPair(int num) {
        
        var ints = num
            .ToString()
            .Select(c => int.Parse(c.ToString()))
            .ToList();
        var largestPair = 0;
        for (var i = 0; i < ints.Count - 1; i++)
        {
            var paiOfInts = int.Parse($"{ints[i]}{ints[i + 1]}");
            if (paiOfInts > largestPair) largestPair = paiOfInts;
        }
        return largestPair;

    }
    
    public static bool ValidateSolution(int[][] board)
    {
        //Sudoku validator
        if (board.Length != 9) return false;
        // check zero
        foreach (var row in board)
        {
            if (row.Length != 9) return false;
            if (row.Any(i => i < 0 || i > 9)) return false;
        }
        // check rows
        foreach (var row in board)
        {
            if (row.Distinct().Count() != 9) return false;
        }
        // check columns
        for (var i = 0; i < 9; i++)
        {
            var column = new List<int>();
            for (var j = 0; j < 9; j++)
            {
                column.Add(board[j][i]);
            }
            if (column.Distinct().Count() != 9) return false;
        }
        // check squares
        for (var i = 0; i < 9; i += 3)
        {
            for (var j = 0; j < 9; j += 3)
            {
                var square = new List<int>();
                for (var k = 0; k < 3; k++)
                {
                    for (var l = 0; l < 3; l++)
                    {
                        square.Add(board[i + k][j + l]);
                    }
                }
                if (square.Distinct().Count() != 9) return false;
            }
        }  
        return true;
    }
    
    public static string Maskify(string cc)
    {
        // Maskify a string except the last 4 characters
        return cc.Length <= 4 ? cc : new string('#', cc.Length - 4) + cc.Substring(cc.Length - 4);
    }
    
    public static string Disemvowel(string str)
    {
        // Remove all of the vowels from the string
        return new string(str.Where(c => !"aeiou".Contains(char.ToLower(c))).ToArray());
        
        /*return Regex.Replace(str,"[aeiou]", "", RegexOptions.IgnoreCase);*/
    }
    
    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable) 
    {
        //returns a list of items without any elements with the same value next to each other and preserving the original order of elements
        var unique = new List<T>();
        foreach (var item in iterable)
        {
            if (unique.Count == 0 || !unique.Last()!.Equals(item)) unique.Add(item);
        }
        return unique;
    }
    
    public static long RowSumOddNumbers(long n)
    {
        // sum of given row in triangle of consecutive odd numbers
        var sum = 0L;
        var start = n * (n - 1) + 1;
        for (var i = 0; i < n; i++)
        {
            sum += start + 2 * i;
        }
        return sum;
        
        //return (long)Math.Pow(n, 3);
    }
    
    public static bool IsTriangle(int a, int b, int c)
    {
        if (a <= 0 || b <= 0 || c <= 0) return false;
        return a + b > c && a + c > b && b + c > a;
    }
    
    public static int[] Arr(int N)
    {
        /* the numbers 0 to N-1 */ 
        return Enumerable.Range(0, N).ToArray();
    }
    
    public static int Find(int[] integers)
    {
        //Write a method that takes the array as an argument and returns this "outlier" N.(odd or even)
        var odd = integers.Where(i => i % 2 != 0).ToList();
        var even = integers.Where(i => i % 2 == 0).ToList();
        return odd.Count == 1 ? odd.First() : even.First();
    }
    
    public static int SumIntervals((int, int)[] intervals)
    {
        // CODEWARS - accepts an array of intervals, and returns the sum of all the interval lengths. Overlapping intervals should only be counted once.
        var sum = 0;
        var intervalsList = intervals.ToList();
        for (var i = 0; i < intervalsList.Count; i++)
        {
            var interval = intervalsList[i];
            for (var j = i + 1; j < intervalsList.Count; j++)
            {
                var nextInterval = intervalsList[j];
                if (interval.Item1 <= nextInterval.Item1 && interval.Item2 >= nextInterval.Item1)
                {
                    interval = (interval.Item1, nextInterval.Item2);
                    intervalsList.RemoveAt(j);
                    j--;
                }
            }
            sum += interval.Item2 - interval.Item1;
        }
        return sum;
    }
    
    public static string VowelCount(string str) {

        // take the str string parameter being passed and return the number of vowels the string contains 
        return str.Count(c => "aeiou".Contains(char.ToLower(c))).ToString();

    }
    
    public static int ClosestEnemy(int[] arr) {

        //take the array of numbers stored in arr and from the position in the array where a 1 is, return the number of spaces either left or right you must move to reach an enemy which is represented by a 2. For example: if arr is [0, 0, 1, 0, 0, 2, 0, 2] then your program should return 3 because the closest enemy (2) is 3 spaces away from the 1. The array will contain any number of 0's and 2's, but only a single 1. It may not contain any 2's at all as well, where in that case your program should return a 0.
        var index = Array.IndexOf(arr, 1);
        var left = index;
        var right = index;
        while (left >= 0 || right < arr.Length)
        {
            left--;
            right++;
            if (left >= 0 && arr[left] == 2) return index - left;
            if (right < arr.Length && arr[right] == 2) return right - index;
        }
        return 0;
        
        

    }
    
    
    public static string EquivalentKeypresses(string[] strArr) {

        //read the array of strings stored in strArr which will contain 2 strings representing two comma separated lists of keypresses. Your goal is to return the string true if the keypresses produce the same printable string and the string false if they do not. A keypress can be either a printable character or a backspace represented by -B. 
        var first = new List<char>();
        foreach (var key in strArr[0].Split(','))
        {
            if (key == "-B")
            {
                if (first.Count > 0) first.RemoveAt(first.Count - 1);
            }
            else
            {
                first.Add(key[0]);
            }
        }
        var second = new List<char>();
        foreach (var key in strArr[1].Split(','))
        {
            if (key == "-B")
            {
                if (second.Count > 0) second.RemoveAt(second.Count - 1);
            }
            else
            {
                second.Add(key[0]);
            }
        }
        if (first.Count != second.Count) return "false";
        if (first.Where((t, i) => t != second[i]).Any()){
            return "false";
        }
        return first.SequenceEqual(second) ? "true" : "false";

    }

    public static bool ValidParentheses(string input)
    {
        // takes a string of parentheses, and determines if the order of the parentheses is valid where only ( and ) are valid parentheses and the brackets must close in the correct order.
        
        var stack = new Stack<char>();
        foreach (var c in input)
        {
            if (c == '(')
            {
                stack.Push(c);
            }
            else if (c == ')')
            {
                if (stack.Count == 0 || stack.Pop() != '(') return false;
            }
        }
        return stack.Count == 0;
    }
    
    public static bool ValidatePin(string pin)
    {
        // takes a string and returns true if it's a valid pin or false if it's not. A valid pin has exactly 4 or 6 characters and only contains numerical characters (0-9).
        return pin.Length == 4 || pin.Length == 6 && pin.All(char.IsDigit);
    }
    
    public static bool IsIsogram(string str)
    {
        // takes a string and returns true if it is an isogram and false if not. An isogram is a word that has no repeating letters, consecutive or non-consecutive.
        return str.ToLower().Distinct().Count() == str.Length;
    }
    
    public static string[] GetStrings(string city)
    {
        // takes a city name and returns a string that shows how many times each letter shows up in the string by using an asterisk (*).
        return city.ToLower().GroupBy(c => c).Select(g => $"{g.Key}:{new string('*', g.Count())}").ToArray();
    }
    
    public static int[] SortArray(int[] array)
    {
        // takes an array of integers and returns a new array with the same numbers but in the following order: odd numbers sorted in ascending order, even numbers sorted in descending order.
        var odd = array.Where(i => i % 2 != 0).OrderBy(i => i).ToList();
        var even = array.Where(i => i % 2 == 0).OrderByDescending(i => i).ToList();
        return array.Select(i => i % 2 != 0 ? odd.First() : even.First()).ToArray();
    }
    
    public static float FindAverage(IEnumerable<int> array)
    {
        // takes an array containing integers and returns the average of the even numbers from the array. The array will never be empty and will only contain values that are greater than or equal to zero.
        return (float) array.Where(i => i % 2 == 0).Average();
    }
    
    public static int[] SortArrayByParity(int[] A)
    {
        // takes an array of non-negative integers and returns an array consisting of all the even elements of the array, followed by all the odd elements of the array.
        return A.OrderBy(i => i % 2).ToArray();
    }
    
    public static string ReverseWordsAndRemoveVowels(string str)
    {
        // takes a string and returns a new string with all the vowels removed and the words in reverse order.
        return string.Join(" ", str.Split(' ').Reverse().Select(s => new string(s.Where(c => !"aeiou".Contains(char.ToLower(c))).ToArray())));
    }
    
    public static string CommonCharacterCount(string s1, string s2)
    {
        // takes two strings and returns the number of common characters between the two strings.
        var count = 0;
        var s2List = s2.ToList();
        foreach (var c in s1.Where(c => s2List.Contains(c))){
            count++;
            s2List.Remove(c);
        }
        return count.ToString();
    }
    
    public static int[] ArrayReplace(IEnumerable<int> inputArray, int elemToReplace, int substitutionElem)
    {
        // takes an array of integers and replaces all the occurrences of elemToReplace with substitutionElem.
        return inputArray.Select(i => i == elemToReplace ? substitutionElem : i).ToArray();
    }
    
    public static int EvenNumbersBeforeFixed(IEnumerable<int> sequence, int fixedElement)
    {
        // takes an array of integers and returns the number of even integers that occur before the first occurrence of the number fixedElement in the array. If the sequence does not contain the number fixedElement, the function should return -1.
        var count = 0;
        foreach (var i in sequence)
        {
            if (i == fixedElement) return count;
            if (i % 2 == 0) count++;
        }
        return -1;
    }
    
    public static IEnumerable<int> Range(int start, int count)
    {
        // takes two integers start and count and returns an array containing count numbers from start to start + count - 1.
        return Enumerable.Range(start, count);
    }
    
    public static int[] AlternatingSums(int[] a)
    {
        // takes an array of integers and returns an array of two integers, where the first element is the sum of all the even-indexed elements of the array, and the second element is the sum of all the odd-indexed elements of the array.
        return new[] {a.Where((i, index) => index % 2 == 0).Sum(), a.Where((i, index) => index % 2 != 0).Sum()};
    }
    
    public static int[] AddBorder(int[][] picture)
    {
        // takes a rectangular matrix of characters and adds a border of asterisks(*) to it.
        var width = picture[0].Length + 2;
        var result = new List<string> {new string('*', width)};
        result.AddRange(picture.Select(row => "*" + string.Join("", row) + "*"));
        result.Add(new string('*', width));
        return result.Select(int.Parse).ToArray();
    }
    
    public static string[] AllLongestStrings(string[] inputArray)
    {
        // takes an array of strings and returns another array containing all of its longest strings.
        var maxLength = inputArray.Max(s => s.Length);
        return inputArray.Where(s => s.Length == maxLength).ToArray();
    }
    
    
    public static int[] ExtractEachKth(IEnumerable<int> inputArray, int k)
    {
        // takes an array of integers and removes each kth element from it.
        return inputArray.Where((i, index) => (index + 1) % k != 0).ToArray();
    }
    
    public static int[] FirstReverseTry(int[] arr)
    {
        // takes an array of integers and returns the same array with the first and last elements of the array swapped.
        if (arr.Length == 0) return arr;
        (arr[0], arr[^1]) = (arr[^1], arr[0]);
        return arr;
    }
    
    public static string WordEnds(string str, string ending)
    {
        // takes a string and an ending and returns the sum of the number of times the ending appears in the string and the number of times the ending appears in the reverse of the string.
        var count = 0;
        for (var i = 0; i < str.Length - ending.Length + 1; i++){
            if (str.Substring(i, ending.Length) != ending) continue;
            count++;
            i += ending.Length - 1;
        }
        return count.ToString();
    }
    
    public static int[] RemoveArrayPart(IEnumerable<int> inputArray, int l, int r)
    {
        // takes an array of integers and removes each kth element from it.
        return inputArray.Where((i, index) => index < l || index > r).ToArray();
    }
    
}



























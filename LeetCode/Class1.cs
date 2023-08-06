using System.Collections;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
using System;

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

    public static int Past(int h, int m, int s){
        return 3600000 * h + 60000 * m + 1000 * s;
    }

    public static long FindNextSquare(long num){
        if (num % Math.Sqrt(num) == 0) return (long) Math.Pow(Math.Sqrt(num) + 1, 2);
        return -1;
    }

    public static List<int> RemoveSmallest(List<int> numbers){
        if (numbers.Count == 0) return numbers;
        var min = numbers.Min();
        numbers.Remove(min);
        return numbers;
    }

    public static bool LoveFunc(int flower1, int flower2){
        return (flower1 + flower2) % 2 == 1;
    }

    public static bool Xo(string input){
        var lowerInput = input.ToLower();
        var xCount = lowerInput.Count(c => c == 'x');
        var oCount = lowerInput.Count(c => c == 'o');

        return xCount == oCount;
    }

    // No space in between the words
    public static string NoSpace(string input){
        return input.Replace(" ", "");
    }

    public static int Multiply(int x){
        return x % 2 == 0 ? x * 8 : x * 9;
    }

    public static int TotalPoints(string[] games){
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

    public static int DoubleInteger(int n){
        return 2 * n;
    }

    public static int FindSmallestInt(int[] args){
        return args.Min();
    }

    public static int Litres(double time){
        var liters = time * 0.5;
        return (int) liters;
        //return (int)(time/2);
    }

    public static string CountSheep(int n){
        var sheep = new StringBuilder();
        for (var i = 1; i < n + 1; i++){
            sheep.Append($"{i} sheep...");
        }

        return sheep.ToString();
    }

    public static IEnumerable<string> FriendOrFoe(string[] names){
        return names.Where(name => name.Length == 4);
    }

    public static bool SetAlarm(bool employed, bool vacation){
        return employed && !vacation;
    }

    public static bool Check(object[] a, object x){
        return a.Contains(x);

    }

    public static int Paperwork(int n, int m){
        return n <= 0 || m <= 0 ? 0 : m * n;
    }

    public static string BreakCamelCase(string str){

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

    public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems){
        //filter out strings from the list and return the integers
        return listOfItems.OfType<int>();

    }

    public static bool IsSquare(int n) => (Math.Sqrt(n) % 1 == 0);

    public static string Rps(string p1, string p2){
        //Rock paper scissors
        if (p1 == p2) return "Draw!";
        switch (p1){
            case "rock" when p2 == "scissors":
            case "scissors" when p2 == "paper":
            case "paper" when p2 == "rock":
                return "Player 1 won!";
            default:
                return "Player 2 won!";
        }
    }

    public static int SquareSum(int[] numbers){
        // Sum of squares
        return numbers.Sum(n => n * n);
    }

    public static int DuplicateCount(string str){
        // Count the number of duplicate characters in a string
        var duplicates = new HashSet<char>();
        var unique = new HashSet<char>();
        foreach (var c in str.ToLower()){
            if (!unique.Add(c)) duplicates.Add(c);
        }

        return duplicates.Count;
    }

    public static int FindLongestWithDistinctChars(string str){
        // Find the longest substring with distinct characters
        var longest = 0;
        for (var i = 0; i < str.Length; i++){
            var distinct = new HashSet<char>();
            for (var j = i; j < str.Length; j++){
                if (!distinct.Add(str[j])) break;
                longest = Math.Max(longest, distinct.Count);
            }
        }

        return longest;
    }

    public static List<string> Number(List<string> lines){
        // Number the lines
        for (var i = 0; i < lines.Count; i++) lines[i] = $"{i + 1}: {lines[i]}";
        return lines;
    }

    public static int GetUnique(IEnumerable<int> numbers){
        // Find the unique number
        return numbers.GroupBy(n => n).First(g => g.Count() == 1).Key;

    }

    public static string PigIt(string str){
        var pigLatin = new StringBuilder();
        foreach (var word in str.Split(' ')){
            if (word.Length == 1){
                pigLatin.Append($"{word} ");
                continue;
            }

            pigLatin.Append($"{word.Substring(1)}{word[0]}ay ");
        }

        return pigLatin.ToString().TrimEnd();
    }

    public static string WordCount(string str){

        // Count the number of words in a string
        return str.Split(' ').Length.ToString();
    }

    public static string NumberAddition(string str){

        // Add the numbers in a string even if they are separated by letters
        return Regex
            .Matches(str, @"\d+")
            .Sum(m => int.Parse(m.Value))
            .ToString();
    }

    public static int LargestPair(int num){

        var ints = num
            .ToString()
            .Select(c => int.Parse(c.ToString()))
            .ToList();
        var largestPair = 0;
        for (var i = 0; i < ints.Count - 1; i++){
            var paiOfInts = int.Parse($"{ints[i]}{ints[i + 1]}");
            if (paiOfInts > largestPair) largestPair = paiOfInts;
        }

        return largestPair;

    }

    public static bool ValidateSolution(int[][] board){
        //Sudoku validator
        if (board.Length != 9) return false;
        // check zero
        foreach (var row in board){
            if (row.Length != 9) return false;
            if (row.Any(i => i < 0 || i > 9)) return false;
        }

        // check rows
        foreach (var row in board){
            if (row.Distinct().Count() != 9) return false;
        }

        // check columns
        for (var i = 0; i < 9; i++){
            var column = new List<int>();
            for (var j = 0; j < 9; j++){
                column.Add(board[j][i]);
            }

            if (column.Distinct().Count() != 9) return false;
        }

        // check squares
        for (var i = 0; i < 9; i += 3){
            for (var j = 0; j < 9; j += 3){
                var square = new List<int>();
                for (var k = 0; k < 3; k++){
                    for (var l = 0; l < 3; l++){
                        square.Add(board[i + k][j + l]);
                    }
                }

                if (square.Distinct().Count() != 9) return false;
            }
        }

        return true;
    }

    public static string Maskify(string cc){
        // Maskify a string except the last 4 characters
        return cc.Length <= 4 ? cc : new string('#', cc.Length - 4) + cc.Substring(cc.Length - 4);
    }

    public static string Disemvowel(string str){
        // Remove all of the vowels from the string
        return new string(str.Where(c => !"aeiou".Contains(char.ToLower(c))).ToArray());

        /*return Regex.Replace(str,"[aeiou]", "", RegexOptions.IgnoreCase);*/
    }

    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable){
        //returns a list of items without any elements with the same value next to each other and preserving the original order of elements
        var unique = new List<T>();
        foreach (var item in iterable){
            if (unique.Count == 0 || !unique.Last()!.Equals(item)) unique.Add(item);
        }

        return unique;
    }

    public static long RowSumOddNumbers(long n){
        // sum of given row in triangle of consecutive odd numbers
        var sum = 0L;
        var start = n * (n - 1) + 1;
        for (var i = 0; i < n; i++){
            sum += start + 2 * i;
        }

        return sum;

        //return (long)Math.Pow(n, 3);
    }

    public static bool IsTriangle(int a, int b, int c){
        if (a <= 0 || b <= 0 || c <= 0) return false;
        return a + b > c && a + c > b && b + c > a;
    }

    public static int[] Arr(int N){
        /* the numbers 0 to N-1 */
        return Enumerable.Range(0, N).ToArray();
    }

    public static int Find(int[] integers){
        //Write a method that takes the array as an argument and returns this "outlier" N.(odd or even)
        var odd = integers.Where(i => i % 2 != 0).ToList();
        var even = integers.Where(i => i % 2 == 0).ToList();
        return odd.Count == 1 ? odd.First() : even.First();
    }

    public static int SumIntervals((int, int)[] intervals){
        // CODEWARS - accepts an array of intervals, and returns the sum of all the interval lengths. Overlapping intervals should only be counted once.
        var sum = 0;
        var intervalsList = intervals.ToList();
        for (var i = 0; i < intervalsList.Count; i++){
            var interval = intervalsList[i];
            for (var j = i + 1; j < intervalsList.Count; j++){
                var nextInterval = intervalsList[j];
                if (interval.Item1 <= nextInterval.Item1 && interval.Item2 >= nextInterval.Item1){
                    interval = (interval.Item1, nextInterval.Item2);
                    intervalsList.RemoveAt(j);
                    j--;
                }
            }

            sum += interval.Item2 - interval.Item1;
        }

        return sum;
    }

    public static string VowelCount(string str){

        // take the str string parameter being passed and return the number of vowels the string contains 
        return str.Count(c => "aeiou".Contains(char.ToLower(c))).ToString();

    }

    public static int ClosestEnemy(int[] arr){

        //take the array of numbers stored in arr and from the position in the array where a 1 is, return the number of spaces either left or right you must move to reach an enemy which is represented by a 2. For example: if arr is [0, 0, 1, 0, 0, 2, 0, 2] then your program should return 3 because the closest enemy (2) is 3 spaces away from the 1. The array will contain any number of 0's and 2's, but only a single 1. It may not contain any 2's at all as well, where in that case your program should return a 0.
        var index = Array.IndexOf(arr, 1);
        var left = index;
        var right = index;
        while (left >= 0 || right < arr.Length){
            left--;
            right++;
            if (left >= 0 && arr[left] == 2) return index - left;
            if (right < arr.Length && arr[right] == 2) return right - index;
        }

        return 0;



    }


    public static string EquivalentKeypresses(string[] strArr){

        //read the array of strings stored in strArr which will contain 2 strings representing two comma separated lists of keypresses. Your goal is to return the string true if the keypresses produce the same printable string and the string false if they do not. A keypress can be either a printable character or a backspace represented by -B. 
        var first = new List<char>();
        foreach (var key in strArr[0].Split(',')){
            if (key == "-B"){
                if (first.Count > 0) first.RemoveAt(first.Count - 1);
            }
            else{
                first.Add(key[0]);
            }
        }

        var second = new List<char>();
        foreach (var key in strArr[1].Split(',')){
            if (key == "-B"){
                if (second.Count > 0) second.RemoveAt(second.Count - 1);
            }
            else{
                second.Add(key[0]);
            }
        }

        if (first.Count != second.Count) return "false";
        if (first.Where((t, i) => t != second[i]).Any()){
            return "false";
        }

        return first.SequenceEqual(second) ? "true" : "false";

    }

    public static bool ValidParentheses(string input){
        // takes a string of parentheses, and determines if the order of the parentheses is valid where only ( and ) are valid parentheses and the brackets must close in the correct order.

        var stack = new Stack<char>();
        foreach (var c in input){
            if (c == '('){
                stack.Push(c);
            }
            else if (c == ')'){
                if (stack.Count == 0 || stack.Pop() != '(') return false;
            }
        }

        return stack.Count == 0;
    }

    public static bool ValidatePin(string pin){
        // takes a string and returns true if it's a valid pin or false if it's not. A valid pin has exactly 4 or 6 characters and only contains numerical characters (0-9).
        return pin.Length == 4 || pin.Length == 6 && pin.All(char.IsDigit);
    }

    public static bool IsIsogram(string str){
        // takes a string and returns true if it is an isogram and false if not. An isogram is a word that has no repeating letters, consecutive or non-consecutive.
        return str.ToLower().Distinct().Count() == str.Length;
    }

    public static string[] GetStrings(string city){
        // takes a city name and returns a string that shows how many times each letter shows up in the string by using an asterisk (*).
        return city.ToLower().GroupBy(c => c).Select(g => $"{g.Key}:{new string('*', g.Count())}").ToArray();
    }

    public static int[] SortArray(int[] array){
        // takes an array of integers and returns a new array with the same numbers but in the following order: odd numbers sorted in ascending order, even numbers sorted in descending order.
        var odd = array.Where(i => i % 2 != 0).OrderBy(i => i).ToList();
        var even = array.Where(i => i % 2 == 0).OrderByDescending(i => i).ToList();
        return array.Select(i => i % 2 != 0 ? odd.First() : even.First()).ToArray();
    }

    public static float FindAverage(IEnumerable<int> array){
        // takes an array containing integers and returns the average of the even numbers from the array. The array will never be empty and will only contain values that are greater than or equal to zero.
        return (float) array.Where(i => i % 2 == 0).Average();
    }

    public static int[] SortArrayByParity(int[] A){
        // takes an array of non-negative integers and returns an array consisting of all the even elements of the array, followed by all the odd elements of the array.
        return A.OrderBy(i => i % 2).ToArray();
    }

    public static string ReverseWordsAndRemoveVowels(string str){
        // takes a string and returns a new string with all the vowels removed and the words in reverse order.
        return string.Join(" ",
            str.Split(' ').Reverse()
                .Select(s => new string(s.Where(c => !"aeiou".Contains(char.ToLower(c))).ToArray())));
    }

    public static string CommonCharacterCount(string s1, string s2){
        // takes two strings and returns the number of common characters between the two strings.
        var count = 0;
        var s2List = s2.ToList();
        foreach (var c in s1.Where(c => s2List.Contains(c))){
            count++;
            s2List.Remove(c);
        }

        return count.ToString();
    }

    public static int[] ArrayReplace(IEnumerable<int> inputArray, int elemToReplace, int substitutionElem){
        // takes an array of integers and replaces all the occurrences of elemToReplace with substitutionElem.
        return inputArray.Select(i => i == elemToReplace ? substitutionElem : i).ToArray();
    }

    public static int EvenNumbersBeforeFixed(IEnumerable<int> sequence, int fixedElement){
        // takes an array of integers and returns the number of even integers that occur before the first occurrence of the number fixedElement in the array. If the sequence does not contain the number fixedElement, the function should return -1.
        var count = 0;
        foreach (var i in sequence){
            if (i == fixedElement) return count;
            if (i % 2 == 0) count++;
        }

        return -1;
    }

    public static IEnumerable<int> Range(int start, int count){
        // takes two integers start and count and returns an array containing count numbers from start to start + count - 1.
        return Enumerable.Range(start, count);
    }

    public static int[] AlternatingSums(int[] a){
        // takes an array of integers and returns an array of two integers, where the first element is the sum of all the even-indexed elements of the array, and the second element is the sum of all the odd-indexed elements of the array.
        return new[]{a.Where((i, index) => index % 2 == 0).Sum(), a.Where((i, index) => index % 2 != 0).Sum()};
    }

    public static int[] AddBorder(int[][] picture){
        // takes a rectangular matrix of characters and adds a border of asterisks(*) to it.
        var width = picture[0].Length + 2;
        var result = new List<string>{new string('*', width)};
        result.AddRange(picture.Select(row => "*" + string.Join("", row) + "*"));
        result.Add(new string('*', width));
        return result.Select(int.Parse).ToArray();
    }

    public static string[] AllLongestStrings(string[] inputArray){
        // takes an array of strings and returns another array containing all of its longest strings.
        var maxLength = inputArray.Max(s => s.Length);
        return inputArray.Where(s => s.Length == maxLength).ToArray();
    }


    public static int[] ExtractEachKth(IEnumerable<int> inputArray, int k){
        // takes an array of integers and removes each kth element from it.
        return inputArray.Where((i, index) => (index + 1) % k != 0).ToArray();
    }

    public static int[] FirstReverseTry(int[] arr){
        // takes an array of integers and returns the same array with the first and last elements of the array swapped.
        if (arr.Length == 0) return arr;
        (arr[0], arr[^1]) = (arr[^1], arr[0]);
        return arr;
    }

    public static string WordEnds(string str, string ending){
        // takes a string and an ending and returns the sum of the number of times the ending appears in the string and the number of times the ending appears in the reverse of the string.
        var count = 0;
        for (var i = 0; i < str.Length - ending.Length + 1; i++){
            if (str.Substring(i, ending.Length) != ending) continue;
            count++;
            i += ending.Length - 1;
        }

        return count.ToString();
    }

    public static int[] RemoveArrayPart(IEnumerable<int> inputArray, int l, int r){
        // takes an array of integers and removes each kth element from it.
        return inputArray.Where((i, index) => index < l || index > r).ToArray();
    }

    public static string TakeParanthesesOut(string str){
        // takes a string and returns a new string with all the parentheses removed.
        return new string(str.Where(c => c != '(' && c != ')').ToArray());
    }

    public static int[] ReplaceMiddle(int[] arr){
        // takes an array of integers and replaces the middle element(s) with the product of their neighbors.
        if (arr.Length % 2 != 0) return arr;
        var middle = arr.Length / 2;
        arr[middle - 1] *= arr[middle];
        return arr.Take(middle).Concat(arr.Skip(middle + 1)).ToArray();
    }

    public static string CountNumberOfGivenConsonants(string str){
        // takes a string and returns the number of consonants in the string.
        return str.Count(c => "bcdfghjklmnpqrstvwxyz".Contains(char.ToLower(c))).ToString();
    }

    public static Stack<int> ReverseStack(Stack<int> stack){
        // takes a stack of integers and returns the same stack with the integers in reversed order.
        var result = new Stack<int>();
        while (stack.Count > 0) result.Push(stack.Pop());
        return result;
    }

    public static int[] ReverseArray(int[] a){
        // takes an array of integers and returns the same array with the integers in reversed order.
        return a.Reverse().ToArray();
    }

    public static int[] ReverseArrayInPlace(int[] a){
        // takes an array of integers and returns the same array with the integers in reversed order.
        Array.Reverse(a);
        return a;
    }

    public static string MakeStringFromConsecutiveNumbers(int[] arr){
        // takes an array of integers and returns a string that represents the numbers in the array as a range.
        var result = new List<string>();
        var start = arr[0];
        var end = arr[0];
        for (var i = 1; i < arr.Length; i++){
            if (arr[i] == end + 1){
                end = arr[i];
                continue;
            }

            result.Add(start == end ? start.ToString() : $"{start}-{end}");
            start = arr[i];
            end = arr[i];
        }

        result.Add(start == end ? start.ToString() : $"{start}-{end}");
        return string.Join(",", result);
    }

    public static int[] RemoveSmallest(int[] arr){
        // takes an array of integers and returns the same array with the smallest integer removed.
        if (arr.Length == 0) return arr;
        var min = arr.Min();
        return arr.Where(i => i != min).ToArray();
    }

    public static Stack<int> RemoveSmallestFromStack(Stack<int> stack){
        // takes a stack of integers and returns the same stack with the smallest integer removed.
        var min = stack.Min();
        var result = new Stack<int>();
        while (stack.Count > 0){
            var i = stack.Pop();
            if (i != min) result.Push(i);
        }

        return result;
    }

    public static List<string> FindTheMirrorWords(string str){
        // takes a string and returns a list of all the mirror words in the string.
        var result = new List<string>();
        var words = str.Split(" ");
        for (var i = 0; i < words.Length - 1; i++){
            var word = words[i];
            var reversed = new string(word.Reverse().ToArray());
            if (words[i + 1] == reversed) result.Add($"{word} <=> {reversed}");
        }

        return result;
    }

    public static int[] SortByHeight(int[] a){
        // takes an array of integers and returns the same array with the trees in their original positions and the people in ascending order.
        var people = a.Where(i => i != -1).OrderBy(i => i).ToArray();
        var result = new List<int>();
        var j = 0;
        foreach (var i in a){
            if (i == -1) result.Add(-1);
            else{
                result.Add(people[j]);
                j++;
            }
        }

        return result.ToArray();
    }

    public static int[] SortByHeightInPlace(int[] a){
        // takes an array of integers and returns the same array with the trees in their original positions and the people in ascending order.
        var people = a.Where(i => i != -1).OrderBy(i => i).ToArray();
        var j = 0;
        for (var i = 0; i < a.Length; i++){
            if (a[i] == -1) continue;
            a[i] = people[j];
            j++;
        }

        return a;
    }

    public static string GameOfThrones(string str){
        // takes a string and returns "YES" if the string can be rearranged into a palindrome and "NO" if it cannot.
        var counts = new Dictionary<char, int>();
        foreach (var c in str){
            if (counts.ContainsKey(c)) counts[c]++;
            else counts[c] = 1;
        }

        return counts.Count(c => c.Value % 2 != 0) > 1 ? "NO" : "YES";
    }

    public static List<string> FindTheAnagrams(string str){
        // takes a string and returns a list of all the anagrams in the string.
        var result = new List<string>();
        var words = str.Split(" ");
        for (var i = 0; i < words.Length - 1; i++){
            var word = words[i];
            var sorted = new string(word.OrderBy(c => c).ToArray());
            for (var j = i + 1; j < words.Length; j++){
                var other = words[j];
                var otherSorted = new string(other.OrderBy(c => c).ToArray());
                if (sorted == otherSorted) result.Add($"{word} <=> {other}");
            }
        }

        return result;
    }

    public static List<string> RemoveOddLengthStrings(List<string> list){
        // takes a list of strings and returns the same list with all the strings of odd length removed.
        return list.Where(s => s.Length % 2 == 0).ToList();
    }

    public static List<int> AddTwoLists(List<int> list1, List<int> list2){
        // takes two lists of integers and returns a list of integers where each integer is the sum of the integers at the same index in the two lists.
        var result = new List<int>();
        var max = Math.Max(list1.Count, list2.Count);
        for (var i = 0; i < max; i++){
            var a = i < list1.Count ? list1[i] : 0;
            var b = i < list2.Count ? list2[i] : 0;
            result.Add(a + b);
        }

        return result;
    }

    public static List<double> AverageOfEachRow(IEnumerable<List<int>> list){
        // takes a list of lists of integers and returns a list of floats where each float is the average of the integers in the list at the same index.
        return list.Select(l => l.Average()).ToList();
    }

    public static ArrayList RemoveOddLengthStrings(ArrayList list){
        // takes an ArrayList of strings and returns the same ArrayList with all the strings of odd length removed.
        var result = new ArrayList();
        foreach (var s in list){
            if (s.ToString()!.Length % 2 == 0) result.Add(s);
        }

        return result;
    }

    public static int UniqueSum(int a, int b, int c){
        // takes three integers and returns the sum of the integers. If two values are the same, they do not count towards the sum.
        var result = 0;
        if (a != b && a != c) result += a;
        if (b != a && b != c) result += b;
        if (c != a && c != b) result += c;
        return result;
    }

    public static int MatrixSum(int[,] matrix){
        // takes a 2D array of integers and returns the sum of all the integers in the array.
        var result = 0;
        for (var i = 0; i < matrix.GetLength(0); i++){
            for (var j = 0; j < matrix.GetLength(1); j++){
                result += matrix[i, j];
            }
        }

        return result;
    }

    public static int[] Matrix2DTo1D(int[,] matrix){
        // takes a 2D array of integers and returns a 1D array of integers where each integer is the sum of the integers in the row of the 2D array.
        var result = new List<int>();
        for (var i = 0; i < matrix.GetLength(0); i++){
            var sum = 0;
            for (var j = 0; j < matrix.GetLength(1); j++){
                sum += matrix[i, j];
            }

            result.Add(sum);
        }

        return result.ToArray();
    }

    public static int[] SnailSort(int[][] array){
        // Given an n x n array, return the array elements arranged from outermost elements to the middle element, traveling clockwise.
        int n = array.Length;
        var result = new int[n * n];
        int index = 0;

        // Initialize boundaries for traversal
        int top = 0;
        int bottom = n - 1;
        int left = 0;
        int right = n - 1;

        while (top <= bottom && left <= right){
            // Traverse top row from left to right
            for (int i = left; i <= right; i++){
                result[index++] = array[top][i];
            }

            top++;

            // Traverse right column from top to bottom
            for (int i = top; i <= bottom; i++){
                result[index++] = array[i][right];
            }

            right--;

            // Traverse bottom row from right to left (if top <= bottom)
            if (top <= bottom){
                for (int i = right; i >= left; i--){
                    result[index++] = array[bottom][i];
                }

                bottom--;
            }

            // Traverse left column from bottom to top (if left <= right)
            if (left <= right){
                for (int i = bottom; i >= top; i--){
                    result[index++] = array[i][left];
                }

                left++;
            }
        }

        return result;
    }

    public static string[] FastestWayToFindAnagrams(string str){
        // takes a string and returns an array of strings where each string is an anagram of the original string.
        var words = str.Split(" ");

        return (from word in words
            let sorted = new string(word.OrderBy(c => c).ToArray())
            from other in words
            where word != other
            let otherSorted = new string(other.OrderBy(c => c).ToArray())
            where sorted == otherSorted
            select $"{word} <=> {other}").ToArray();
    }

    public static int[] FindTheMissingNumbers(int[] array){
        // takes an array of integers and returns an array of integers where each integer is a number that is missing from the original array.
        var result = new List<int>();
        var max = array.Max();
        for (var i = 1; i <= max; i++){
            if (!array.Contains(i)) result.Add(i);
        }

        return result.ToArray();
    }

    public static int BreadthFirstSearch(int[,] graph, int start, int end){
        // takes a graph and two integers and returns the shortest path between the two integers.
        var queue = new Queue<int>();
        var visited = new HashSet<int>();
        var distances = new Dictionary<int, int>();
        queue.Enqueue(start);
        visited.Add(start);
        distances[start] = 0;
        while (queue.Count > 0){
            var current = queue.Dequeue();
            if (current == end) return distances[current];
            for (var i = 0; i < graph.GetLength(0); i++){
                if (graph[current, i] == 1 && !visited.Contains(i)){
                    queue.Enqueue(i);
                    visited.Add(i);
                    distances[i] = distances[current] + 1;
                }
            }
        }

        return -1;
    }

    public static string FindTheThreeLongestWords(string str){
        // takes a string and returns the three longest words in the string.
        var words = str.Split(" ");
        var result = new List<string>();
        for (var i = 0; i < 3; i++){
            var longest = words.OrderByDescending(w => w.Length).First();
            result.Add(longest);
            words = words.Where(w => w != longest).ToArray();
        }

        return string.Join(" ", result);
    }

    public static IEnumerable<int> ShiftArray(int[] array, int shift){
        // takes an array of integers and an integer and returns an array of integers where each integer is the original integer shifted by the integer.
        return array.Select(i => i + shift);
    }

    public static IEnumerable<int> SubArray(int[] array, int start, int end){
        // takes an array of integers and two integers and returns an array of integers where each integer is an integer from the original array between the two integers.
        return array.Skip(start).Take(end - start + 1);
    }

    public static IEnumerable<string> FindTheLongestWords(string str){
        // takes a string and returns an array of strings where each string is a word from the original string that is the longest word in the original string.
        var words = str.Split(" ");
        var longest = words.OrderByDescending(w => w.Length).First();
        return words.Where(w => w.Length == longest.Length);
    }

    public static float PieNumberCalculation(int n){
        // takes an integer and returns the value of pi using the Gregory-Leibniz series.
        var result = 0f;
        for (var i = 0; i < n; i++){
            result += (float) Math.Pow(-1, i) / (2 * i + 1);
        }

        return result * 4;
    }

    public static float DimensionalCalculation(int n){
        // takes an integer and returns the value of pi using the Nilakantha series.
        var result = 3f;
        for (var i = 0; i < n; i++){
            result += (float) Math.Pow(-1, i) * 4 / (2 * i + 2) / (2 * i + 3) / (2 * i + 4);
        }

        return result;
    }

    public static float IntegralCalculation(int n){
        // takes an integer and returns the value of pi using the Ramanujan series.
        var result = 0f;
        for (var i = 0; i < n; i++){
            result += (float) (Math.Pow(4, i) * Math.Pow(1103 + 26390 * i, 1 / 4f) /
                               (Math.Pow(99, 4 * i) * Math.Pow(396, i)));
        }

        return 1 / result;
    }

    public static string EmailValidation(string email){
        // takes an email address and returns a string that indicates whether the email address is valid or invalid.
        var regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        return regex.IsMatch(email) ? "Valid" : "Invalid";
    }

    public static string PhoneValidation(string phone){
        // takes a phone number and returns a string that indicates whether the phone number is valid or invalid.
        var regex = new Regex(@"^(\d{3})\D*(\d{3})\D*(\d{4})\D*(\d*)$");
        return regex.IsMatch(phone) ? "Valid" : "Invalid";
    }

    public static int Febonacci(int n){
        // takes an integer and returns the nth number in the Fibonacci sequence.
        if (n == 0) return 0;
        if (n == 1) return 1;
        return Febonacci(n - 1) + Febonacci(n - 2);
    }

    public static int Factorial(int n){
        // takes an integer and returns the factorial of the integer.
        if (n == 0) return 1;
        return n * Factorial(n - 1);
    }

    public static int SumOfDigits(int n){
        // takes an integer and returns the sum of the digits of the integer.
        if (n == 0) return 0;
        return n % 10 + SumOfDigits(n / 10);
    }

    public static int SumOfDigitsOfFactorial(int n){
        // takes an integer and returns the sum of the digits of the factorial of the integer.
        return SumOfDigits(Factorial(n));
    }

    public static int SumOfDigitsOfFebonacci(int n){
        // takes an integer and returns the sum of the digits of the nth number in the Fibonacci sequence.
        return SumOfDigits(Febonacci(n));
    }

    public static int SumOfDigitsOfFebonacciFactorial(int n){
        // takes an integer and returns the sum of the digits of the factorial of the nth number in the Fibonacci sequence.
        return SumOfDigits(Factorial(Febonacci(n)));
    }

    public static int CreateCardNumber(int n){
        // takes an integer and returns a credit card number with the integer as the last four digits.
        var random = new Random();
        var result = "";
        for (var i = 0; i < 15; i++){
            result += random.Next(0, 9);
        }

        result += n;
        return int.Parse(result);
    }

    public static int CreateCardNumberWithLuhn(int n){
        // takes an integer and returns a credit card number with the integer as the last four digits and the credit card number passes the Luhn test.
        var random = new Random();
        var result = "";
        for (var i = 0; i < 15; i++){
            result += random.Next(0, 9);
        }

        result += n;
        var sum = 0;
        for (var i = 0; i < result.Length; i++){
            var digit = int.Parse(result[i].ToString());
            if (i % 2 == 0){
                digit *= 2;
                if (digit > 9) digit -= 9;
            }

            sum += digit;
        }

        var checkDigit = (10 - sum % 10) % 10;
        return int.Parse(result + checkDigit);
    }

    public static int CreateCardNumberWithLuhnAndPrefix(int n, int prefix){
        // takes an integer and a prefix and returns a credit card number with the integer as the last four digits, the credit card number passes the Luhn test, and the credit card number starts with the prefix.
        var random = new Random();
        var result = prefix.ToString();
        for (var i = 0; i < 15 - prefix.ToString().Length; i++){
            result += random.Next(0, 9);
        }

        result += n;
        var sum = 0;
        for (var i = 0; i < result.Length; i++){
            var digit = int.Parse(result[i].ToString());
            if (i % 2 == 0){
                digit *= 2;
                if (digit > 9) digit -= 9;
            }

            sum += digit;
        }

        var checkDigit = (10 - sum % 10) % 10;
        return int.Parse(result + checkDigit);
    }

    public static int CreateCardNumberWithLuhnAndPrefixAndLength(int n, int prefix, int length){
        // takes an integer, a prefix, and a length and returns a credit card number with the integer as the last four digits, the credit card number passes the Luhn test, the credit card number starts with the prefix, and the credit card number has the length.
        var random = new Random();
        var result = prefix.ToString();
        for (var i = 0; i < length - prefix.ToString().Length - 1; i++){
            result += random.Next(0, 9);
        }

        result += n;
        var sum = 0;
        for (var i = 0; i < result.Length; i++){
            var digit = int.Parse(result[i].ToString());
            if (i % 2 == 0){
                digit *= 2;
                if (digit > 9) digit -= 9;
            }

            sum += digit;
        }

        var checkDigit = (10 - sum % 10) % 10;
        return int.Parse(result + checkDigit);
    }

    public static int CreateCardNumberWithLuhnAndPrefixAndLengthAndCount(int n, int prefix, int length, int count){
        // takes an integer, a prefix, a length, and a count and returns a credit card number with the integer as the last four digits, the credit card number passes the Luhn test, the credit card number starts with the prefix, the credit card number has the length, and the credit card number has the count.
        var random = new Random();
        var result = prefix.ToString();
        for (var i = 0; i < length - prefix.ToString().Length - 1 - count.ToString().Length; i++){
            result += random.Next(0, 9);
        }

        result += count + n;
        var sum = 0;
        for (var i = 0; i < result.Length; i++){
            var digit = int.Parse(result[i].ToString());
            if (i % 2 == 0){
                digit *= 2;
                if (digit > 9) digit -= 9;
            }

            sum += digit;
        }

        var checkDigit = (10 - sum % 10) % 10;
        return int.Parse(result + checkDigit);
    }

    public static string TicTacToe(){
        // returns a string that represents a random tic-tac-toe board.
        var random = new Random();
        var result = "";
        for (var i = 0; i < 9; i++){
            var number = random.Next(0, 3);
            if (number == 0) result += "X";
            else if (number == 1) result += "O";
            else result += " ";
        }

        return result;
    }

    public static string TicTacToeWithWinner(){
        // returns a string that represents a random tic-tac-toe board with a winner.
        var random = new Random();
        var result = "";
        for (var i = 0; i < 9; i++){
            var number = random.Next(0, 3);
            result += number switch{
                0 => "X",
                1 => "O",
                _ => " "
            };
        }

        var winner = random.Next(0, 2);
        if (winner == 0){
            var number = random.Next(0, 3);
            result = number switch{
                0 => string.Concat("XXX", result.AsSpan(3)),
                1 => string.Concat(result.AsSpan(0, 3), "XXX", result.AsSpan(6)),
                _ => string.Concat(result.AsSpan(0, 6), "XXX")
            };
        }
        else{
            var number = random.Next(0, 3);
            result = number switch{
                0 => string.Concat("OOO", result.AsSpan(3)),
                1 => string.Concat(result.AsSpan(0, 3), "OOO", result.AsSpan(6)),
                _ => string.Concat(result.AsSpan(0, 6), "OOO")
            };
        }

        return result;
    }

    public static string PokerHand(){
        // returns a string that represents a random poker hand.
        var random = new Random();
        var result = "";
        for (var i = 0; i < 5; i++){
            var number = random.Next(0, 13);
            result += number switch{
                0 => "A",
                1 => "2",
                2 => "3",
                3 => "4",
                4 => "5",
                5 => "6",
                6 => "7",
                7 => "8",
                8 => "9",
                9 => "10",
                10 => "J",
                11 => "Q",
                12 => "K",
                _ => ""
            };

            number = random.Next(0, 4);
            result += number switch{
                0 => "♠",
                1 => "♥",
                2 => "♦",
                3 => "♣",
                _ => ""
            };
        }

        return result;
    }

    public static int[] ArrayOfMultiples(int number, int length){
        // takes a number and a length and returns an array of multiples of the number up to the specified length.
        var result = new int[length];
        for (var i = 0; i < length; i++){
            result[i] = number * (i + 1);
        }

        return result;
    }

    public static string[] ArticleMaker(){
        // returns an array of strings that represents a random article.
        var random = new Random();
        var result = new string[3];
        var number = random.Next(0, 3);
        result[0] = number switch{
            0 => "a",
            1 => "an",
            _ => "the"
        };

        number = random.Next(0, 3);
        result[1] = number switch{
            0 => "big",
            1 => "small",
            _ => "medium"
        };

        number = random.Next(0, 3);
        result[2] = number switch{
            0 => "dog",
            1 => "cat",
            _ => "mouse"
        };

        return result;
    }

    public static string[] StringManipulator(string[] array){
        // takes an array of strings and returns an array of strings with the first and last letters of each string swapped.
        var result = new string[array.Length];
        for (var i = 0; i < array.Length; i++){
            var first = array[i][0];
            var last = array[i][array[i].Length - 1];
            result[i] = last + array[i].Substring(1, array[i].Length - 2) + first;
        }

        return result;
    }

    public static string[] TranslateToPigLatin(string[] array){
        // takes an array of strings and returns an array of strings with each string translated to pig latin.
        var result = new string[array.Length];
        for (var i = 0; i < array.Length; i++){
            var first = array[i][0];
            var last = array[i][array[i].Length - 1];
            result[i] = last + array[i].Substring(1, array[i].Length - 2) + first + "ay";
        }

        return result;
    }

    public static string[] PossibleTextCombinations(string[] array){
        // takes an array of strings and returns an array of strings with all possible combinations of the strings in the array.
        var result = new string[(int) Math.Pow(2, array.Length)];
        for (var i = 0; i < result.Length; i++){
            var number = i;
            var index = 0;
            while (number > 0){
                if (number % 2 == 1){
                    result[i] += array[index];
                }

                number /= 2;
                index++;
            }
        }

        return result;
    }

    public static float[] CalculateAverage(int[][] array){
        // takes a 2D array of integers and returns an array of floats with the average of each row.
        var result = new float[array.Length];
        for (var i = 0; i < array.Length; i++){
            var sum = 0;
            for (var j = 0; j < array[i].Length; j++){
                sum += array[i][j];
            }

            result[i] = (float) sum / array[i].Length;
        }

        return result;
    }

    public static int[][] SwapTwoRows(int[][] array){
        // takes a 2D array of integers and returns a 2D array of integers with the first and last rows swapped.
        var result = new int[array.Length][];
        for (var i = 0; i < array.Length; i++){
            result[i] = new int[array[i].Length];
            for (var j = 0; j < array[i].Length; j++){
                result[i][j] = array[i][j];
            }
        }

        (result[0], result[^1]) = (result[^1], result[0]);

        return result;
    }

    public static Stack<string> StackOfPossibilities(string[] array){
        // takes an array of strings and returns a stack of strings with all possible combinations of the strings in the array.
        var result = new Stack<string>();
        for (var i = 0; i < (int) Math.Pow(2, array.Length); i++){
            var number = i;
            var index = 0;
            var temp = "";
            while (number > 0){
                if (number % 2 == 1){
                    temp += array[index];
                }

                number /= 2;
                index++;
            }

            result.Push(temp);
        }

        return result;
    }

    public static Queue<string> QueueOfPossibilities(string[] array){
        // takes an array of strings and returns a queue of strings with all possible combinations of the strings in the array.
        var result = new Queue<string>();
        for (var i = 0; i < (int) Math.Pow(2, array.Length); i++){
            var number = i;
            var index = 0;
            var temp = "";
            while (number > 0){
                if (number % 2 == 1){
                    temp += array[index];
                }

                number /= 2;
                index++;
            }

            result.Enqueue(temp);
        }

        return result;
    }

    public static Dictionary<string, int> DictionaryOfMultiples(int number, int length){
        // takes a number and a length and returns a dictionary of multiples of the number up to the specified length.
        var result = new Dictionary<string, int>();
        for (var i = 0; i < length; i++){
            result.Add((i + 1).ToString(), number * (i + 1));
        }

        return result;
    }

    public static float[] HecksMethod(int[][] array){
        // takes a 2D array of integers and returns an array of floats with the average of each row.
        var result = new float[array.Length];
        for (var i = 0; i < array.Length; i++){
            var sum = 0;
            for (var j = 0; j < array[i].Length; j++){
                sum += array[i][j];
            }

            result[i] = (float) sum / array[i].Length;
        }

        return result;
    }

    public static string GuessTheNumber(int number){
        // takes a number and returns a string that represents the number guessed by the computer.
        var random = new Random();
        var result = "";
        var guess = random.Next(0, 100);
        while (guess != number){
            result += guess + ", ";
            guess = random.Next(0, 100);
        }

        result += guess;

        return result;
    }

    public static string[] SwapTWithD(string[] array){
        // takes an array of strings and returns an array of strings with all instances of the letter t swapped with the letter d.
        var result = new string[array.Length];
        for (var i = 0; i < array.Length; i++){
            result[i] = array[i].Replace('t', 'd');
        }

        return result;
    }

    public static string[] SwapNumbersWithWords(string[] array){
        // takes an array of strings and returns an array of strings with all instances of numbers swapped with the corresponding word.
        var result = new string[array.Length];
        for (var i = 0; i < array.Length; i++){
            result[i] = array[i].Replace('0', 'o').Replace('1', 'i').Replace('2', 't').Replace('3', 'e')
                .Replace('4', 'a').Replace('5', 's').Replace('6', 'g').Replace('7', 't').Replace('8', 'b')
                .Replace('9', 'g');
        }

        return result;
    }

    public static int PasswordStrength(string password){
        // takes a string and returns an integer that represents the strength of the password.
        var result = 0;
        if (password.Length >= 8){
            result++;
        }

        if (password.Any(char.IsUpper)){
            result++;
        }

        if (password.Any(char.IsLower)){
            result++;
        }

        if (password.Any(char.IsDigit)){
            result++;
        }

        if (password.Any(char.IsSymbol)){
            result++;
        }

        return result;
    }

    public static int DataBank(string[] array){
        // takes an array of strings and returns an integer that represents the number of times the string "data" appears in the array.

        return array.Count(t => t.Contains("data"));
    }

    public static List<int> TelephoneNumbers(string[] array){
        // takes an array of strings and returns a list of integers that represents the telephone numbers in the array.

        return (from t in array
            select t.Where(char.IsDigit).Aggregate("", (current, c)
                => current + c)
            into temp
            where temp.Length == 10
            select int.Parse(temp)).ToList();
    }

    public static ArrayList[] SortByColumn(int[][] array, int column){
        // takes a 2D array of integers and a column number and returns an array of array lists with the rows sorted by the specified column.
        var result = new ArrayList[array.Length];
        for (var i = 0; i < array.Length; i++){
            result[i] = new ArrayList();
            for (var j = 0; j < array[i].Length; j++){
                result[i].Add(array[i][j]);
            }
        }

        Array.Sort(result, (a, b) => (int) a[column] - (int) b[column]);

        return result;
    }

    public static ArrayList[] Shuffle(int[][] array){
        // takes a 2D array of integers and returns an array of array lists with the rows shuffled.
        var result = new ArrayList[array.Length];
        for (var i = 0; i < array.Length; i++){
            result[i] = new ArrayList();
            for (var j = 0; j < array[i].Length; j++){
                result[i].Add(array[i][j]);
            }
        }

        var random = new Random();
        for (var i = 0; i < result.Length; i++){
            var index = random.Next(0, result.Length);
            (result[i], result[index]) = (result[index], result[i]);
        }

        return result;
    }

    public static int BreakTheCode(string code){
        // takes a string and returns an integer that represents the number of times the string "code" appears in the string.
        var result = 0;
        for (var i = 0; i < code.Length - 3; i++){
            if (code.Substring(i, 4) == "code"){
                result++;
            }
        }

        return result;
    }

    public static int CustomIndexOf(string[] array, string value){
        // takes an array of strings and a string and returns an integer that represents the index of the string in the array.
        for (var i = 0; i < array.Length; i++){
            if (array[i] == value){
                return i;
            }
        }

        return -1;
    }

    public static int[] CustomIndexOfAll(string[] array, string value){
        // takes an array of strings and a string and returns an array of integers that represents the indexes of the string in the array.
        var result = new List<int>();
        for (var i = 0; i < array.Length; i++){
            if (array[i] == value){
                result.Add(i);
            }
        }

        return result.ToArray();
    }

    public static float OctalToDecimal(string octal){
        // takes a string and returns a float that represents the decimal value of the octal number.

        return octal.Select((t, i) => (float) char.GetNumericValue(t) * (float) Math.Pow(8, octal.Length - i - 1))
            .Sum();
    }

    public static string DecimalToOctal(float number){
        // takes a float and returns a string that represents the octal value of the decimal number.
        var result = "";
        while (number > 0){
            result = (number % 8) + result;
            number /= 8;
        }

        return result;
    }

    public static string[] CustomSplit(string text, char separator){
        // takes a string and a character and returns an array of strings that represents the string split by the character.
        var result = new List<string>();
        var temp = "";
        foreach (var t in text){
            if (t == separator){
                result.Add(temp);
                temp = "";
            }
            else{
                temp += t;
            }
        }

        result.Add(temp);

        return result.ToArray();
    }

    public static char[][] DrawTriangle(int size){
        // takes an integer and returns a 2D array of characters that represents a triangle with the specified size.
        var result = new char[size][];
        for (var i = 0; i < size; i++){
            result[i] = new char[i + 1];
            for (var j = 0; j < i + 1; j++){
                result[i][j] = '*';
            }
        }

        return result;
    }

    public static char[][] DrawSquare(int size){
        // takes an integer and returns a 2D array of characters that represents a square with the specified size.
        var result = new char[size][];
        for (var i = 0; i < size; i++){
            result[i] = new char[size];
            for (var j = 0; j < size; j++){
                result[i][j] = '*';
            }
        }

        return result;
    }

    public static int[] BinaryTreeBottom(int[] array){
        // takes an array of integers and returns an array of integers that represents the bottom row of a binary tree with the specified values.

        return array.Where((t, i) => i * 2 + 1 >= array.Length).ToArray();
    }

    public static int[] BinaryTreeTop(int[] array){
        // takes an array of integers and returns an array of integers that represents the top row of a binary tree with the specified values.

        return array.Where((t, i) => i == 0 || i % 2 == 0).ToArray();
    }

    public static int[] BinaryTreeLeft(int[] array){
        // takes an array of integers and returns an array of integers that represents the left column of a binary tree with the specified values.

        return array.Where((t, i) => i % 2 == 0).ToArray();
    }

    public static int[] BinaryTreeRight(int[] array){
        // takes an array of integers and returns an array of integers that represents the right column of a binary tree with the specified values.

        return array.Where((t, i) => i % 2 == 1).ToArray();
    }

    public static int[] BinaryTreeLeftDiagonal(int[] array){
        // takes an array of integers and returns an array of integers that represents the left diagonal of a binary tree with the specified values.

        return array.Where((t, i) => i % 2 == 0 && i * 2 + 1 < array.Length).ToArray();
    }

    public static int[] BinaryTreeRightDiagonal(int[] array){
        // takes an array of integers and returns an array of integers that represents the right diagonal of a binary tree with the specified values.

        return array.Where((t, i) => i % 2 == 1 && i * 2 + 2 < array.Length).ToArray();
    }

    public static int[] BinaryTreeDiagonal(int[] array){
        // takes an array of integers and returns an array of integers that represents the diagonal of a binary tree with the specified values.

        return array.Where((t, i) => i * 2 + 1 < array.Length).ToArray();
    }

    public static int[] BinaryTreeOptimal(int[] array){
        // takes an array of integers and returns an array of integers that represents the optimal path of a binary tree with the specified values.

        var result = new List<int>();
        var index = 0;
        while (index < array.Length){
            result.Add(array[index]);
            index = array[index * 2 + 1] > array[index * 2 + 2] ? index * 2 + 1 : index * 2 + 2;
        }

        return result.ToArray();
    }

    public static int SumOfEven(int[] array){
        // takes an array of integers and returns an integer that represents the sum of all the even numbers in the array.
        return array.Where(t => t % 2 == 0).Sum();
    }

    public static bool IsPalindrome(string text){
        // takes a string and returns a boolean that represents whether the string is a palindrome or not.
        return text == new string(text.Reverse().ToArray());
    }

    public static int LargestMultipleOfThree(int[] nums){
        // takes an array of integers and returns an integer that represents the largest multiple of three that can be made from the array.
        var largestProduct = 0;

        // Sort the array in descending order
        Array.Sort(nums);
        Array.Reverse(nums);

        // Check the largest product of the first three numbers and the largest and smallest numbers with the second largest number
        largestProduct = Math.Max(nums[0] * nums[1] * nums[2], nums[0] * nums[^1] * nums[^2]);

        return largestProduct;
    }

    //Write a function that takes a string as input and returns the number of words in the string.

    public static int CountWords(string text){
        return text.Split(' ').Length;
    }

    //Given a list of integers, write a function that returns the second largest number in the list.

    public static int SecondLargest(int[] array){
        return array.OrderByDescending(t => t).Skip(1).First();
    }

    public static int LongestConsecutiveSequence(int[] array){
        // takes an array of integers and returns an integer that represents the length of the longest consecutive sequence in the array.
        var result = 0;
        var temp = 0;
        var sorted = array.OrderBy(t => t).ToArray();
        for (var i = 0; i < sorted.Length; i++){
            if (i == 0 || sorted[i] == sorted[i - 1] + 1){
                temp++;
            }
            else{
                temp = 1;
            }

            result = Math.Max(result, temp);
        }

        return result;
    }

    public static int[] LongestConsecutiveSequenceArray(int[] array){
        // takes an array of integers and returns an array of integers that represents the longest consecutive sequence in the array.
        var result = new List<int>();
        var temp = new List<int>();
        var sorted = array.OrderBy(t => t).ToArray();
        for (var i = 0; i < sorted.Length; i++){
            if (i == 0 || sorted[i] == sorted[i - 1] + 1){
                temp.Add(sorted[i]);
            }
            else{
                if (temp.Count > result.Count){
                    result = temp;
                }

                temp = new List<int>{sorted[i]};
            }
        }

        if (temp.Count > result.Count){
            result = temp;
        }

        return result.ToArray();
    }

    public static int[] ShortestConsecutiveSequenceArray(int[] array){
        // takes an array of integers and returns an array of integers that represents the shortest consecutive sequence in the array.
        var result = new List<int>();
        var temp = new List<int>();
        var sorted = array.OrderBy(t => t).ToArray();
        for (var i = 0; i < sorted.Length; i++){
            if (i == 0 || sorted[i] == sorted[i - 1] + 1){
                temp.Add(sorted[i]);
            }
            else{
                if (temp.Count < result.Count || result.Count == 0){
                    result = temp;
                }

                temp = new List<int>{sorted[i]};
            }
        }

        if (temp.Count < result.Count || result.Count == 0){
            result = temp;
        }

        return result.ToArray();
    }

    public static int[][] GroupByConsecutive(int[] array){
        // takes an array of integers and returns an array of arrays of integers that represents the consecutive sequences in the array.
        var result = new List<List<int>>();
        var temp = new List<int>();
        var sorted = array.OrderBy(t => t).ToArray();
        for (var i = 0; i < sorted.Length; i++){
            if (i == 0 || sorted[i] == sorted[i - 1] + 1){
                temp.Add(sorted[i]);
            }
            else{
                result.Add(temp);
                temp = new List<int>{sorted[i]};
            }
        }

        result.Add(temp);

        return result.Select(t => t.ToArray()).ToArray();
    }

    public static string[][] CreateAnagramGroups(string[] array){
        // takes an array of strings and returns an array of arrays of strings that represents the anagram groups in the array.
        var result = new List<List<string>>();
        var temp = new List<string>();
        var sorted = array.OrderBy(t => t).ToArray();
        for (var i = 0; i < sorted.Length; i++){
            if (i == 0 || new string(sorted[i].OrderBy(t => t).ToArray()) ==
                new string(sorted[i - 1].OrderBy(t => t).ToArray())){
                temp.Add(sorted[i]);
            }
            else{
                result.Add(temp);
                temp = new List<string>{sorted[i]};
            }
        }

        result.Add(temp);

        return result.Select(t => t.ToArray()).ToArray();
    }

    public static string[][] BuildPyramid(string[] array){
        // takes an array of strings and returns an array of arrays of strings that represents the pyramid of the array.
        var result = new List<List<string>>();
        var temp = new List<string>();
        var sorted = array.OrderBy(t => t).ToArray();
        for (var i = 0; i < sorted.Length; i++){
            if (i == 0 || new string(sorted[i].OrderBy(t => t).ToArray()) ==
                new string(sorted[i - 1].OrderBy(t => t).ToArray())){
                temp.Add(sorted[i]);
            }
            else{
                result.Add(temp);
                temp = new List<string>{sorted[i]};
            }
        }

        result.Add(temp);

        return result.Select(t => t.ToArray()).ToArray();
    }

    public static string AlgorithmicCrush(int n, int[][] queries){
        // takes an integer n and an array of arrays of integers and returns a string that represents the maximum value in the resulting array.
        var result = new long[n];
        var max = 0L;
        foreach (var query in queries){
            var a = query[0] - 1;
            var b = query[1] - 1;
            var k = query[2];
            result[a] += k;
            if (b + 1 < n){
                result[b + 1] -= k;
            }
        }

        var temp = 0L;
        for (var i = 0; i < n; i++){
            temp += result[i];
            max = Math.Max(max, temp);
        }

        return max.ToString();
    }

    public static int[] ArrayManipulation(int n, int[][] queries){
        // takes an integer n and an array of arrays of integers and returns an array of integers that represents the resulting array.
        var result = new long[n];
        var max = 0L;
        foreach (var query in queries){
            var a = query[0] - 1;
            var b = query[1] - 1;
            var k = query[2];
            result[a] += k;
            if (b + 1 < n){
                result[b + 1] -= k;
            }
        }

        var temp = 0L;
        for (var i = 0; i < n; i++){
            temp += result[i];
            max = Math.Max(max, temp);
        }

        return new[]{(int) max};
    }

    public static float[][] DistanceMatrix(float[][] array){
        // takes an array of arrays of floats and returns an array of arrays of floats that represents the distance matrix of the array.
        var result = new float[array.Length][];
        for (var i = 0; i < array.Length; i++){
            result[i] = new float[array.Length];
            for (var j = 0; j < array.Length; j++){
                result[i][j] =
                    (float) Math.Sqrt(Math.Pow(array[i][0] - array[j][0], 2) + Math.Pow(array[i][1] - array[j][1], 2));
            }
        }

        return result;
    }

    public static float[] GravityCenter(float[][] array){
        // takes an array of arrays of floats and returns an array of floats that represents the gravity center of the array.
        var result = new float[2];
        for (var i = 0; i < array.Length; i++){
            result[0] += array[i][0];
            result[1] += array[i][1];
        }

        result[0] /= array.Length;
        result[1] /= array.Length;

        return result;
    }

    public static float[] ClosestPair(float[][] array){
        // takes an array of arrays of floats and returns an array of floats that represents the closest pair of the array.
        var result = new float[4];
        var min = float.MaxValue;
        for (var i = 0; i < array.Length; i++){
            for (var j = i + 1; j < array.Length; j++){
                var distance =
                    (float) Math.Sqrt(Math.Pow(array[i][0] - array[j][0], 2) + Math.Pow(array[i][1] - array[j][1], 2));
                if (distance < min){
                    min = distance;
                    result[0] = array[i][0];
                    result[1] = array[i][1];
                    result[2] = array[j][0];
                    result[3] = array[j][1];
                }
            }
        }

        return result;
    }

    public static float[] FarthestPair(float[][] array){
        // takes an array of arrays of floats and returns an array of floats that represents the farthest pair of the array.
        var result = new float[4];
        var max = float.MinValue;
        for (var i = 0; i < array.Length; i++){
            for (var j = i + 1; j < array.Length; j++){
                var distance =
                    (float) Math.Sqrt(Math.Pow(array[i][0] - array[j][0], 2) + Math.Pow(array[i][1] - array[j][1], 2));
                if (distance > max){
                    max = distance;
                    result[0] = array[i][0];
                    result[1] = array[i][1];
                    result[2] = array[j][0];
                    result[3] = array[j][1];
                }
            }
        }

        return result;
    }

    public static string PyramidOfNumbers(int n){
        // takes an integer n and returns a string that represents the pyramid of numbers of n.
        var result = new StringBuilder();
        for (var i = 1; i <= n; i++){
            for (var j = 1; j <= i; j++){
                result.Append(j);
            }

            result.AppendLine();
        }

        return result.ToString();
    }

    public static string EmainMaelc(int n){
        // takes an integer n and returns a string that represents the emain maelc of n.
        var result = new StringBuilder();
        for (var i = 1; i <= n; i++){
            for (var j = 1; j <= i; j++){
                result.Append(j);
            }

            result.AppendLine();
        }

        for (var i = n - 1; i >= 1; i--){
            for (var j = 1; j <= i; j++){
                result.Append(j);
            }

            result.AppendLine();
        }

        return result.ToString();
    }

    public static string[] SpiralMatrix(int n){
        // takes an integer n and returns an array of strings that represents the spiral matrix of n.
        var result = new string[n];
        for (var i = 0; i < n; i++){
            result[i] = new string(' ', n);
        }

        var x = 0;
        var y = 0;
        var dx = 1;
        var dy = 0;
        for (var i = 1; i <= n * n; i++){
            result[y] = result[y].Substring(0, x) + i + result[y].Substring(x + 1);
            if (x + dx >= n || x + dx < 0 || y + dy >= n || y + dy < 0 || result[y + dy][x + dx] != ' '){
                var temp = dx;
                dx = -dy;
                dy = temp;
            }

            x += dx;
            y += dy;
        }

        return result;
    }

    public static string[] Minesweeper(int[][] array){
        // takes an array of arrays of integers and returns an array of strings that represents the minesweeper of the array.
        var result = new string[array.Length];
        for (var i = 0; i < array.Length; i++){
            result[i] = new string(' ', array[i].Length);
        }

        for (var i = 0; i < array.Length; i++){
            for (var j = 0; j < array[i].Length; j++){
                if (array[i][j] == 1){
                    result[i] = result[i].Substring(0, j) + '*' + result[i].Substring(j + 1);
                    if (i - 1 >= 0){
                        result[i - 1] = result[i - 1].Substring(0, j) + (result[i - 1][j] == '*' ? '*' : '1') +
                                        result[i - 1].Substring(j + 1);
                        if (j - 1 >= 0){
                            result[i - 1] = result[i - 1].Substring(0, j - 1) +
                                            (result[i - 1][j - 1] == '*' ? '*' : '1') + result[i - 1].Substring(j);
                        }

                        if (j + 1 < array[i].Length){
                            result[i - 1] = result[i - 1].Substring(0, j + 1) +
                                            (result[i - 1][j + 1] == '*' ? '*' : '1') + result[i - 1].Substring(j + 2);
                        }
                    }

                    if (i + 1 < array.Length){
                        result[i + 1] = result[i + 1].Substring(0, j) + (result[i + 1][j] == '*' ? '*' : '1') +
                                        result[i + 1].Substring(j + 1);
                        if (j - 1 >= 0){
                            result[i + 1] = result[i + 1].Substring(0, j - 1) +
                                            (result[i + 1][j - 1] == '*' ? '*' : '1') + result[i + 1].Substring(j);
                        }

                        if (j + 1 < array[i].Length){
                            result[i + 1] = result[i + 1].Substring(0, j + 1) +
                                            (result[i + 1][j + 1] == '*' ? '*' : '1') + result[i + 1].Substring(j + 2);
                        }

                    }


                    if (j - 1 >= 0){
                        result[i] = result[i].Substring(0, j - 1) + (result[i][j - 1] == '*' ? '*' : '1') +
                                    result[i].Substring(j);
                    }

                    if (j + 1 < array[i].Length){
                        result[i] = result[i].Substring(0, j + 1) + (result[i][j + 1] == '*' ? '*' : '1') +
                                    result[i].Substring(j + 2);
                    }

                }

            }

        }

        return result;

    }

    public static string Letterbox(int[][] array){
        // takes an array of arrays of integers and returns a string that represents the letterbox of the array.
        var result = new StringBuilder();
        var count = new int[10];
        foreach (var t in array){
            foreach (var t1 in t){
                count[t1]++;
            }
        }

        for (var i = 9; i >= 0; i--){
            result.Append(i + ": " + count[i] + "\n");
        }

        return result.ToString();

    }

    public static string InsideOut(string s){
        // takes a string s and returns a string that represents the inside out of s.
        var result = new StringBuilder();
        var words = s.Split(' ');
        foreach (var word in words){
            if (word.Length % 2 == 0){
                result.Append(word.Substring(word.Length / 2) + word.Substring(0, word.Length / 2) + " ");
            }
            else{
                result.Append(word.Substring(word.Length / 2 + 1) + word[word.Length / 2] +
                              word.Substring(0, word.Length / 2) + " ");
            }
        }

        return result.ToString().Trim();
    }

    public static Stack<string> DuplicateEncoder(string s){
        // takes a string s and returns a stack of strings that represents the duplicate encoder of s.
        var result = new Stack<string>();
        var words = s.Split(' ');
        foreach (var word in words){
            var temp = new StringBuilder();
            for (var i = 0; i < word.Length; i++){
                var count = 0;
                for (var j = 0; j < word.Length; j++){
                    if (word[i] == word[j]){
                        count++;
                    }
                }

                temp.Append(count > 1 ? ')' : '(');
            }

            result.Push(temp.ToString());
        }

        return result;
    }

    public static int CountTrailingZerosInFactorial(int n){
        // Write a program that will calculate the number of trailing zeros in a factorial of a given number.

        // N! = 1 * 2 * 3 *  ... * N

        var count = 0;

        for (var i = 5; n / i >= 1; i *= 5) count += n / i;

        return count;
    }

    public static int BouncingBall(double h, double bounce, double window){
        /*A child is playing with a ball on the nth floor of a tall building. The height of this floor above ground level, h, is known.

            He drops the ball out of the window. The ball bounces (for example), to two-thirds of its height (a bounce of 0.66).

            His mother looks out of a window 1.5 meters from the ground.

            How many times will the mother see the ball pass in front of her window (including when it's falling and bouncing?

            Three conditions must be met for a valid experiment:
        Float parameter "h" in meters must be greater than 0
        Float parameter "bounce" must be greater than 0 and less than 1
        Float parameter "window" must be less than h.
            If all three conditions above are fulfilled, return a positive integer, otherwise return -1.*/

        if (h <= 0 || bounce <= 0 || bounce >= 1 || window >= h){
            return -1;
        }

        var numberOfBounces = 0;

        while (h > window){
            numberOfBounces++; // Ball is falling
            h *= bounce;

            if (h > window){
                numberOfBounces++; // Ball is bouncing up
            }
        }

        return numberOfBounces;
    }

    public static string buildString(string[] args){
        // Oh no! Timmy hasn't followed instructions very carefully and forgot how to use the new String Template feature, Help Timmy with his string template so it works as he expects!

        return String.Format("I like {1}!", String.Join(",", args));
    }

    public static string[] FindDuplicatePhoneNumbers(string[] phoneNumbers){
        Dictionary<string, int> phoneCount = new Dictionary<string, int>();
        string[] mapping ={"", "", "ABC", "DEF", "GHI", "JKL", "MNO", "PRS", "TUV", "WXY"};

        foreach (var phoneNumber in phoneNumbers){
            var standardForm = "";
            foreach (char c in phoneNumber.ToUpper()){
                if (char.IsDigit(c)) standardForm += c;
                else if (char.IsLetter(c)){
                    for (int i = 0; i < mapping.Length; i++){
                        if (!mapping[i].Contains(c)) continue;
                        standardForm += i;
                        break;
                    }
                }
            }

            standardForm = standardForm.Insert(3, "-");

            if (phoneCount.ContainsKey(standardForm)){
                phoneCount[standardForm]++;
            }
            else{
                phoneCount[standardForm] = 1;
            }
        }

        var duplicates = (from kvp in phoneCount where kvp.Value > 1 select kvp.Key + ":" + kvp.Value).ToList();

        duplicates.Sort();

        return duplicates.ToArray();
    }

    static int SumOfDigitsFor(int number){
        var sum = 0;
        while (number > 0){
            sum += number % 10;
            number /= 10;
        }

        return sum;
    }

    static bool IsComfortable(int a, int b){
        int s_a = SumOfDigitsFor(a);
        int s_b = SumOfDigitsFor(b);
        return a != b && a >= b - s_b && a <= b + s_b;
    }

    public static int ComfortablePairs(int L, int R){
        var count = 0;
        for (var a = L; a <= R; a++){
            for (var b = a + 1; b <= R; b++){
                if (IsComfortable(a, b) && IsComfortable(b, a)){
                    count++;
                }
            }
        }

        return count;
    }

    public static int[] Divisors(int n){
        //Create a function named divisors/Divisors that takes an integer n > 1 and returns an array with all of the integer's divisors(except for 1 and the number itself), from smallest to largest. If the number is prime return the string '(integer) is prime' (null in C#) (use Either String a in Haskell and Result<Vec<u32>, String> in Rust).

        var divisors = new List<int>();

        for (var i = 2; i <= Math.Sqrt(n); i++){
            if (n % i != 0) continue;
            divisors.Add(i);
            if (i != n / i){
                divisors.Add(n / i);
            }
        }

        if (divisors.Count == 0) return null;

        divisors.Sort();

        return divisors.ToArray();
    }


    // Decode the Morse code, for real kata
    public static string decodeBitsAdvanced(string bits){
        bits = bits.Trim('0');
        if (bits.Length == 0){
            return "";
        }

        var ones = Regex.Matches(bits, "1+").Cast<Match>().Select(m => m.Length);
        var zeros = Regex.Matches(bits, "0+").Cast<Match>().Select(m => m.Length);

        int rate = Math.Min(ones.Min(), zeros.Min());

        var morse = bits.Replace(new string('1', 3 * rate), "-")
            .Replace(new string('0', 7 * rate), "   ")
            .Replace(new string('1', rate), ".")
            .Replace(new string('0', 3 * rate), " ")
            .Replace(new string('0', rate), "");

        return morse;
    }

    public static string decodeMorse(string morseCode){
        if (string.IsNullOrWhiteSpace(morseCode)){
            return "";
        }

        Dictionary<string, string> morseCodeDictionary = new Dictionary<string, string>{
            {".-", "A"},{"-...", "B"},{"-.-.", "C"},{"-..", "D"},{".", "E"},
            {"..-.", "F"},{"--.", "G"},{"....", "H"},{"..", "I"},{".---", "J"},
            {"-.-", "K"},{".-..", "L"},{"--", "M"},{"-.", "N"},{"---", "O"},
            {".--.", "P"},{"--.-", "Q"},{".-.", "R"},{"...", "S"},{"-", "T"},
            {"..-", "U"},{"...-", "V"},{".--", "W"},{"-..-", "X"},{"-.--", "Y"},
            {"--..", "Z"},{"-----", "0"},{".----", "1"},{"..---", "2"},{"...--", "3"},
            {"....-", "4"},{".....", "5"},{"-....", "6"},{"--...", "7"},{"---..", "8"},
            {"----.", "9"},{"...---...", "SOS"}
        };

        return string.Join(" ", morseCode.Trim().Split("   ").Select(word =>
            string.Join("", word.Split(' ').Select(letter =>
                morseCodeDictionary[letter]))));
    }

    public static string DuplicateEncode(string word){
        // Convert the word to lowercase for case-insensitivity
        word = word.ToLower();
        // Create a dictionary to store the count of each character
        var charCount = new Dictionary<char, int>();
        foreach (var c in word){
            if (charCount.ContainsKey(c)){
                charCount[c]++;
            }
            else{
                charCount[c] = 1;
            }
        }

        // Create a new string with parentheses based on the character count
        var result = new StringBuilder();
        foreach (var c in word){
            result.Append(charCount[c] > 1 ? ')' : '(');
        }

        return result.ToString();
    }

    public static int Persistence(long n){
        //Write a function, persistence, that takes in a positive parameter num and returns its multiplicative persistence, which is the number of times you must multiply the digits in num until you reach a single digit.

        var count = 0;
        while (n > 9) // Keep looping until we get a single-digit number
        {
            long product = 1;
            while (n > 0) // Calculate the product of the digits
            {
                var digit = (int) (n % 10);
                product *= digit;
                n /= 10;
            }

            n = product;
            count++; // Increment the persistence count
        }

        return count;
    }

    public static int[] FindPath(bool[] maze, int size, int startIndex, int goalIndex){
        // Convert the 1D maze array to a 2D matrix for easier indexing
        bool[,] matrix = new bool[size, size];
        for (int i = 0; i < size; i++){
            for (int j = 0; j < size; j++){
                matrix[i, j] = maze[i * size + j];
            }
        }

        // Initialize a stack to keep track of the visited cells
        var stack = new Stack<int>();
        stack.Push(startIndex);

        // Initialize an array to keep track of the previous cell for each cell
        var prev = new int[size * size];
        for (int i = 0; i < prev.Length; i++){
            prev[i] = -1;
        }

        prev[startIndex] = startIndex;

        // Perform a modified version of Depth First Search (DFS) to find the path
        while (stack.Count > 0){
            var current = stack.Pop();
            if (current != goalIndex){
                var x = current / size;
                var y = current % size;
                if (x > 0 && matrix[x - 1, y] && prev[current - size] == -1) // Check top cell
                {
                    stack.Push(current - size);
                    prev[current - size] = current;
                }

                if (x < size - 1 && matrix[x + 1, y] && prev[current + size] == -1) // Check bottom cell
                {
                    stack.Push(current + size);
                    prev[current + size] = current;
                }

                if (y > 0 && matrix[x, y - 1] && prev[current - 1] == -1) // Check left cell
                {
                    stack.Push(current - 1);
                    prev[current - 1] = current;
                }

                if (y >= size - 1 || !matrix[x, y + 1] || prev[current + 1] != -1) continue; // Check right cell
                stack.Push(current + 1);
                prev[current + 1] = current;
            }
            else{
                // Reconstruct the path from the goal to the start by following the previous cells
                var path = new List<int>();
                var index = current;
                while (index != startIndex){
                    path.Add(index);
                    index = prev[index];
                }

                path.Add(startIndex);
                path.Reverse();
                return path.ToArray();
            }
        }

        // No path found
        return null!;
    }

    public static int[] VideoPart(string part, string total){
        //Task
        //You have been watching a video for some time. Knowing the total video duration find out what portion of the video you have already watched.

        var partTime = ParseTime(part);
        var totalTime = ParseTime(total);
        var partSeconds = partTime[0] * 3600 + partTime[1] * 60 + partTime[2];
        var totalSeconds = totalTime[0] * 3600 + totalTime[1] * 60 + totalTime[2];
        var gcd = Gcd(partSeconds, totalSeconds);
        return new int[]{partSeconds / gcd, totalSeconds / gcd};
    }

    static int[] ParseTime(string timeString){
        var parts = timeString.Split(':');
        var result = new int[3];
        for (var i = 0; i < 3; i++){
            result[i] = int.Parse(parts[i]);
        }

        return result;
    }

    static int Gcd(int a, int b){
        while (true){
            if (b == 0) return a;
            var a1 = a;
            a = b;
            b = a1 % b;
        }
    }

    public static string[] DirReduc(string[] arr){
        //Task
        //Write a function dirReduc which will take an array of strings and returns an array of strings with the needless directions removed (W<->E or S<->N side by side).

        var stack = new Stack<string>();
        foreach (var direction in arr){
            if (stack.Count > 0 && AreOpposite(stack.Peek(), direction)){
                stack.Pop();
            }
            else{
                stack.Push(direction);
            }
        }

        var result = stack.ToArray();
        Array.Reverse(result);
        return result;
    }

    static bool AreOpposite(string peek, string direction){
        return peek == "NORTH" && direction == "SOUTH" ||
               peek == "SOUTH" && direction == "NORTH" ||
               peek == "EAST" && direction == "WEST" ||
               peek == "WEST" && direction == "EAST";
    }

    public static int[] Snail(int[][] array){
        //Task
        //Given an n x n array, return the array elements arranged from outermost elements to the middle element, traveling clockwise.

        var n = array.Length;
        var result = new int[n * n];
        var index = 0;
        for (var i = 0; i < n / 2; i++){
            // Top row
            for (var j = i; j < n - i; j++){
                result[index++] = array[i][j];
            }

            // Right column
            for (var j = i + 1; j < n - i; j++){
                result[index++] = array[j][n - i - 1];
            }

            // Bottom row
            for (var j = i + 1; j < n - i; j++){
                result[index++] = array[n - i - 1][n - j - 1];
            }

            // Left column
            for (var j = i + 1; j < n - i - 1; j++){
                result[index++] = array[n - j - 1][i];
            }
        }

        if (n % 2 == 1){
            result[index] = array[n / 2][n / 2];
        }

        return result;
    }

    public static string[][] Partlist(string[] arr){
        //Task
        //Write a function partlist that gives all the ways to divide a list (an array) of at least two elements into two non-empty parts.

        var result = new string[arr.Length - 1][];
        for (var i = 0; i < arr.Length - 1; i++){
            result[i] = new string[2];
            result[i][0] = string.Join(" ", arr.Take(i + 1));
            result[i][1] = string.Join(" ", arr.Skip(i + 1));
        }

        return result;
    }

    public static int[] ArrayDiff(int[] a, int[] b){
        //Task
        //Your goal in this kata is to implement a difference function, which subtracts one list from another and returns the result.

        var set = new HashSet<int>(b);
        return a.Where(x => !set.Contains(x)).ToArray();
    }

    public static int HashCracker(string[][] hashes, string[] dictionary){
        //Task
        //Given a list of hashes and a dictionary, find the password.

        var dictionarySet = new HashSet<string>(dictionary);
        foreach (var hash in hashes){
            var password = string.Join("", hash.Select(word => dictionarySet.Contains(word) ? word[0].ToString() : ""));
            if (password.Length == hash.Length){
                return int.Parse(password);
            }
        }

        return -1;
    }

    public static int UserConnections(string[][] users, string[][] connections, string user){
        //Task
        //Given a list of users and a list of connections, find the number of connections of the given user.

        var userIndex = Array.IndexOf(users, user);
        return connections.Count(connection => connection[0] == user || connection[1] == user);
    }

    public static int CountSmileys(string[] smileys){
        //Task
        //Given an array (arr) as an argument complete the function countSmileys that should return the total number of smiling faces.

        return smileys.Count(smiley => Regex.IsMatch(smiley, @"^[:;][-~]?[)D]$"));
    }

    public static string ChangeCurseWorldWithThreeStars(string text){
        //Task
        //Write a function that takes in a string and replaces all curse words with three asterisks.

        return Regex.Replace(text, @"(shit|crap|damn)", "***", RegexOptions.IgnoreCase);
    }

    public static string AnswerToGreetings(string name){
        //Task
        //Write a function that takes in a string and replaces all curse words with three asterisks.

        return Regex.Replace(name, @"(hello|ciao|salut|hallo|hola|ahoj|czesc)", "Hi!", RegexOptions.IgnoreCase);
    }

    public static string RemoveExclamationMarks(string s){
        //Task
        //Write function RemoveExclamationMarks which removes all exclamation marks from a given string.

        return Regex.Replace(s, @"!", "");
    }

    public static string[] EmailSorter(string[] emails){
        //Task
        //Given an array of email addresses, return an array of only the email addresses that are considered "valid".

        return emails.Where(email => Regex.IsMatch(email, @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$"))
            .ToArray();
    }

    public static string RemoveUrlAnchor(string url){
        //Task
        //Complete the function/method so that it returns the url with anything after the anchor (#) removed.

        return Regex.Replace(url, @"#.*$", "");
    }

    public static int ArchiveNumberOfFiles(string[] files){
        //Task
        //Given an array of file names, return the number of files that are archives.

        return files.Count(file => Regex.IsMatch(file, @"\.zip$"));
    }

    public static int[] StringLetterCount(string str){
        //Task
        //Take a string str and return an array of length 26 with the count of each letter in str.

        var result = new int[26];
        foreach (var c in str){
            result[c - 'a']++;
        }

        return result;
    }

    public static int DepthFirstSearch(int[][] graph, int[] values, int node){
        //Task
        //Given a graph (represented as an adjacency matrix) and an array of values, return the index of the deepest value in the graph.

        var max = values[node];
        var maxIndex = node;
        for (var i = 0; i < graph.Length; i++){
            if (graph[node][i] == 1){
                var index = DepthFirstSearch(graph, values, i);
                if (values[index] > max){
                    max = values[index];
                    maxIndex = index;
                }
            }
        }

        return maxIndex;
    }

    public static int BreadthFirstSearch(int[][] graph, int[] values, int node){
        //Task
        //Given a graph (represented as an adjacency matrix) and an array of values, return the index of the deepest value in the graph.

        var queue = new Queue<int>();
        queue.Enqueue(node);
        var max = values[node];
        var maxIndex = node;
        while (queue.Count > 0){
            var current = queue.Dequeue();
            for (var i = 0; i < graph.Length; i++){
                if (graph[current][i] != 1) continue;
                queue.Enqueue(i);
                if (values[i] <= max) continue;
                max = values[i];
                maxIndex = i;
            }
        }

        return maxIndex;
    }

    public static int[] FindTheOddInt(int[] seq){
        //Task
        //Given an array, find the int that appears an odd number of times.

        return seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).ToArray();
    }

    public static int[] BucketSort(int[] arr){
        //Task
        //Given an array of integers, sort the array in ascending order using the Bucket Sort algorithm.

        var buckets = new List<int>[arr.Length];
        foreach (var t in arr){
            var index = t / 10;
            buckets[index] ??= new List<int>();
            buckets[index].Add(t);
        }

        var result = new List<int>();
        foreach (var bucket in buckets){
            if (bucket == null) continue;
            bucket.Sort();
            result.AddRange(bucket);
        }

        return result.ToArray();
    }

    public static int[] InsertionSort(int[] arr){
        //Task
        //Given an array of integers, sort the array in ascending order using the Insertion Sort algorithm.

        for (var i = 1; i < arr.Length; i++){
            var j = i;
            while (j > 0 && arr[j - 1] > arr[j]){
                (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
                j--;
            }
        }

        return arr;
    }

    public static int[] SelectionSort(int[] arr){
        //Task
        //Given an array of integers, sort the array in ascending order using the Selection Sort algorithm.

        for (var i = 0; i < arr.Length - 1; i++){
            var minIndex = i;
            for (var j = i + 1; j < arr.Length; j++){
                if (arr[j] >= arr[minIndex]) continue;
                minIndex = j;
            }

            if (minIndex == i) continue;
            (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
        }

        return arr;
    }

    public static int[] BubbleSort(int[] arr){
        //Task
        //Given an array of integers, sort the array in ascending order using the Bubble Sort algorithm.

        for (var i = 0; i < arr.Length - 1; i++){
            for (var j = 0; j < arr.Length - i - 1; j++){
                if (arr[j] <= arr[j + 1]) continue;
                (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
            }
        }

        return arr;
    }

    public static int[] SearchInRotatedSortedArray(int[] nums, int target){
        //Task
        //Given an array of integers nums sorted in ascending order, find the starting and ending position of a given target value.

        var result = new int[2];
        var left = 0;
        var right = nums.Length - 1;
        while (left <= right){
            var mid = (left + right) / 2;
            if (nums[mid] == target){
                result[0] = mid;
                result[1] = mid;
                while (result[0] > 0 && nums[result[0] - 1] == target){
                    result[0]--;
                }

                while (result[1] < nums.Length - 1 && nums[result[1] + 1] == target){
                    result[1]++;
                }

                return result;
            }

            if (nums[mid] < target){
                left = mid + 1;
            }
            else{
                right = mid - 1;
            }
        }

        result[0] = -1;
        result[1] = -1;
        return result;
    }

    public static int[] SearchInSortedArray(int[] nums, int target){
        //Task
        //Given an array of integers nums sorted in ascending order, find the starting and ending position of a given target value.

        var result = new int[2];
        var left = 0;
        var right = nums.Length - 1;
        while (left <= right){
            var mid = (left + right) / 2;
            if (nums[mid] == target){
                result[0] = mid;
                result[1] = mid;
                while (result[0] > 0 && nums[result[0] - 1] == target){
                    result[0]--;
                }

                while (result[1] < nums.Length - 1 && nums[result[1] + 1] == target){
                    result[1]++;
                }

                return result;
            }

            if (nums[mid] < target){
                left = mid + 1;
            }
            else{
                right = mid - 1;
            }
        }

        result[0] = -1;
        result[1] = -1;
        return result;
    }

    public static int[] LinearSearch(int[] nums, int target){
        //Task
        //Given an array of integers nums sorted in ascending order, find the starting and ending position of a given target value.

        var result = new int[2];
        for (var i = 0; i < nums.Length; i++){
            if (nums[i] != target) continue;
            result[0] = i;
            result[1] = i;
            while (result[0] > 0 && nums[result[0] - 1] == target){
                result[0]--;
            }

            while (result[1] < nums.Length - 1 && nums[result[1] + 1] == target){
                result[1]++;
            }

            return result;
        }

        result[0] = -1;
        result[1] = -1;
        return result;
    }

    public static int[] DijkstraAlgorithm(int[,] graph, int source){
        //Task
        //Given an array of integers nums sorted in ascending order, find the starting and ending position of a given target value.

        var result = new int[graph.GetLength(0)];
        var visited = new bool[graph.GetLength(0)];
        for (var i = 0; i < result.Length; i++){
            result[i] = int.MaxValue;
        }

        result[source] = 0;
        for (var i = 0; i < result.Length; i++){
            var minIndex = -1;
            for (var j = 0; j < result.Length; j++){
                if (visited[j] || (minIndex != -1 && result[j] >= result[minIndex])) continue;
                minIndex = j;
            }

            visited[minIndex] = true;
            for (var j = 0; j < result.Length; j++){
                if (graph[minIndex, j] == 0 || visited[j] ||
                    result[j] <= result[minIndex] + graph[minIndex, j]) continue;
                result[j] = result[minIndex] + graph[minIndex, j];
            }
        }

        return result;
    }

    public static int[] BellmanFordAlgorithm(int[,] graph, int source){
        //Task
        //Given an array of integers nums sorted in ascending order, find the starting and ending position of a given target value.

        var result = new int[graph.GetLength(0)];
        for (var i = 0; i < result.Length; i++){
            result[i] = int.MaxValue;
        }

        result[source] = 0;
        for (var i = 0; i < result.Length - 1; i++){
            for (var j = 0; j < graph.GetLength(0); j++){
                for (var k = 0; k < graph.GetLength(0); k++){
                    if (graph[j, k] == 0 || result[j] == int.MaxValue || result[j] + graph[j, k] >= result[k]) continue;
                    result[k] = result[j] + graph[j, k];
                }
            }
        }

        return result;
    }

    public static int[] FloydWarshallAlgorithm(int[,] graph){
        //Task
        //Given an array of integers nums sorted in ascending order, find the starting and ending position of a given target value.

        var result = new int[graph.GetLength(0), graph.GetLength(0)];
        for (var i = 0; i < result.GetLength(0); i++){
            for (var j = 0; j < result.GetLength(0); j++){
                result[i, j] = graph[i, j];
            }
        }

        for (var i = 0; i < result.GetLength(0); i++){
            for (var j = 0; j < result.GetLength(0); j++){
                for (var k = 0; k < result.GetLength(0); k++){
                    if (result[j, i] == int.MaxValue || result[i, k] == int.MaxValue ||
                        result[j, i] + result[i, k] >= result[j, k]) continue;
                    result[j, k] = result[j, i] + result[i, k];
                }
            }
        }

        return result.Cast<int>().ToArray();
    }

    public static int[] KruskalAlgorithm(int[,] graph){
        //Task
        //Given an array of integers nums sorted in ascending order, find the starting and ending position of a given target value.

        var result = new int[graph.GetLength(0)];
        var visited = new bool[graph.GetLength(0)];
        for (var i = 0; i < result.Length; i++){
            result[i] = int.MaxValue;
        }

        result[0] = 0;
        for (var i = 0; i < result.Length; i++){
            var minIndex = -1;
            for (var j = 0; j < result.Length; j++){
                if (visited[j] || (minIndex != -1 && result[j] >= result[minIndex])) continue;
                minIndex = j;
            }

            visited[minIndex] = true;
            for (var j = 0; j < result.Length; j++){
                if (graph[minIndex, j] == 0 || visited[j] || result[j] <= graph[minIndex, j]) continue;
                result[j] = graph[minIndex, j];
            }
        }

        return result;
    }

    public static int[] PrimAlgorithm(int[,] graph){
        //Task
        //Given an array of integers nums sorted in ascending order, find the starting and ending position of a given target value.

        var result = new int[graph.GetLength(0)];
        var visited = new bool[graph.GetLength(0)];
        for (var i = 0; i < result.Length; i++){
            result[i] = int.MaxValue;
        }

        result[0] = 0;
        for (var i = 0; i < result.Length; i++){
            var minIndex = -1;
            for (var j = 0; j < result.Length; j++){
                if (visited[j] || (minIndex != -1 && result[j] >= result[minIndex])) continue;
                minIndex = j;
            }

            visited[minIndex] = true;
            for (var j = 0; j < result.Length; j++){
                if (graph[minIndex, j] == 0 || visited[j] || result[j] <= graph[minIndex, j]) continue;
                result[j] = graph[minIndex, j];
            }
        }

        return result;
    }

    public static int[] TopologicalSorting(int[,] graph){
        //Task
        //Given an array of integers nums sorted in ascending order, find the starting and ending position of a given target value.

        var result = new int[graph.GetLength(0)];
        var visited = new bool[graph.GetLength(0)];
        for (var i = 0; i < result.Length; i++){
            result[i] = int.MaxValue;
        }

        result[0] = 0;
        for (var i = 0; i < result.Length; i++){
            var minIndex = -1;
            for (var j = 0; j < result.Length; j++){
                if (visited[j] || (minIndex != -1 && result[j] >= result[minIndex])) continue;
                minIndex = j;
            }

            visited[minIndex] = true;
            for (var j = 0; j < result.Length; j++){
                if (graph[minIndex, j] == 0 || visited[j] || result[j] <= graph[minIndex, j]) continue;
                result[j] = graph[minIndex, j];
            }
        }

        return result;
    }

    public static int[] HuffmanCoding(int[,] graph){
        //Task
        //Given an array of integers nums sorted in ascending order, find the starting and ending position of a given target value.

        var result = new int[graph.GetLength(0)];
        var visited = new bool[graph.GetLength(0)];
        for (var i = 0; i < result.Length; i++){
            result[i] = int.MaxValue;
        }

        result[0] = 0;
        for (var i = 0; i < result.Length; i++){
            var minIndex = -1;
            for (var j = 0; j < result.Length; j++){
                if (visited[j] || (minIndex != -1 && result[j] >= result[minIndex])) continue;
                minIndex = j;
            }

            visited[minIndex] = true;
            for (var j = 0; j < result.Length; j++){
                if (graph[minIndex, j] == 0 || visited[j] || result[j] <= graph[minIndex, j]) continue;
                result[j] = graph[minIndex, j];
            }
        }

        return result;
    }

    public static int[] BackTracking(int[,] graph){
        //Task
        //Given an array of integers nums sorted in ascending order, find the starting and ending position of a given target value.

        var result = new int[graph.GetLength(0)];
        var visited = new bool[graph.GetLength(0)];
        for (var i = 0; i < result.Length; i++){
            result[i] = int.MaxValue;
        }

        result[0] = 0;
        for (var i = 0; i < result.Length; i++){
            var minIndex = -1;
            for (var j = 0; j < result.Length; j++){
                if (visited[j] || (minIndex != -1 && result[j] >= result[minIndex])) continue;
                minIndex = j;
            }

            visited[minIndex] = true;
            for (var j = 0; j < result.Length; j++){
                if (graph[minIndex, j] == 0 || visited[j] || result[j] <= graph[minIndex, j]) continue;
                result[j] = graph[minIndex, j];
            }
        }

        return result;
    }

    public static int[] RobinsonKarpAlgorithm(int[,] graph){
        //Task
        //Given an array of integers nums sorted in ascending order, find the starting and ending position of a given target value.

        var result = new int[graph.GetLength(0)];
        var visited = new bool[graph.GetLength(0)];
        for (var i = 0; i < result.Length; i++){
            result[i] = int.MaxValue;
        }

        result[0] = 0;
        for (var i = 0; i < result.Length; i++){
            var minIndex = -1;
            for (var j = 0; j < result.Length; j++){
                if (visited[j] || (minIndex != -1 && result[j] >= result[minIndex])) continue;
                minIndex = j;
            }

            visited[minIndex] = true;
            for (var j = 0; j < result.Length; j++){
                if (graph[minIndex, j] == 0 || visited[j] || result[j] <= graph[minIndex, j]) continue;
                result[j] = graph[minIndex, j];
            }
        }

        return result;
    }

    public static int[] LeakyBucketAlgorithm(int[,] graph){
        //Task
        //Given an array of integers nums sorted in ascending order, find the starting and ending position of a given target value.

        var result = new int[graph.GetLength(0)];
        var visited = new bool[graph.GetLength(0)];
        for (var i = 0; i < result.Length; i++){
            result[i] = int.MaxValue;
        }

        result[0] = 0;
        for (var i = 0; i < result.Length; i++){
            var minIndex = -1;
            for (var j = 0; j < result.Length; j++){
                if (visited[j] || (minIndex != -1 && result[j] >= result[minIndex])) continue;
                minIndex = j;
            }

            visited[minIndex] = true;
            for (var j = 0; j < result.Length; j++){
                if (graph[minIndex, j] == 0 || visited[j] || result[j] <= graph[minIndex, j]) continue;
                result[j] = graph[minIndex, j];
            }
        }

        return result;
    }

    public static int[] LevelOrderTraversal(int[,] graph){
        //Task
        //Given an array of integers nums sorted in ascending order, find the starting and ending position of a given target value.

        var result = new int[graph.GetLength(0)];
        var visited = new bool[graph.GetLength(0)];
        for (var i = 0; i < result.Length; i++){
            result[i] = int.MaxValue;
        }

        result[0] = 0;
        for (var i = 0; i < result.Length; i++){
            var minIndex = -1;
            for (var j = 0; j < result.Length; j++){
                if (visited[j] || (minIndex != -1 && result[j] >= result[minIndex])) continue;
                minIndex = j;
            }

            visited[minIndex] = true;
            for (var j = 0; j < result.Length; j++){
                if (graph[minIndex, j] == 0 || visited[j] || result[j] <= graph[minIndex, j]) continue;
                result[j] = graph[minIndex, j];
            }
        }

        return result;
    }

    public static int FindCheapestPrice(int[,] graph){
        //Task
        //Given an array of integers nums sorted in ascending order, find the starting and ending position of a given target value.

        var result = new int[graph.GetLength(0)];
        var visited = new bool[graph.GetLength(0)];
        for (var i = 0; i < result.Length; i++){
            result[i] = int.MaxValue;
        }

        result[0] = 0;
        for (var i = 0; i < result.Length; i++){
            var minIndex = -1;
            for (var j = 0; j < result.Length; j++){
                if (visited[j] || (minIndex != -1 && result[j] >= result[minIndex])) continue;
                minIndex = j;
            }

            visited[minIndex] = true;
            for (var j = 0; j < result.Length; j++){
                if (graph[minIndex, j] == 0 || visited[j] || result[j] <= graph[minIndex, j]) continue;
                result[j] = graph[minIndex, j];
            }
        }

        return result[^1];
    }

    public static int DeleteOperationForTwoStrings(string word1, string word2){
        //Task
        //Delete Operation for Two Strings - LeetCode
        //Given two strings word1 and word2 return the operartion that delete the minimum number of characters from word1 and word2 to make them equal.

        var result = new int[word1.Length + 1, word2.Length + 1];

        return result[word1.Length, word2.Length];
    }

    public static int[] RemoveNegativeNumbers(int[] nums){
        //Task
        //Given an array of integers nums remove the negative numbers and return the array.

        var result = new int[nums.Length];
        var index = 0;
        foreach (var num in nums){
            if (num < 0) continue;
            result[index++] = num;
        }

        return result;
    }
    
    
    public static string ConvertCobolToPascal(string cobol){
        //Task
        //Given a string in cobol convert it to pascal case.

        var result = new StringBuilder();
        var isSpace = false;
        foreach (var ch in cobol){
            if (ch == ' '){
                isSpace = true;
                continue;
            }

            if (isSpace){
                result.Append(char.ToUpper(ch));
                isSpace = false;
            }
            else{
                result.Append(char.ToLower(ch));
            }
        }

        return result.ToString();
    }

    public static int HexToBinary(string hex){
        //Task
        //Given a string in hex convert it to binary.

        var result = 0;
        var index = 0;

        for (var i = hex.Length - 1; i >= 0; i--){
            var ch = hex[i];
            var num = 0;
            if (ch >= '0' && ch <= '9'){
                num = ch - '0';
            }
            else if (ch >= 'A' && ch <= 'F'){
                num = ch - 'A' + 10;
            }
            else if (ch >= 'a' && ch <= 'f'){
                num = ch - 'a' + 10;
            }
            else{
                throw new ArgumentException("Invalid hex string");
            }

            result += num * (int) Math.Pow(16, index++);
        }

        return result;

    }
    
    public static string ConvertToHex(int num){
        //Task
        //Given a string in hex convert it to binary.

        var result = new StringBuilder();
        while (num > 0){
            var rem = num % 16;
            if (rem < 10){
                result.Append(rem);
            }
            else{
                result.Append((char) ('A' + rem - 10));
            }

            num /= 16;
        }

        return result.ToString();
    }
    
    public static int[] FindAllAnagrams(string s, string p){
        //Task
        //Given a string s and a non-empty string p, find all the start indices of p's anagrams in s.

        var result = new List<int>();
        var map = new Dictionary<char, int>();
        foreach (var ch in p){
            if (map.ContainsKey(ch)){
                map[ch]++;
            }
            else{
                map[ch] = 1;
            }
        }

        var start = 0;
        var end = 0;
        var count = map.Count;
        while (end < s.Length){
            var ch = s[end];
            if (map.ContainsKey(ch)){
                map[ch]--;
                if (map[ch] == 0){
                    count--;
                }
            }

            end++;
            while (count == 0){
                if (end - start == p.Length){
                    result.Add(start);
                }

                var ch2 = s[start];
                if (map.ContainsKey(ch2)){
                    map[ch2]++;
                    if (map[ch2] > 0){
                        count++;
                    }
                }

                start++;
            }
        }

        return result.ToArray();
    }
    
    public static int AsciiToInteger(string str){
        //Task
        //Given a string str convert it to integer.

        var result = 0;
        var isNegative = false;
        var index = 0;
        if (str[0] == '-'){
            isNegative = true;
            index++;
        }

        for (var i = index; i < str.Length; i++){
            var ch = str[i];
            if (ch < '0' || ch > '9'){
                throw new ArgumentException("Invalid string");
            }

            result = result * 10 + (ch - '0');
        }

        return isNegative ? -result : result;
    }
}




    



























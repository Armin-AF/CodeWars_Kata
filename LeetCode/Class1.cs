using System.Collections;
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

        return (from word in words let sorted = new string(word.OrderBy(c => c).ToArray()) from other in words where word != other let otherSorted = new string(other.OrderBy(c => c).ToArray()) where sorted == otherSorted select $"{word} <=> {other}").ToArray();
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

}



























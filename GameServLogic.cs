using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace GamingLogic
{
    public static class GameServLogic
    {
        public static int[] DivisibleBy(int[] numbers, int divisor)
        {
            List<int> divisible = new List<int>();

            foreach (var item in numbers)
            {
                int divis = item % divisor;

                if (divis == 0)
                {
                    divisible.Add(item);
                }
            }

            var results = divisible.ToArray();
            return results;
        }

        //Kata.CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns "(123) 456-7890"
        public static string CreatePhoneNumber(int[] numbers)
        {
            //Convert simple int array to string
            var phoneNumber = String.Join(" ", numbers.Select(a => a.ToString()).ToArray()).Replace(" ", "");

            var code = phoneNumber.Substring(0, 3);
            var body = phoneNumber.Substring(3, 3);
            var end = phoneNumber.Substring(6, 4);

            var phone = $"({code}) {body}-{end}";

            return phone;
        }

        public static bool XO(string input)
        {
            List<char> Ohs = new List<char>();
            List<char> Xhs = new List<char>();

            foreach (var item in input)
            {
                if (char.IsLetter(item))
                {
                    if (item == 'o' || item == 'O')
                    {
                        Ohs.Add(item);
                    }

                    if (item == 'x' || item == 'X')
                    {
                        Xhs.Add(item);
                    }

                    if (item != 'x' || item != 'o')
                    {
                        continue;
                    }
                }
            }

            bool isExOr;
            if (Ohs.Count() == Xhs.Count())
            {

                isExOr = true;
            }
            else
            {
                isExOr = false;
            }
            return isExOr;
        }
        public static bool IsPangram(string str)
        {
            bool isParam;
            var results = str.ToLower().Where(a => char.IsLetter(a)).GroupBy(a => a).Count() == 26;
            if (results)
            {
                isParam = true;
            }
            else
            {
                isParam = false;

            }
            return isParam;
        }
        // I can make this better and less line................
        public static bool ValidPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length < 14)
            {
                return false;
            }
            var code = phoneNumber.Substring(0, 5);
            var body = phoneNumber.Substring(6, 4);
            var charater = phoneNumber.Substring(10, 4);
            var phone = $"{code} {body + charater}";

            bool isValid;

            if (code.StartsWith('(') && code.EndsWith(')'))
            {
                if (!phoneNumber.Contains("-"))
                {
                    return false;
                }
                else
                {
                    if (!phoneNumber.Contains("-"))
                    {
                        isValid = false;
                    }

                    if (phoneNumber.Equals(phone))
                    {
                        isValid = true;
                    }
                    else
                    {
                        isValid = false;
                    }
                }
                return isValid;
            }
            else
            {
                return false;
            }
        }
        public static bool IsPrime(int n)
        {
            if (n < 1)
                return false;

            int k = 2;
            while (k * k <= n)
            {
                if ((n % k) == 0)
                    return false;
                else k++;
            }
            Console.WriteLine($"Pass {n}");
            return true;

        }
        public static string BreakCamelCase(string str)
        {
            string input = string.Empty;

            foreach (char c in str)
                if (char.IsUpper(c))
                    input = new string(string.Concat(input, " ", c.ToString()).ToCharArray());
                else
                    input = new string(string.Concat(input, c.ToString()).ToCharArray());

            return input;
        }
        public static string ToCamelCase(string str)
        {
            string both;

            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }

            if (str.StartsWith(str.First().ToString().ToUpper()))
            {
                both = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(str).Replace("-", "").Replace("_", "");
            }
            else
            {
                var lower = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(str).Replace("-", "").Replace("_", "");
                both = lower.First().ToString().ToLower() + lower.Substring(1);
            }

            return both;
        }
        public static int FindTheUniqueNumber(IEnumerable<int> numbers)
        {
            int unique = 0;
            int notUnique = 0;
            var number = numbers.ToArray();
            foreach (var item in number)
            {
                if (numbers.Count(a => a == item) > 1)
                {
                    notUnique = unique;
                }
                else
                {
                    unique = item;
                }
            }
            return unique;
        }
        public static bool IsIsogram(string str)
        {
            bool isValid = false;
            var i = 0;

            Dictionary<char, int> word = new Dictionary<char, int>();

            bool rf = bool.Parse(str.Contains("").ToString());
            if (rf) isValid = true;
            foreach (var isgram in str.ToLower())
            {
                if (word.ContainsKey(isgram))
                {
                    isValid = false;
                    break;
                }
                word[isgram] = i++;

                isValid = true;
            }
            return isValid;
        }
        public static int DuplicateCount(string str)
        {
            var result = new HashSet<int>();
            Dictionary<char, int> duplicates = new Dictionary<char, int>();
            foreach (var item in CultureInfo.InvariantCulture.TextInfo.ToLower(str))
            {
                if (duplicates.ContainsKey(item))
                {
                    result.Add(item);
                }
                duplicates[item] = 1;
            }
            return result.Count;
        }
        public static Dictionary<char, int> CountTheOccurenceOfCharactersInAString(string str)
        {
            Dictionary<char, int> justBeYou = new Dictionary<char, int>();

            foreach (var item in str.Replace(" ", ""))
            {
                if (justBeYou.ContainsKey(item))
                {
                    justBeYou[item]++;
                }
                else
                {
                    justBeYou[item] = 1;
                }
            }

            foreach (var keys in justBeYou.Keys)
            {
                Console.WriteLine("{0}: {1}", keys, justBeYou[keys]);
            }

            return justBeYou;
        }
        public static int[] MinimumAndMaximum(int[] ListOfNumbers)
        {
            int minNumber = ListOfNumbers.Min();
            int maxNumber = ListOfNumbers.Max();

            int[] prices = { minNumber, maxNumber };
            return prices.ToArray();
        }
        public static string ToJadnerCase(this string words)
        {
            //string original = string.Empty;
            //original = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(words);
            //return original;

            string phrase = "";

            #region Refactored
            string originalTweet = "";
            int arrLength = phrase.Length - 1;
            string[] results = phrase.Split();

            for (int i = 0; i < arrLength; i++)
            {
                if (i < arrLength)
                {
                    originalTweet += results[i].ToUpper().First() + results[i].Substring(i);
                }
            }

            return originalTweet;
            #endregion
        }
        static public string ReserveStringShort(string name)
        {
            char[] str = name.ToCharArray();
            Array.Reverse(str);
            return new string(str);
        }
        public static string ReserveString(string name)
        {
            // Given a string str, reverse it omitting all non-alphabetic characters.
            //For str = "ultr53o?n", the output should be "nortlu" //"ultr53o?n"
            string reserveString = string.Empty;
            string storeWord = string.Empty;

            foreach (var word in name)
            {
                if (char.IsDigit(word) || !char.IsLetterOrDigit(word))
                {
                    continue;
                }

                storeWord += word;
            }

            // You can improve this 
            var results = storeWord.Length - 1;

            while (results >= 0)
            {
                reserveString += storeWord[results];
                results--;
            }
            // End here

            //for (int i = 0; i <= storeWord.Length - 1; i++)
            ////{
            ////    reserveString += storeWord[i];
            ////    i--;
            ////}
            return reserveString;
        }
        public static string CreditCard(string creditCardNumber)
        {
            string hiddenCharacters = string.Empty;

            for (int i = 0; i < creditCardNumber.Length - 4; i++)
            {
                hiddenCharacters += "#";
            }

            return hiddenCharacters += creditCardNumber.Substring(creditCardNumber.Length - 4);
        }
        //To refactor an change his Logic not mine just like the solution
        public static string ReverseLetter(string str)
        {
            var ans = string.Empty;
            var countWords = str.Length - 1;

            for (int j = 0; j < countWords; j++)
            {
                if (str[j] >= 'a' && str[j] <= 'z')
                {
                    ans += str[j].ToString();
                }
                else
                {
                    ans += "";
                }
            }

            return ans;
        }
        public static int CountVowelOne(string str)
        {
            int vowelCount = 0;

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            foreach (var item in str)
            {
                if (vowels.Contains(item))
                {
                    vowelCount++;
                }
            }

            return vowelCount;
        }
        public static string SwapWord(ref string firstName, ref string lastName)
        {
            string tempName = firstName;
            firstName = lastName;
            lastName = tempName;

            var results = $"{firstName} | {lastName}";
            Console.WriteLine($"{results}");
            return results;
        }
        public static void FizzBuzz(int number)
        {
            if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
        }
        public static string CamelCase(this string str)
        {
            var letter = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(str).Replace(" ", "");
            return letter;
        }
        public static bool validate(string n)
        {
            var b = false;
            if (!string.IsNullOrEmpty(n))
            {
                var results = n.Length;
                var r = n.ToArray();

                if (results % 2 == 0)
                {
                    b = IsValidCreditCardNumber(r, 0);
                }
                else
                {
                    b = IsValidCreditCardNumber(r, 1);

                }
            }

            return b;
        }
        public static bool IsValidCreditCardNumber(char[] arrStr, int index)
        {
            var arrVal = new int[arrStr.Length];
            var total = 0;
            for (int i = index; i < arrStr.Length; i = i + 2)
            {
                Int32.TryParse(arrStr[i].ToString(), out int val);

                arrVal[i] = val * 2;
                if (arrVal[i] > 9)
                {
                    arrVal[i] = arrVal[i] - 9;
                }
            }

            index = index == 0 ? 1 : 0;
            for (int i = index; i < arrStr.Length; i = i + 2)
            {
                Int32.TryParse(arrStr[i].ToString(), out int val);

                arrVal[i] = val;
            }


            for (int i = 0; i < arrVal.Length; i++)
            {
                total = arrVal[i] + total;
            }

            return total % 10 == 0 ? true : false;
        }
        public static string[] SortByLength(string[] array)
        {
            var sortedArrayByLength = array.OrderBy(s => s.Length).ToList();

            return sortedArrayByLength.ToArray();

            #region Another Solution
            //public static string[] SortByLength(string[] array)
            //{
            //    string temp = null;
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        for (int k = i + 1; k < array.Length; k++)
            //        {
            //            if (array[i].Length > array[k].Length)
            //            {
            //                temp = array[i];
            //                array[i] = array[k];
            //                array[k] = temp;
            //            }
            //        }
            //    }
            //    return array;
            //}
            #endregion
        }
        public static int CountVowels(string name)
        {
            Char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            int numberOfVowels = 0;

            foreach (var item in name)
            {
                if (vowels.Contains(item))
                {
                    numberOfVowels++;
                }
            }

            return numberOfVowels;
        }
        public static string CapitaliseWord(string name)
        {
            string firstLetter = string.Empty;

            foreach (var item in name)
            {
                firstLetter += item;
            }

            var results = firstLetter.First().ToString().ToUpper() + firstLetter.Substring(1);
            // var results = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(name);

            return results;

        }
        public static int FindTheNthNumber(int number)
        {
            int results = 0;

            for (int i = 1; i <= number; i++)
            {
                results += i;
                int[] values = new int[results];

            }

            return results;
        }
        public static int[] Digits()
        {

            int[] arr1 = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] arr2 = new[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            List<int> store = new List<int>();
            store.AddRange(arr2);
            store.AddRange(arr1);


            int[] results = store.ToArray();
            Array.Sort(results);

            return results;

        }
        public static List<string> CountDuplicates(string[] name)
        {
            HashSet<string> newStringSet = new HashSet<string>();
            int numberOfDuplicates = 0;
            var storeName = string.Empty;

            foreach (var item in name)
            {
                if (newStringSet.Contains(item))
                {
                    numberOfDuplicates++;
                    if (numberOfDuplicates > 0)
                    {
                        storeName = item;
                    }
                }
                else
                {
                    newStringSet.Add(item);
                }
            }

            return newStringSet.ToList();
        }
        public static int CountWords(string words)
        {
            int NumberOfWords = 0;
            List<string> wordd = new List<string>();

            foreach (char word in words)
            {
                var results = word;
                NumberOfWords++;
            }

            return NumberOfWords;
        }
        public static string BreakCamel(string name)
        {
            TextInfo str = new CultureInfo("en-US", false).TextInfo;

            name = str.ToTitleCase(name).First().ToString().Substring(1).ToUpper();

            name = name.Replace(" ", "");
            return name;

        }
    }
}

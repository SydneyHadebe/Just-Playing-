using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace GamingLogic
{
    public static class CodeToReadFromCodeWars
    {
        public static int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int start = A[0];
            int missing = 0;
            int end = A[A.Length - 1];
            int[] newArray = new int[end];
            for (int i = 0; i < A.Length; i++)
            {
                newArray[i] = start++;
            }

            missing = Convert.ToInt32(A.Except(newArray).ToString());

            return missing;
        }

        public static bool XO(string input)
        {
            return input.ToLower().Count(i => i == 'x') == input.ToLower().Count(i => i == 'o');
        }

        public static bool IsPangram(string str)
        {
            str = str.ToLower();

            for (char letter = 'a'; letter <= 'z'; letter++)
            {
                if (str.IndexOf(letter) == -1) return false;
            }
            return true;
        }
        // Guy with Rank 2 wrote this
        public static bool ValidPhoneNumber(string phoneNumber)
        {
            for (int i = 0; i < phoneNumber.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        if (phoneNumber[i] != '(')
                            return false;
                        break;
                    case 4:
                        if (phoneNumber[i] != ')')
                            return false;
                        break;
                    case 9:
                        if (phoneNumber[i] != '-')
                            return false;
                        break;
                    case 5:
                        break;
                    default:
                        if (phoneNumber[i] < '0' || phoneNumber[i] > '9')
                            return false;
                        break;
                }
            }
            return true;
        }
        public static int GetUniqueNumber(IEnumerable<int> numbers)
        {
            List<int> numbersList = numbers.ToList();
            numbersList.Sort();
            if (numbersList[0] != numbersList[1])
            {
                return numbersList[0];
            }
            return numbersList[numbersList.Count - 1];
        }
        // The use of hashset, i will look into this later on. 
        public static bool IsIsogram(string str)
        {
            var dictionary = new Dictionary<char, char>();

            if (str.Length == 0)
                return true;

            str = str.ToLower();

            foreach (char ch in str)
            {
                if (dictionary.ContainsKey(ch))
                    return false;

                dictionary.Add(ch, ch);
            }
            return true;
        }
        public static bool IsIsogram1(string str)
        {
            var chars = str.ToLower().ToCharArray();
            var hash = new HashSet<char>();

            foreach (var c in chars)
            {
                if (hash.Contains(c))
                {
                    return false;
                }
                else
                {
                    hash.Add(c);
                }
            }

            return true;
        }
        public static int DuplicateCount1(string str)
        {
            int count = 0;
            char[] alphaNum = "abcdefghijklmnopqrstuvwxyz0123456789".ToCharArray();

            foreach (char character in alphaNum)
            {
                if (str.ToLower().Count(c => c == character) > 1)
                    count++;
            }
            return count;
        }
        //Mine this is my code
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
        public static int[] minMax(int[] lst)
        {
            return new int[] { lst.Min(), lst.Max() };
        }
        public static string FavouriteCodeIwroteSoFar(this string phrase)
        {
            return Regex.Replace(phrase, @"(:?^|[ ])([a-z])", m => m.Value.ToUpper());
        }
        public static string FavouriteCodeIwroteSoFar2(this string phrase)
        {
            char[] p = phrase.ToLower().ToCharArray();

            for (int i = 0; i < p.Count(); i++)
            {
                p[i] = i == 0 || p[i - 1] == ' ' ? char.ToUpper(p[i]) : p[i];

            }

            return new string(p);

        }
        public static string FavouriteCodeIwroteSoFar3(this string phrase)
        {
            string[] inputStrArr = phrase.Split(' ');
            string jadenCase = "";
            for (int i = 0; i < inputStrArr.Length; i++)
            {
                if (i < inputStrArr.Length - 1)
                    jadenCase += inputStrArr[i].ToUpper().First() + inputStrArr[i].Substring(1) + " ";
                else
                    jadenCase += inputStrArr[i].ToUpper().First() + inputStrArr[i].Substring(1);
            }
            return jadenCase;
        }
    }
}

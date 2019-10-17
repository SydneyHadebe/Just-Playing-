using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GamingLogic
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int co = 0;
            string stat = new string('*', 5);

            string s1 = "sydney";
            string s2 = "sydney";

            var re = string.Compare(s1, s2);
            if (re == 0)
            {
                Console.WriteLine(true);
            }

            if (string.Compare(s1, s2, true) == 0);


            if(s1.Equals(s2))
            {
                Console.WriteLine($"Ziyafana");
            }
            else
            {
                Console.WriteLine(false);
            }

            var results = ReserveString("sydney");
            Console.WriteLine($"The name {results}");

            string num = "1";
            int r = int.Parse(num);
            Console.WriteLine(r);

            Console.WriteLine($"the number of starts {stat}");


            Console.WriteLine($"The {Right("Sydney", 4)}");
            Console.ReadLine();
        }

        static public string Right(string name, int count)
        {
            string newString = string.Empty;

            if (name != null && count > 0)
            {
                int startIndex = name.Length - count;
                if (startIndex > 0)

                    newString = name.Substring(startIndex, count);
                else
                    newString = name;
            }

            return new string(newString);
        }

        static public string ReserveString(string name)
        {
            char[] str = name.ToCharArray();
             Array.Reverse(str);
            return new string(str);
        }

        public static int Solution(int num)
        {
            int sum = 0;

            for (int i = 0; i < num; i++)
            {
                sum = '+';
            }
            
            return 0;
        }

        public static int[] Solution(string number)
        {
            int[] R = { };

            int cal = 0;
            for (int i = 0; i < 100; i++)
            {
               
            }
           

            return R;

        }

        //public int solution(int[] A)
        //{
        //    int ans = 0;
        //    for (int i = 1; i < A.Length; i++)
        //    {
        //        if (A[i] < ans)
        //        {
        //            ans = A[i];
        //        }
        //    }
        //    return ans;
        //}

        public static int[] ArrayDiff(int[] a, int[] b)
        {
            // Your brilliant solution goes here
            // It's possible to pass random tests in about a second ;)

            if (a == b)
            {
                
            }
            return null;

        }
    }
}


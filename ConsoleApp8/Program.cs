using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Маханов 1исп11-17 практика 7
/// </summary>

namespace ConsoleApp8
{
    class Program
    {
        static string prog2(string s)
        {
            string res = "";
            for (int i = 0; i < s.Length; i++)
            {
                res += s[i] + " ";
            }
            return res;
        }
        static string prog3(string s)
        {
            string res;
            string[] words = s.Split();
            string[] wordsReverse = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                wordsReverse[i] = words[words.Length - i - 1];
            }
            res = string.Join(" ", wordsReverse);
            return res;
        }
        static bool compare(char c1, char c2)
        {
            return (c1 - c2) > -2 && (c1 - c2) < 2;
        }
        static bool prog4(string s1, string s2)
        {
            bool flag = true;
            for (int i = 0; i < s1.Length; i++)
            {
                flag = compare(s1[i], s2[i]);
                if (!flag)
                {
                    break;
                }
            }
            return flag;
        }
        static string sort(string s)
        {
            bool flag = true;
            char[] res = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                res[i] = s[i];
            }
            while (flag)
            {
                flag = false;
                for (int i = 0; i < res.Length - 1; i++)
                {
                    if (res[i] > res[i + 1])
                    {
                        char a = res[i];
                        res[i] = res[i + 1];
                        res[i + 1] = a;
                    }
                }
            }
            string res1 = "";
            foreach (char c in res)
            {
                res1 += c;
            }
            return res1;
        }
        static bool prog5(string s1, string s2)
        {
            string S1 = "";
            string S2 = "";
            foreach (char c in s1)
            {
                if (!S1.Contains(c))
                {
                    S1 += c;
                }
            }
            foreach (char c in s2)
            {
                if (!S2.Contains(c))
                {
                    S2 += c;
                }
            }
            S1 = sort(S1);
            S2 = sort(S2);
            return S1 == S2;
        }
        static int[] prog6(string s, char c)
        {
            int[] res;
            if (s.Contains(c))
            {
                int n = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == c)
                    {
                        n++;
                    }
                }
                res = new int[n];
                int j = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == c)
                    {
                        res[j] = i;
                        j++;
                    }
                }
            }
            else
            {
                res = new int[1];
                res[0] = -1;
            }
            return res;
        }
        static char[] prog7(string s)
        {
            string S = "";
            string exclude = ",./;:\\ \"!?()*&^%$#@";
            foreach (char c in s)
            {
                if (!S.Contains(c) && !exclude.Contains(c))
                {
                    S += c;
                }
            }
            S = sort(S);
            char[] res = new char[S.Length];
            for (int i = 0; i < S.Length; i++)
            {
                res[i] = S[i];
            }
            return res;
        }
        static string prog8(string s, int a, int b)
        {
            string res = "";
            for (int i = a; i < a + b; i++)
            {
                res += s[i];
            }
            return res;
        }
        class prog9
        {
            string s;
            public prog9(string s1)
            {
                s = s1;
            }
            public void method1(string inp, int x)
            {
                string s1 = s.Substring(0, x);
                string s2 = s.Substring(x, s.Length - x);
                s = s1 + inp + s2;
            }
            override public string ToString()
            {
                return s;
            }
        }
        class prog10
        {
            string s;
            char c;
            public string[] method1()
            {
                return s.Split(c);
            }
            override public string ToString()
            {
                return s + " " + c + " " + string.Join(" ", this.method1());
            }
        }
        class prog11
        {
            int[] n;
            public prog11(int x)
            {
                Random rnd = new Random();
                n = new int[x];
                for (int i = 0; i < x; i++)
                {
                    n[i] = rnd.Next();
                }
            }
            public override string ToString()
            {
                string s = "";
                foreach (int i in n)
                {
                    s += Convert.ToString(i) + " ";
                }
                s = s.Substring(0, s.Length - 1);
                return s;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCodeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program program = new Program();
            Console.ReadLine();
        }

        public bool IsValid(string s)
        {
            Hashtable ht = new Hashtable();
            ht.Add(')', '(');
            ht.Add(']', '[');
            ht.Add('{', '}');
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (ht.ContainsKey(s[i]))
                {
                    if (stack.Count != 0 && stack.Peek() == Convert.ToChar(ht[s[i]]))
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(s[i]);
                }
            }

            if (stack.Count > 0)
            {
                return false;
            }

            return true;
        }
    }
}

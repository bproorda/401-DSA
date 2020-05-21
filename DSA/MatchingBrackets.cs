using DataStructures.StackAndQueue;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
   public class MatchingBrackets
    {
        public static bool MultiBracketValidation(string input)
        {
            MyStack<char> bracketStack = new MyStack<char>();
            bool output = false;

            foreach(char item in input.ToCharArray())
            {
                if (item == '(' || item == '{' || item == '[')
                {
                    bracketStack.push(item);
                } else if (item == '(' || item == '{' || item == '[')
                {
                    if(FindMatch(item) == bracketStack.peek())
                    {
                        bracketStack.pop();
                    }
                }
            }

            if (bracketStack.Top !=null)
            {
                output = true;
            }
            return output;
        }

        public static char FindMatch(char input)
        {
            switch (input)
            {
                case ')':
                    return '(';
                case '}':
                    return '{';
                case ']':
                    return '[';
                default:
                    return ' ';
            }
        }
    }
}

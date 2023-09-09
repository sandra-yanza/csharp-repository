using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = "abcd";
            x = ReverseString1(x);

            Console.WriteLine(x);

            //exercise 2
            string _inputstr, _reversestr = string.Empty;
            Console.Write("Enter a string : ");
            _inputstr = Console.ReadLine();
            if (_inputstr != null)
            {
                for (int i = _inputstr.Length - 1; i >= 0; i--)
                {
                    _reversestr += _inputstr[i].ToString();
                }
                if (_reversestr == _inputstr)
                {
                    Console.WriteLine("String is Palindrome Input = {0} and Output= {1}", _inputstr, _reversestr);
                }
                else
                {
                    Console.WriteLine("String is not Palindrome Input = {0} and Output= {1}", _inputstr, _reversestr);
                }
            }

            Console.ReadLine();
        }

        public static string ReverseString1(string str)
        {
            char[] chars = str.ToCharArray();
            char[] result = new char[chars.Length];
            for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
            {
                result[i] = chars[j];
            }
            return new string(result);
        }
    }
}

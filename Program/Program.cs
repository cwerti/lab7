using System;
using System.Text;

namespace Program
{
    public class Utility
    {
        public static int[] SortArray(int[]? array)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));

            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }
        public static bool IsPalindrome(string? str)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));

            int left = 0, right = str.Length - 1;
            while (left < right)
            {
                if (str[left] != str[right]) return false;
                left++;
                right--;
            }
            return true;
        }

        public static long Factorial(int n)
        {
            if (n < 0) throw new ArgumentOutOfRangeException(nameof(n), "Факториал не определен для отрицательных чисел.");
            if (n == 0) return 1;

            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        public static int Fibonacci(int n)
        {
            if (n < 0) throw new ArgumentOutOfRangeException(nameof(n), "Индекс не может быть отрицательным.");
            if (n == 0) return 0;
            if (n == 1) return 1;

            int a = 0, b = 1, temp;
            for (int i = 2; i <= n; i++)
            {
                temp = a + b;
                a = b;
                b = temp;
            }
            return b;
        }

        public static int IndexOfSubstring(string? str, string? substring)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));
            if (substring == null) throw new ArgumentNullException(nameof(substring));

            return str.IndexOf(substring);
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public static int ReverseInteger(int x)
        {
            int sign = x < 0 ? -1 : 1;
            x = Math.Abs(x);
            int reversed = 0;

            while (x != 0)
            {
                int digit = x % 10;
                x /= 10;

                if (reversed > (int.MaxValue - digit) / 10)
                    return 0;

                reversed = reversed * 10 + digit;
            }

            return sign * reversed;
        }

        public static string ToRoman(int num)
        {
            if (num <= 0 || num > 3999) throw new ArgumentOutOfRangeException(nameof(num), "Число должно быть в диапазоне от 1 до 3999.");

            StringBuilder roman = new StringBuilder();
            var romanNumerals = new[]
            {
            new { Value = 1000, Symbol = "M" },
            new { Value = 900, Symbol = "CM" },
            new { Value = 500, Symbol = "D" },
            new { Value = 400, Symbol = "CD" },
            new { Value = 100, Symbol = "C" },
            new { Value = 90, Symbol = "XC" },
            new { Value = 50, Symbol = "L" },
            new { Value = 40, Symbol = "XL" },
            new { Value = 10, Symbol = "X" },
            new { Value = 9, Symbol = "IX" },
            new { Value = 5, Symbol = "V" },
            new { Value = 4, Symbol = "IV" },
            new { Value = 1, Symbol = "I" },
        };
            foreach (var item in romanNumerals)
            {
                while (num >= item.Value)
                {
                    roman.Append(item.Symbol);
                    num -= item.Value;
                }
            }

            return roman.ToString();
        }
        public static void Main(string[] args)
        {

        }
    }
}
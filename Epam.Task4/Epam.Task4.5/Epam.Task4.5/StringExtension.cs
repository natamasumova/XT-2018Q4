using System;

namespace Epam.Task4._5
{
    public static class StringExtension
    {
        public static bool IsInt(this string str)
        {
            if (HasPoint(str) < 0)
            {
                return true;
            }
            int mantissa = CountMantissa(str);
            if (HasExponent(str) < 0)
            {
                return false;
            }
            if (CountMantissa(str) < CountFraction(str))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int FirstCorrectSymbols(string str)
        {
            if (!Char.IsDigit(str[0]))
            {
                if (str[0] == '+' || str[0] == '-')
                {
                    if (Char.IsDigit(str[1]))
                    {
                        return 2;
                    }
                }
                throw new FormatException();
            }
            else
            {
                return 1;
            }
        }
        public static int HasPoint(string str)
        {
            int i = FirstCorrectSymbols(str);
            while (i < str.Length)
            {
                if (!Char.IsDigit(str[i]))
                {
                    if (str[i] != '.')
                    {
                        throw new FormatException();
                    }
                    else return i;
                }
            }
            return -1;
        }

        public static int CountMantissa(string str)
        {
            int mantissa = 0;
            int i = HasPoint(str) + 1;
            while (i < str.Length)
            {
                if (!Char.IsDigit(str[i]))
                {
                    if (!IsExponent(str[i]))
                    {
                        throw new FormatException();
                    }
                    else break;
                }
                mantissa++;
                i++;
            }
            return mantissa;
        }

        public static bool IsExponent(char ch)
        {
            if (ch == 'e' || ch == 'E')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int HasExponent(string str)
        {
            for (int i = 2; i < str.Length; i++)
            {
                if (IsExponent(str[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        public static int CountFraction(string str)
        {
            int fraction = 0;
            int i = HasExponent(str) + 1;

            if (str[i] != '+')
            {
                throw new FormatException();
            }
            i++;
            while (i < str.Length)
            {
                if (!Char.IsDigit(str[i]))
                {
                    throw new FormatException();
                }
                else
                {
                    if (str[i] != '0')
                    {
                        fraction = fraction * 10 + (str[i] - '0');
                    }
                    i++;
                }
            }
            return fraction;
        }
    }
}

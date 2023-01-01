using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTools
{
    public class iText
    {
        public static string RemoveVowels(string text)
        {
            StringBuilder rs = new StringBuilder();
            foreach (char item in text)
            {
                if (!"aeiouy".Contains(item.ToString().ToLower()))
                {
                    rs.Append(item);
                }
            }
            return rs.ToString();
        }

        public static string RemoveSpaces(string text)
        {
            string rs = string.Empty;
            char[] charArray = text.ToCharArray();
            char prev = ' ';
            for (int i = 0; i < charArray.Length; i++)
            {
                char current = charArray[i];
                if (!(prev == ' ' && current == prev))
                    rs = rs + current;
                prev = current;
            }
            return rs;
        }

        public static string RemoveLettre(string text, char lettre)
        {
            string rs = string.Empty;
            foreach (char c in text)
            {
                if (c != lettre)
                    rs += c;
            }
            return rs;
        }

        public static string ReverseWord(string text)
        {
            string rs = string.Join(" ", text.Split(' ').Reverse());

            return rs;
        }

        public static string ReverseString(string text)
        {
            char[] str = text.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                char c = str[i];
                str[i] = str[j];
                str[j] = c;
            }

            return new string(str);
        }

        public static bool IsDigitOrLetters(string input)
        {
            bool rs = false;
            foreach (var item in input)
            {
                if (char.IsLetterOrDigit(item))
                    rs = true;
                else
                    rs = false;
            }
            return rs;
        }

        public static string UpperCase(string text)
        {
            return text.ToUpper();
        }

        public static string LowerCase(string text)
        {
            return text.ToLower();
        }

        public static string DefaultText(string text)
        {
            string rs = string.Empty;
            if (!string.IsNullOrEmpty(text))
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (i == 0)
                        rs += text[i].ToString().ToUpper();
                    else
                        rs += text[i].ToString().ToLower();
                }
                return rs;
            }
            else
                rs = string.Empty;

            return rs;
        }
    }
}
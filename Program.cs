using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = String2Int("1qaz2wsx3edc4rv");
            Console.Write(result);
        }

        public static int String2Int(string val)
        {
            string result = string.Empty;
            if(!string.IsNullOrEmpty(val))
            {
                char[] arr = val.ToCharArray();

                foreach(var i in arr)
                {
                    switch ( i )
                    {
                        case '0' :
                        case '1':
                        case '2':
                        case '3':
                        case '4':
                        case '5':
                        case '6':
                        case '7':
                        case '8':
                        case '9':
                            result += i.ToString();
                            break;
                        default:
                            result += "";
                            break;

                    }
                     

                }
            }

            return convertToInt(result);
        }

        public static int convertToInt(String numString)
        {
            int answer = 0;
            int factor = 1;

            for (int i = numString.Length - 1; i >= 0; i--)
            {
                answer += (numString[i] - '0') * factor;
                factor *= 10;
            }
            return answer;
        }
    }
}

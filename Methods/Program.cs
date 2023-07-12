using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string result = "";
            bool shart = str.Contains('0');
            Console.WriteLine(decimal.MaxValue);
            while (!shart)
            {

                result += str;
                str = Console.ReadLine();
                shart = str.Contains('0');
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '0')
                {
                    break;
                }
                result += str[i].ToString();
            }
            int counter = 1, maxCounter = 1, fiderNum = 0, prevNum = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (char.IsDigit(result[i]))
                {
                    if (str[i+1] == str[i])
                    {
                        counter++;
                    }
                    else if (prevNum == 0)
                    {
                        prevNum = str[i+1] - '0';
                    }
                    else
                    {
                        if (maxCounter <= counter)
                        {
                            maxCounter = counter;
                            fiderNum = prevNum;
                        }
                        prevNum = str[i + 1];
                        counter = 1;
                    }



                    //sdfsrfgd/ed
                }
            }
                

        }
    }
}
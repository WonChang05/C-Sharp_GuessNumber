using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace guessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArray = new ArrayList();
            string temp = "";
            Random ran = new Random();
            string answer = "";

            for (int i = 0; i < 4; i++)
            {
                do
                {
                    temp = Convert.ToString(ran.Next(0, 10));
                }
                while (myArray.IndexOf(temp) != -1);
                myArray.Add(temp);

            }
            answer = Convert.ToString(myArray[0]) + Convert.ToString(myArray[1])
                    + Convert.ToString(myArray[2]) + Convert.ToString(myArray[3]);
            //Console.WriteLine(answer);

            int cnt = 0;
            string flag = "n";
            while (flag == "n" && cnt < 10)
            {
                Console.Write("請輸入答案(四位數)：");
                string input = Console.ReadLine();
                if (input.Length == 4)
                {
                    string[] ans = new string[4];
                    for (int i = 0; i < 4; i++)
                    {
                        ans[i] = input.Substring(i, 1);
                    }
                    int a = 0, b = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        if (answer.IndexOf(ans[i]) == i)
                        {
                            a += 1;
                        }
                        else if (answer.IndexOf(ans[i]) > -1)
                        {
                            b += 1;
                        }
                    }
                    if (answer == input)
                    {
                        Console.WriteLine("答案正確");
                        flag = "y";
                    }
                    else
                    {
                        Console.WriteLine($"{input}為 {a}A {b}B");
                    }
                    cnt++;
                    if (cnt == 10 && flag == "n")
                    {
                        Console.WriteLine($"******GG******\n答案是{answer}");
                    }
                }
                else
                {
                    Console.WriteLine("錯誤，請重新輸入。");
                }
            }    
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public class Chapter16Intermediate
    {

        

        // 中級問題
        public Chapter16Intermediate(){


            // 
        }


        // 
        public static int[] swapWithoutVariables(int a ,int b)
        {
            // a=b,b=a;
            a = a - b;
            b = a + b;
            a = b - a;


            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
            
            // python の場合はお互いの入れ替え代入ができる
　　　　　　// [a,b] = [b,a]

            int[] res = new int[2];
            res[0] = a;
            res[1] = b;
            return res;

        }

        /// <summary>
        /// 本の中にある単語が何度出てくるか調べる
        /// </summary>
        /// <param name="book"></param>
        public static void countWordInBook(string book,string word)
        {

            // 正規表現で 文字列の中に何度出現するかしらべる
            MatchCollection matched = Regex.Matches(book, word);

            System.Console.WriteLine(matched.Count);


        }


    }
}

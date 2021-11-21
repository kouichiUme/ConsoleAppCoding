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
        public void swapWithoutVariables()
        {

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

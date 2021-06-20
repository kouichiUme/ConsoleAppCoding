using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Chapter1String
    {






        public String checkDeplicatedCharactor(String s)
        {





            return s;

        }


        // 

        static public bool checkSortedString(String s1, String s2)
        {
            bool result = false;

            char[] s1c= s1.ToCharArray();
            char[] s2c = s2.ToCharArray();

            // 
            Array.Sort(s1c);
            Array.Sort(s2c);

            // arrayのまま比べたかったけれどわからないのでそのまま
            // linq
            // Listにする方法があるみたい
            if(s1c.Length != s2c.Length)
            {
                return false;
            }

            bool[] results = new bool[s1c.Length];
            for(int i = 0; i < results.Length; i++)
            {
                results[i] = false;
            }
            for(int i=0;i<s1c.Length; i++)
            {
                if(s1c[i] != s2c[i])
                {
                    results[i] = false;
                }
                else
                {
                    results[i] = true;
                }
            }
            bool tempResult = results[0];
            for(int i = 0; i < results.Length; i++)
            {
                tempResult = tempResult && results[i]; 
            }

            result = tempResult;


            return result;
            
        }

    }
}

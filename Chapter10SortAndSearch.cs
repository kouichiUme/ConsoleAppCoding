using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Chapter10SortAndSearch<T> where T : IComparable
    {

        public static void mergeArray(T[] a, T[] b)
        {
            int aReplaceIndex = 0;
            int aIndex = 0;
            int bIndex = 0;


            // a
            // b
            // 
            for (int i = 0; GetAReplaceIndex(aReplaceIndex) < a.Length;)
            {

                if (a[aReplaceIndex] == null)
                {
                    a[aReplaceIndex] = b[bIndex];
                    bIndex++;
                }
                else if (bIndex < b.Length - 1)
                {

                    if (a[aReplaceIndex].CompareTo(b[bIndex]) > 0)
                    {
                        a[aReplaceIndex] = a[aReplaceIndex];
                        aReplaceIndex++;


                    }
                    else if (a[aReplaceIndex].CompareTo(b[bIndex]) == 0)
                    {

                        // ひとつづつ右にずらす

                        a[aReplaceIndex] = a[aReplaceIndex];
                        // 一つ進める
                        aReplaceIndex++;
                        // a を一つ進める
                        // b はそのまま
                        // 

                    }
                    // aのほうがちいさい
                    else if ((a[aReplaceIndex].CompareTo(b[bIndex]) < 0))
                    {

                        // ひとつづつ右にずらす
                        for (int k = a.Length - 1; k > aReplaceIndex; k--)
                        {
                            a[k] = a[k - 1];
                        }



                    }
                }
            }
        }

        private static int GetAReplaceIndex(int aReplaceIndex)
        {
            return aReplaceIndex;
        }




        public void mergeInvertArray(T[] a, T[] b)
        {

        }


    }
}

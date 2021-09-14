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
            for (int i = 0; aReplaceIndex < a.Length;)
            {

                if(a[aReplaceIndex] == null)
                {
                    a[aReplaceIndex] = b[bIndex];
                    bIndex++;
                }
                else if (bIndex < b.Length - 1)
                {

                    // aのほうがちいさい
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
                    else if ((a[aReplaceIndex].CompareTo(b[bIndex]) < 0))
                    {

                        // ひとつづつ右にずらす
                        for (int k = a.Length -1; k > aReplaceIndex; k--)
                        {
                            a[k] = a[k-1];
                        }



                    }
                }

                    }
                }

                else
                {
                    //終わり
                    break;
                }



            }


        }

        public void mergeInvertArray(T[] a, T[] b)
        {

        }


    }
}

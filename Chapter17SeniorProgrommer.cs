using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    public class Chapter17SeniorProgrommer
    {

        public int FourBitFullAdder(int a ,int b,int c)
        {
            // 1桁目
            


            // xor 
            int residue = a ^ b;
            // and 
            int advance = a & b;
            // kuriage (advance)
            advance <<= advance;

            // 繰り返し条件

            // 4ビット full adder
            // 回以上繰り返し4
            // 4桁だとすると4桁目に1となっていること

            int advanceFilterAnd = 0b1000;

            // 途中3桁で繰り上げが起こっていることを確認する
            int advanceFilterOr = ~0b1000;


            // 1桁繰り上げがある
            int advanceFullAdder = 0b0;


            return advanceFullAdder;

        }

        public int[] OneBitFullAdder(int a,int b,int c)
        {

            int carry = 0b0;

            int reside = (a ^ b);

            carry = a & b | reside & c;
            reside = reside ^ c;


            return new int[]{ reside,carry};

        }


        public int adder(int a,int b)
        {

            // 
            int intlength = 32;
            int[] ra = {0,0};
            int result = 0;
            for(int i = 0;i < intlength; i++)
            {

                ra = OneBitFullAdder(a, b, ra[1]);

                result |= (ra[0] << i);

            }

            return result;

        }


        public double randomGenerator()
        {
            Random r = new Random();
            // 
            return r.NextDouble();
        }


        static public IEnumerable<int> GetUniqNumber()
        {
            // 
            int count = 0;

            List<int> work = Enumerable.Range(0, 52).ToList();

            Random r = new Random();
            //
            // 
            for (int i =0; i<count; i++)
            {

                int pos = r.Next(0, work.Count);

                int value = work[pos];
                work.Remove(pos);


                yield return value;

            }

        }



        public void shuffle()
        {

            // ダスティンフィルドのアルゴリズム


            double random = randomGenerator();


            Random r = new Random();
            int index = r.Next(0, 52);

            int[] card = new int[52];

            


        }




        /// <summary>
        /// 
        /// </summary>
        public void coarseResembling()
        {


        
        }





        public void histgram()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Chapter5Bit
    {
        public UInt32 problem1(UInt32 binaryN, UInt32 binaryM,int i,int j)
        {
            // self xor make all 0;

            // binaryM ^= binaryM;

            UInt32 binaryIJ = 0b1;
            UInt32 binaryFilter = 0b0;
            for(int k = 0; k < j; k++)
            {
                binaryIJ = 0b1;
                binaryIJ <<= k;
                binaryFilter += binaryIJ;

            }
            binaryFilter <<= i;

            binaryFilter = ~binaryFilter;
            UInt32 tmpBinary = binaryN & binaryFilter;
            binaryM <<= i;
            tmpBinary |= binaryM;

            return tmpBinary;
        }
    }
}

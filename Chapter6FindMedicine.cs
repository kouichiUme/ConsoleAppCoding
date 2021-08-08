using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Chapter6FindMedicine
    {


        public static int findBinFromMedicine(LinkedList<LinkedList<double>> allBins)
        {
            int binNumber = -1;
            int index = 1;

            double summary = 0;
            double expectedMedicine = 1.0;
            double findMedicine = 1.1;

            double expectedSummary = 0;
            

            foreach(LinkedList<double> bin in allBins)
            {

                // 瓶から一つ取り出して倍増させる
                double medicine = bin.First.Value;
                summary += medicine * index;
                

                // 本来の重さの数だけ合計する
                expectedSummary += expectedMedicine * index;

                index++;

            }

            double indexCandidate = (summary - expectedSummary) / (findMedicine - expectedMedicine);

            binNumber = ((int)Math.Round(indexCandidate));


            return binNumber;


        }


    }
}

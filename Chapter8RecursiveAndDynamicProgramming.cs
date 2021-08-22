using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Chapter8RecursiveAndDynamicProgramming
    {

        public class ResultObjects
        {
            public int stepsCase = 0;
            public int remaining = 0;
        }

        public ResultObjects findStep(ResultObjects argResult)
        {

            ResultObjects result = new ResultObjects();

            int n = argResult.remaining;


            if (n > 3)
            {
                // 1 ,2 ,3どのケースに分割するか
                for(int takeStep = 1; takeStep <= 3; takeStep ++)
                {
                    // recursive ?
                    ResultObjects a1 = new ResultObjects();
                    a1.stepsCase = 0;
                    a1.remaining = n - takeStep;

                    while(a1.remaining > 0)
                    {
                        a1 = findStep(a1);

                    }
                    result.stepsCase += a1.stepsCase;

                }

                return result;
                // base case 3
            }else if(n == 3)
            {
                // 3 
                // 2, 1
                // 1, 2
                // 1,1,1

                result.stepsCase = 4;
                result.remaining = argResult.remaining - 3;
                return result;
                
            }
                // base case 2
            else if(n == 2)
            {
                // 1step .1step
                // 2 step
                result.stepsCase = 2;
                result.remaining= argResult.remaining - 2;

                return result;

            }
            // base case1 
            else if(n == 1){
                result.stepsCase = 1;
                result.remaining = argResult.remaining - 1;

                return result;

                
            }
            



            return result;

        }
    }
}

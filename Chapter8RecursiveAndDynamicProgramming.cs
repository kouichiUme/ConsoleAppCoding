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
            public int reside = 0;
        }

        public ResultObjects findStep(ResultObjects argResult)
        {

            ResultObjects result = new ResultObjects();

            int n = argResult.reside;


            if (n > 3)
            {
                // 1 ,2 ,3どのケースに分割するか
                for(int takeStep = 1; takeStep <= 3; takeStep ++)
                {
                    // 
                    ResultObjects a1 = new ResultObjects();
                    a1.stepsCase = 0;
                    a1.reside = n - takeStep;

                    while(a1.reside > 0)
                    {
                        a1 = findStep(a1);

                    }
                    result.stepsCase += a1.stepsCase;

                }

                return result;

            }else if(n == 3)
            {
                // 3 
                // 2, 1
                // 1, 2
                // 1,1,1

                result.stepsCase = 4;
                result.reside = argResult.reside - 3;
                return result;
                
            }
            
            else if(n == 2)
            {
                // 1step .1step
                // 2 step
                result.stepsCase = 2;
                result.reside= argResult.reside - 2;

                return result;

            }
            else if(n == 1){
                result.stepsCase = 1;
                result.reside = argResult.reside - 1;

                return result;

                
            }
            



            return result;

        }
    }
}

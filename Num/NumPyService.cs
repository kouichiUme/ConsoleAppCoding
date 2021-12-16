using System;
using System.Collections.Generic;
using System.Text;
using NumSharp;



namespace ConsoleApp1.Num
{
    public class NumPyService
    {

        public static NDArray initNDArray()
        {

            NDArray nd = np.full(5,12);

            nd.reshape(3, 4);

            return nd;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Module_5_6_try1
{
    class NumberManipulator
    {
        public int FindMax( int first, int second )
        {
            int result;

            if ( first > second)
            {
                result = first;
            }
            else
            {
                result = second;
            }
            return result;
        }
    }
}

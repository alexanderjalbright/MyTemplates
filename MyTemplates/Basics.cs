using System;
using System.Collections.Generic;
using System.Text;

namespace MyTemplates
{
    public class Basics
    {
        public void Variables()
        {
            char character = 'a';
            string text = "words";

            // Whole numbers and max values, obtained from <type>.MaxValue
            short smallerWholeNumber = 32767;
            int wholeNumber = 2147483647;
            long biggerWholeNumber = 9223372036854775807;

            // Decimal numbers and max digits
            decimal smallerDecimalNumber = 9999999999999999999999999999M;
            float decimalNumber = 99999999999999999999999999999999999999F;
            double largeDecimalNumber = 99999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999D;
        }

        public void Loops()
        {
            for(int i = 0; i < 10; i++)
            {
                // perform loop 10 times
            }

            bool whileLoop = true;
            while(whileLoop)
            {
                // only do if statement is true
                // keep doing until false
                whileLoop = false;
            };

            bool doLoop = true;
            do
            {
                // do once no matter what
                // keep doing until false
                doLoop = false;
            } while (doLoop);

            List<int> numbers = new List<int>();
            foreach (int number in numbers)
            {

            }
        }

        public void Comparators()
        {
            int var1 = 0;
            int var2 = 1;

            // Greater than
            if (var1 > var2)
            {
                
            }

            // Greater than or equal to
            if (var1 >= var2)
            {

            }

            // Less than
            if (var1 < var2)
            {

            }

            // Less than or equal to
            if (var1 <= var2)
            {

            }

            // Equal to
            if (var1 == var2)
            {

            }

            // Not equal to
            if (var1 != var2)
            {

            }
        }



    }
}

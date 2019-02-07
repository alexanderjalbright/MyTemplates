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

        public void Comparators()
        {
            int var1 = 0;
            int var2 = 1;

            // Greater than
            if (var2 > var1)
            {

            }

            // Greater than or equal to
            if (var2 >= var1)
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

            if(true == false)
            {

            }
            else if(true == true)
            {

            }
            else
            {

            }
        }

        public void Math()
        {
            // All equal to 4

            // Add
            int sum = 3 + 1;

            // Subtract
            int difference = 5 - 1;

            // Multiply
            int product = 2 * 2;

            // Divide
            int quotent = 8 / 2;

            // Modulus (Remainder)
            int modulus = 9 % 5;

            // Exponent
            int exponent = 2 ^ 2;

            // Absolute Value
            float positive = MathF.Abs(-6);

            // Square Root
            float root = MathF.Sqrt(36);
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
    }

    public class Enumerables
    {
        // Arrays
        string[] array = new string[4];
        string[] initializedArray = new string[] { "We", "Can", "Code", "IT" };

        // Lists
        List<string> list = new List<string>() { "We", "Can", "Code", "IT" };

        // Dictionary
        Dictionary<int, string> dictionary = new Dictionary<int, string>() { { 1, "We" }, { 1, "Can" }, { 1, "Code" }, { 1, "IT" } };
        
    }


    public class Parent
    {
        // Constructor
        // Can have multiple depending on if it has arguments
        public Parent()
        {
            
        }

        public Parent(string lastName)
        {
            LastName = lastName;
        }

        // Properties
        public string LastName { get; set; }

        // Can only be changed by parent(class it resides in)
        public List<Child> Children { get; private set;}

        // Can only be changed by family of class (residing class and offspring)
        public string NetflixPassword { get; protected set; }
    }

    public class Child : Parent
    {
        // Own unique contructor
        public Child()
        {
            LastName = "Albright";
            NetflixPassword = "thgirblA";
        }

        // Shares Parents constructor
        public Child(string lastName) : base(lastName)
        {
            NetflixPassword = "8675309";
        }
    }

    
}

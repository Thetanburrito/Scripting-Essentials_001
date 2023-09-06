using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Here I will initialize all of my variables I will need for this project
             normally I dont do this at the beginning but the code will be very simple
            and small, these are simple variables that have a range of types*/
            int integerVariable = 0;
            double doubleVariable = 0.0;
            bool boolVariable = true;

            //Now I will alter the variables using operations and functions
            while(boolVariable) //this is a loop function that loops as long as the variable in the function is true.
            {
                integerVariable++; //This is a simplified method to adding 
                doubleVariable = doubleVariable + 0.1; //this is a unique number to add to variables, the only variable type that can hold a decimal place are doubles and floats.
                if (integerVariable >= 10)//This will test the variable "integerVariable" every time it loops to see if it is equal or greater than 10
                {
                    boolVariable = false;//Once the function is true it will run this which turns boolVariable False, this will break the loop.
                }
            }

        }
    }
}
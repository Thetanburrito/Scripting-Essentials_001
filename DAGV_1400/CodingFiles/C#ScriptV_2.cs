using System;

namespace HelloWorld
	{
  		class Program
  		{
    			static void Main(string[] args)
    			{
				//This is the Integer example, this adds to the example Integer until it equals the ammount of letters in the string Test
      			int exampleInteger = 0;
      			string Test = "four";
      			foreach(char f in Test)
      			{
      				exampleInteger++;
      				Console.WriteLine(exampleInteger);
      			}
				//This is the End of the Integer Example----------------------------------

				//This is the begining of the Double Example, This does the same thing as the Interger Example but allows it to use decimal points
				double exampleDouble = 0.0;
    				while (exampleDouble != exampleInteger)
        			{
        				exampleDouble = exampleDouble + 0.5;
                			Console.WriteLine(exampleDouble);
        			}
				//This is the end of the Double Example------------------------------------------

				//This is a more complicated example that should allow an input from the user where it compares it to a random number, if they are the same number at the end of the operation then it congradulates the user, else it shows them the random number generator and moves on.
                /*
				Console.WriteLine("Write a nubmer between 1 and 10: ");
				string input = Console.ReadLine();
				int result = Int32.Parse(input);
				Random rnd = new Random();
				int compare = rnd.Next(1, 10);
				if (result == compare)
				{
                   		Console.WriteLine("Congrats! You got it right!");
                    	}
                		else
                		{
                    		Console.WriteLine("Ooooh Not Quite, the number was" + input);
    				}
                    */
				//Unfortunatley this example does not work on w3schools.com I believe its due to it being a basic compiler that doesn't allow input and doesn't allow the random function to work due to it not having it in its basic libraries, if you would like to try it just remove the "/*  */" and it will become available
                
                
                
                //This is the final Example and the start of the Bool Example
				bool exampleBoolean = true;
				int boolExampleInt = 0;
				while(exampleBoolean)
				{
					if (boolExampleInt < 10)
					{
                    	Console.WriteLine(exampleBoolean);
						boolExampleInt++;
					}
					else
					{
						exampleBoolean = !exampleBoolean;
                        Console.WriteLine(exampleBoolean);
					}
				}
				//This is the end of the example
            
            	}
  		}
	}
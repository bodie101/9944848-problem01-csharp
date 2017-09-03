using System;

namespace problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();
            
            Console.WriteLine("This program will take two numbers and tell you what one is greater");

             Console.WriteLine("Enter a number");
                    var number1 = int.TryParse(Console.ReadLine(), out int a); 

             Console.WriteLine("enter anothor number"); 
                    var number2 = int.TryParse(Console.ReadLine(), out int b);



            if (a < b)
            {
                Console.WriteLine("Number1 is smaller than number2");
            }
            if (b < a)  
            {
                Console.WriteLine("Numebr2 is bigger than number1");
            }
            if (a == b) 
            {
                Console.WriteLine("Number1 is the same as number2");
            }
            else 
            {
                Console.WriteLine("please enter a number");
            }     



                    
                

            

        

        
            
            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
        }
    }
}

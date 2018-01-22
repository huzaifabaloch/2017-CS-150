using System;

class Program
{
        static void Main()
        {
            //// FACTORIAL WITHOUT RECURSION
            //int number;
            //int fact = 1;

            //Console.WriteLine("Enter a Number");
            //number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= number; i++)
            //{
            //    fact = i * fact;

            //}

            //Console.WriteLine(fact);
            //Console.ReadKey();




            // // SWAPING
            //int firstNum;
            //int secondNum;

            //Console.WriteLine("Enter Your First Number");
            //firstNum = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Your Second Number");
            //secondNum = int.Parse(Console.ReadLine());

            //firstNum = firstNum + secondNum;
            //secondNum = firstNum - secondNum;
            //firstNum = firstNum - secondNum;

            //Console.WriteLine("First = {0}\nSecond = {1}", firstNum, secondNum);
            //Console.ReadKey();



            //int number;

            //Console.WriteLine("Enter a Number");
            //number = int.Parse(Console.ReadLine());

            //string result = ((number % 2) == 0) ? "EVEN" : "ODD";
       
            //Console.WriteLine("\nThe Number is {0}", result);
            //Console.ReadKey();


            int fnum = 1;
            int snum;
            
            snum = fnum;

            int next = fnum + snum;

            int userNumber;

            Console.WriteLine("ENTER ?");
            userNumber = int.Parse(Console.ReadLine());

            while(next <= userNumber) {

                Console.Write("{0}, ", next);
                fnum = snum;
                snum = next;
                next = fnum + snum;
            }

            Console.ReadKey();
        }
 }


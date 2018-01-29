using System;

class Program
    {

    public static double Addition(double fnum, double snum) {

        return fnum + snum;
    }

    public static double Subtraction(double fnum, double snum) {

        return fnum - snum;
    }

    public static double Multiplication(double fnum, double snum)
    {

        return fnum * snum;
    }


    public static double Division(double fnum, double snum)
    {

        return fnum / snum;
    }

    public static double InputOne() {

        double fnum;

        Console.WriteLine("\nEnter the first number");
        fnum = Convert.ToDouble(Console.ReadLine());

        return fnum;
    
    }

    public static double InputTwo()
    {
        double snum; 

        Console.WriteLine("\nEnter the second number");
        snum = Convert.ToDouble(Console.ReadLine());

        return snum;
    }

    static void Main(string[] args)  {

        double firstNumber = 0;
        double secondNumber = 0;
        double answer;
        int userOption;
        char exit;

        do {
        Console.Clear();
        Console.WriteLine("\n======CALCULATOR======");
        Console.WriteLine("\n1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Power");
        Console.WriteLine("6. Square Root");
        Console.WriteLine("7. Logarithm");
        Console.WriteLine("\nSelect Your Operation?");
        Console.WriteLine("--------------------------"); 
        userOption = int.Parse(Console.ReadLine());


        switch (userOption) { 
 

            case 1:

                firstNumber = InputOne();
                secondNumber = InputTwo();
                answer = Addition(firstNumber, secondNumber);
                Console.WriteLine("\n\tThe Result of Addtion, {0}", answer);
                break;


            case 2:

                firstNumber = InputOne();
                secondNumber = InputTwo();
                answer = Subtraction(firstNumber, secondNumber);
                Console.WriteLine("\n\tThe Result of Subtraction, {0}", answer);

                break;

            case 3:

                firstNumber = InputOne();
                secondNumber = InputTwo();
                answer = Multiplication(firstNumber, secondNumber);
                Console.WriteLine("\n\tThe Result of Multiplication, {0}", answer);
                break;


            case 4:

                firstNumber = InputOne();
                secondNumber = InputTwo();
                answer = Division(firstNumber, secondNumber);
                Console.WriteLine("\n\tThe Result of Division, {0}", answer);
                break;

            case 5:

                firstNumber = InputOne();
                Console.WriteLine("\nEnter the value of power");
                secondNumber = Convert.ToInt32(Console.ReadLine());
                answer = Math.Pow(firstNumber, secondNumber);
                Console.WriteLine("\n\tThe {0} times {1} is {2}", secondNumber, firstNumber, answer);
                break;


            case 6:

                Console.WriteLine("\nEnter the number for square root");
                firstNumber = Convert.ToInt32(Console.ReadLine());
                answer = Math.Sqrt(firstNumber);
                Console.WriteLine("\n\tThe Square Root of {0} is {1}", firstNumber, answer);
                break;

            case 7:

                Console.WriteLine("\nEnter the number for log");
                firstNumber = Convert.ToInt32(Console.ReadLine());
                answer = Math.Log(firstNumber);
                Console.WriteLine("\n\tThe Log of {0} is {1}", firstNumber, answer);
                break;
        }


        Console.ReadKey();

        Console.Clear();
        Console.WriteLine("CONTINUE USING EXTRA SMART CALCULATOR?");
        exit = char.Parse(Console.ReadLine());

        }while(exit != 'N'); 
}


    }

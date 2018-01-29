using System;




/*

class Student
{

    public string name;
    public byte age;
    public int mrksOfEng;
    public int mrksOfMaths;
    public int mrksOfSci;
    public int totalMarks;
    public int obtainedMarks;
    public float perCentage;

}

class Program
{
    static void Main(string[] args)
    {
        Student STD = new Student();

        int Total;
        float perCent;
 
        Console.WriteLine("\nEnter Your Name");
        STD.name = Console.ReadLine();

        Console.WriteLine("\nEnter Your Age");
        STD.age = Convert.ToByte(Console.ReadLine());

        Console.WriteLine("\nEnter Your Marks in English");
        STD.mrksOfEng = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nEnter Your Marks in Mathematics");
        STD.mrksOfMaths = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nEnter Your Marks in Science");
        STD.mrksOfSci = Convert.ToInt32(Console.ReadLine());

        Total = Total_Marks(STD.mrksOfEng, STD.mrksOfMaths, STD.mrksOfSci);

        perCent = Percentage_I(Total);

        Console.Clear();
        Console.WriteLine("=======================================");
        Console.WriteLine("\t\tSTUDENT RESULT");
        Console.WriteLine("=======================================");
        Console.WriteLine("Name = {0}",STD.name);
        Console.WriteLine("Age = {0}", STD.age);
        Console.WriteLine("English = {0}", STD.mrksOfEng);
        Console.WriteLine("Mathematics = {0}", STD.mrksOfMaths);
        Console.WriteLine("Science = {0}", STD.mrksOfSci);
        Console.WriteLine("Total Marks = {0}", Total);
        Console.WriteLine("Percentage = {0}", perCent);
        Console.ReadKey();

    }


    public static int Total_Marks(int eng, int maths, int sci) {

        Student STD = new Student();

        STD.obtainedMarks = eng + maths + sci;

        return STD.obtainedMarks;

    }

    public static float Percentage_I(int obtained) {
        
        Student STD = new Student();
        STD.totalMarks = 300;

        STD.perCentage = ((float)obtained / STD.totalMarks) * 100;

        return STD.perCentage;

        
        
    }
}
*/




class Program {

    static void Main(string[] args)
    {

        string name;
        int vowels = 0;
        int storeLen;

        Console.WriteLine("Enter a name to see vowels in it");
        name = Console.ReadLine();

        storeLen = name.Length;

        int i;

        for (i = 0; i < storeLen; i++)
        {
            if(name[i] == 'a' || name[i] == 'e' || name[i] == 'i' || name[i] == 'o' || name[i] == 'u' ||
                name[i] == 'A' || name[i] == 'E' || name[i] == 'I' || name[i] == 'O' || name[i] == 'U')
            {
                vowels++;
            }
        }


        Console.WriteLine("The number of vowels in {0} are {1}", name, vowels);
        Console.ReadKey();


    }


    }










/*
class Rectangle {

    private double length;
    private double width;

    public double Perimeter_Rectangle(double l, double w) {

        length = l;
        width = w;
        return 2 * (length + width);

    }

    public double Area_of_Rectangle(double l, double w) {

        length = l;
        width = w;
        return width * length;
    
    }
}


class Program {

    static void Main(string[] args) {

        Rectangle rect = new Rectangle();

        double perimeter;
        double area;
        double len;
        double wid;

        Console.WriteLine("Enter the lenght");
        len = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the width");
        wid = Convert.ToDouble(Console.ReadLine());

        perimeter = rect.Perimeter_Rectangle(len, wid);
        area = rect.Area_of_Rectangle(len, wid);

        Console.WriteLine(perimeter);
        Console.WriteLine(area);
        Console.ReadKey();
     
    }
}
*/


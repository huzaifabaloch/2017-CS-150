using System;

class Get_Set {

    /*
     * This program focuses on data hiding, in every programming language
     * the concept of OOP is very important which brings us into data hiding category
     * in OOP a variable doesnot has to be public, it is a bad programming practise
     * and makes the code to mess up very easily, so we will try to hide the data members
     * of a class to other classes but in order to use them we have the following methods
     * 1. using accessor and mutator 
     * 2. get and set properties
     * 
     * which will allow us to set and get those variables through methods.
     
     */

    private string name;  // private variable for storing string 

    // use of get and set properties 
    public string PersonName {  //  creating our own property for name variable
        get {  //  returning the value

            return name;   
        
        }
        set {   // initializing of value

            name = value;  // the keyword value is reserved which will automaically set the value of user
        }
    }

}


class MainClass {

    static void Main(string[] args) {  // entry point into the application

        Get_Set gs = new Get_Set();    // instance of the class Get and Set

        string tempName;            // temperory variable 
        Console.WriteLine("Enter Name: ");
        tempName = Console.ReadLine();
        gs.PersonName = tempName;     // using the user defined value & initializing into our property
        Console.WriteLine("Name is , {0}", gs.PersonName);  // returing or geting back our value
        Console.ReadKey();        
  
    }
}




=================================================================================



using System;

class Factorial {

    long Answer;

    public long finalAnswer {

        get { return Answer; }
        set { Answer = value; }
    }

    //  factorial function
    public static long factorial(int number) {   // no object is required for static members
        // they are globally accessible


        // if number gets equal to 1 then it will return number value as 1
        if (number == 1)
            return 1;

        // else number greater than 1 then it will multiply that number with same number 
            //but less than one of it.
        else
            return number * factorial(number - 1);
    }
}

class Program {

    public static void Main(string[] args) {
        Factorial f = new Factorial();
        int tempFact;
        Console.WriteLine("Enter a Number");
        tempFact = Convert.ToInt32(Console.ReadLine());
        f.finalAnswer = Factorial.factorial(tempFact);
        Console.WriteLine("The Answer is, {0}", f.finalAnswer);
        Console.ReadKey();
        
    
    }
}

 ======================================================================================


using System;

class Vehicle {

    string type;
    string name;
    int noOfWheels;

    // USE OF ACCESSOR AND MUTATOR METHODS TO SET AND GET THE PRIAVTE DATA MEMBERS
    public void setType(string t) {   type = t;  }

    public string getType() {   return type;  }

    public void setName(string n) { name = n; }

    public string getName() { return name; }

    public void setNoOfWheels(int wheels) { noOfWheels = wheels; }

    public int getNoOfWheels() { return noOfWheels; }
    
}

class Program {

    public static void Main(string[] args) {

        Vehicle car = new Vehicle();  // 1st Object
        Vehicle motorcycle = new Vehicle();  // 2nd Object 
        Vehicle Truck = new Vehicle();      // 3rd  Object

        int choice;

        Console.WriteLine("1. Car");
        Console.WriteLine("2. Motorcycle");
        Console.WriteLine("3. Jeep");
        choice = int.Parse(Console.ReadLine());

        switch (choice) { 

            case 1:

                car.setType("Sports Car");
                car.setName("Audi R8");
                car.setNoOfWheels(4);
                Console.WriteLine("\n\n====CAR====");
                Console.WriteLine("\nType = {0}", car.getType());
                Console.WriteLine("\nName = {0}", car.getName());
                Console.WriteLine("\nNo of Wheels = {0}", car.getNoOfWheels());

                break;

            case 2:

                motorcycle.setType("Bicycle");
                motorcycle.setName("BMX");
                motorcycle.setNoOfWheels(2);
                Console.WriteLine("\n\n====MOTORCYCLE====");
                Console.WriteLine("\nType = {0}", motorcycle.getType());
                Console.WriteLine("\nName = {0}", motorcycle.getName());
                Console.WriteLine("\nNo of Wheels = {0}", motorcycle.getNoOfWheels());

                break;

            case 3:

                Truck.setType("Tractor");
                Truck.setName("Backhoe Loader");
                Truck.setNoOfWheels(4);
                Console.WriteLine("\n\n====TRUCK====");
                Console.WriteLine("\nType = {0}", Truck.getType());
                Console.WriteLine("\nName = {0}", Truck.getName());
                Console.WriteLine("\nNo of Wheels = {0}", Truck.getNoOfWheels());

                break;
        }
        Console.ReadKey();

    
    }
}
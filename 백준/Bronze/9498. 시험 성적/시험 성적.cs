using System;
public class MainClass
{
    public static void Main()
    {
         string value = Console.ReadLine();
        string result = "";
        int testValue = Convert.ToInt32(value);
 
        if (testValue >= 0 && testValue <= 100)
        {
            if (testValue >= 90 && testValue <= 100)
                result = "A";
            else if (testValue >= 80 && testValue <= 89)
                result = "B";
            else if (testValue >= 70 && testValue <= 79)
                result = "C";
            else if (testValue >= 60 && testValue <= 69)
                result = "D";
            else
                result = "F";
 
 
            Console.WriteLine(result);
        }
    
    }
}
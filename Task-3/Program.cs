namespace Task_3;

class Program
{
    static void Main()
    {
        //Declare and initalizes variables
        byte byteValue = 10;
        short shortValue = 100;
        int intValue = 42;
        long longValue = 100000L;
        float floatValue = 3.14f;
        double doubleValue = 5.67;
        decimal decimalValue = 5.67m;
        char charValue = 'A';
        bool boolValue = true;
        
        // Convert string "3.14" to string
        string stringValue = intValue.ToString();
        
        // Convert string "1.14" to double
        double stringToDouble = Convert.ToDouble(3.14);
        
        //Print all variables with types and values
        Console.WriteLine("byte    : " + byteValue);
        Console.WriteLine("short    : " + shortValue);
        Console.WriteLine("int    : " + intValue);
        Console.WriteLine("long    : " + longValue);
        Console.WriteLine("float  : " + floatValue);
        Console.WriteLine("double  : " + doubleValue);
        Console.WriteLine("decimal  : " + decimalValue);
        Console.WriteLine("char     : " + charValue);
        Console.WriteLine("bool    : " + boolValue);
        
        Console.WriteLine("string  : " + stringValue);
        Console.WriteLine("stringToDouble : " + stringToDouble);
        

    }
}
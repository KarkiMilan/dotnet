        bool equal = Calculator.AreEqual(4,4);
        Console.WriteLine(equal);
        bool equal1 = Calculator.AreEqual("Nepal","Switerland");
        Console.WriteLine(equal1);
public class Calculator
{
    
    public static bool AreEqual <T> (T value1, T value2)
    {
        return value1.Equals(value2);

    }
}
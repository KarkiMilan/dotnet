        bool equal = Calculator.AreEqual(4,4);
        Console.WriteLine(equal);
        //bool equal = calculator.AreEqual("Nepal","Switerland");
        //Console.WriteLine(equal);
public class Calculator
{
    
    public static bool AreEqual (int value1, int value2)
    {
        return value1.Equals(value2);

    }
}
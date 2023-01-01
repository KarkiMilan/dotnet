        bool equal = Calculator <int>.AreEqual(4,4);
        Console.WriteLine(equal);
        bool equal1 = Calculator<string>.AreEqual("Nepal","Switerland");
        Console.WriteLine(equal1);
public class Calculator <T>
{
    
    public static bool AreEqual (T value1, T value2)
    {
        return value1.Equals(value2);

    }
}
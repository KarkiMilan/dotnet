panda p1 = new panda ("Pan Daw");
panda p2 = new panda ("Paan Dha");
Console.WriteLine(p1.Name);
Console.WriteLine(p2.Name);
Console.WriteLine(panda.Population);
public class panda{
    public String Name;
    public static int Population;
    public panda (string n){
        Name = n;
        Population = Population + 1;
    }

}
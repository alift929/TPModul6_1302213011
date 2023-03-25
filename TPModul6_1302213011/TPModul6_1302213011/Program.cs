// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main()
    {
        var STB = new SayaTubeVideo("Tutorial Design By Contract - Alif Taufiqurrahman");
        STB.IncreasePlayCount(2);
        STB.PrintVideoDetails();
    }
}

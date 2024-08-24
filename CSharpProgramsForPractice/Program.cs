namespace CSharpProgramsForPractice;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine(FeetToInches(30));
        Console.WriteLine(FeetToInches(100));
    }

    private static int FeetToInches(int feet)
    {
        var inches = feet * 12;
        return inches;
    }
}
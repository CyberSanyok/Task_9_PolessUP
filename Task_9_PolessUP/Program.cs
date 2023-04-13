internal class Program
{
    private static void Main(string[] args)
    {
        int date = 2000;
        Console.WriteLine(date+": "+DateTime.IsLeapYear(date));
        date = 2015;
        Console.WriteLine(date+": "+DateTime.IsLeapYear(date));

    }
}
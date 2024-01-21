namespace FørsteCraigOppgave;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Git!");
        Console.WriteLine("My name is Sigurd");
        // skriver ut tall en til 12 :)
        int[] time = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12];
        foreach (int num in time)
        {
            Console.WriteLine(num);
        }
    }
}
namespace Bankamat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Bankomat bankamat = new Bankomat();
            bankamat.Adress();
            bankamat.SelectLanguage();
            bankamat.Enterpin();
        }
    }
}
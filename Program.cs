namespace Cezar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello World!";

            Cezar cezar = new Cezar();

            Console.WriteLine(text);
            Console.WriteLine(cezar.Encrypt(text));
        }
    }
}
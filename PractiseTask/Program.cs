namespace PractiseTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Massivin uzunlugunu daxil edin : ");
            CustomArray arr = new CustomArray(Convert.ToInt32(Console.ReadLine()));
        }
    }
}
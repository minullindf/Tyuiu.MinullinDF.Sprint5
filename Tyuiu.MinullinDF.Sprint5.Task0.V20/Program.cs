using Tyuiu.MinullinDF.Sprint5.Task0.V20.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int x = 2;

        DataService ds = new DataService();
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
        Console.WriteLine("****************************************************************************");

        Console.WriteLine("x = " + x);

        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        string res = ds.SaveToFileTextData(x);

        Console.WriteLine("Файл: " + res + " Создан");
        Console.ReadKey();
    }
}
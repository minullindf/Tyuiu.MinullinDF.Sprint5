using Tyuiu.MinullinDF.Sprint5.Task1.V8.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int sv = -5;
        int ev = 5;

        DataService ds = new DataService();
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
        Console.WriteLine("****************************************************************************");

        Console.WriteLine("startValue = " + sv);
        Console.WriteLine("endValue = " + ev);

        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        string res = ds.SaveToFileTextData(sv, ev);

        Console.WriteLine("Файл: " + res + " Создан");
        Console.ReadKey();
    }
}
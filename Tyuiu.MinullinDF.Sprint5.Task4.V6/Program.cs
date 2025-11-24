using Tyuiu.MinullinDF.Sprint5.Task4.V6.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        string path = $@"C:\DataSprint5\InPutDataFileTask4V6.txt";
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
        Console.WriteLine("****************************************************************************");

        Console.WriteLine($"путь = {path}");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        var res = ds.LoadFromDataFile(path);

        Console.WriteLine("Ответ: " + res);
        Console.ReadKey();
    }
}
using Tyuiu.MinullinDF.Sprint5.Task5.V16.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V16.txt");
        //string path = $@"C:\DataSprint5\InPutDataFileTask5V16.txt";
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
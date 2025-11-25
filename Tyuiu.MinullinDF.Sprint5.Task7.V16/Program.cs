using Tyuiu.MinullinDF.Sprint5.Task7.V16.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V16.txt");
        //string path = $@"C:\DataSprint5\InPutDataFileTask7V16.txt";
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
        Console.WriteLine("****************************************************************************");

        Console.WriteLine($"путь = {path}");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        var res = ds.LoadDataAndSave(path);

        Console.WriteLine("Ответ: " + res);
        Console.ReadKey();
    }
}
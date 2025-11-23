using Tyuiu.MinullinDF.Sprint5.Task2.V16.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int[,] mtrx = new int[3, 3] {
                { 2, -4, -8 },
                { 3, -7, -2 },
                { 3, 8, 6 } };
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
        Console.WriteLine("****************************************************************************");

        for (int i = 0; i < mtrx.GetLength(0); i++) 
        {
            for (int j = 0; j < mtrx.GetLength(1); j++) 
            {
                Console.Write($"{mtrx[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        string res = ds.SaveToFileTextData(mtrx);

        Console.WriteLine("Файл: " + res + " Создан");
        Console.ReadKey();
    }
}
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MinullinDF.Sprint5.Task0.V20.Lib
{
    public class DataService : ISprint5Task0V20
    {
        public string SaveToFileTextData(int x)
        {
            string path1 = Path.GetTempPath();
            string path2 = "OutPutFileTask0.txt";
            string path = Path.Combine(path1, path2);
            double y = Math.Round(2.12 * Math.Pow(x, 3) + 1.05 * Math.Pow(x, 2) + 4.1 * x * 2, 3);
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}

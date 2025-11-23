using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MinullinDF.Sprint5.Task1.V8.Lib
{
    public class DataService : ISprint5Task1V8
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            double y, result;
            string path1 = Path.GetTempPath();
            string path2 = "OutPutFileTask1.txt";
            string path = Path.Combine(path1, path2);
            FileInfo fileInfo = new FileInfo(path);

            if (fileInfo.Exists) 
            {
                File.Delete(path);
            }

            for (double x = startValue; x <= stopValue; x++) 
            {
                y = 4 - 2 * x + (2 + Math.Cos(x))/(2*x-2);
                if (double.IsInfinity(y) || double.IsNaN(y))
                {
                    result = 0;
                } else 
                {
                    result = Math.Round(y, 2);
                }
                File.AppendAllText(path, $"{Convert.ToString(result)}\n");

            }
            return path;
        } 
    }
}

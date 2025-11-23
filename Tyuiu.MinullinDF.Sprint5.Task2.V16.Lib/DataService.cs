using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MinullinDF.Sprint5.Task2.V16.Lib
{
    public class DataService : ISprint5Task2V16
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path1 = Path.GetTempPath();
            string path2 = "OutPutFileTask2.csv";
            string path = Path.Combine(path1, path2);
            FileInfo fileInfo = new FileInfo(path);

            if (fileInfo.Exists)
            {
                File.Delete(path);
            }
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++) 
                {
                    if (matrix[i, j] < 0) 
                    {
                        if (j == n - 1) {File.AppendAllText(path, "0");}
                        else { File.AppendAllText(path, "0;"); }
                    } else 
                    {
                        if (j == n - 1) { File.AppendAllText(path, "1"); }
                        else { File.AppendAllText(path, "1;"); }
                    }
                }
                if (i == m - 1) { break; }
                else { File.AppendAllText(path, "\n"); ; }
            }
            return path;
        }
    }
}

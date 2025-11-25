using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MinullinDF.Sprint5.Task6.V27.Lib
{
    public class DataService : ISprint5Task6V27
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            int a = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (char.IsDigit(line[i]))
                        {
                            a++;
                        }
                        if (!char.IsDigit(line[i]) && a == 3)
                        {
                            a = 0;
                            count++;
                        }
                        if (!char.IsDigit(line[i]) && a > 3) { a = 0; }
                    }
                }
            }
            return count;
        }
    }
}

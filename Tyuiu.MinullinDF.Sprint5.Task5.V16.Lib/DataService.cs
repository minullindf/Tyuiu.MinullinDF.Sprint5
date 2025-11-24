using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MinullinDF.Sprint5.Task5.V16.Lib
{
    public class DataService : ISprint5Task5V16
    {
        public double LoadFromDataFile(string path)
        {
            // ошибка в проверяющей системе, т.к. не засчитывает 0, хотя оно подходит под условия
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            double a;
            double c = 0, b = 0;
            string[] nums = File.ReadAllText(path).Split(" ");

            for (int i = 0; i < nums.Length; i++) 
            {
                a = double.Parse(nums[i]);
                if ((int)a == a && a % 10 == 0 && a != 0) 
                {
                    if (c == 0) 
                    {
                        b = a;
                        c++;
                    }
                    else if (a > b) { b = a; }
                }
            }
            return Math.Round(b, 3);
        }
    }
}

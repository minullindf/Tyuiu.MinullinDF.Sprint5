using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MinullinDF.Sprint5.Task4.V6.Lib
{
    public class DataService : ISprint5Task4V6
    {
        public double LoadFromDataFile(string path)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            string strX = File.ReadAllText(path);
            Console.WriteLine(strX);
            double x = Convert.ToDouble(strX);
            double y = 1.0 / Math.Cos(x) + 2.2*Math.Pow(x, 2);
            return Math.Round(y, 3);
        }
    }
}

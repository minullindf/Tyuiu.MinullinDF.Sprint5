using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MinullinDF.Sprint5.Task3.V1.Lib
{
    public class DataService : ISprint5Task3V1
    {
        public string SaveToFileTextData(int x)
        {
            double y = Math.Round((Math.Pow(x, 3) - 8)/2*Math.Pow(x, 2), 3);
            string path1 = Path.GetTempPath();
            string path2 = "OutPutFileTask3.bin";
            string path = Path.Combine(path1, path2);
            FileInfo fileInfo = new FileInfo(path);

            if (fileInfo.Exists) { File.Delete(path); }

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8)) 
            {
                writer.Write(BitConverter.GetBytes(y));
            }
                
            return path;

        }
    }
}

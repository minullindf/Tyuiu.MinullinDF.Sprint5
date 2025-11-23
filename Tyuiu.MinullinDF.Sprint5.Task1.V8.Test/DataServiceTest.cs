using Tyuiu.MinullinDF.Sprint5.Task1.V8.Lib;
namespace Tyuiu.MinullinDF.Sprint5.Task1.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = $@"D:\TYUIU\Tyuiu.MinullinDF.Sprint5\Tyuiu.MinullinDF.Sprint5.Task1.V8\bin\Debug\OutPutFileTask1.txt";
            DataService ds = new DataService();
            int sV = -5;
            int eV = 5;
            FileInfo fileinfo = new FileInfo(ds.SaveToFileTextData(sV, eV));
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}

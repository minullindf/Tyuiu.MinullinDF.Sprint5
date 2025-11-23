using Tyuiu.MinullinDF.Sprint5.Task3.V1.Lib;
namespace Tyuiu.MinullinDF.Sprint5.Task1.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = $@"D:\TYUIU\Tyuiu.MinullinDF.Sprint5\Tyuiu.MinullinDF.Sprint5.Task3.V1\bin\Debug\OutPutFileTask3.bin";
            DataService ds = new DataService();
            int x = 3;
            FileInfo fileinfo = new FileInfo(ds.SaveToFileTextData(x));
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
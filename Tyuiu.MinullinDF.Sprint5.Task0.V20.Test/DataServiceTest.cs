using Tyuiu.MinullinDF.Sprint5.Task0.V20.Lib;
namespace Tyuiu.MinullinDF.Sprint5.Task0.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = $@"D:\TYUIU\Tyuiu.MinullinDF.Sprint5\Tyuiu.MinullinDF.Sprint5.Task0.V20\bin\Debug\OutPutFileTask0.txt";
            DataService ds = new DataService();
            int x = 2;
            FileInfo fileinfo = new FileInfo(ds.SaveToFileTextData(x));
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}

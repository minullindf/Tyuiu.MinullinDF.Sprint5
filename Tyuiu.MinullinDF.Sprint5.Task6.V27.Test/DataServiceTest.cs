using Tyuiu.MinullinDF.Sprint5.Task6.V27.Lib;
namespace Tyuiu.MinullinDF.Sprint5.Task6.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = $@"C:\DataSprint5\InPutDataFileTask6V27.txt";
            DataService ds = new DataService();
            int result = ds.LoadFromDataFile(path);
            int wait = 2;
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string path = $@"C:\DataSprint5\InPutDataFileTask6V27.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}

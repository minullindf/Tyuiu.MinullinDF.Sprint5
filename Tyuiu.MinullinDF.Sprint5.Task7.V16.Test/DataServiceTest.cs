using Tyuiu.MinullinDF.Sprint5.Task7.V16.Lib;
namespace Tyuiu.MinullinDF.Sprint5.Task5.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path1 = $@"C:\DataSprint5\InPutDataFileTask7V16.txt";
            string path2 = $@"C:\DataSprint5\OutPutDataFileTask7V16.txt";
            DataService ds = new DataService();
            string newPath = ds.LoadDataAndSave(path1);
            FileInfo fileInfo = new FileInfo(path2);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}

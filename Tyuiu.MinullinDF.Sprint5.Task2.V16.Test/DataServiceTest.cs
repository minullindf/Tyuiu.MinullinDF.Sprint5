using Tyuiu.MinullinDF.Sprint5.Task2.V16.Lib;
namespace Tyuiu.MinullinDF.Sprint5.Task1.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = $@"D:\TYUIU\Tyuiu.MinullinDF.Sprint5\Tyuiu.MinullinDF.Sprint5.Task2.V16\bin\Debug\OutPutFileTask2.csv";
            DataService ds = new DataService();
            int[,] mtrx = new int[3, 3] {
                { 2, -4, -8 }, 
                { 3, -7, -2 },
                { 3, 8, 6 } };
            FileInfo fileinfo = new FileInfo(ds.SaveToFileTextData(mtrx));
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
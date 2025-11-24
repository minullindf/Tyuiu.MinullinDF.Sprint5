using Tyuiu.MinullinDF.Sprint5.Task4.V6.Lib;
namespace Tyuiu.MinullinDF.Sprint5.Task4.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = $@"C:\DataSprint5\InPutDataFileTask4V6.txt";
            var result = ds.LoadFromDataFile(path);
            double wait = 9;
            Assert.AreEqual(wait, result);
        }
    }
}

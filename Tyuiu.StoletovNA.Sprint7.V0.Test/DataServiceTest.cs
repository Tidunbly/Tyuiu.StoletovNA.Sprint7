using Tyuiu.StoletovNA.Sprint7.V0.Lib;
namespace Tyuiu.StoletovNA.Sprint7.V0.Test {
    [TestClass]
    public sealed class DataServiceTest {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.DataTableMaker("C:\\Users\\Никита\\Downloads\\DomUprProTest.csv");
            Assert.IsNotNull(res);

        }
    }
}

using Tyuiu.HoteevaEV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.HoteevaEV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Елена";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Елена", res);
        }
    }
}
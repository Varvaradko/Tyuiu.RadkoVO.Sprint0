using Tyuiu.RadkoVO.Sprint0.Task2.V0.Lib;

namespace Tyuiu.RadkoVO.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Варя";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет..., Варя", res);
        }
    }
}

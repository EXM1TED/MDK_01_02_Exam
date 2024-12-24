using MDK_01_02_Exam;

namespace UnitTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod_NegativeNumber_Minus_2()
        {
            double expected = -0.0025737674949015384;
            double actual = FuncTabulation.MainFunction(-2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod_IncludeNumber_5()
        {
            double expected = 0.002556764334277533;
            double actual = FuncTabulation.MainFunction(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod_RightBorder_17()
        {
            double expected = -0.0015781465965192375;
            double actual = FuncTabulation.MainFunction(17);

            Assert.AreEqual(expected, actual);
        }
    }
}

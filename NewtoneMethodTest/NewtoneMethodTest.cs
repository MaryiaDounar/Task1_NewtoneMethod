using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewtoneMethod;
using System.Data;

namespace Test
{
    [TestClass()]
    public class NewtoneMethodTest
    {
        public TestContext TestContext { get; set; }

        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\Data.xml",
            "TestCase",
            DataAccessMethod.Sequential)]
        [DeploymentItem("NewtoneMethodTest\\Data.xml")]
        [TestMethod]
        public void ExecuteNewtoneMethod()
        {
            double a = Convert.ToDouble(TestContext.DataRow["A"]);
            int n = Convert.ToInt32(TestContext.DataRow["N"]);
            double eps = Convert.ToDouble(TestContext.DataRow["EPS"]);
            double expected = Math.Round(Math.Pow(a, 1d / n),5);
            double actual = Math.Round(SolutionByNewtoneMethod.Execute(a, n, eps), 5);
            Assert.IsTrue(expected == actual);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Mukha_otrezki_praktika;
namespace Mukha_otrezki_testirovaniye
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UnitTestUgol()
        {
            var page = new MainWindow();
            Assert.IsTrue(page.TestUgol(5, 5, 10, 10, 10, 2, 8, 5));
            Assert.IsTrue(page.TestUgol(5, 4, 3, 2, 1, 0, -1, -2));
            Assert.IsTrue(page.TestUgol(1,2,3,4,5,6,7,8));
        }

        [TestMethod]
        public void UnitTestPovorot()
        {
            var page = new MainWindow();
            Assert.IsTrue(page.TestPovorot(5, 5, 10, 10, 0, 0, 90));
            Assert.IsTrue(page.TestPovorot(2,2,5,5,1,3,132));
            Assert.IsTrue(page.TestPovorot(10,10,5,5,0,0,16));

        }

        [TestMethod]
        public void UnitTestRazdelit()
        {
            var page = new MainWindow();
            Assert.IsTrue(page.TestRazdelit(1, 1, 10, 10, 1, 2, 3, 4));
            Assert.IsTrue(page.TestRazdelit(2,3,4,5,1,2,3,4));
            Assert.IsTrue(page.TestRazdelit(2, 2, 10, 10, 1, 2, 3, 4));
        }

        [TestMethod]
        public void UnitTestPeresechenie()
        {
            var page = new MainWindow();
            Assert.IsTrue(page.TestPeresechenie(5, 5, 10, 10, 10, 2, 8, 5));
            Assert.IsTrue(page.TestPeresechenie(1, 2, 4, 5, -1, -2, -3, -4));
            Assert.IsTrue(page.TestPeresechenie(12, 12, 4, 4, 10, 12, 8, 8));
            Assert.IsTrue(page.TestPeresechenie(-3, -4, 4, 5, -5, -8, 0, 11));
        }

        [TestMethod]
        public void UnitTestVivodOtrezka()
        {
            var page = new MainWindow();
            Assert.IsTrue(page.Vivod(5, 5, 10, 10));
            Assert.IsTrue(page.Vivod(2, 3, -1, 1));
            Assert.IsTrue(page.Vivod(-2, 0, 3, 0));
        }
    }
}

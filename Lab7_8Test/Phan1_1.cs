using App_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_8Test
{
    public class Phan1_1
    {
        Calculator _math = new Calculator();

        /// Test Phép Nhân
        [Test]
        [TestCase(1, 2, 2)]
        [TestCase(5, 6, 30)]
        [TestCase(17, 2, 34)]
        [TestCase(11, 2, 22)]
        [TestCase(14, 2, 28)]
        [TestCase(10, 25, 250)]
        [TestCase(1, 211111, 211111)]
        [TestCase(178, 2, 356)]
        [TestCase(112, 3, 336)]
        [TestCase(2, 2, 4)]
        public void phepnhanTest(double a,double b,double kq)
        {
            var result = _math.phepnhan(a, b);
            Assert.AreEqual(kq, result);
        }

        /// Test Phép nhân lỗi kiểu định dạnh
        [Test]
        [TestCase(1.2, 2)]
        public void phepnhanTest_Exception(double a, double b)
        {
            Assert.Throws<Exception>(() => _math.phepnhan(a, b));
        }



        /// Test Phép Chia
        [Test]
        [TestCase(1, 2, 0)]
        [TestCase(18, 6, 3)]
        [TestCase(14, 2, 7)]
        [TestCase(10, 2, 5)]
        [TestCase(24, 3, 8)]
        [TestCase(100, 25, 4)]
        [TestCase(75000, 250, 300)]
        [TestCase(178, 2, 89)]
        [TestCase(102, 3, 34)]
        [TestCase(2, 2, 1)]
        public void phepchiaTest(double a, double b, double kq)
        {
            var result = _math.phepchia(a, b);
            Assert.AreEqual(kq, result);
        }

        /// Test Phép chia lỗi kiểu định dạnh
        [Test]
        [TestCase(1.2, 2)]
        [TestCase(1, 2.4)]
        public void phepchiaTest_Exception(double a, double b)
        {
            Assert.Throws<Exception>(() => _math.phepchia(a, b));
        }

        /// Test Phép chia lỗi chia cho 0
        [Test]
        [TestCase(1, 0)]
        [TestCase(0, 0)]
        public void phepchiaTest_DivideByZeroException(double a, double b)
        {
            Assert.Throws<DivideByZeroException>(() => _math.phepchia(a, b));
        }
    }
}

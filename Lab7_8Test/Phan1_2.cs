using App_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_8Test
{
    public class Phan1_2
    {
        StudentGrader student = new StudentGrader();

        /// Test Xếp loại
        [Test]
        [TestCase(99, @"Xếp loại ""A""")]
        [TestCase(79, @"Xếp loại ""B""")]
        [TestCase(89, @"Xếp loại ""A""")]
        [TestCase(69, @"Xếp loại ""C""")]
        [TestCase(59, @"Xếp loại ""D""")]
        [TestCase(49, @"Xếp loại ""D""")]
        [TestCase(39, @"Xếp loại ""F""")]
        [TestCase(80, @"Xếp loại ""B""")]
        [TestCase(70, @"Xếp loại ""C""")]
        [TestCase(100, @"Xếp loại ""A""")]
        public void xeploaiTest(double diemso, string hocluc)
        {
            var result = student.xeploai(diemso);
            Assert.AreEqual(hocluc, result);
        }


        /// Test Xếp loại lỗi điểm số < 0 || >100
        [Test]
        [TestCase(999)]
        [TestCase(-79)]
        public void xeploaiTest(double diemso)
        {
            Assert.Throws<ArgumentException>(()=>student.xeploai(diemso));
        }
    }
}

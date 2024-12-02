using App_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_8Test
{
    public class Phan2
    {
        BaiHatService baiHatService = new BaiHatService();
        public List<BaiHat> listBaihat = new List<BaiHat>()
        {
            new BaiHat(){id = "1",ten="LaLung1",tenCaSi="Vu1",doDai=1,tenNhacSi="Phat1"},
            new BaiHat(){id = "2",ten="LaLung2",tenCaSi="Vu2",doDai=2,tenNhacSi="Phat2"},
            new BaiHat(){id = "3",ten="LaLung3",tenCaSi="Vu3",doDai=3,tenNhacSi="Phat3"},
            new BaiHat(){id = "4",ten="LaLung4",tenCaSi="Vu4",doDai=4,tenNhacSi="Phat4"},
            new BaiHat(){id = "5",ten="LaLung5",tenCaSi="Vu5",doDai=5,tenNhacSi="Phat5"},
        };

        //Test các trường hợp Add Ok
        [Test]
        [TestCase("6", "LaLung6", "Vu6", 6, "Phat6")]
        [TestCase("7", "LaLung7", "Vu7", 7, "Phat7")]
        [TestCase("8", "LaLung8", "Vu8", 8, "Phat8")]
        [TestCase("9", "LaLung9", "Vu9", 9, "Phat9")]
        [TestCase("10", "LaLung10", "Vu10", 10, "Phat10")]
        public void AddBaihat_Test(string id, string ten, string tenCaSi, double doDai, string tenNhacSi)
        {
            baiHatService.AddBaihat(id, ten, tenCaSi, doDai, tenNhacSi, listBaihat);
            Assert.IsTrue(listBaihat.Any(x => x.id == id));
        }

        //Test các trường hợp Add lỗi
        [Test]
        [TestCase("6", "LaLung6", "Vu6", 0, "Phat6")]
        [TestCase("7", "LaLung7", "Vu7", -1, "Phat7")]
        [TestCase("1", "LaLung8", "Vu8", 8, "Phat8")]
        [TestCase("2", "LaLung9", "Vu9", 9, "Phat9")]
        [TestCase("3", "LaLung10", "Vu10", 10, "Phat10")]
        public void AddBaihat_Exception(string id, string ten, string tenCaSi, double doDai, string tenNhacSi)
        {
            Assert.Throws<Exception>(() => baiHatService.AddBaihat(id, ten, tenCaSi, doDai, tenNhacSi, listBaihat));
        }

        //Test các trường hợp Remove Ok
        [Test]
        [TestCase("6")]
        [TestCase("7")]
        [TestCase("8")]
        [TestCase("9")]
        [TestCase("10")]
        public void RemoveBaihat_Test(string id)
        {
            baiHatService.RemoveBaihat(id,  listBaihat);
            Assert.IsTrue(listBaihat.Any(x => x.id != id));
        }

        //Test các trường hợp Remove Lỗi
        [Test]
        [TestCase("60")]
        [TestCase("70")]
        [TestCase("80")]
        [TestCase("90")]
        [TestCase("100")]
        public void RemoveBaihat_Exception(string id)
        {
            Assert.Throws<Exception>(() => baiHatService.RemoveBaihat(id, listBaihat));
        }
    }
}

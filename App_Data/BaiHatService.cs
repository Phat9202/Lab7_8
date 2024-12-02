using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Data
{
    public class BaiHatService
    {
        public BaiHatService() { }
        
        public void AddBaihat(string id, string ten, string tenCaSi, double doDai, string tenNhacSi,List<BaiHat> listBaihat)
        {
            if (doDai % 1 != 0 || doDai<=0)
            {
                throw new Exception("Độ dài bài hát phải là số nguyên dương");
            }
            if (listBaihat.Any(x => x.id == id))
            {
                throw new Exception($"Id bài hát đã tồn tại không thể thêm mới!");
            }
            listBaihat.Add(new BaiHat(){ id = id, ten = ten, tenCaSi = tenCaSi,doDai=(int)doDai,tenNhacSi = tenNhacSi});
        }

        public void UpdateBaihat(string id, string ten, string tenCaSi, double doDai, string tenNhacSi, List<BaiHat> listBaihat)
        {
            if (doDai % 1 != 0 || doDai <= 0)
            {
                throw new Exception("Độ dài bài hát phải là số nguyên dương");
            }
            if (!listBaihat.Any(x => x.id == id))
            {
                throw new Exception($"Không tồn tại Bài hát nào có id={id}");
            }
            var baihat= listBaihat.FirstOrDefault(x=>x.id == id);
            baihat.ten = ten;
            baihat.tenCaSi = tenCaSi;
            baihat.doDai = (int)doDai;
            baihat.tenNhacSi = tenNhacSi;    
        }

        public void RemoveBaihat(string id, List<BaiHat> listBaihat)
        {
            if (!listBaihat.Any(x => x.id == id))
            {
                throw new Exception($"Không tồn tại Bài hát nào có id={id}");
            }
            listBaihat.RemoveAll(x => x.id == id);
        }
    }
}

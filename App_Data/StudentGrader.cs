using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Data
{
    public class StudentGrader
    {
        public string xeploai(double diemso)
        {
            if (diemso < 0 || diemso > 100)
            {
                throw new ArgumentException("Điểm số phải nằm trong khoản 0-100");
            }
            if (diemso > 0 && diemso <= 40)
            {
                return @"Xếp loại ""F""";
            }
            else if (diemso <= 60)
            {
                return @"Xếp loại ""D""";
            }
            else if (diemso <= 70)
            {
                return @"Xếp loại ""C""";
            }
            else if (diemso <= 80)
            {
                return @"Xếp loại ""B""";
            }
            return @"Xếp loại ""A""";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Data
{
    public class Calculator
    {
        public int phepnhan(double a,double b)
        {

            if (a % 1 != 0 || b % 1 != 0)
            {
                throw new Exception("Không đúng định dạng int");
            }

            var phanso = (int)a;
            var tuso = (int)b;

            return phanso * tuso;
        }

        public int phepchia(double a, double b)
        {

            if (a % 1 != 0 || b % 1 != 0)
            {
                throw new Exception("Không đúng định dạng int");
            }
            if (b == 0)
            {
                throw new DivideByZeroException("Không thể chia cho không");
            }

            var phanso = (int)a;
            var tuso = (int)b;

            return phanso / tuso;
        }
    }
}

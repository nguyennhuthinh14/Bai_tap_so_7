using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_so_7
{
    class HinhVuong: HinhCN
    {
        public float Chuvi;
        public float Dientich;
        public float Canh
        {
            get { return Chieudai; }
            set { Chieudai = value; }
        }
        public HinhVuong() { }

        public HinhVuong(float canh)
        {
            Chieudai = canh;
        }
        public void Chuvi()
        {
            Chuvi = Dai * 4;
        }
        public void Dientich()
        {
            Dientich = Dai * Dai;
        }
    }
}

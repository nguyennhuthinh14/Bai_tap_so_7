using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_so_7
{
    class HinhCN: Hinhhoc
    {
        protected float Chieudai;
        private float Chieurong;
        public float Chuvi;
        public float Dientich;
        public float Dai
        {
            get { return Chieudai; }
            set { Chieudai = value; }
        }
        public float Rong
        {
            get { return Chieurong; }
            set { Chieurong = value; }
        }
        public HinhCN(float dai, float rong)
        {
            Chieudai = dai;
            Chieurong = rong;
        }
        public HinhCN() { }
        public void ChuVi()
        {
            Chuvi = (Chieudai + Chieurong) * 2;
        }
        public void DienTich()
        {
            Dientich = Chieudai * Chieurong;
        }
    }
}

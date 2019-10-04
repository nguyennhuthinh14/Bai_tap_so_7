using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_so_7
{
    class HinhTron; Hinhhoc
    {
        private const float pi = 3.14f;
        public float r;
        public float Chuvi;
        public float Dientich;
        public float Bankinh
        {
            get { return r; }
            set { r = value; }
        }
        public HinhTron() { }
        public HinhTron(float r)
        {
            this.r = r;
        }
        public void ChuVi()
        {
            Chuvi = r * 2 * pi;
        }
        public void DienTich()
        {
            Dientich = 2 * pi * (r * r);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWF02
{
    internal class TinhToan
    {
        public int Cong(int SoThuNhat, int SoThuHai)
        {
            return SoThuNhat + SoThuHai;
        }
        public int Tru(int SoThuNhat, int SoThuHai)
        {
            return SoThuNhat - SoThuHai;
        }
        public int Nhan(int SoThuNhat, int SoThuHai)
        {
            return SoThuNhat * SoThuHai;
        }
        public int Chia(int SoThuNhat, int SoThuHai)
        {
            return SoThuNhat / SoThuHai;
        }
    }
}

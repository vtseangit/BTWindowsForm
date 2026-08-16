using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWF03
{
    internal class clsBai3
    {
        public void TachChuoi(string hoTen, out string s1, out string s2)
        {
            string[] arr = hoTen.Split(' ');
            s1 = arr[0];
            s2 = arr[arr.Length - 1];
        }

        public bool ThuTu(int n1, int n2) { 
            if (n2 == n1 + 1)
                return true;
            else
                return false;
        }
    }
}

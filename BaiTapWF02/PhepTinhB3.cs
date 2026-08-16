using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWF02
{
    internal class PhepTinhB3
    {
        public static void NoiChuoi(string ho, string ten, out string s)
        {
            s = ho + " " + ten;
        }

        public static long GiaiThua(int n)
        {
            long gt = 1;
            for (int i = 1; i <= n; i++)
            {
                gt *= i;
            }
            return gt;
        }
    }
}
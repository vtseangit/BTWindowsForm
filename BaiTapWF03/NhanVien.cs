using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWF03
{
    internal class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public double HeSoLuong { get; set; }
        public double HeSoPhuCap { get; set; }

        public NhanVien(string maNV, string hoTen, DateTime ngaySinh, double heSoLuong, double heSoPhuCap)
        {
            MaNV = maNV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            HeSoLuong = heSoLuong;
            HeSoPhuCap = heSoPhuCap;
        }

        public double TongLuong()
        {
            return HeSoLuong + HeSoPhuCap * 1150000;
        }
        public string HienThi()
        {
            return $"Mã NV: {MaNV} | Họ tên: {HoTen} | Ngày sinh: {NgaySinh.ToShortDateString()}" +
                $"\nHệ số lương: {HeSoLuong} | Hệ số phụ cấp : {HeSoPhuCap}\n" +
                $"\n=> là: {TongLuong():N0} VND";
        }
    }
}
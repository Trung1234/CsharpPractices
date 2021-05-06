using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyGiaoVien.Models
{
    public class GiaoVien : NguoiLaoDong
    {
        private int heSoLuong;
        public GiaoVien()
        {
        }

        /// <summary>
        /// overload trong contructor ở class GiaoVien
        /// </summary>
        /// <param name="hoTen"></param>
        /// <param name="namSinh"></param>
        /// <param name="luongCoBan"></param>
        public GiaoVien(string hoTen, int namSinh, int luongCoBan) : base(hoTen, namSinh, luongCoBan)
        {
        }
        public void NhapThongTin(int heSoLuong)
        {
            this.heSoLuong = heSoLuong;
        }
        public override double TinhLuong()
        {
            return base.TinhLuong()* heSoLuong*1.25;
        }

        public override void XuatThongtin()
        {
            base.XuatThongtin();
            Console.WriteLine("he so luong la: " + heSoLuong + ", luong : " + TinhLuong());
        }
        public double XuLy()
        {
            return heSoLuong + 0.6;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyGiaoVien.Models
{
    public abstract class NguoiLaoDong
    {
        private string hoTen;
        private int namSinh;
        private int luongCoBan;
        public NguoiLaoDong() { }

        /// <summary>
        /// overload trong contructor ở class NguoiLaoDong
        /// </summary>
        /// <param name="hoTen"></param>
        /// <param name="namSinh"></param>
        /// <param name="luongCoBan"></param>
        public NguoiLaoDong(string hoTen, int namSinh, int luongCoBan)
        {
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.luongCoBan = luongCoBan;   
        }
        public virtual double TinhLuong()
        {
            return luongCoBan;
        }
        public virtual void XuatThongtin()
        {
            Console.WriteLine("Ho ten la: "+hoTen+", nam sinh: "+ namSinh + ", luong co ban: "+luongCoBan+".");
        }
    }
}

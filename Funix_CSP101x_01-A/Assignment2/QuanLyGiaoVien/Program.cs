using QuanLyGiaoVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyGiaoVien
{
    class Program
    {
        static void Main(string[] args)
        {
            List<GiaoVien> listGiaoVien = new List<GiaoVien>();
            string hoTen;
            int namSinh;
            int luongCoBan;
            int heSoLuong;
            while (true)
            {
                Console.WriteLine("moi nhap vao ho ten giao vien ");
                hoTen = Console.ReadLine();
                try
                {
                    Console.WriteLine("moi nhap vao nam sinh giao vien ");
                    namSinh = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("moi nhap vao luong Co Ban  giao vien ");
                    luongCoBan = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("moi nhap vao he so luong  giao vien ");
                    heSoLuong = Int32.Parse(Console.ReadLine());
                    //NhapThongTin
                }
                catch 
                {
                    Console.WriteLine("thong tin nhap vao khong hop le, xin moi nhap lai thong tin giao vien");
                    continue;
                }
                Console.WriteLine("Hay nhap vao phim H de ket thuc");
                GiaoVien giaoVien = new GiaoVien(hoTen, namSinh, luongCoBan);
                giaoVien.NhapThongTin(heSoLuong);
                listGiaoVien.Add(giaoVien);
                var key = Console.ReadKey();
                
                if (key.Key == ConsoleKey.H)
                    HienThiThongTin(listGiaoVien);
                Console.WriteLine();
                continue;
            }
        }
        static void HienThiThongTin(List<GiaoVien> listGiaoVien)
        {          
            if(listGiaoVien != null)
            {
                if (listGiaoVien.Count > 0)
                {
                    GiaoVien giaoVienLuongThap = listGiaoVien.First();
                    double luongThapNhat = giaoVienLuongThap.TinhLuong();
                    Console.WriteLine("Giao vien co luong thap nhat");
                    for (int i = 1; i < listGiaoVien.Count; i++)
                    {
                        if (listGiaoVien[i].TinhLuong() < luongThapNhat)
                        {
                            luongThapNhat = listGiaoVien[i].TinhLuong();
                            giaoVienLuongThap = listGiaoVien[i];
                        }
                    }
                    //GiaoVien giaoVienLuongThap = listGiaoVien.FirstOrDefault(y => y.TinhLuong() == luongThapNhat);
                    giaoVienLuongThap.XuatThongtin();
                    Console.WriteLine("Thong tin cac giao vien");
                    foreach (var giao in listGiaoVien)
                    {
                        giao.XuatThongtin();
                    }
                }              
            }
            
        }
    }
}

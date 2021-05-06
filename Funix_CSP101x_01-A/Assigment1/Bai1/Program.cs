using System;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://courses.funix.edu.vn/courses/course-v1:FUNiX+CSP101x_01-A_VN+2020_T5/courseware/3a8c750402a24420904c42983322073a/5fcdd7763b1849658c86b6371c519cda/?activate_block_id=block-v1%3AFUNiX%2BCSP101x_01-A_VN%2B2020_T5%2Btype%40sequential%2Bblock%405fcdd7763b1849658c86b6371c519cda
            int dayLon = 0;
            int dayNho = 0;
            int chieuCao = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Nhap vao day lon : ");
                    dayLon = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap vao day nho : ");
                    dayNho = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap vao chieu cao : ");
                    chieuCao = Int32.Parse(Console.ReadLine());
                    if(dayLon <= 0 || dayNho <= 0 || chieuCao <= 0)
                    {
                        Console.WriteLine("Hay nhap vao so lon hon 0");
                        Console.WriteLine("xin moi nhap lai");
                        continue;
                    }
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("xin moi nhap lai");
                    continue;
                }
            }
            
            double dienTich = TinhDienTichHinhThang(dayLon, dayNho, chieuCao);
            Console.WriteLine("Dien tich hinh thang la : {0} ", dienTich);
            Console.ReadLine();
        }

        static double TinhDienTichHinhThang(int dayLon, int dayNho, int chieuCao)
        {
            return (dayLon + dayNho) * chieuCao / 2;
        }
    }
}

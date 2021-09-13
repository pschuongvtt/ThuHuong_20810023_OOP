using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;

namespace ThuHuong_Tuan02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Kết quả : 
            Program p = new Program();
            p.XepLoaiDiemTB();
            p.XuatSoNgayThang();
            p.BaiO6();
            p.Bai07();
            p.Bai08();
            p.Bai09();
            p.Bai10();
            p.Bai11();
            p.Bai12();
            Console.ReadKey();
        }

        private void XepLoaiDiemTB()
        {
            Console.WriteLine("---------------------ThuHuong - XepLoaiTB --------------------- ");    
            Console.WriteLine("Mời bạn nhập điểm toán");
            double diemtoan = (Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Mời bạn nhập điểm lý");
            double diemly = (Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Mời bạn nhập điểm hóa");
            double diemhoa = (Convert.ToDouble(Console.ReadLine()));

            double diemtb = (diemtoan + diemly + diemhoa) * 1.0 / 3;
            if (diemtb < 5)
                Console.WriteLine("Xếp loại Yếu : {0}\n\n\n", Math.Round(diemtb, 2));
            else if (diemtb < 6.5)
                Console.WriteLine("Xếp loại Trung bình : {0}\n\n\n", Math.Round(diemtb, 2));
            else if (diemtb < 8)
                Console.WriteLine("Xếp loại Khá : {0}\n\n\n", Math.Round(diemtb, 2));
            else if (diemtb < 9)
                Console.WriteLine("Xếp loại Giỏi : {0}\n\n\n", Math.Round(diemtb, 2));
            else Console.WriteLine("Xếp loại Xuất sắc {0}\n\n\n", Math.Round(diemtb, 2));
        }

        private void XuatSoNgayThang()
        {
            Console.WriteLine("---------------------ThuHuong - XuatSoNgayCuaThang--------------------- ");
            Console.WriteLine("Mời bạn nhập tháng");
            byte thang = (Convert.ToByte(Console.ReadLine()));
            switch (thang)
            {
                case 1:case 3:case 5:case 7:case 8:case 10:case 12:
                    Console.WriteLine("Tháng {0} có 31 ngày\n\n\n", thang);
                    break;
                case 2:
                    Console.WriteLine("Mời bạn nhập năm\n\n\n");
                    short nam = short.Parse(Console.ReadLine());
                    if ((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0)
                        Console.WriteLine("Tháng {0} có 29 ngày\n\n\n", thang);
                    else Console.WriteLine("Tháng {0} có 28 ngày\n\n\n", thang);
                    break;
                default:
                    Console.WriteLine("Tháng {0} có 30 ngày\n\n\n", thang);
                    break;
            }
        }

        private void BaiO6()
        {
            /*Bài 6: Viết chương trình nhập năm sinh. Tính tuổi 
             * . Nếu >= 18. Xuất thông báo "Bạn đủ tuổi để lái xe"
             * . Ngược lại : Xuất thông báo "Bạn chưa dủ tuổi đê lái xe"
             */
            Console.WriteLine("---------------------ThuHuong - Bai 6--------------------- ");
            Console.WriteLine("Mời bạn nhập năm sinh: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((DateTime.Now.Year) - year >= 18)
                Console.WriteLine("Bạn đủ tuổi để lái xe \n\n\n");
            else Console.WriteLine("Bạn chưa đủ tuổi để lái xe \n\n\n");

        }

        private void Bai07()
        {
            /*Bài 07: Viết chương trình yêu cầu người dùng nhập vào số cân nặng(kg), chiều cao(m)
             Tính chỉ số BMI*/
            Console.WriteLine("---------------------ThuHuong - Bai 7--------------------- ");
            Console.WriteLine("Mời bạn nhập cân nặng (kg): ");
            double cannang = (Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Mời bạn nhập chiều cao (m): ");
            double chieucao = (Convert.ToDouble(Console.ReadLine()));

            double bmi = Math.Round(cannang / (chieucao * chieucao), 1);
            string[] columnNames = { "BMI", "Thể trạng" };
            string[] kq = new string[2];
            var table = new ConsoleTable(columnNames);
            if (bmi >= 40.0)
            {
                kq[0] = ">= 18.5";
                kq[1] = "Béo phì cấp độ 3";
            }
            else if (bmi > 35.0 && bmi <= 39.9)
            {
                kq[0] = "35.0 - 39.9";
                kq[1] = "Béo phì cấp độ 2";
            }
            else if (bmi > 30.0 && bmi <= 34.9)
            {
                kq[0] = "30.0 - 34.9";
                kq[1] = "Béo phì cấp độ 1";
            }
            else if (bmi > 35.0 && bmi <= 39.9)
            {
                kq[0] = "25.0 - 24.9";
                kq[1] = "Thừa cân";
            }
            else if (bmi > 30.0 && bmi <= 34.9)
            {
                kq[0] = "18.5 - 24.9";
                kq[1] = "Cân đối";
            }
            else
            {
                kq[0] = "<18.5";
                kq[1] = "Gầy";
            }

            table.Rows.Add(kq);
            table.Write(Format.Alternative);
            Console.Write("\n\n\n");
        }
        private void Bai08()
        {
            /*Bài 08 : Viết chương trình tính tiền cho 1 cửa hàng quần áo*/
            Console.WriteLine("---------------------ThuHuong - Bai 8--------------------- ");
            Console.WriteLine("Nhập số lượng áo cần mua ban đầu: ");
            int slao = Convert.ToInt32(Console.ReadLine());
            const double giaban = 200000;
            double tongtien;
            int soaodu = slao % 5;
            int soluongaotang = slao / 5;
            if (slao >= 5)
                tongtien = 5 * giaban + (slao - 5) * giaban * 0.9;
            else tongtien = slao * giaban;
            Console.WriteLine("--> Tổng tiền phải trả: {0} VNĐ.\n--> Số lượng áo đã mua: {1} \n\n\n", tongtien, slao + soluongaotang);
        }

        private void Bai09()
        {
            /*Bài 09: Viết chương trình cho nhập số giờ đổ xe 
             Tính và in ra tiền đổ xe cho khách hàng 
             */
            Console.WriteLine("---------------------ThuHuong - Bai 9--------------------- ");
            Console.WriteLine("Nhập số giờ đổ xe : ");
            double sogio = Convert.ToDouble(Console.ReadLine());
            if (sogio<=3.0)
                Console.WriteLine("Số tiền đổ xe của khách hàng: 40000\n\n\n");
            else if (sogio >= 24.0)
                Console.WriteLine("Số tiền đổ xe của khách hàng: 200000\n\n\n");
            else Console.WriteLine("Số tiền đổ xe của khách hàng: {0}\n\n\n", (sogio - 3)*10000 + 40000);
        }
        
        private void Bai10()
        {
            /*Bài 10: Viết chương trình nhập điểm trung bình của 3 năm học phổ thông. 
             Xuất điểm trung bình cả 3 năm học, và quà tặng đi kèm nếu có */
            Console.WriteLine("---------------------ThuHuong - Bai 10--------------------- ");
            Console.WriteLine("Mời bạn nhập điểm trung bình năm nhất : ");
            double dtb1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập điểm trung bình năm hai : ");
            double dtb2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập điểm trung bình năm ba : ");
            double dtb3 = Convert.ToDouble(Console.ReadLine());

            string thongbao = "";
            double dtb = Math.Round((dtb1+dtb2+dtb3)/3, 2);
            if (dtb >=8.5)
                thongbao = "Bạn được tặng 1 chiếc xe đạp leo núi";
            else
            {
                if (dtb >= 6.5)
                    thongbao = "Bạn được tặng 1 chiếc balo";
                else thongbao = "Bạn không được tặng quà. Hãy học chăm chỉ hơn";
            }

            Console.WriteLine("==> Điểm trung bình năm nhất : {0}, Điểm trung bình năm 2 : {1}, Điểm trung bình năm 3 : {2}", dtb1, dtb2, dtb3);
            Console.WriteLine("==> Điểm trung bình 3 năm học của bạn : {0}",dtb);
            Console.WriteLine("{0}\n\n\n", thongbao);
        }

        private void Bai11()
        {
            /*Bài 11 : Viết chương trình nhập lượng MB cần tính 
             Viết chương trình tính cước ADSL*/
            Console.WriteLine("---------------------ThuHuong - Bai 11--------------------- ");
            Console.WriteLine("Mời bạn nhập lượng MB cần dùng: ");
            double luongmb = Convert.ToDouble(Console.ReadLine());
            double thanhtien = 0; 

            //Hiển thị kết quả theo yêu cầu 
            Console.WriteLine("==> Phiếu thanh toán:");
            Console.WriteLine("  Lượng MB\t\t Đơn giá\t\t Thành tiền");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------");
            if (luongmb <= 500)
	        {
                thanhtien = luongmb * 60;
                Console.WriteLine("{0, 10} {1, 22} {2, 25}", luongmb, 60, luongmb * 60);
            }
            else
            {
                if (luongmb <= 850)
                {
                    thanhtien = 500 * 60 + ((luongmb - 500) * 55);
                    Console.WriteLine("{0, 10} {1, 22} {2, 25}", 500, 60, 500 * 60);
                    Console.WriteLine("{0, 10} {1, 22} {2, 25}", luongmb - 500, 55, (luongmb - 500) * 55);
                }
                else if (luongmb <= 1100)
                {
                    thanhtien = 500 * 60 + 350 * 55 + ((luongmb - 850) * 45);
                    Console.WriteLine("{0, 10} {1, 22} {2, 25}", 500, 60, 500 * 60);
                    Console.WriteLine("{0, 10} {1, 22} {2, 25}", 350, 55, 350 * 55);
                    Console.WriteLine("{0, 10} {1, 22} {2, 25}", luongmb - 850, 45, (luongmb - 850) * 45);
                }
                else if (luongmb <= 1300)
                {
                    thanhtien = 500 * 60 + 350 * 55 + 250 * 45 + ((luongmb - 1100) * 30);
                    Console.WriteLine("{0, 10} {1, 22} {2, 25}", 500, 60, 500 * 60);
                    Console.WriteLine("{0, 10} {1, 22} {2, 25}", 350, 55, 350 * 55);
                    Console.WriteLine("{0, 10} {1, 22} {2, 25}", 250, 45, 250 * 45);
                    Console.WriteLine("{0, 10} {1, 22} {2, 25}", luongmb - 1100, 30, (luongmb - 1100) * 30);
                }
                else
                {
                    thanhtien = 500 * 60 + 350 * 55 + 250 * 45 + 200 * 30 + ((luongmb - 1300) * 15);
                    Console.WriteLine("{0, 10} {1, 22} {2, 25}", 500, 60, 500 * 60);
                    Console.WriteLine("{0, 10} {1, 22} {2, 25}", 350, 55, 350 * 55);
                    Console.WriteLine("{0, 10} {1, 22} {2, 25}", 250, 45, 250 * 45);
                    Console.WriteLine("{0, 10} {1, 22} {2, 25}", 200, 30, 200 * 30);
                    Console.WriteLine("{0, 10} {1, 22} {2, 25}", luongmb - 1300, 15, (luongmb - 1300) * 15);
                }
            }
            
                
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Cộng {0,5} {1,48}\n\n\n", luongmb, thanhtien);
        }

        private void Bai12()
        {
            /*Bài 12 : Viết chương trình tính can chi dựa vào năm cho trước */
            Console.WriteLine("---------------------ThuHuong - Bai 11--------------------- ");
            Console.WriteLine("Mời bạn nhập năm cần tính can chi: ");
            short namsinh = short.Parse(Console.ReadLine());
            
            //Xử lý
            string can = "";
            switch (namsinh % 10)
            {
                case 0:
                    can = "CANH";
                    break;
                case 1:
                    can = "TÂN";
                    break;
                case 2:
                    can = "NHÂM";
                    break;
                case 3:
                    can = "QUÝ";
                    break;
                case 4:
                    can = "GIÁP";
                    break;
                case 5:
                    can = "ẤT";
                    break;
                case 6:
                    can = "BÍNH";
                    break;
                case 7:
                    can = "ĐINH";
                    break;
                case 8:
                    can = "MẬU";
                    break;
                case 9:
                    can = "KỶ";
                    break;
            }
            string chi = "";
            switch (namsinh % 12)
            {
                case 0:
                    chi = "THÂN";
                    break;
                case 1:
                    chi = "DẬU";
                    break;
                case 2:
                    chi = "TUẤT";
                    break;
                case 3:
                    chi = "HỢI";
                    break;
                case 4:
                    chi = "TÝ";
                    break;
                case 5:
                    chi = "SỬU";
                    break;
                case 6:
                    chi = "DẦN";
                    break;
                case 7:
                    chi = "MẸO";
                    break;
                case 8:
                    chi = "THÌN";
                    break;
                case 9:
                    chi = "TỴ";
                    break;
                case 10:
                    chi = "NGỌ";
                    break;
                case 11:
                    chi = "MÙI";
                    break;
            }

            //Xuất KQ 
            Console.WriteLine("==> Năm sinh {0} của bạn là năm: {1} {2}",namsinh ,can, chi);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;

namespace ThuHuong_Tuan01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Kết quả : 
            Program p = new Program();
            p.BaiO1();
            p.BaiO2();
            p.BaiO3();
            p.BaiO4();
            p.BaiO5();
            Console.ReadKey();
        }
       
        private void BaiO1()
        {

            /*Bài 1 : Mời người dùng nhập họ tên. Xuất tên, tuổi ở hiện tại và tuổi 2025*/
            string name;
            int year;

            //Xử lý nhập Họ Tên
            Console.WriteLine("---------------------ThuHuong - Bai 1--------------------- ");
            Console.WriteLine("Mời bạn nhập Họ Tên: ");
            name = Console.ReadLine();

            //Xử lý nhập năm sinh : 
            Console.WriteLine("Mời bạn nhập năm sinh: ");
            year = Convert.ToInt32(Console.ReadLine());

            //Hiển thị kết quả 
            Console.WriteLine("Hi {0}. Năm nay bạn {1} tuổi. Tuổi của bạn năm 2025 sẽ là {2} \n\n\n", name, (DateTime.Now.Year) - year, 2025 - year);

        }
        private void BaiO2()
        {
            /*Bài 2 : Yêu cầu người dùng nhập vào lương chính thức. 
            Viết chương trình tính lương thử việc, biết rằng lương thử việc bằng 85% lương chính thức*/
            decimal luongchinhthuc;

            //Xử lý nhập lương chính thức
            Console.WriteLine("---------------------ThuHuong - Bai 2--------------------- ");
            Console.WriteLine("Mời bạn nhập lương chính thức: ");
            luongchinhthuc = Convert.ToDecimal(Console.ReadLine());

            //Hiện thị kết quả 
            Console.WriteLine("- Lương chính thức của bạn là : {0}\n- Lương thử việc của bạn bằng 85% lương chính thức là : {1} \n\n\n", luongchinhthuc, (luongchinhthuc * 85 / 100));

        }
        private void BaiO3()
        {
            /*Bài 3 : Yêu cầu người dùng nhập vào số lượng nam sinh, nữ sinh và sỉ số của 1 lớp học. 
            Viết chương trình quy đổi số lượng nam sinh, nữ sinh chiếm bao nhiêu % trong lớp học*/
            int slnamsinh;
            int slnusinh;

            //Xử lý nhập 
            Console.WriteLine("---------------------ThuHuong - Bai 3--------------------- ");
            Console.WriteLine("Mời bạn nhập số lượng nam sinh: ");
            slnamsinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập số lượng nữ sinh: ");
            slnusinh = Convert.ToInt32(Console.ReadLine());

            //Hiển thị thông tin kết quả 
            Console.WriteLine("Nam sinh chiếm {0} % học sinh trong lớp. Nữ sinh chiếm {1}% số học sinh trong lớp  \n\n\n", Math.Round((slnamsinh * 1.0) / (slnamsinh + slnusinh) * 100, 1), Math.Round(100 - ((slnamsinh * 1.0) / (slnamsinh + slnusinh) * 100)),1);

        }
        private void BaiO4()
        {
            /*Bài 4 : Yêu cầu người dùng nhập vào sỉ số lớp học và số lượng sinh viên vắng học
            Viết chương trình quy đổi tỉ lệ % số lượng học sinh hiện diện và vắng mặt trong lớp*/
            int sisolophoc;
            int slvanghoc;

            //Xử lý nhập 
            Console.WriteLine("---------------------ThuHuong - Bai 4--------------------- ");
            Console.WriteLine("Mời bạn nhập sỉ số: ");
            sisolophoc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập số lượng hs vắng học: ");
            slvanghoc = Convert.ToInt32(Console.ReadLine());

            //Hiển thị thông tin kết quả 
            Console.WriteLine("Tỷ lệ chuyên cần: {0}%. Tỷ lệ vắng học: {1}% \n\n\n", Math.Round(100 - ((slvanghoc * 1.0 / sisolophoc) * 100), 1), Math.Round((slvanghoc * 1.0 / sisolophoc) * 100),1);

        }
        private void BaiO5()
        {
            /*Bài 5 : Yêu cầu nhập số tiền cần gửi và kỳ hạn gửi. 
             Tính lãi suất hàng tháng và tổng tiền gửi(vốn + lãi) sau khi hạn*/
            double sotiengui;
            int kyhan;

            //Xử lý nhập 
            Console.WriteLine("---------------------ThuHuong - Bai 5--------------------- ");
            Console.WriteLine("Mời bạn nhập số tiền cần gửi: ");
            sotiengui = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập kỳ hạn cần gửi: ");
            kyhan = Convert.ToInt32(Console.ReadLine());

            //Hiển thị thông tin kết quả 
            Console.WriteLine("Lãi suất năm : 7%\n--> Lãi suất hàng tháng: {0} VNĐ. Tổng tiền gửi sau kì hạn {1} VNĐ \n\n\n", Math.Round((sotiengui * 0.07) / 12, 1), Math.Round(sotiengui + (((sotiengui * 0.07) / 12) * kyhan), 1));

        }

    }
}

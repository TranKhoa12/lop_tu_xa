using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai01_cong3so
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so thu nhat: ");
            int soThuNhat = int.Parse(Console.ReadLine()); //nhap so thu nhat

            Console.WriteLine("Nhap so thu hai: ");
            int soThuHai = int.Parse(Console.ReadLine()); //nhap so thu hai

            Console.WriteLine("Nhap so thu ba: ");
            int soThuBa = int.Parse(Console.ReadLine()); //nhap so thu ba

            int tong = soThuNhat + soThuHai + soThuBa;
            Console.WriteLine("Tong 3 so la: " + tong); // nội dung tong 3 so

            // ctrl + k + d để format code

        }
    }
}

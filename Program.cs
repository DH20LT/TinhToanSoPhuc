using System;
using System.Text;

namespace ComplexNumberCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            SoPhuc[] soPhuc = new SoPhuc[10];
            int LuongSoPhuc = 0;
            do
            {
                Console.WriteLine("1. Thêm số phức");
                Console.WriteLine("5. Hiện tất cả số phức");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("Chọn Chức Năng");
                int iChucNang = int.Parse(Console.ReadLine());
                switch (iChucNang)
                {
                    case 0: //Exit
                        Environment.Exit(0);
                        break;
                    case 1: //Add
                        {
                            Console.WriteLine("Nhập số phức:");
                            soPhuc[LuongSoPhuc] = new SoPhuc();
                            soPhuc[LuongSoPhuc].NhapSoPhuc();
                            LuongSoPhuc++;
                        }
                    case 2: //Show
                        {
                            Console.WriteLine("Hiện tất cả số phức:");
                            for (int i = 0; i < soPhuc.Length; i++)
                            {
                                soPhuc[i].HienSoPhuc();
                            } 
                        }
                    default:
                }
            } while (true);
        }
    }
}

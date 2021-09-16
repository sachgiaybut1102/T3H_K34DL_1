using FirstAppWinform.Chuong3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppWinform
{
    class Program
    {
        static void Main(string[] args)
        {
            IDongVatTrenCan conEch = new ConEch();
            IDongVatTrenCan suTu = new SuTu();

            conEch.Di();
            suTu.Di();

            Console.ReadLine();
        }

        private static void TaoMang()
        {
            //Đề bài: XD c/tr cho phép nhập vào 1 dẫy số nguyên. Tính tổng của dãy số đó

            int n; //Khai báo biến n lưu trữ số lượng phần tử

            Console.Write("Nhap so phan tu cua day so: ");
            do
            {
                n = int.Parse(Console.ReadLine()); //Gán Nhận giá trị từ bàn bím và ép kiểu sang int để gán cho n
            }
            while (n <= 0);

            Int16[] arr = new Int16[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("A[{0}] = ", i + 1);
                arr[i] = Int16.Parse(Console.ReadLine());
            }

            Int16 s = 0;

            for (int i = 0; i < n; i++)
            {
                s += arr[i];
            }

            Console.Write("Tong day so bang: {0}", s);
        }

        private static void TimSoLonNhat(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine("a lon hon b");
            }
            else
            {
                Console.WriteLine("b lon hon a");
            }
        }

        private static void TimSoLonNhat(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                Console.WriteLine("a lon nhat");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("b lon nhat");
            }
            else
            {
                Console.WriteLine("c lon nhat");
            }
        }

        private static void HoanVi(int a, int b)
        {
            int tam = a;
            a = b;
            b = tam;
            Console.WriteLine("Trong HoanVi: a = " + a + ";b = " + b);
        }
        static void HoanVi(ref int a, ref int b)
        {
            int tam = a;
            a = b;
            b = tam;
            Console.WriteLine("Trong HoanVi: a = " + a + ";b = " + b);
        }
    }
}

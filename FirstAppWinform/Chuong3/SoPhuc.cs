using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppWinform.Chuong3
{
    /// <summary>
    /// Ví dụ về nạp chồng
    /// </summary>
    public class SoPhuc
    {
        private double _phanThuc;
        public double PhanThuc
        {
            get
            {
                return _phanThuc;
            }

            set
            {
                _phanThuc = value;
            }
        }

        private double _phanAo;
        public double PhanAo
        {
            get
            {
                return _phanAo;
            }

            set
            {
                _phanAo = value;
            }
        }

        public SoPhuc()
        {
            _phanAo = 0;
            _phanThuc = 0;
        }

        public SoPhuc(double phanThuc, double phanAo)
        {
            _phanThuc = phanThuc;
            _phanAo = phanAo;
        }

        public static SoPhuc Cong(SoPhuc a, SoPhuc b)
        {
            SoPhuc soPhuc = new SoPhuc();

            soPhuc._phanThuc = a._phanThuc + b._phanThuc;
            soPhuc._phanAo = a._phanAo + b._phanAo;

            return soPhuc;
        }

        public static SoPhuc Cong(SoPhuc a, double b)
        {
            SoPhuc soPhuc = new SoPhuc();

            soPhuc._phanThuc = a._phanThuc + b;
            soPhuc._phanAo = a._phanAo;

            return soPhuc;
        }

        public static SoPhuc operator +(SoPhuc a, SoPhuc b)
        {
            SoPhuc soPhuc = new SoPhuc();

            soPhuc._phanThuc = a._phanThuc + b._phanThuc;
            soPhuc._phanAo = a._phanAo + b._phanAo;

            return soPhuc;
        }

        public static SoPhuc operator +(SoPhuc a, double b)
        {
            SoPhuc soPhuc = new SoPhuc();

            soPhuc._phanThuc = a._phanThuc + b;
            soPhuc._phanAo = a._phanAo;

            return soPhuc;
        }

        public void In()
        {
            Console.Write("({0} , {1})", _phanThuc, _phanAo);
        }
    }
}

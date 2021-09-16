using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppExample.Hoc.Chuong3
{
    public class HinhChuNhat : Hinh
    {
        protected double _chieuDai;
        public double ChieuDai
        {
            get
            {
                return _chieuDai;
            }

            set
            {
                _chieuDai = value;
            }
        }

        protected double _chieuRong;
        public double ChieuRong
        {
            get
            {
                return _chieuRong;
            }

            set
            {
                _chieuRong = value;
            }
        }

        public HinhChuNhat()
        {
            _chieuDai = 0;
            _chieuRong = 0;
        }

        public HinhChuNhat(double chieuDai, double chieuRong)
        {
            _chieuDai = chieuDai;
            _chieuRong = chieuRong;
        }

        public override double DienTich()
        {
            return _chieuDai * _chieuRong;
        }
    }
}

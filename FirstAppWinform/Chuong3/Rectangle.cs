using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppWinform.Chuong3
{
    public class Rectangle : Shapes
    {
        private double _width;
        public double Width
        {
            get
            {
                return _width;
            }

            set
            {
                _width = value;
            }
        }

        private double _height;
        public double Height
        {
            get
            {
                return _height;
            }

            set
            {
                _height = value;
            }
        }

        /// <summary>
        /// Hàm tạo có tham số, trong trường hợp tham số = null thì sẽ đặt mặc định là 0
        /// </summary>
        /// <param name="width"></param>
        /// <param name="heght"></param>
        public Rectangle(double width = 0, double heght = 0)
        {
            _width = width;
            _height = heght;
        }

        public Rectangle()
        {
            _width = 0;
            _height = 0;
        }

        /// <summary>
        /// Tính diện tích
        /// </summary>
        /// <returns></returns>
        public override double GetArea()
        {
            return _width * _height;
        }
    }
}

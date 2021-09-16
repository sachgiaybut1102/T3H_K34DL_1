using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppWinform.Chuong3
{
    public class Square : Rectangle
    {
        /// <summary>
        /// Gán giá trị cho hàm tạo của lớp Base (cha)
        /// </summary>
        /// <param name="a"></param>
        public Square(double a) : base(a, a)
        {
        }
    }
}

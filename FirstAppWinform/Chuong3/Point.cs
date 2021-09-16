using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppWinform.Chuong3
{
    public class Point
    {
        private int x_;
        public int X
        {
            get
            {
                return x_;
            }

            set
            {
                x_ = value;
            }
        }

        private int y_;
        public int Y
        {
            get
            {
                return y_;
            }

            set
            {
                y_ = value;
            }
        }

        private static string nameSatatic_;
        public string NameSatatic
        {
            get
            {
                return nameSatatic_;
            }

            set
            {
                nameSatatic_ = value;
            }
        }

        public static string NameSatatic2
        {
            get
            {
                return nameSatatic_;
            }

            set
            {
                nameSatatic_ = value;
            }
        }

        private string nameDynamic_;
        public string NameDynamic
        {
            get
            {
                return nameDynamic_;
            }

            set
            {
                nameDynamic_ = value;
            }
        }

        /// <summary>
        /// Dùng để thay đổi tọa của point từ vị trí hiện tại sang vị trí khác
        /// </summary>
        /// <param name="dx">là khoảng cách từ x đến điểm x mới</param>
        /// <param name="dy">là khoảng cách từ y đến điểm y mới</param>
        public void Move(int dx, int dy)
        {
            x_ += dx;
            y_ += dy;
        }

        public void Show()
        {
            Console.WriteLine("Coordinates: ({0} , {1})", x_, y_);
        }

        public void Input()
        {
            Console.WriteLine("Enter your coordiantes:");

            x_ = GetInput("x");
            y_ = GetInput("y");
        }

        public int GetInput(string name)
        {
            bool flag = true;

            int num;

            do
            {
                flag = true;

                Console.Write("{0} = ", name);

                if (!int.TryParse(Console.ReadLine(), out num))
                {
                    flag = false;

                    Console.WriteLine("The data is not in the correct format, please try agin!!!!");
                }
            } while (!flag);

            return num;
        }
    }
}

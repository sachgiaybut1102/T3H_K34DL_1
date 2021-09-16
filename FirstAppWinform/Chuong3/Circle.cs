﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppWinform.Chuong3
{
    public class Circle : Shapes
    {
        private double _r;
        public double R
        {
            get
            {
                return _r;
            }

            set
            {
                _r = value;
            }
        }

        public Circle()
        {

        }

        public Circle(double r = 0)
        {
            _r = r;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(_r, 2);
        }
    }
}

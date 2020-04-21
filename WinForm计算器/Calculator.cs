using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm计算器
{
    class Calculator
    {
        public double NumOne
        {
            get;
            set;
        }

        public double NumTwo
        {
            get;
            set;
        }

        public double Add()
        {
            return NumOne + NumTwo;
        }

        public double Sub()
        {
            return NumOne - NumTwo;
        }

        public double Mul()
        {
            return NumOne * NumTwo;
        }

        public double Div()
        {

            return NumOne/NumTwo;
        }

    }
}

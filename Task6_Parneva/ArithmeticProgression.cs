using System;
using System.Collections.Generic;
using System.Text;

namespace Task6_Parneva
{
    public class ArithmeticProgression : IIndexableSeries
    {

        public double this[int index] => _start + ( index - 1)*_x;
        double _now;
        int _x;
        double _start;
        public double GetCurrent()
        {
           
            return _now;
        }

        public bool MoveNext()
        {
            _now += _x;
            return true;
        }

        public void Reset()
        {
            _now = _start;
        }
        public ArithmeticProgression(int x, double start)
        {
            _x = x;
            _start = start;
            _now = start;
        }


    }
}

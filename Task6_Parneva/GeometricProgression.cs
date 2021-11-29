using System;
using System.Collections.Generic;
using System.Text;

namespace Task6_Parneva
{
    public class GeometricProgression : IIndexableSeries
    {
     

        public double this[int index] => _start *Math.Pow(_x,(index - 1));

        int _x;
        double _start;
        double _now;
        public double GetCurrent()
        {
          
            return _now;
        }

        public bool MoveNext()
        {
            _now *= _x;
            return true;
        }

        public void Reset()
        {
            _now = _start;
        }
        public GeometricProgression(int x, double start)
        {
            _x = x;
            _start = start;
            _now = start;
        }
        

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Task6_Parneva
{
    public interface ISeries
    {
        double GetCurrent();
        bool MoveNext();
        void Reset();
    }
}

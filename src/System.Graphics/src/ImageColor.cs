using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Graphics
{
    public struct ImageColor
    {
        internal ImageColor(int colorIndex)
        {
            ColorIndex = colorIndex;
        }

        internal int ColorIndex;
    }
}

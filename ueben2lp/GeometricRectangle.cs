using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ueben2lp
{
    public class GeometricRectangle : GeometricObject
    {
        private int height;
        private int width;
    }

    public class GeometricTriangle : GeometricObject
    {
        private int height;
    }

    public class GeometricCircle : GeometricObject
    {
        private int diameter;
    }
}
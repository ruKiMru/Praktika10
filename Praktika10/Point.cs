using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika10
{
    class Point
    {
        public int Info { get; set; }
        public Point Next { get; set; }
        public Point Previous { get; set; }
        public Point(int info)
        {
            Info = info;
            Next = null;
        }
        public Point(int info, Point prev)
        {
            Info = info;
            Next = null;
            Previous = prev;
        }
        public static implicit operator bool(Point point)
        {
            if (point.Info >= 0)
                return true;
            else
                return false;
        }
    }
}

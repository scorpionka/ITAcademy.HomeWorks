using System;

namespace HW_11
{
    class Square : Shape
    {
        public Square() { }
        public Square(int side)
        {
            SideOrRadius = side;
        }
        public override void CalculateAreaOfShape()
        {
            base.CalculateAreaOfShape();
            Area = Math.Pow(SideOrRadius, 2);
        }
    }
}
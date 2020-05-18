using System;

namespace HW_11
{
    class Circle : Shape
    {
        public Circle() { }
        public Circle(int radius)
        {
            SideOrRadius = radius;
        }
        public override void CalculateAreaOfShape()
        {
            base.CalculateAreaOfShape();
            Area = Math.PI * Math.Pow(SideOrRadius, 2);
        }
    }
}
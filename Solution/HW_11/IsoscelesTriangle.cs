using System;

namespace HW_11
{
    class IsoscelesTriangle : Shape
    {
        public IsoscelesTriangle() { }
        public IsoscelesTriangle(int sideA, int sideB)
        {
            SideOrRadius = sideA;
            BaseOfTriangle = sideB;
        }
        public override void CalculateAreaOfShape()
        {
            base.CalculateAreaOfShape();
            Area = (BaseOfTriangle * Math.Sqrt(Math.Pow(SideOrRadius, 2) - Math.Pow(BaseOfTriangle, 2) / 4)) / 2;
        }
    }
}
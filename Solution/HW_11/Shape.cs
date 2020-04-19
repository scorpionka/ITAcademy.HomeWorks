namespace HW_11
{
    class Shape
    {
        public virtual void CalculateAreaOfShape() { }
        private double _area;
        public double Area
        {
            get
            {
                CalculateAreaOfShape();
                return _area;
            }
            set
            {
                _area = value;
            }
        }
        public int SideOrRadius { get; set; }
        public int BaseOfTriangle { get; set; }
    }
}
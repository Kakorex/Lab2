using System;

namespace Lab2
{
    public class Circle : IComparable, IComparable<Circle>
    {
        private string fillingColor { get; set; }
        private string borderColor { get; set; }
        private double radius { get; set; }
        private double area;
        private double circumference;


        public Circle(string fillingColor, string borderColor, double radius)
        {
            this.fillingColor = fillingColor;
            this.borderColor = borderColor;
            this.radius = radius;
        }
        public double Area
        {
            get
            {
                area = Math.PI * Math.Pow(radius, 2);

                return Math.Round(area, 2);
            }
        }
        public double Circumference
        {
            get
            {
                circumference = 2 * Math.PI * radius;

                return Math.Round(circumference, 2);
            }
        }
        public int CompareTo(Circle? other)
        {
            if (other == null) return 1;
            return this.radius.CompareTo(other.radius);
        }
        int IComparable.CompareTo(object? obj)
        {
            if (obj == null) return 1;
            if (obj is Circle otherCircle)
                return CompareTo(otherCircle);
            throw new ArgumentException("Object is not a Circle");
        }
        public override string ToString()
        {
            return 
                $"Circle radius: {radius}\n" +
                $"Circle area: {Area}\n" +
                $"Circumference: {Circumference}\n" +
                $"Border color: {borderColor}\n" +
                $"Filling color: {fillingColor}\n";
        }
        public override bool Equals(object? obj)
        {
            return obj.ToString().Equals(this.ToString());
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

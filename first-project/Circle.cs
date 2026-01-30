namespace first_project
{
    internal class Circle : Shape
    {
        public double Area(int radius, int unused)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be greater than zero");

            return Math.PI * radius * radius;
        }
    }
}

namespace JobApplicationTask
{
    public class Triangle : FIgure
    {
        double A { get; set; }
        double B { get; set; }
        double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double GetArea()
        {
            IsValidTriangle();

            var p = (A + B + C) / 2;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool IsRectangular()
        {
            IsValidTriangle();

            if (A > B)
            {
                if (A > C)
                    return Math.Pow(B, 2) + Math.Pow(C, 2) == Math.Pow(A, 2);
            }
            else
            {
                if (B > C)
                    return Math.Pow(A, 2) + Math.Pow(C, 2) == Math.Pow(B, 2);
            }

            return Math.Pow(A, 2) + Math.Pow(B, 2) == Math.Pow(C, 2);
        }

        private void IsValidTriangle()
        {
            if (A <= 0 || B <= 0 || C <= 0 ||
                A + B < C || A + C < B || C + B < A)
                throw new ArgumentException();
        }
    }
}

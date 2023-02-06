namespace JobApplicationTask
{
    public class Circle : FIgure
    {
        double R { get; set; }

        public Circle(double r)
        {
            R = r;
        }

        public override double GetArea()
        {
            if (R <= 0)
                throw new ArgumentException();

            return 3.14 * Math.Pow(R, 2);
        }
    }
}

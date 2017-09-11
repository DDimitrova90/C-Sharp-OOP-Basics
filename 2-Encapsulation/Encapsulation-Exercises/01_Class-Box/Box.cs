namespace _01_Class_Box
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public double GetSurfaceArea()
        {
            return 
                (2 * this.length * this.width) + 
                (2 * this.length * this.height) + 
                (2 * this.width * this.height);
        }

        public double GetLateralSurfaceArea()
        {
            return (2 * this.length * this.height) + (2 * this.height * this.width);
        }

        public double GetVolume()
        {
            return this.height * this.width * this.length;
        }
    }
}

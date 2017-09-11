namespace _09_Rectangle_Intersection
{
    public class Rectangle
    {
        public Rectangle(string id, double width, double height, double topLeftX, double topLeftY)
        {
            this.ID = id;
            this.Width = width;
            this.Height = height;
            this.TopLeftX = topLeftX;
            this.TopLeftY = topLeftY;
        }

        public string ID { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }

        public double TopLeftX { get; set; }

        public double TopLeftY { get; set; }

        public bool CheckIfIntersect(Rectangle secondRectangle)
        {
            return (secondRectangle.TopLeftX <= this.TopLeftX + this.Width) &&
                   (this.TopLeftX <= (secondRectangle.TopLeftX + secondRectangle.Width)) &&
                   (secondRectangle.TopLeftY <= this.TopLeftY + this.Height) &&
                   (this.TopLeftY <= secondRectangle.TopLeftY + secondRectangle.Height);
        }
    }
}

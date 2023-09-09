using System.Drawing;

namespace EmptyWASM
{
    public class CustomObject
    {
        public double  left { get; set; } = 0.0;
        public double top { get; set; } = 0.0;
        public int Position { get; set; }
        public string Style { get; set; }
        public CustomObject(double top, double left,int position)
        {
            Position = position;
            this.left = left;
            this.top = top;
            var color = GenerateColor();
            Console.WriteLine(color);
            Style = $"top:{top}px;left:{left}px;background-color:{color}";
        }

        private string GenerateColor()
        {
            Random random = new Random();

            int red = random.Next(256);
            int green = random.Next(256);
            int blue = random.Next(256);

            return string.Format("#{0:X2}{1:X2}{2:X2}", red, green, blue);
        
        }
    }
}


namespace ColorApp
{ 
    public class ColorModel
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }

        public Color ToColor()
        {
            return Color.FromArgb(Red, Green, Blue);
        }

        public string ToHex()
        {
            return $"#{Red:X2}{Green:X2}{Blue:X2}";
        }

        public override string ToString()
        {
            return $"RGB: {Red}, {Green}, {Blue}";
        }
    }

}
namespace ColorApp
{
    public interface IColorGenerator
    {
        ColorModel Generate();
    }

    public class RandomColorGenerator : IColorGenerator
    {
        private Random _rnd = new Random();
        public ColorModel Generate()
        {
            return new ColorModel
            {
                Red = _rnd.Next(0, 256),
                Green = _rnd.Next(0, 256),
                Blue = _rnd.Next(0, 256)
            };
        }
    }

    public class GrayScaleGenerator : IColorGenerator
    {
        private Random _rnd = new Random();
        public ColorModel Generate()
        {
            int value = _rnd.Next(0, 256);
            return new ColorModel { Red = value, Green = value, Blue = value };
        }
    }


        public class PastelColorGenerator : IColorGenerator
        {
            private Random _rnd = new Random();

            public ColorModel Generate()
            {
                float hue = _rnd.Next(360);      // valfri färgton
                float saturation = 0.3f;         // låg mättnad
                float lightness = 0.8f;          // hög ljushet

                return FromHSL(hue, saturation, lightness);
            }

            private ColorModel FromHSL(float h, float s, float l)
            {
                float c = (1 - Math.Abs(2 * l - 1)) * s;
                float x = c * (1 - Math.Abs((h / 60f) % 2 - 1));
                float m = l - c / 2;

                float r = 0, g = 0, b = 0;

                if (h < 60) { r = c; g = x; }
                else if (h < 120) { r = x; g = c; }
                else if (h < 180) { g = c; b = x; }
                else if (h < 240) { g = x; b = c; }
                else if (h < 300) { r = x; b = c; }
                else { r = c; b = x; }

                return new ColorModel
                {
                    Red = (int)((r + m) * 255),
                    Green = (int)((g + m) * 255),
                    Blue = (int)((b + m) * 255)
                };
            }
        }
  

}

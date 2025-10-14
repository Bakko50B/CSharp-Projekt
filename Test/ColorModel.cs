
/// <summary>
/// Representerar en färg med RGB-komponenter.
/// </summary>

namespace ColorApp
{ 
    public class ColorModel
    {
        /// <summary>Röd komponent (0–255)</summary>
        public int Red { get; set; }
        /// <summary>Grön komponent (0–255)</summary>
        public int Green { get; set; }
        /// <summary>Blå komponent (0–255)</summary>
        public int Blue { get; set; }

        /// <summary>Konverterar till System.Drawing.Color</summary>
        public Color ToColor()
        {
            return Color.FromArgb(Red, Green, Blue);
        }

        /// <summary>Returnerar färgen som en hex-sträng (#RRGGBB)</summary>
        public string ToHex()
        {
            return $"#{Red:X2}{Green:X2}{Blue:X2}";
        }

        /// <summary>Returnerar färgen som en RGB-sträng (R, G, B)</summary>
        public override string ToString()
        {
            return $"{Red}, {Green}, {Blue}";
        }
    }
}
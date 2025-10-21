
namespace ColorApp
{
    /// <summary>
    /// Representerar en färgmodell med komponenterna röd, grön och blå – var och en i intervallet 0 till 255.
    /// </summary>
    /// <remarks>
    /// Klassen innehåller metoder för att konvertera färgen till olika format, såsom en hexadecimal sträng
    /// eller en instans av <see cref="System.Drawing.Color"/>. Den överskuggar även <see cref="object.ToString"/>
    /// för att returnera färgen som en RGB-sträng.
    /// </remarks>
    public class ColorModel
    {
        /// <summary>Röd komponent (0–255)</summary>
        public int Red { get; set; }
        /// <summary>Grön komponent (0–255)</summary>
        public int Green { get; set; }
        /// <summary>Blå komponent (0–255)</summary>
        public int Blue { get; set; }

        /// <summary>
        /// Konverterar färgmodellen till en <see cref="System.Drawing.Color"/>-instans.
        /// </summary>
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
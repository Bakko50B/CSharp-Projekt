using System.Text.Json;
// using System.Text.Json.Serialization;
// Förberett för framtida behov av JSON-attribut, t.ex. för att styra serialisering av egenskaper.

namespace ColorApp
{
    /// <summary>
    /// Hanterar lagring och hämtning av färger i form av ColorModel-objekt.
    /// </summary>
    public class ColorStorage   
    {
        /// <summary>
        /// Lista över sparade färger.
        /// </summary>
        public List<ColorModel> Colors { get; private set; } = new List<ColorModel>();

        /// <summary>
        /// Lägger till en färg i listan.
        /// </summary>
        /// <param name="color">Färgen som ska läggas till.</param>
        public void AddColor(ColorModel color)
        {
            Colors.Add(color);
        }

        /// <summary>
        /// Sparar alla färger till en JSON-fil.
        /// </summary>
        /// <param name="filePath">Sökväg till filen som ska skapas eller uppdateras.</param>
        public void SaveToFile(string filePath)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(Colors, options);
            File.WriteAllText(filePath, json);
        }

        /// <summary>
        /// Läser in färger från en JSON-fil.
        /// Om filen inte finns eller innehållet är ogiltigt, skapas en tom lista.
        /// </summary>
        /// <param name="filePath">Sökväg till filen som ska läsas.</param>
        public void LoadFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                Colors = JsonSerializer.Deserialize<List<ColorModel>>(json) ?? new List<ColorModel>();
            }
        }
    }
}
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ColorApp
{
    public class ColorStorage   
    {
        public List<ColorModel> Colors { get; private set; } = new List<ColorModel>();

        public void AddColor(ColorModel color)
        {
            Colors.Add(color);
        }

        public void SaveToFile(string filePath)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(Colors, options);
            File.WriteAllText(filePath, json);
        }

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
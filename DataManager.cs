using System.Text.Json;

namespace HeatChecker
{
    internal class DataManager
    {
        public static SettingsModel ReadSettings(string filePath, bool readBytes)
        {
            if (!File.Exists(filePath))
                File.Create(filePath).Dispose();

            if (readBytes)
            {
                // Read the file as bytes and deserialize using System.Text.Json
                byte[] fileBytes = File.ReadAllBytes(filePath);
                var json = System.Text.Encoding.UTF8.GetString(fileBytes);
                return JsonSerializer.Deserialize<SettingsModel>(json)
                       ?? throw new InvalidOperationException("Failed to deserialize binary settings.");
            }
            else
            {
                // Read the file as text and deserialize from JSON format
                string fileContent = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<SettingsModel>(fileContent)
                       ?? throw new InvalidOperationException("Failed to deserialize JSON settings.");
            }
        }

        public static void WriteSettings(string filePath, SettingsModel settings, bool writeBytes)
        {
            if (writeBytes)
            {
                // Serialize to JSON, convert to bytes, and write to file
                var json = JsonSerializer.Serialize(settings);
                byte[] fileBytes = System.Text.Encoding.UTF8.GetBytes(json);
                File.WriteAllBytes(filePath, fileBytes);
            }
            else
            {
                // Serialize to JSON format and write as text
                var json = JsonSerializer.Serialize(settings);
                File.WriteAllText(filePath, json);
            }
        }
    }
}
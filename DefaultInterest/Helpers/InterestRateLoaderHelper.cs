using DefaultInterest.Models;
using System.Text.Json;

namespace DefaultInterest.Helpers;

public static class InterestRateLoaderHelper
{
    public static List<InterestRate> Load(string filePath)
    {
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        var json = File.ReadAllText(filePath);

        var rates = JsonSerializer.Deserialize<List<InterestRate>>(json, options);

        return rates ?? [];
    }
}

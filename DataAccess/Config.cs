using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Dynamic;

namespace DataAccess;

public class Config
{
    //public string ConnectionStrings { get; protected set; }

    public int ParkingSpotSize { get; set; }
    public int ParkingLotSize { get; set; }
    public int CarSize { get; set; }
    public int McSize { get; set; }
    public int CarFeePerHour { get; set; }
    public int McFeePerHour { get; set; }

    string appSettingsPath = Path.Combine(System.IO.Directory.GetCurrentDirectory(), "appSettings.json");

    public void ReadFromJson()
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile(appSettingsPath).Build();

        var section = config.GetSection(nameof(Config));
        var values = section.Get<Config>();

        CarFeePerHour = values.CarFeePerHour;
        McFeePerHour = values.McFeePerHour;
        ParkingSpotSize = values.ParkingSpotSize;
        ParkingLotSize = values.ParkingLotSize;
    }

    public void UpdateJson(string carPrice, string mcPrice, string parkingSize)
    {
        var json = File.ReadAllText(appSettingsPath);

        var jsonSettings = new JsonSerializerSettings();
        jsonSettings.Converters.Add(new ExpandoObjectConverter());
        jsonSettings.Converters.Add(new StringEnumConverter());

        dynamic config = JsonConvert.DeserializeObject<ExpandoObject>(json, jsonSettings);

        config.DebugEnabled = true;
        config.Config.CarFeePerHour = carPrice;
        config.Config.McFeePerHour = mcPrice;
        config.Config.ParkingLotSize = parkingSize;

        var newJson = JsonConvert.SerializeObject(config, Formatting.Indented, jsonSettings);
        File.WriteAllText(appSettingsPath, newJson);
    }


}

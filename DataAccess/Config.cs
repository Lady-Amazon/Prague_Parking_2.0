using Microsoft.Extensions.Configuration;

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


}

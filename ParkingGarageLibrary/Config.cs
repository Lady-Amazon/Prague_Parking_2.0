using Microsoft.Extensions.Configuration;

namespace DataAccess;

public class Config
{
    public Config()
    {
        // TODO: Läs appsettings.json och fyll på parametrarna nedan
        var conf = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build()
            .Get<Config>();
    }
    public string ConnectionStrings { get; protected set; }
    public bool DebugEnable { get; set; }
    public int ParkingSpotSize { get; set; }
    public int ParkingLotSize { get; set; }
    public int CarSize { get; set; }
    public int McSize { get; set; }
    public int CarFeePerHour { get; set; }
    public int McFeePerHour { get; set; }
}

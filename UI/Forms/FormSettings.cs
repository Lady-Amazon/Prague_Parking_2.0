using DataAccess;
using Microsoft.Extensions.Configuration;

using System.Text.Json;
using System.Text.Json.Serialization;

namespace UI;

public partial class FormSettings : Form
{
   // ConfigurationBuilder config = new ConfigurationBuilder();
    public FormSettings()
    {
        InitializeComponent();
    }

    private void btnSavesetting_Click(object sender, EventArgs e)
    {
        //Läser in konfiguration från appsettings
        var config = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build()
            .Get<Config>();

        //Ändrar på värden

        config.CarFeePerHour = int.Parse(txtChangeFeeCar.Text);
        config.McFeePerHour = int.Parse(txtChangeFeeMc.Text);

        
        //config.ParkingLotSize = int.Parse(txtChangeLotSize.Text);
        //config.ParkingSpotSize = int.Parse(txtChangeSpotSize.Text);

        //Serialiserar konfigurationsobjektet och skriver över filen
        var jsonWriteOptions = new JsonSerializerOptions()
        {
            WriteIndented = true
        };

        jsonWriteOptions.Converters.Add(new JsonStringEnumConverter());

        var newJson = JsonSerializer.Serialize(config, jsonWriteOptions);

        var appsettingsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
        File.WriteAllText(appsettingsPath, newJson);

    }

    
}

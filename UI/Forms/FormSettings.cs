using DataAccess;
using Microsoft.Extensions.Configuration;

using System.Text.Json;
using System.Text.Json.Serialization;

namespace UI;

public partial class FormSettings : Form
{
    Config config = new Config();
    // ConfigurationBuilder config = new ConfigurationBuilder();
    public FormSettings()
    {
        InitializeComponent();
    }

    private void btnSavesetting_Click(object sender, EventArgs e)
    {

        string CarFeePerHour = txtChangeFeeCar.Text;
        string McFeePerHour = txtChangeFeeMc.Text;
        string gSize = txtChangeLotSize.Text;
        config.UpdateJson(CarFeePerHour, McFeePerHour, gSize);
        MessageBox.Show("New configuration set!");


        ////Läser in konfiguration från appsettings
        //var config = new ConfigurationBuilder()
        //    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
        //    .AddJsonFile("appsettings.json")
        //    .Build()
        //    .Get<Config>();

        ////Ändrar på värden

        //config.CarFeePerHour = int.Parse(txtChangeFeeCar.Text);
        //config.McFeePerHour = int.Parse(txtChangeFeeMc.Text);


        ////config.ParkingLotSize = int.Parse(txtChangeLotSize.Text);
        ////config.ParkingSpotSize = int.Parse(txtChangeSpotSize.Text);

        ////Serialiserar konfigurationsobjektet och skriver över filen
        //var jsonWriteOptions = new JsonSerializerOptions()
        //{
        //    WriteIndented = true
        //};

        //jsonWriteOptions.Converters.Add(new JsonStringEnumConverter());

        //var newJson = JsonSerializer.Serialize(config, jsonWriteOptions);

        //var appsettingsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
        //File.WriteAllText(appsettingsPath, newJson);

    }

    

    private void btnExit_Click_1(object sender, EventArgs e)
    {
        Application.Exit();
    }
}

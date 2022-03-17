using DataAccess;
using Microsoft.Extensions.Configuration;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace UI
{
    public partial class FormSettings : Form
    {
        ConfigurationBuilder _config = new ConfigurationBuilder();
        public FormSettings()
        {
            InitializeComponent();
        }

        private void btnSavesetting_Click(object sender, EventArgs e)
        {
            var _config = new ConfigurationBuilder()
          .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
          .AddJsonFile("appsettings.json")
          .Build()
          .Get<Config>();

            _config.CarFeePerHour = 30;

            var jsonWriteOptions = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            jsonWriteOptions.Converters.Add(new JsonStringEnumConverter());
            var newJson = JsonSerializer.Serialize(_config, jsonWriteOptions);

            var appsettingsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
            File.WriteAllText(appsettingsPath, newJson);

        }
        //public void ReadFromJson()
        //{
        //    var config = new ConfigurationBuilder()
        //        .AddJsonFile(appSettingsPath).Build();
        //    var section = config.GetSection(nameof(Config));
        //    var values = section.Get<Config>();

        //    CarFeePerHour = values.CarFeePerHour;
        //    McFePerHour = values.McFePerHour;
        //    ParkingSpotSize = values.ParkingSpotSize;
        //    ParkingLotSize = values.ParkingLotSize;

        //}
    }
}

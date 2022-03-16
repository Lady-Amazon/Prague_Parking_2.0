using ParkingGarageLibrary;

namespace DataAccess
{
    public class Config
    {
        public ParkingGarageClientConfig ParkingGarageClientConfig;
        public string ConnectionString { get; protected set; }
        public bool DebugEnabled { get; set; }
        
    }
}

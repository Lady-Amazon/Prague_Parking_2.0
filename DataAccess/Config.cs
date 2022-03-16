namespace DataAccess
{
    public class Config
    {
        public string ConnectionString { get; protected set; }
        public int TimeOutSeconds { get; protected set; }
        public ParkingGarageClientConfig ParkingGarageClientConfig { get; set; }
        public bool DebugEnabled { get; set; }
    }
}

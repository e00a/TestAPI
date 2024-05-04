namespace TestAPI
{
    public class AppConfig
    {
        private readonly IConfiguration _config;
        private int myProperty;

        public AppConfig(IConfiguration config)
        {
            _config = config;
        }

        public string ConnectionString
        {
            get
            {
                return _config.GetConnectionString("MysqlDefaultConnection") ?? "";
            }
        }
    }
}


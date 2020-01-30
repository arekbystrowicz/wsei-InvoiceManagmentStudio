using System.Configuration;

namespace Infrastructure
{
    public class AppProfile : IAppProfile
    {
        // TODO from properties
        private const string DefaultDataSource = @"127.0.0.1";
        private const string DefaultUsername = "postgres";
        private const string DefaultPassword = "postgres";
        private const string DefaultDatabase = "ivms";

        public string DataSource { get; }
        public string Username { get; }
        public string Password { get; }
        public string Database { get; }
        
        public AppProfile()
        {
            DataSource = DefaultDataSource;
            Username = DefaultUsername;
            Password = DefaultPassword;
            Database = DefaultDatabase;
        }
    }
}
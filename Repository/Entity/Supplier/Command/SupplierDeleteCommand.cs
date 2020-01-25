using Npgsql;

namespace Repository.Entity.Supplier.Command
{
    public class SupplierDeleteCommand
    {
        private const string Sql = "DELETE FROM supplier WHERE id = @Id;";
        
        private readonly SupplierRowMapper _rowMapper;
        private readonly DataSourceConfig _dataSource;
        private readonly ulong _id;
        
        public SupplierDeleteCommand(DataSourceConfig dataSource, ulong id)
        {
            _rowMapper = new SupplierRowMapper();
            _dataSource = dataSource;
            _id = id;
        }

        // TODO ArBy returning id
        public bool Execute()
        {
            var command = new NpgsqlCommand(Sql, _dataSource.DbConnection);
            command.Parameters.AddWithValue("Id", _id);
            return command.ExecuteNonQuery() > 0;
        }
    }
}
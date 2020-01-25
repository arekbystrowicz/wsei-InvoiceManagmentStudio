using System.Collections.Generic;
using Npgsql;

namespace Repository.Entity.Receiver.Command
{
    public class ReceiverFindAllCommand
    {
        private const string Sql = "SELECT * FROM receiver;";

        private readonly AbstractRowMapper<ReceiverEntity> _rowMapper;
        private readonly DataSourceConfig _dataSource;

        public ReceiverFindAllCommand(DataSourceConfig dataSource)
        {
            _rowMapper = new ReceiverRowMapper();
            _dataSource = dataSource;
        }

        public List<ReceiverEntity> Execute()
        {
            var command = new NpgsqlCommand(Sql, _dataSource.DbConnection);
            var resultSet = command.ExecuteReader();

            return _rowMapper.FromResultSet(resultSet);
        }
    }
}
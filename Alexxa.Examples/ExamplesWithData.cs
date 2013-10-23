namespace Alexxa.Examples
{
    using System.Data;
    using System.Data.SqlClient;

    using Alexxa.Core.Data;

    public class ExamplesWithData
    {
        public string ExampleWithSql()
        {
            using (var sqlCon = new SqlConnection("server=prodsql01;catalog=Datastore;integrated security=true"))
            using (var sqlCmd = sqlCon.CreateCommand())
            {
                sqlCmd.CommandText = "SELECT TOP 1 FullName FROM People ORDER BY Age DESC";
                sqlCmd.CommandTimeout = 30;
                sqlCmd.CommandType = CommandType.Text;

                return sqlCmd.ExecuteScalar() as string;
            }
        }

        public string ExampleWithAlexxa()
        {
            using (var alxCon = new AlexxaConnection("deployment=Datastore"))
            using (var alxCmd = alxCon.CreateCommand())
            {
                alxCmd.CommandText = "SELECT TOP 1 FullName FROM People ORDER BY Age DESC";
                alxCmd.CommandTimeout = 30;
                alxCmd.CommandType = CommandType.Text;

                alxCmd.Partition = AlexxaPartitionService.GetPartition(1982);

                return alxCmd.ExecuteScalar() as string;
            }
        }
    }
}
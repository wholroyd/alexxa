alexxa
========

Automatic data partitioning library for use with Microsoft SQL Server 2008 - 2012

examples
==========
When using SQL Server directly (non-partitioned)

        public string ExampleWithSql()
        {
            using (var sqlCon = new SqlConnection())
            using (var sqlCmd = sqlCon.CreateCommand())
            {
                sqlCmd.CommandText = "SELECT TOP 1 FullName FROM People ORDER BY Age DESC";
                sqlCmd.CommandTimeout = 30;
                sqlCmd.CommandType = CommandType.Text;

                return sqlCmd.ExecuteScalar() as string;
            }
        }
When using Alexxa with SQL Server (partitioned)

        public string ExampleWithAlexxa()
        {
            using (var alxCon = new AlexxaConnection())
            using (var alxCmd = alxCon.CreateCommand())
            {
                alxCmd.CommandText = "SELECT TOP 1 FullName FROM People ORDER BY Age DESC";
                alxCmd.CommandTimeout = 30;
                alxCmd.CommandType = CommandType.Text;

                alxCmd.Partition = AlexxaPartitionService.GetPartition(1982);

                return alxCmd.ExecuteScalar() as string;
            }
        }

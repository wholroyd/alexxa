alexxa
========

Data partitioning library for use with Microsoft SQL Server 2008 - 2014 that attempts to replicate the sharding/partitioning functionality of Microsoft's internal WebStore tooling without the fail-safe-set feature.

examples with data
==================
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

examples with management
========================
When using SQL Server's SMO library

        public void ExampleWithSql()
        {
            Smo.Server sqlServer = new Smo.Server("prodsqlserver01");
            Smo.Database sqlDatabase = sqlServer.Databases[0];
            Smo.Table sqlTable = sqlDatabase.Tables[0];
            Smo.Column sqlColumn = sqlTable.Columns[0];
            sqlColumn.Drop();
        }

When using Alexxa's AMO library

        public void ExampleWithAlexxa()
        {
            Amo.Server alxServer = new Amo.Server("prodalxserver01");
            Amo.Database alxDatabase = alxServer.Databases[0];
            Amo.Table alxTable = alxDatabase.Tables[0];
            Smo.Column alxColumn = alxTable.Columns[0];
            alxColumn.Drop();
        }

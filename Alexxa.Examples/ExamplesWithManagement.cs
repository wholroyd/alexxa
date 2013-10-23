namespace Alexxa.Examples
{
    using System;
    using System.Collections.Specialized;

    using Microsoft.SqlServer.Management.Smo;

    public class ExamplesWithManagement
    {
        public void ExampleWithSql()
        {
            var sqlServer = new Microsoft.SqlServer.Management.Smo.Server();
            var sqlDatabase = sqlServer.Databases[0];
            sqlDatabase.Alter();
            sqlDatabase.Alter(TerminationClause.FailOnOpenTransactions);
            sqlDatabase.Alter(new TimeSpan());
            sqlDatabase.ChangeMirroringState(MirroringOption.Failover);
            StringCollection allocations = sqlDatabase.CheckAllocations(RepairType.AllowDataLoss);
            StringCollection allocationsData = sqlDatabase.CheckAllocationsDataOnly();
            var sqlTable = sqlDatabase.Tables[0];
            var sqlColumn = sqlTable.Columns[0];
            sqlColumn.AddDefaultConstraint();
            sqlColumn.Alter();
            sqlColumn.BindDefault(string.Empty, string.Empty);
            sqlColumn.BindRule(string.Empty, string.Empty);
            sqlColumn.Create();
            sqlColumn.Discover();
            sqlColumn.Drop();
            sqlColumn.EnumForeignKeys();
            sqlColumn.EnumIndexes();
            sqlColumn.EnumUserPermissions(string.Empty);
        }
        
        public void ExampleWithAlexxa()
        {
            var alxServer = new Core.Management.Amo.Server();
            var alxDatabase = alxServer.Databases[0];
            alxDatabase.Alter();
            alxDatabase.Alter(TerminationClause.FailOnOpenTransactions);
            alxDatabase.Alter(new TimeSpan());
            alxDatabase.ChangeMirroringState(MirroringOption.Failover);
            StringCollection allocations = alxDatabase.CheckAllocations(RepairType.AllowDataLoss);
            StringCollection allocationsData = alxDatabase.CheckAllocationsDataOnly();
            var alxTable = alxDatabase.Tables[0];
            var alxColumn = alxTable.Columns[0];
            alxColumn.AddDefaultConstraint();
            alxColumn.Alter();
            alxColumn.BindDefault(string.Empty, string.Empty);
            alxColumn.BindRule(string.Empty, string.Empty);
            alxColumn.Create();
            alxColumn.Discover();
            alxColumn.Drop();
            alxColumn.EnumForeignKeys();
            alxColumn.EnumIndexes();
            alxColumn.EnumUserPermissions(string.Empty);
        }
    }
}
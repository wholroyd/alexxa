namespace Alexxa.Core.Management.Amo
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;

    using Smo = Microsoft.SqlServer.Management.Smo;

    /// <summary>
    /// Modeled after Microsoft.SqlServer.Management.Smo.Database
    /// </summary>
    public class Database : Smo.ScriptNameObjectBase 
    {
        public List<Table> Tables { get; set; }

        public void Alter()
        {
            throw new NotImplementedException();
        }

        public void Alter(Smo.TerminationClause failOnOpenTransactions)
        {
            throw new NotImplementedException();
        }

        public void Alter(TimeSpan failOnOpenTransactions)
        {
            throw new NotImplementedException();
        }

        public void ChangeMirroringState(Smo.MirroringOption failover)
        {
            throw new NotImplementedException();
        }

        public StringCollection CheckAllocations(Smo.RepairType allowDataLoss)
        {
            throw new NotImplementedException();
        }

        public StringCollection CheckAllocationsDataOnly()
        {
            throw new NotImplementedException();
        }
    }
}

namespace Alexxa.Core.Management.Amo
{
    using System.Collections.Generic;

    using Smo = Microsoft.SqlServer.Management.Smo;

    /// <summary>
    /// Modeled after Microsoft.SqlServer.Management.Smo.Server
    /// </summary>
    public class Server : Smo.SqlSmoObject
    {
        public List<Database> Databases { get; set; }
    }
}
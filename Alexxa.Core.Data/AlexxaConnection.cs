namespace Alexxa.Core.Data
{
    using System;

    /// <summary>
    /// Modeled after System.Data.SqlConnection
    /// </summary>
    public class AlexxaConnection : IDisposable
    {
        public AlexxaConnection(string connectionString)
        {
            throw new NotImplementedException();
        }

        public AlexxaCommand CreateCommand()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
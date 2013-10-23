namespace Alexxa.Core.Data
{
    using System;
    using System.Data;

    /// <summary>
    /// Modeled after System.Data.SqlCommand
    /// </summary>
    public class AlexxaCommand : IDisposable
    {

        public string CommandText { get; set; }

        public int CommandTimeout { get; set; }

        public CommandType CommandType { get; set; }

        public int Partition { get; set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public object ExecuteScalar()
        {
            throw new NotImplementedException();
        }
    }
}
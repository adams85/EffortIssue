using System.Data.Common;
using System.Data.Entity;

namespace AccessEffortDbFromMultipleThreads
{
    public partial class DataContextContainer : DbContext, IDataContext
    {
        public DataContextContainer(DbConnection connection) : base(connection, contextOwnsConnection: false) { }
    }
}

using System.Data.Common;
using System.Data.Entity;

namespace AccessEffortDbFromMultipleThreads
{
    class CodeFirstDataContext : DbContext, IDataContext
    {
        public CodeFirstDataContext(DbConnection connection) : base(connection, contextOwnsConnection: false) { }

        public DbSet<Item> Items { get; set; }
    }
}

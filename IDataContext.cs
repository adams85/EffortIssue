using System;
using System.Data.Entity;

namespace AccessEffortDbFromMultipleThreads
{
    interface IDataContext : IDisposable
    {
        DbSet<Item> Items { get; set; }
        int SaveChanges();
    }
}
using BankTransaction.App.Models;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace BankTransaction.App.DBFolder
{
    public class TransactionDbContext:DbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options):base(options)
        {

        }

        public DbSet<Transactions> Transaction { get; set; }
    }
}

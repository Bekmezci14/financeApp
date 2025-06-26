using financeApp.Models;
using Microsoft.EntityFrameworkCore;

namespace financeApp.Data
{
    public class FinanceAppContext : DbContext
    {
        public FinanceAppContext(DbContextOptions<FinanceAppContext> options):base(options) { }

        public DbSet<Expense> Expenses {  get; set; }  
    }

}

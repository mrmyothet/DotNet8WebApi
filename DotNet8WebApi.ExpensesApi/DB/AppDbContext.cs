using DotNet8WebApi.ExpensesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet8WebApi.ExpensesApi.DB;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options)
        : base(options) { }

    public DbSet<ExpenseModel> Expenses { get; set; }
}

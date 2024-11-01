using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNet8WebApi.ExpensesApi.Models;

[Table("Tbl_Expense")]
public class ExpenseModel
{
    [Key]
    public int ExpenseId { get; set; }

    public string Title { get; set; }

    public decimal MoneySpent { get; set; }

    public DateTime SpentDate { get; set; }

    public string Category { get; set; }

    public bool IsDeleted { get; set; }
}

using DotNet8WebApi.ExpensesApi.DB;
using DotNet8WebApi.ExpensesApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNet8WebApi.ExpensesApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExpenseController : ControllerBase
{
    private readonly AppDbContext _AppDbContext;

    public ExpenseController(AppDbContext context)
    {
        _AppDbContext = context;
    }

    [HttpGet]
    public IActionResult GetExpenses()
    {
        List<ExpenseModel> lst = _AppDbContext.Expenses.ToList();
        return Ok(lst);
    }
}

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class MyTableController : ControllerBase
{
    private readonly MyDbContext _context;

    public MyTableController(MyDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var data = _context.MyTables.ToList();
        return Ok(data);
    }
}

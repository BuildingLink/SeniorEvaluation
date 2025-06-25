[ApiController]
[Route("api/workers")]
public class WorkersController : ControllerBase
{
    private readonly AppDbContext _dbContext;
    public WorkersController(AppDbContext dbContext) => _dbContext = dbContext;

    [HttpGet]
    public IActionResult GetWorkers() => Ok(_dbContext.Workers.ToList());
}
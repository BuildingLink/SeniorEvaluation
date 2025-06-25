[ApiController]
[Route("api/facilities")]
public class FacilitiesController : ControllerBase
{
    private readonly AppDbContext _dbContext;
    public FacilitiesController(AppDbContext dbContext) => _dbContext = dbContext;

    [HttpGet]
    public IActionResult GetFacilities() => Ok(_dbContext.Facilities.ToList());
}
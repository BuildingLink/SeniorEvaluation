[ApiController]
[Route("api/facilities")]
public class FacilitiesController : ControllerBase
{
    private readonly AppDbContext _dbContext;
    private readonly RateWorkerHandler _rateWorkerHandler;
    private readonly BlockWorkerHandler _blockWorkerHandler;

    public FacilitiesController(AppDbContext dbContext, RateWorkerHandler rateWorkerHandler, BlockWorkerHandler blockWorkerHandler)
    {
        _dbContext = dbContext;
        _rateWorkerHandler = rateWorkerHandler;
        _blockWorkerHandler = blockWorkerHandler;
    }

    [HttpGet("facilities/list")]
    public async Task<IActionResult> GetFacilities([FromBody] RateWorkerRequest request)
    {
        return await _dbContext.Facilities.ToListAsync();
    }

    [HttpPost("facilities/rate-worker")]
    public async Task<IActionResult> RateWorker([FromBody] RateWorkerRequest request)
    {
        return await _rateWorkerHandler.HandleAsync(request);
    }

    [HttpPost("facilities/block-worker")]
    public async Task<IActionResult> BlockWorker([FromBody] BlockWorkerRequest request)
    {
        return await _blockWorkerHandler.HandleAsync(request);
    }
}
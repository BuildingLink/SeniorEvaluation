[ApiController]
[Route("api/shifts")]
public class ShiftsController : ControllerBase
{
    private readonly AppDbContext _dbContext;
    public ShiftsController(AppDbContext dbContext) => _dbContext = dbContext;

    [HttpGet]
    public IActionResult GetShifts() => Ok(_dbContext.Shifts.ToList());

    [HttpPost("{shiftId}/assign/{workerId}")]
    public async Task<IActionResult> AssignWorker(int shiftId, int workerId)
    {
        var shift = await _dbContext.Shifts.FindAsync(shiftId);
        var worker = await _dbContext.Workers.FindAsync(workerId);

        if (shift == null || worker == null)
            return NotFound();

        shift.WorkerId = worker.Id;
        await _dbContext.SaveChangesAsync();

        return NoContent();
    }
}
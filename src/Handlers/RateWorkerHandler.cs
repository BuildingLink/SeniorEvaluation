public class RateWorkerHandler
{
    private readonly AppDbContext _dbContext;

    public RateWorkerHandler(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IActionResult> HandleAsync(RateWorkerRequest request)
    {
        try
        {
            var shiftRating = new ShiftRating
            {
                ShiftId = request.ShiftId,
                FacilityId = request.FacilityId,
                WorkerId = request.WorkerId,
                Score = request.Score
            };

            _dbContext.ShiftRatings.Add(shiftRating);
            await _dbContext.SaveChangesAsync();

            return new JsonResult(shiftRating);
        }
        catch (Exception e)
        {
            return new JsonResult(new { error = e.Message });
        }
    }
}
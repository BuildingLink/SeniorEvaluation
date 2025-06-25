public class BlockWorkerHandler
{
    private readonly WorkerRepository _workerRepository;

    public BlockWorkerHandler(WorkerRepository workerRepository)
    {
        _workerRepository = workerRepository;
    }

    public async Task<IActionResult> HandleAsync(BlockWorkerRequest request)
    {
        try
        {
            _workerRepository.BlockWorker(request.WorkerId, request.FacilityId);
        }
        catch (Exception e)
        {
            return new JsonResult(new { error = e.Message });
        }
    }
}
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class CashDrawerController : ControllerBase
{
    private readonly CashDrawerService _cashDrawerService;

    public CashDrawerController(CashDrawerService cashDrawerService)
    {
        _cashDrawerService = cashDrawerService;
    }

    [HttpGet("trigger")]
    public IActionResult Trigger()
    {
        try
        {
            _cashDrawerService.TriggerCashDrawer();
            return Ok("Cash drawer triggered");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
}

namespace WoodTrack.Api.Controllers;

[Authorize(AuthenticationSchemes = "Bearer")]
[Route("/[controller]")]
public class ReportsController : ControllerBase
{
    private readonly IReportsService _reportsService;
    public ReportsController(IReportsService reportsService)
    {
        _reportsService = reportsService;
    }

    [HttpGet("clients")]
    public async Task<IActionResult> GetClientsReport(UsersSearchObject searchObject)
    {
        var pdfBytes = await _reportsService.GenerateClientsReport(searchObject);
        return File(pdfBytes, "application/pdf", "izvjestaj_pacijenata.pdf");
    }

    [HttpGet("orders")]
    public async Task<IActionResult> GetOrdersReport(OrderSearchObject searchObject)
    {
        var pdfBytes = await _reportsService.GenerateOrdersReport(searchObject);
        return File(pdfBytes, "application/pdf", "izvjestaj_narudzbi.pdf");
    }

}

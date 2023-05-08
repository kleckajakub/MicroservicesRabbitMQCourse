using MicroservicesRabbitMQCourse.Transfer.Application.Interfaces;
using MicroservicesRabbitMQCourse.Transfer.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicesRabbitMQCourse.Transfer.Api.Controllers; 

[Route("api/[controller]")]
[ApiController]
public class TransferController : ControllerBase {
  private readonly ITransferService transferService;

  public TransferController(ITransferService transferService) {
    this.transferService = transferService;
  }

  [HttpGet]
  public ActionResult<IEnumerable<TransferLog>> Get() {
    return Ok(transferService.GetTransferLogs());
  }
}
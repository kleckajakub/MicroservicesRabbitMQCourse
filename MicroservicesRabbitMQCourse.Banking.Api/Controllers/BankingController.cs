using MicroservicesRabbitMQCourse.Banking.Application.Interfaces;
using MicroservicesRabbitMQCourse.Banking.Application.Models;
using MicroservicesRabbitMQCourse.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicesRabbitMQCourse.Banking.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BankingController : ControllerBase {
  private readonly IAccountService accountService;

  public BankingController(IAccountService accountService) {
    this.accountService = accountService;
  }

  [HttpGet]
  public ActionResult<IEnumerable<Account>> Get() {
    return Ok(accountService.GetAccounts());
  }
  
  [HttpPost]
  public ActionResult Post([FromBody] AccountTransfer accountTransfer) {
    accountService.Transfer(accountTransfer);
    return Ok(accountTransfer);
  }
}
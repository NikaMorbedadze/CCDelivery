using CCDelivery.Domain.Entities;
using CCDelivery.Infrastructure.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CCDelivery.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BasePersonController : ControllerBase
{
    private readonly IBasePersonRepository _basePersonRepository;

    public BasePersonController(IBasePersonRepository basePersonRepository)
    {
        _basePersonRepository= basePersonRepository;
    }
    [HttpGet]
    public IActionResult Get()
    {

        var personsDb = _basePersonRepository.GetAll();
        return Ok(personsDb);


    }
    [HttpPost]
    public IActionResult Create(BasePerson basePerson)
    {
        var persondb = new BasePerson();
        _basePersonRepository.Create(basePerson);
        return Ok();
    }
    [HttpPut]
    public IActionResult Update(BasePerson basePerson)
    {
        _basePersonRepository.Update(basePerson);
        return Ok();
    }

    [HttpDelete]
    public IActionResult Delete(int id)
    {
        var basePerson = new BasePerson { ID = id };
        _basePersonRepository.Delete(basePerson);
        return Ok();

    }

}

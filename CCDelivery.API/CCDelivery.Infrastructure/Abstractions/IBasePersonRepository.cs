using CCDelivery.Domain.Entities;

namespace CCDelivery.Infrastructure.Abstractions;

public interface IBasePersonRepository
{
    void Create(BasePerson basePerson);
    void Update(BasePerson basePerson);
    void Delete(BasePerson basePerson);
    IEnumerable<BasePerson> GetAll();
    
}

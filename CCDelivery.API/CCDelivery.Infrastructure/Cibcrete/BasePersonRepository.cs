using CCDelivery.Domain.Entities;
using CCDelivery.Infrastructure.Abstractions;
using CCDelivery.Infrastructure.Data;

namespace CCDelivery.Infrastructure.Cibcrete;

public class BasePersonRepository : IBasePersonRepository
{
    private readonly ApplicationDbContext _db;
    public BasePersonRepository(ApplicationDbContext dbContext) => _db=dbContext;
    public void Create(BasePerson basePerson)
    {
        _db.Persons.Add(basePerson);
        _db.SaveChanges();
    }

    public void Delete(BasePerson basePerson)
    {
        _db.Persons.Remove(basePerson);
        _db.SaveChanges();
    }

    public IEnumerable<BasePerson> GetAll()
    {
        return _db.Persons.ToList();
    }

    public void Update(BasePerson basePerson)
    {
        _db.Persons.Update(basePerson);
        _db.SaveChanges();
    }
}

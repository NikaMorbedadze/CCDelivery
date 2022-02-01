namespace CCDelivery.Domain.Entities;

public class BasePerson : BaseEntity
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Mail { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
    public string RepeatedPassword { get; set; }

}

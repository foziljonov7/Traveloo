using API.Entities;

namespace API.Dtos
{
    public class GetHumanDto
    {
        public GetHumanDto(Human entity)
        {
            Id = entity.Id;
            Firstname = entity.Firstname;
            Lastname = entity.Lastname;
            Age = entity.Age;
            PhoneNumber = entity.PhoneNumber;
            Location = entity.Location;
            CategoryId = entity.CategoryId;
            TicketId = entity.TicketId;
        }

        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Location { get; set; }
        public int CategoryId { get; set; }
        public int TicketId { get; set; }
    }
}

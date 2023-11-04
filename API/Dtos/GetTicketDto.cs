using API.Entities;

namespace API.Dtos
{
    public class GetTicketDto
    {
        public GetTicketDto(Ticket entity)
        {
            Id = entity.Id;
            Flight = entity.Flight;
            Price = entity.Price;
            Date = entity.Date;
        }

        public int Id { get; set; }
        public string Flight { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
    }
}

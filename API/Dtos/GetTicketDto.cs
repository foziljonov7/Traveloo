namespace API.Dtos
{
    public class GetTicketDto
    {
        public int Id { get; set; }
        public string Flight { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
    }
}

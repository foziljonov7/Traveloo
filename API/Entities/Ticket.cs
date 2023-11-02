namespace API.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Flight { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
    }
}

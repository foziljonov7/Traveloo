namespace API.Dtos
{
    public class EditHumanDto
    {
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

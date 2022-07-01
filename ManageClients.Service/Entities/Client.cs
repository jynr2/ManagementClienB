namespace ManageClients.Service.Entities
{
    public class Client
    {
        public int? DocumentType { get; set; }
        public long? DocumentNumber { get; set; }
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? Surname { get; set; }
        public string? SecondSurname { get; set; }
        public long? Phone { get; set; }
        public string? Address { get; set; }
        public string? ResidenceCity { get; set; }
    }
}

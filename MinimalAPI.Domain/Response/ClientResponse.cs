namespace MinimalAPI.Domain.Response
{
    public class ClientResponse
    {
        public int? Id { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}

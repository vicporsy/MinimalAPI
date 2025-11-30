namespace MinimalAPI.Infra.Entities
{
    public class Client : BaseDomain
    {
        public Guid Guid { get; set; } = Guid.CreateVersion7();
        public string Name { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}

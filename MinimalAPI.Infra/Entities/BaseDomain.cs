namespace MinimalAPI.Infra.Entities
{
    public class BaseDomain
    {
        public int? Id { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }
    }
}
namespace TaskForProject.Api.Models.Base
{
    public abstract class Auditabe : BaseEntity
    {
        public DateTime IsCreate { get; set; }=DateTime.UtcNow.AddHours(5);
        public DateTime UpdateAt { get; set; }=DateTime.UtcNow.AddHours(5);
    }
}

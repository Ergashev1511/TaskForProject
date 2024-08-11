using TaskForProject.Api.Models.Base;

namespace TaskForProject.Api.Models
{
    public class Book2 : Auditabe
    {
        public string Author { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string BookName { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
    }
}

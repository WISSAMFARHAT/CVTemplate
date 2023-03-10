namespace CVTemplate.Model
{
    public class EmployeModel
    {
        public Guid ID { get; set; }

        public Guid CheckInput { get; set; } = Guid.NewGuid();
        public string? Title { get; set; }
        public string? Employee { get; set; }
        public string? City { get; set; }

        public DateTime? Started { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Description { get; set; }
        public bool Present { get; set; } = false;
    }
}

namespace CVTemplate.Model
{
    public class SkillModel
    {
        public Guid ID { get; set; }
        public string? Title { get; set; }
        public string? Range { get; set; } = "0";
        public string? RangeName { get; set; } = "Make a choice";
    }
}

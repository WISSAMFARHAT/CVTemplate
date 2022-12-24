namespace CVTemplate.Model
{
    public class PersonalModel
    {
        public Guid ID { get; set; }
        public string? photo { get; set; }
        public string? Name { get; set; }
        public string? Position { get; set; }
        public string? Headline { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? PostCode { get; set; }
        public string? City { get; set; }

        public DateTime? DateofBirth { get; set; }
        public string? PalaceofBirth { get; set; }
        public string? Gender { get; set; }
        public string? Nationality { get; set; }
        public string? Website { get; set; }

        public bool IsEmpty => string.IsNullOrEmpty(photo)
            && string.IsNullOrEmpty(photo)
            && string.IsNullOrEmpty(Name)
            && string.IsNullOrEmpty(Position)
            && string.IsNullOrEmpty(Headline)
            && string.IsNullOrEmpty(Email)
            && string.IsNullOrEmpty(PhoneNumber)
            && string.IsNullOrEmpty(Address)
            && string.IsNullOrEmpty(PostCode)
            && string.IsNullOrEmpty(City)
            && string.IsNullOrEmpty(PalaceofBirth)
            && string.IsNullOrEmpty(Gender)
            && !DateofBirth.HasValue
            && string.IsNullOrEmpty(Nationality)
            && string.IsNullOrEmpty(Website);
    }
}

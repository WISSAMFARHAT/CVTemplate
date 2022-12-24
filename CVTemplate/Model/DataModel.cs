namespace CVTemplate.Model
{
    public class DataModel
    {
        public PersonalModel Personal { get; set; } = new();
        public List<EducationModel> Educations { get; set; } = new();
        public List<EmployeModel> Employees { get; set; } = new();
        public List<HobbyModel> Hobbies { get; set; } = new();
        public List<LanguagesModel> Languages { get; set; } = new();
        public List<SkillModel> Skills { get; set; } = new();
        public bool IsEmpty => Personal.IsEmpty
            && !Educations.Any()
            && !Employees.Any()
            && !Hobbies.Any()
            && !Languages.Any()
            && !Skills.Any();
    }
}

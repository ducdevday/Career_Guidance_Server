namespace EducationChallengerBE.Shared.Dtos
{
    public class BaseApiRequest
    {
        public int? PageSize { get; set; }
        public int? PageIndex { get; set; }
        public List<FieldFilter>? Filters { get; set; }
    }
}

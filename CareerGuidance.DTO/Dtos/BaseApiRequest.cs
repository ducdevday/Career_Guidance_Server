namespace EducationChallengerBE.Shared.Dtos
{
    public abstract class BaseApiRequest
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}

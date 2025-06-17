namespace EducationChallengerBE.Shared.Dtos
{
    public class BaseApiResponse<T>
    {
        public T? Data { get; set; }
        public string? Code { get; set; }
        public Guid TraceId { get; set; }
        public bool Success { get; set; }
        public List<string>? Messages { get; set; }
        public int? CurrentPageIndex { get; set; }
        public int? CurrentPageCount { get; set; }
        public int? TotalCount { get; set; }
    }
}

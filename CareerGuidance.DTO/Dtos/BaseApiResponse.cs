using System.Net;

namespace EducationChallengerBE.Shared.Dtos
{
    public class BaseApiResponse<T>
    {
        public HttpStatusCode StatusCode { get; set; }
        public List<string>? Messages { get; set; }
        public T? Data { get; set; }
        public int? CurrentPageIndex { get; set; }
        public int? CurrentPageCount { get; set; }
        public int? TotalCount { get; set; }
        public BaseApiResponse(HttpStatusCode statusCode, List<string> messages, T data)
        {
            StatusCode = statusCode;
            Messages = messages;
            Data = data;
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {

    }

    public class ApiResponse<T>
    {
        public string? Status { get; set; }
        public T? Data { get; set; }
        public ApiError? Error { get; set; }
        public ApiMeta? Meta { get; set; }
    }

    public class ApiError
    {
        public int? Code { get; set; }
        public string? Message { get; set; }
        public List<string>? Details { get; set; }
    }

    public class ApiMeta
    {
        public int? CurrentPage { get; set; }
        public int? TotalPages { get; set; }
        public int? TotalItems { get; set; }
    }

}

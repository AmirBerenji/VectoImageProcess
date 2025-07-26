using Application.Core;
using Application.Dtos;
using Application.Services.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ImageProcessController : BaseApiController
    {
    
        private readonly IImageProcessService _imageProcessService;
        public ImageProcessController( IImageProcessService imageProcessService)
        {
            _imageProcessService = imageProcessService; 
        }

        [HttpPost("process")]
        public async Task<IActionResult> ProcessImages([FromBody] List<ImageRequestDto> request)
        {
            try
            {
              
                var result = await _imageProcessService.ImageProcess(request);

                var response = new ApiResponse<List<string>>()
                {
                    Status = "Success",
                    Data = result
                };

                return Ok(response);
            }
            catch (Exception e)
            {
                var response = new ApiResponse<string>()
                {
                    Status = "Failed",
                    Error = new ApiError()
                    {
                        Code = 500,
                        Message = e.Message
                    }
                };

                return BadRequest(response);
            };    
            
        }

    }
}

using Application.Core;
using Application.Dtos;
using Application.Services.interfaces;

namespace Application.Services
{
    public class ImageProcessService : IImageProcessService
    {
        private readonly ImageProcessor _processor;
        public ImageProcessService(ImageProcessor processor)
        {
            _processor = processor;
        }

        public async Task<List<string>> ImageProcess(List<ImageRequestDto> request)
        {
            var images = request.Select(img => new Image
            {
                Name = img.Name,
                Effects = img.Effects.Select(e => (e.Name, (object)e.Param)).ToList()
            }).ToList();

            var result = await _processor.ProcessImages(images);

            return result;
        }
    }
}

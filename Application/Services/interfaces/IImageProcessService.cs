using Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.interfaces
{
    public interface IImageProcessService
    {
        Task<List<string>> ImageProcess(List<ImageRequestDto> request);
    }
}

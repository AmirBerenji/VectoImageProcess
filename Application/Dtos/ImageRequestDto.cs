using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class ImageRequestDto
    {
        public string Name { get; set; }
        public List<EffectDto> Effects { get; set; }
    }
}

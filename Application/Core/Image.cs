using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core
{
    public class Image
    {
        public string Name { get; set; }
        public List<(string EffectName, object Parameter)> Effects { get; set; } = new();
    }
}

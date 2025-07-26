using Application.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Plugins
{
    public class GrayscaleEffect : ImageEffectBase
    {
        public override string Name => "Grayscale";

        public override void Apply(string imageName, object parameter = null)
        {
            LogEffect(imageName, parameter);
        }
    }
}

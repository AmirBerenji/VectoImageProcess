using Application.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Plugins
{
    public class BlurEffect : ImageEffectBase
    {
        public override string Name => "Blur";

        public override void Apply(string imageName, object parameter = null)
        {
            LogEffect(imageName, parameter);
        }
    }
}

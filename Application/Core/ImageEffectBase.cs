using Application.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core
{
    public abstract class ImageEffectBase : IImageEffect
    {
        public abstract string Name { get; }

        public abstract void Apply(string imageName, object parameter = null);

        protected void LogEffect(string imageName, object parameter)
        {
            Console.WriteLine($"[Effect: {Name}] applied on '{imageName}' with parameter: {parameter ?? "None"}");
        }
    }
}

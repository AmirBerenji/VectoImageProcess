using Application.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core
{
    public class ImageProcessor
    {
        private readonly Dictionary<string, IImageEffect> _availableEffects = new();

        public ImageProcessor()
        {
            LoadEffects();
        }

        private void LoadEffects()
        {
            var effectType = typeof(IImageEffect);
            var types = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => effectType.IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract);

            foreach (var type in types)
            {
                var effect = (IImageEffect)Activator.CreateInstance(type);
                _availableEffects[effect.Name.ToLower()] = effect;
            }
        }

        public async  Task<List<string>> ProcessImages(List<Image> images)
        {
            var logs = new List<string>();

            foreach (var image in images)
            {
                logs.Add($"Processing '{image.Name}':");

                foreach (var (effectName, parameter) in image.Effects)
                {
                    if (_availableEffects.TryGetValue(effectName.ToLower(), out var effect))
                    {
                        logs.Add($"- {effect.Name} applied with parameter: {parameter ?? "None"}");
                        effect.Apply(image.Name, parameter);
                    }
                    else
                    {
                        logs.Add($"- [Warning] Effect '{effectName}' not found.");
                    }
                }
            }

            return logs;
        }
    }
}

using AlchemyColorShaper.Core;
using System;

namespace AlchemyColorShaper.Cli
{
    internal class Program
    {
        private const double _scaleFactor = 0.4;

        // TODO: Implement flags and clean up the entrypoint
        static void Main(string[] args)
        {
            if (args.Length < 1) Environment.Exit(1);
            var image = Importer.ImportImage(args[0]);

            var paletteCountingMethod = PaletteGenerator.GeneratePalette(image, new PaletteGeneratorOptions
            {
                Algorithm = PaletteGeneratorAlgorithm.CountingMethod,
                ScaleFactor = _scaleFactor,
                ColorThreshold = 250,
                MaxEntries = 7
            });

            var paletteTensorMethod = PaletteGenerator.GeneratePalette(image, new PaletteGeneratorOptions
            {
                Algorithm = PaletteGeneratorAlgorithm.TensorMethod,
                ScaleFactor = _scaleFactor,
                MaxEntries = 7
            });

            Exporter.ExportPalleteImageAsPngFile("palette-counting-method.png", paletteCountingMethod, 800, false);
            Exporter.ExportPalleteImageAsPngFile("palette-tensor-method.png", paletteTensorMethod, 800, false);

            Environment.Exit(0);
        }
    }
}
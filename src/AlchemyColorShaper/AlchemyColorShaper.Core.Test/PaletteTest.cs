using AlchemyColorShaper.Core.Test.Extensions;
using SkiaSharp;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Sdk;

namespace AlchemyColorShaper.Core.Test
{
    public class PaletteTest
    {
        private static readonly SKColor Red = new(255, 0, 0);
        private static readonly SKColor Green = new(0, 255, 0);
        private static readonly SKColor Blue = new(0, 0, 255);
        private static readonly SKColor White = new(255, 255, 255);
        private static readonly SKColor Black = new(0, 0, 0);

        [Fact]
        public void Palette_Empty_Should_Create()
        {
            var palette = Palette.CreateEmpty();

            Assert.NotNull(palette);
            Assert.Empty(palette.Colors);
        }

        [Fact]
        public void Palette_From_Color_Enumerable_Should_Create()
        {
            var colors = new List<SKColor>{ Red, Green, Blue, Black, White };
            var palette = Palette.CreateFromEnumerable(colors);

            Assert.NotNull(palette);
            Assert.NotEmpty(palette.Colors);

        }

        [Fact]
        public void Palette_Should_Order_Colors_By_Brightness()
        {
            var colors = new List<SKColor> { Red, Green, Blue, Black, White };
            var palette = Palette.CreateFromEnumerable(colors);

            Assert.NotNull(palette);
            Assert.NotEmpty(palette.Colors);

            var expected = (new List<SKColor> { White, Green, Red, Blue, Black }).AsReadOnly();

            Assert.Equal(expected, palette.Colors);
        }

        [Fact]
        public void Palette_Generate_Palette_Image_Default()
        {
            var colors = new List<SKColor> { Red, Green, Blue };
            var palette = Palette.CreateFromEnumerable(colors);

            Assert.NotNull(palette);
            Assert.NotEmpty(palette.Colors);

            var expectedWidth = 2;
            var expectedHeight = 6;

            var expectedImage = new SKBitmap(expectedWidth, expectedHeight);
            foreach (var y in Enumerable.Range(0, expectedHeight))
            {
                foreach (var x in Enumerable.Range(0, expectedWidth))
                {
                    var color = y switch
                    {
                        0 or 1 => Green,
                        2 or 3 => Red,
                        4 or 5 => Blue,
                        _ => throw new XunitException()
                    };

                    expectedImage.SetPixel(x, y, color);
                }
            }

            var actualImage = palette.GeneratePaletteImage(expectedHeight, false);

            Assert.NotNull(actualImage);

            Assert.Equal(expectedWidth, actualImage.Width);
            Assert.Equal(expectedHeight, actualImage.Height);
            Assert.True(ImageAssert.ImagesEqual(expectedImage, actualImage));
        }

        [Fact]
        public void Palette_Generate_Palette_Image_Inverted()
        {
            var colors = new List<SKColor> { Red, Green, Blue };
            var palette = Palette.CreateFromEnumerable(colors);

            Assert.NotNull(palette);
            Assert.NotEmpty(palette.Colors);

            var expectedWidth = 2;
            var expectedHeight = 6;

            var expectedImage = new SKBitmap(expectedWidth, expectedHeight);
            foreach (var y in Enumerable.Range(0, expectedHeight))
            {
                foreach (var x in Enumerable.Range(0, expectedWidth))
                {
                    var color = y switch
                    {
                        0 or 1 => Blue,
                        2 or 3 => Red,
                        4 or 5 => Green,
                        _ => throw new XunitException()
                    };

                    expectedImage.SetPixel(x, y, color);
                }
            }

            var actualImage = palette.GeneratePaletteImage(expectedHeight, true);

            Assert.NotNull(actualImage);

            Assert.Equal(expectedWidth, actualImage.Width);
            Assert.Equal(expectedHeight, actualImage.Height);
            Assert.True(ImageAssert.ImagesEqual(expectedImage, actualImage));
        }
    }
}

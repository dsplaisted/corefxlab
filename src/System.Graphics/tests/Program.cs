using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Graphics.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var image = new Image(100, 100, true);
            var r = image.AllocateColor(255, 0, 0);
            var g = image.AllocateColor(0, 255, 0);
            var b = image.AllocateColor(0, 0, 255);

            image.FillRectangle(0, 0, 99, 99, r);
            image.DrawRectangle(20, 20, 79, 79, g);
            image.DrawEllipse(70, 25, 30, 20, b);

            using (var stream = File.OpenWrite("test.png"))
            {
                image.WritePng(stream);
            }

            using (var stream = File.OpenRead("test.png"))
            {
                image = Image.FromPng(stream);
            }

            var grey = image.AllocateColor(127, 127, 127);
            image.FillRectangle(30, 30, 49, 49, grey);

            image = image.Resize(image.Width * 2, image.Height * 2);

            using (var stream = File.OpenWrite("test2.png"))
            {
                image.WritePng(stream);
            }
        }
    }
}

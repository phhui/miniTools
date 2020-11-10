using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace ppqq
{
    class Unpacker
    {
        const byte ALPHA_THRESHOLD = 1;

        public void Unpack(string path)
        {
            if (path.Length < 1) return;
            var bitmap = (Bitmap)Bitmap.FromFile(path);
            var bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            var pixels = new byte[bitmap.Width * bitmap.Height * 4];
            var marks = new bool[bitmap.Width * bitmap.Height];
            Marshal.Copy(bitmapData.Scan0, pixels, 0, pixels.Length);
            bitmap.UnlockBits(bitmapData);

            System.Console.WriteLine("#### Parse Rectangles");

            var rects = new List<Rectangle>();
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    int p = x * 4 + y * bitmapData.Stride;
                    var a = pixels[p + 3];
                    if (a < ALPHA_THRESHOLD)
                        continue;
                    if (marks[x + y * bitmap.Width])
                        continue;

                    marks[x + y * bitmap.Width] = true;

                    var rect = new Rectangle(new Point(x, y), new Size(1, 1));
                    var stack = new Stack<Point>();
                    stack.Push(new Point(x, y));
                    do
                    {
                        int bx = x;
                        int by = y;

                        bool marked = false;
                        for (int ty = -1; ty <= +1 && !marked; ty++)
                        {
                            for (int tx = -1; tx <= +1 && !marked; tx++)
                            {
                                x = bx + tx;
                                y = by + ty;
                                if (Mark(ref rect, ref pixels, ref marks, x, y, bitmap.Width, bitmap.Height, bitmapData.Stride))
                                {
                                    stack.Push(new Point(x, y));
                                    marked = true;
                                }
                            }
                        }
                        if (marked)
                            continue;

                        x = stack.Peek().X;
                        y = stack.Peek().Y;
                        stack.Pop();
                    }
                    while (stack.Any());
                    rects.Add(rect);

                    FillMark(ref rect, ref marks, bitmap.Width);

                    System.Console.WriteLine("Add Rectangle {0}, {1}, {2}, {3}", rect.X, rect.Y, rect.Width, rect.Height);
                }
            }

            var dirName = Path.GetDirectoryName(path);
            var fileName = Path.GetFileNameWithoutExtension(path);
            var newDirName = Path.Combine(dirName, fileName);
            if (!Directory.Exists(newDirName))
                Directory.CreateDirectory(newDirName);

#if false

			var image = new Bitmap(bitmap.Width, bitmap.Height);
			var g = Graphics.FromImage(image);
			var brushes = new Brush[]
			{
				//new SolidBrush(Color.FromArgb(0xFF, 0xFF, 0x00, 0x00)),
				//new SolidBrush(Color.FromArgb(0xFF, 0xFF, 0x40, 0x00)),
				//new SolidBrush(Color.FromArgb(0xFF, 0xFF, 0x80, 0x00)),
				//new SolidBrush(Color.FromArgb(0xFF, 0xFF, 0xC0, 0x00)),
				//new SolidBrush(Color.FromArgb(0xFF, 0xFF, 0xFF, 0x00)),
				//new SolidBrush(Color.FromArgb(0xFF, 0xC0, 0xFF, 0x00)),
				//new SolidBrush(Color.FromArgb(0xFF, 0x80, 0xFF, 0x00)),
				//new SolidBrush(Color.FromArgb(0xFF, 0x40, 0xFF, 0x00)),
				new SolidBrush(Color.FromArgb(0xFF, 0x00, 0xFF, 0x00)),
				new SolidBrush(Color.FromArgb(0xFF, 0x00, 0xFF, 0x40)),
				new SolidBrush(Color.FromArgb(0xFF, 0x00, 0xFF, 0x80)),
				new SolidBrush(Color.FromArgb(0xFF, 0x00, 0xFF, 0xC0)),
				new SolidBrush(Color.FromArgb(0xFF, 0x00, 0xFF, 0xFF)),
				new SolidBrush(Color.FromArgb(0xFF, 0x00, 0xC0, 0xFF)),
				new SolidBrush(Color.FromArgb(0xFF, 0x00, 0x80, 0xFF)),
				new SolidBrush(Color.FromArgb(0xFF, 0x00, 0x40, 0xFF)),
				new SolidBrush(Color.FromArgb(0xFF, 0x00, 0x00, 0xFF)),
				//new SolidBrush(Color.FromArgb(0xFF, 0x40, 0x00, 0xFF)),
				//new SolidBrush(Color.FromArgb(0xFF, 0x80, 0x00, 0xFF)),
				//new SolidBrush(Color.FromArgb(0xFF, 0xC0, 0x00, 0xFF)),
				//new SolidBrush(Color.FromArgb(0xFF, 0xFF, 0x00, 0xFF)),
				//new SolidBrush(Color.FromArgb(0xFF, 0xFF, 0x00, 0xC0)),
				//new SolidBrush(Color.FromArgb(0xFF, 0xFF, 0x00, 0x80)),
				//new SolidBrush(Color.FromArgb(0xFF, 0xFF, 0x00, 0x40)),
			};
			for (int i = 0; i < rects.Count; i++)
			{
				if (i > 0)
				{
					int j = (i + brushes.Length - 1) % brushes.Length;
					var brush = brushes[j];
					g.FillRectangle(brush, rects[i - 1]);
				}
				{
					var brush = Brushes.Red;
					g.FillRectangle(brush, rects[i]);
				}
				image.Save(Path.Combine(newDirName, i.ToString("D4")) + ".png");
			}

			//bitmap = (Bitmap)pictureBox2.Image;
			//bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
			//Marshal.Copy(pixels, 0, bitmapData.Scan0, pixels.Length);
			//bitmap.UnlockBits(bitmapData);

#else

            System.Console.WriteLine("#### Output Images");

            for (int i = 0; i < rects.Count; i++)
            {
                var destBitmap = bitmap.Clone(rects[i], PixelFormat.Format32bppArgb);
                var name = newDirName.Substring(newDirName.LastIndexOf("\\") + 1);
                var destPath = Path.Combine(newDirName, name + i.ToString("D4")) + ".png";

                System.Console.WriteLine("Output '{0}'", destPath);

                destBitmap.Save(destPath);
            }

#endif
        }

        bool Mark(ref Rectangle rect, ref byte[] pixels, ref bool[] marks, int x, int y, int width, int height, int stride)
        {
            if (x < 0)
                return false;
            if (x > width - 1)
                return false;
            if (y < 0)
                return false;
            if (y > height - 1)
                return false;

            int p = x * 4 + y * stride;
            var a = pixels[p + 3];
            if (a < ALPHA_THRESHOLD)
                return false;
            if (marks[x + y * width])
                return false;

            marks[x + y * width] = true;

            if (rect.X > x)
            {
                rect.X = x;
                rect.Width++;
            }
            if (rect.X + rect.Width <= x)
            {
                rect.Width++;
            }
            if (rect.Y > y)
            {
                rect.Y = y;
                rect.Height++;
            }
            if (rect.Y + rect.Height <= y)
            {
                rect.Height++;
            }

            return true;
        }

        void FillMark(ref Rectangle rect, ref bool[] marks, int width)
        {
            int p = rect.X + rect.Y * width;
            for (int y = 0; y < rect.Height; y++)
            {
                for (int x = 0; x < rect.Width; x++)
                    marks[p++] = true;
                p += width - rect.Width;
            }
        }
    }
}

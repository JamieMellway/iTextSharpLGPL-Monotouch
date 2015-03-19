using System.IO;

namespace System.Drawing
{
	public sealed class Bitmap : Image
	{
		public Bitmap (int width, int height) { throw new NotImplementedException ("System.Drawing.Bitmap is not implemented in Mono For Android"); }

		public Bitmap (Stream stream, bool useIcm) { throw new NotImplementedException ("System.Drawing.Bitmap is not implemented in Mono For Android"); }

		public Bitmap (Type type, string resource) { throw new NotImplementedException ("System.Drawing.Bitmap is not implemented in Mono For Android"); }

		public Bitmap (Image original, int width, int height) { throw new NotImplementedException ("System.Drawing.Bitmap is not implemented in Mono For Android"); }

		public Color GetPixel (int x, int y) { throw new NotImplementedException ("System.Drawing.Bitmap is not implemented in Mono For Android"); }

		public void SetPixel (int x, int y, Color color) { throw new NotImplementedException ("System.Drawing.Bitmap is not implemented in Mono For Android"); }
	}
}
using System.IO;
using System.Drawing.Imaging;

namespace System.Drawing
{
	public abstract class Image 
	{
		public void Save (Stream stream, ImageFormat format) { throw new NotImplementedException ("System.Drawing.Image is not implemented in Mono For Android");}

		public int Height {	get { throw new NotImplementedException ("System.Drawing.Image is not implemented in Mono For Android");	} }

		public int Width { get { throw new NotImplementedException ("System.Drawing.Image is not implemented in Mono For Android"); } }
	}
}
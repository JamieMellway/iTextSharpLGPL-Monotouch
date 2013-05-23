using System;
using MonoTouch.QuickLook;
using MonoTouch.Foundation;
using System.IO;

namespace iTextSharpTest
{
	public class PDFViewDataSource : QLPreviewControllerDataSource
	{
		public PDFViewDataSource (string fileName)
		{
			this.fileName = fileName;
		}

		private string fileName;

		public override int PreviewItemCount(QLPreviewController controller)
		{
			return 1;
		}

		public override QLPreviewItem GetPreviewItem(QLPreviewController controller, int index)
		{
			string documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.InternetCache);
			NSUrl url = NSUrl.FromFilename (Path.Combine (documentsPath, fileName));

			return new PDFViewItem (fileName, url);
		}
	}


}


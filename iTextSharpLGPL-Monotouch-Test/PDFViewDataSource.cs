using System;
using QuickLook;
using Foundation;
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

		public override nint PreviewItemCount(QLPreviewController controller)
		{
			return 1;
		}

		public override IQLPreviewItem GetPreviewItem(QLPreviewController controller, nint index)
		{
			string documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.InternetCache);
			NSUrl url = NSUrl.FromFilename (Path.Combine (documentsPath, fileName));

			return new PDFViewItem (fileName, url);
		}
	}


}


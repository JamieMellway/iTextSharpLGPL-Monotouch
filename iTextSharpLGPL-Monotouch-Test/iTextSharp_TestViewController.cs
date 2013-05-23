using System;
using System.IO;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MonoTouch.QuickLook;

namespace iTextSharpTest
{
	public partial class iTextSharp_TestViewController :  UIViewController
	{
		string filePdf = string.Empty;

		public iTextSharp_TestViewController () : base ("iTextSharp_TestViewController", null)
		{
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);

			QLPreviewController previewController = new QLPreviewController();
			previewController.DataSource = new PDFViewDataSource(filePdf);
			this.PresentViewController(previewController, true, null);
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			filePdf = Path.Combine (Environment.GetFolderPath (Environment.SpecialFolder.InternetCache), "PDF_Temp.pdf");
			
			var document = new Document(PageSize.LETTER);
			
			// Create a new PdfWriter object, specifying the output stream
			var output = new FileStream(filePdf, FileMode.Create);
			var writer = PdfWriter.GetInstance(document, output);
			
			// Open the Document for writing
			document.Open();

			BaseFont bf = BaseFont.CreateFont (BaseFont.HELVETICA, BaseFont.CP1252, false);
			iTextSharp.text.Font font = new iTextSharp.text.Font (bf, 16, iTextSharp.text.Font.BOLD);
			var p = new Paragraph ("Sample text", font);

			document.Add (p);
			document.Close ();
			writer.Close ();

			//Close the Document - this saves the document contents to the output stream
			document.Close();
			writer.Close ();
		}
	}
}


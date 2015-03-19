using System;
using QuickLook;
using Foundation;
using System.IO;

namespace iTextSharpTest
{
	public class PDFViewItem : QLPreviewItem
	{
		public PDFViewItem(string title, NSUrl url)
		{
			this.title = title.Substring(title.LastIndexOf("/") + 1, title.Length - title.LastIndexOf("/") -1);
			this.url = url;
		}

		private string title;
		private NSUrl url;

		public override string ItemTitle
		{
			get { return title; }
		}

		public override NSUrl ItemUrl
		{
			get { return url; }
		}
	}
}


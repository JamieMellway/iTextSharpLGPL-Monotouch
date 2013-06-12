iTextSharpLGPL-Monotouch
========================
This project is taking the last version of the iTextSharp that was licenced with LGPL, putting it 
in an iOS Library Project, adding a reference to monotouch, adding in a Mono System.Drawing.dll 
from the Mono sysdrawing-coregraphics project, and making a few minor tweaks to get it working.

Changes to code:
- Added setter to the Chunk Content.  (This was a custom need.) 
- Removed Barcode files.  (iTextSharp-Monotouch did this and I didn't need it, so I removed it just in case.)
- Removed an optimization in the ECFieldElement sqrt() function.  (I needed to do this to compile) 
- Commented out line 623 in LinearGradientBrush (context.DrawShading(shading);) in Mono's sysdrawing-coregraphics to get it to compile.
- In Properties.Load, falling back to no specified encoding for StreamReader on exception.  (CJK fonts did not work until I fixed this.)
- I needed to restore the Resource IDs of everything in iTextSharp/text/pdf/fonts so they started with "iTextSharp.text.pdf.fonts." so that fonts worked.

Licensing
=========
You have three license choices when it comes to iTextSharp: LGPL, AGPL, or a commercial license. The LGPL license is only an option with the older 4.1.6 version (used here). After that version, they switched to a dual AGPL/Commercial.

The short version of the license conditions goes like this. With LGPL you need to publicly release any changes to the library itself (like I have done here) but you don't have to release the projects that link to the library. With the AGPL license, you need to release all your source code publicly. By merely linking their code in your project, your project is now open-source. Paying for a commercial license, however, let's you use their library and not require you to release your source code. Go here to fill out a form, so they can email you the price: http://itextpdf.com/terms-of-use/index.php

If you need a more recent version, you either have to make your project open-source or pay the license fee.  For the AGPL and commercial license, use https://github.com/mapo80/iTextSharp-Monotouch/ instead as it uses the more recent AGPL/Commercial version of iTextSharp. 

Links
=====
iTextSharp-LGPL NuGet Package
http://nuget.org/packages/iTextSharp-LGPL

iTextSharp-4.1.6 From GitHub
https://github.com/itextsharper/iTextSharp-4.1.6

iTextSharp
http://itextpdf.com

iTextSharp-Monotouch is a similar project that uses a dual AGPL/Commercial license version of iTextSharp
https://github.com/mapo80/iTextSharp-Monotouch

Monotouch
http://xamarin.com/monotouch

Mono's sysdrawing-coregraphics
https://github.com/mono/sysdrawing-coregraphics
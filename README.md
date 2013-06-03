iTextSharpLGPL-Monotouch

This project is taking the last version of the iTextSharp that was licenced with LGPL, putting it 
in an iOS Library Project, adding a reference to monotouch, adding in a Mono System.Drawing.dll 
from the Mono sysdrawing-coregraphics project, and making a few minor tweaks to get it working.

Changes to code:
- Added setter to the Chunk Content
- Removed Barcode files
- Removed an optimization in the ECFieldElement sqrt() function
- Commented out line 623 in LinearGradientBrush (context.DrawShading(shading);) in Mono's sysdrawing-coregraphics to get it to compile.
- In Properties.Load, falling back to no specified encoding for StreamReader on exception

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
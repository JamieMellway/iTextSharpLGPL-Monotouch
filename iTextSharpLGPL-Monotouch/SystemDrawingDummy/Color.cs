using System;

namespace System.Drawing 
{
	[Serializable]
	public struct Color {
		int value;

		public static Color FromArgb (int red, int green, int blue)
		{
			return FromArgb (255, red, green, blue);
		}

		public static Color FromArgb (int alpha, int red, int green, int blue)
		{
			if((red > 255) || (red < 0))
				throw CreateColorArgumentException(red, "red");
			if((green > 255) || (green < 0))
				throw CreateColorArgumentException (green, "green");
			if((blue > 255) || (blue < 0))
				throw CreateColorArgumentException (blue, "blue");
			if((alpha > 255) || (alpha < 0))
				throw CreateColorArgumentException (alpha, "alpha");

			Color color = new Color ();
			color.value = (int)((uint) alpha << 24) + (red << 16) + (green << 8) + blue;
			return color;
		}
	
		public static Color FromArgb (int argb)
		{
			return FromArgb ((argb >> 24) & 0x0FF, (argb >> 16) & 0x0FF, (argb >> 8) & 0x0FF, argb & 0x0FF);
		}

		public int ToArgb()
		{
			return (int) value;
		} 

		public byte A {
			get { return (byte) (value >> 24); }
		}

		public byte R {
			get { return (byte) (value >> 16); }
		}

		public byte G {
			get { return (byte) (value >> 8); }
		}

		public byte B {
			get { return (byte) value; }
		}

		private static ArgumentException CreateColorArgumentException (int value, string color)
		{
			return new ArgumentException (string.Format ("'{0}' is not a valid"
				+ " value for '{1}'. '{1}' should be greater or equal to 0 and"
				+ " less than or equal to 255.", value, color));
		}

		static public Color Gray {
			get { 
				return Color.FromArgb (0x80, 0x80, 0x80);  // TODO: Fix.  This is not the right value.
				//return KnownColors.FromKnownColor (KnownColor.Gray); 
			}
		}
	}
}


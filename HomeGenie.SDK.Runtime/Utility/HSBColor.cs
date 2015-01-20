using System;
using System.Globalization;
#if SILVERLIGHT
using System.Windows.Media;
#else
using Windows.UI;   
#endif

namespace HomeGenie.SDK.Utility
{
    public class HSBColor
    {
        public double H { get; set; }
        public double S { get; set; }
        public double B { get; set; }
        public byte A { get; set; }

        public static HSBColor FromColor(Color rgbColor)
        {
            HSBColor result = new HSBColor {A = rgbColor.A};

            // preserve alpha

            // convert R, G, B to numbers from 0 to 1
            double r = rgbColor.R / 255d;
            double g = rgbColor.G / 255d;
            double b = rgbColor.B / 255d;

            double max = Math.Max(r, Math.Max(g, b));
            double min = Math.Min(r, Math.Min(g, b));

            // hue
            if (max == min)
                result.H = 0;
            else if (max == r)
                result.H = (60 * (g - b) / (max - min) + 360) % 360;
            else if (max == g)
                result.H = 60 * (b - r) / (max - min) + 120;
            else
                result.H = 60 * (r - g) / (max - min) + 240;

            // saturation
            if (max == 0)
                result.S = 0;
            else
                result.S = 1 - min / max;

            // brightness
            result.B = max;

            return result;
        }

        public Color ToColor()
        {
            Color result = new Color {A = A};

            int hi = (int)Math.Floor(H / 60) % 6;
            double f = H / 60 - Math.Floor(H / 60);

            double p = B * (1 - S);
            double q = B * (1 - f * S);
            double t = B * (1 - (1 - f) * S);

            switch (hi)
            {
                case 0:
                    result.R = (byte)(B * 255);
                    result.G = (byte)(t * 255);
                    result.B = (byte)(p * 255);
                    break;
                case 1:
                    result.R = (byte)(q * 255);
                    result.G = (byte)(B * 255);
                    result.B = (byte)(p * 255);
                    break;
                case 2:
                    result.R = (byte)(p * 255);
                    result.G = (byte)(B * 255);
                    result.B = (byte)(t * 255);
                    break;
                case 3:
                    result.R = (byte)(p * 255);
                    result.G = (byte)(q * 255);
                    result.B = (byte)(B * 255);
                    break;
                case 4:
                    result.R = (byte)(t * 255);
                    result.G = (byte)(p * 255);
                    result.B = (byte)(B * 255);
                    break;
                case 5:
                    result.R = (byte)(B * 255);
                    result.G = (byte)(p * 255);
                    result.B = (byte)(q * 255);
                    break;
            }

            return result;
        }

        public static HSBColor FromString(string value)
        {
            string[] colors = value.Split(',');
            if (colors.Length >= 3)
            {
                double h;
                double s;
                double b;
                if (double.TryParse(colors[0].Trim(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out h) &&
                    double.TryParse(colors[1].Trim(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out s) &&
                    double.TryParse(colors[2].Trim(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out b))
                {
                    return new HSBColor {A = 255, H = h*360d, S = s, B = b};
                }
            }

            return null;
        }
    }
}

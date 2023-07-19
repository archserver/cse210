using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chemical_Release_Pathing
{
    public static class TheamColor
    {
        public static List<string> ColorList = new List<string>()
                       {"#3F51B5",
                       "#009688",
                       "#FF5722",
                       "#607D8B",
                       "#FF9800",
                       "#9C27B0",
                       "#2196F3",
                       "#EA676C",
                       "#5978BB",
                       "#018790",
                       "#15E5E5",
                       "#15E5EA",
                       "#15E5EE",
                       "#15E5F5",
                       "#15CECE",
                       "#15B1B1",
                       "#C6E5E5",
                       "#C6E5E5",
                       "#C6E5E5",
                       "#ABE5E5",
                       "#88E5E5"};
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            //If correctionfactor is less than 0, darken color
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correctionfactor is greater than or equal to 0, lighten color
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}

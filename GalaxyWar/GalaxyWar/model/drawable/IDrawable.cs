using System.Drawing;

namespace GalaxyWar.model.drawable
{
    interface IDrawable
    {

        PointF Destination { get; set; }
        PointF Location { get; set; }
        SizeF Size { get; set; }
        Bitmap Model { get; set; }
        double Speed { get; set; }
        int Alpha { get; set; }
        Civilization Civilization { get; set; }
        PointF Center { get; set; }

    }
}

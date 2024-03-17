using System.Drawing.Drawing2D;

namespace AS_Coursework.Custom_Controls; 
public static class CustomControlGraphics {
    // Create a rounded rectangle graphics path
    public static GraphicsPath GetRoundedRectangleGraphicsPath(RectangleF rectangle, float cornerRadius) {
        GraphicsPath path = new();
        float curveSize = cornerRadius * 2f;

        path.StartFigure();

        // Add the arcs to the corners of the rectangle
        path.AddArc(rectangle.X, rectangle.Y, curveSize, curveSize, 180, 90);
        path.AddArc(rectangle.Right - curveSize, rectangle.Y, curveSize, curveSize, 270, 90);
        path.AddArc(rectangle.Right - curveSize, rectangle.Bottom - curveSize, curveSize, curveSize, 0, 90);
        path.AddArc(rectangle.X, rectangle.Bottom - curveSize, curveSize, curveSize, 90, 90);

        // Finish the path and return it
        path.CloseFigure();
        return path;
    }
}

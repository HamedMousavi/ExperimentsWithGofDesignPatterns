// -----------------------------------------------------------------------
// <copyright file="CanvasExtensions.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Patterns.Composite
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public static class CanvasExtensions
    {
        public static void DrawLines(this IShapeElement shape)
        {
            if (shape is Canvas)
            {
                System.Diagnostics.Debug.WriteLine(
                    $"{shape.Name}-EXTENSION: Drawing lines...");
                foreach (var child in shape)
                {
                    if (child is LineElement)
                    {
                        child.Draw();
                    }
                }
            }
        }
    }
}

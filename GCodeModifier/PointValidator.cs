using System;
using System.Linq;
using System.Text;

namespace GCodeModifier
{
    public class PointValidator
    {
        private const double Tolerance = 0.1; // 0.1 mm

        public static bool ValidateRigidTransformation(
            (double X, double Y)[] topPoints,
            (double X, double Y)[] bottomPoints,
            out string result)
        {
            if (topPoints.Length != 4 || bottomPoints.Length != 4)
            {
                result = "❌ Error: Exactly 4 points are required for both top and bottom.";
                return false;
            }

            var sb = new StringBuilder();

            // Compute centroids
            var centroidTop = GetCentroid(topPoints);
            var centroidBottom = GetCentroid(bottomPoints);

            // Center the points
            var topCentered = topPoints.Select(p => (p.X - centroidTop.X, p.Y - centroidTop.Y)).ToArray();
            var bottomCentered = bottomPoints.Select(p => (p.X - centroidBottom.X, p.Y - centroidBottom.Y)).ToArray();

            // Compute rotation using simplified Kabsch approach (2D)
            double[,] H = new double[2, 2];
            for (int i = 0; i < 4; i++)
            {
                H[0, 0] += topCentered[i].Item1 * bottomCentered[i].Item1;
                H[0, 1] += topCentered[i].Item1 * bottomCentered[i].Item2;
                H[1, 0] += topCentered[i].Item2 * bottomCentered[i].Item1;
                H[1, 1] += topCentered[i].Item2 * bottomCentered[i].Item2;
            }

            double theta = Math.Atan2(H[0, 1] - H[1, 0], H[0, 0] + H[1, 1]);
            double cos = Math.Cos(theta);
            double sin = Math.Sin(theta);

            double totalError = 0;
            bool allWithinTolerance = true;

            sb.AppendLine($"🔍 Tolerance = {Tolerance} mm");
            sb.AppendLine();

            for (int i = 0; i < 4; i++)
            {
                // Apply rotation
                double rotX = cos * topCentered[i].Item1 - sin * topCentered[i].Item2;
                double rotY = sin * topCentered[i].Item1 + cos * topCentered[i].Item2;

                // Apply translation to match bottom centroid
                double transformedX = rotX + centroidBottom.X;
                double transformedY = rotY + centroidBottom.Y;

                double dx = transformedX - bottomPoints[i].X;
                double dy = transformedY - bottomPoints[i].Y;
                double distance = Math.Sqrt(dx * dx + dy * dy);
                totalError += distance;

                string status = distance <= Tolerance ? "OK" : "X Exceeds";
                if (distance > Tolerance) allWithinTolerance = false;

                sb.AppendLine($"Point {i + 1} distance: {distance:F4} mm — {status}");
            }

            double averageError = totalError / 4.0;
            sb.AppendLine($"\nAverage transformation error: {averageError:F4} mm");

            result = sb.ToString();
            return allWithinTolerance;
        }

        private static (double X, double Y) GetCentroid((double X, double Y)[] points)
        {
            double sumX = points.Sum(p => p.X);
            double sumY = points.Sum(p => p.Y);
            return (sumX / points.Length, sumY / points.Length);
        }
    }
}

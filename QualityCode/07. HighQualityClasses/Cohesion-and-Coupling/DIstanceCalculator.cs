using System;

namespace CohesionAndCoupling
{
    public static class DistanceCalculator
    {
        /// <summary>
        /// Calculate the distance between two points in two dimentional plane.
        /// </summary>
        /// <param name="x1">First point horizontal position</param>
        /// <param name="y1">First point vertical position</param>
        /// <param name="x2">Second point horizontal position</param>
        /// <param name="y2">Second point vertical positio</param>
        /// <returns>The distance between the two points in a two dimentional plane</returns>
        public static double CalcDistance2D(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        /// <summary>
        /// Calculate the distance between two points in three dimentional plane.
        /// </summary>
        /// <param name="x1">First point horizontal position</param>
        /// <param name="y1">First point vertical position</param>
        /// <param name="z1">First point depth position</param>
        /// <param name="x2">Second point horizontal position</param>
        /// <param name="y2">Second point vertical positio</param>
        /// <param name="z2">Second point depth position</param>
        /// <returns>The distance between the two points in a three dimentional plane</returns>
        public static double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
            return distance;
        }
    }
}

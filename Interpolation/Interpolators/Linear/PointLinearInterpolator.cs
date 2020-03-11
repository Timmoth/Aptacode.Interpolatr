﻿using System.Drawing;
using System.Numerics;
using Aptacode.Interpolation.Interpolators.Linear.Generic;

namespace Aptacode.Interpolation.Interpolators.Linear
{
    public sealed class PointLinearInterpolator : GenericVec2LinearInterpolator<Point>
    {
        public override Point FromVector(Vector2 value)
        {
            return new Point((int) value.X, (int) value.Y);
        }

        public override Vector2 ToVector(Point value)
        {
            return new Vector2(value.X, value.Y);
        }
    }
}
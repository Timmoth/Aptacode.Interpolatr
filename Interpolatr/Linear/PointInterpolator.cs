﻿using System.Drawing;
using System.Numerics;
using Aptacode.Interpolatr.Linear.Generic;

namespace Aptacode.Interpolatr.Linear
{
    public sealed class PointInterpolator : GenericVec2Interpolator<Point>
    {
        public override Point FromVector(Vector2 vector) => new Point((int) vector.X, (int) vector.Y);

        public override Vector2 ToVector(Point value) => new Vector2(value.X, value.Y);
    }
}
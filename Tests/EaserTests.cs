﻿using NUnit.Framework;

namespace Aptacode.Interpolatr.Tests
{
    /// <summary>
    ///     Checks the ProgressAt(int, int) methods for each built in easer function return the correct value
    ///     at for specified index and total
    /// </summary>
    [TestFixture]
    public class EaserTests
    {
        private static readonly EaserFunction LinearEaser = DefaultEasers.Linear;

        [Test]
        [TestCase(0, 100, 0)]
        [TestCase(0, 1, 0)]
        [TestCase(1, 1, 1)]
        [TestCase(1, 2, 0.5)]
        [TestCase(1, 3, 0.33)]
        [TestCase(2, 3, 0.66)]
        [TestCase(0, 10, 0)]
        [TestCase(1, 10, 0.1)]
        [TestCase(2, 10, 0.2)]
        [TestCase(3, 10, 0.3)]
        [TestCase(4, 10, 0.4)]
        [TestCase(5, 10, 0.5)]
        [TestCase(6, 10, 0.6)]
        [TestCase(7, 10, 0.7)]
        [TestCase(8, 10, 0.8)]
        [TestCase(9, 10, 0.9)]
        [TestCase(10, 10, 1)]
        public void LinearEaserTests(int index, int total, double expectedValue)
        {
            Assert.That(LinearEaser(index, total), Is.EqualTo(expectedValue).Within(0.01));
        }
    }
}
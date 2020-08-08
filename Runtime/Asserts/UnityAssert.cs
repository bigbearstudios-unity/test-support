using UnityEngine;
using NUnit.Framework;
using System;

namespace BBUnity.TestSupport {
    public static class UnityAssert {
        public static void AreEqual(Vector2 v, Vector2 v2, float tolerance = 0.001f) {
            float distance = Vector2.Distance(v, v2);
            Assert.That(distance, Is.LessThanOrEqualTo(tolerance), AssertMessage(v, v2, distance, tolerance));
        }

        public static void AreEqual(Vector3 v, Vector3 v2, float tolerance = 0.001f) {
            float distance = Vector2.Distance(v, v2);
            Assert.That(distance, Is.LessThanOrEqualTo(tolerance), AssertMessage(v, v2, distance, tolerance));
        }

        public static void AreEqual(float f, float f2, float tolerance = 0.001f) {
            float absolute = Math.Abs(f - f2);
            Assert.That(absolute, Is.LessThanOrEqualTo(tolerance), AssertMessage(f, f2, absolute, tolerance)); 
        }

        private static string AssertMessage(Vector3 v, Vector3 v2, float distance, float tolerance) {
            return String.Format("Expected: Vector3({0}, {1}, {2})\nBut was:  Vector3({3}, {4}, {5})\nDistance: {6} is greated than allowed delta {7}",
                                    v.x, v.y, v.z,
                                    v2.x, v2.y, v2.z,
                                    distance, tolerance);
        }

        private static string AssertMessage(float f, float f2, float distance, float tolerance) {
            return String.Format("Expected: float({0})\nBut was:  float({1})\nAbsolute: {2} is greated than allowed delta {3}",
                                    f, f2, distance, tolerance);
        }
    }
}

﻿using UnityEngine;
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

        public static void AreEqual(Quaternion q, Quaternion q2, float tolerance = 0.001f) {
            float wDiff = Math.Abs(q.w - q2.w);
            float xDiff = Math.Abs(q.x - q2.x);
            float yDiff = Math.Abs(q.y - q2.y);
            float zDiff = Math.Abs(q.z - q2.z);

            Assert.That(wDiff, Is.LessThanOrEqualTo(tolerance), AssertMessage(q, q2, wDiff, tolerance)); 
            Assert.That(xDiff, Is.LessThanOrEqualTo(tolerance), AssertMessage(q, q2, xDiff, tolerance)); 
            Assert.That(yDiff, Is.LessThanOrEqualTo(tolerance), AssertMessage(q, q2, yDiff, tolerance)); 
            Assert.That(zDiff, Is.LessThanOrEqualTo(tolerance), AssertMessage(q, q2, zDiff, tolerance)); 
        }

        private static string AssertMessage(Vector3 v, Vector3 v2, float distance, float tolerance) {
            return String.Format("Expected: Vector3({0}, {1}, {2})\nBut was:  Vector3({3}, {4}, {5})\nDistance: {6} is greated than allowed delta {7}",
                                    v.x, v.y, v.z,
                                    v2.x, v2.y, v2.z,
                                    distance, tolerance);
        }

        private static string AssertMessage(Quaternion q, Quaternion q2, float distance, float tolerance) {
            return String.Format("Expected: Quaternion({0}, {1}, {2}, {3})\nBut was:  Quaternion({4}, {5}, {6}, {7})\nDistance: {8} is greated than allowed delta {9}",
                                    q.w, q.x, q.y, q.z,
                                    q2.w, q2.x, q2.y, q2.z,
                                    distance, tolerance);
        }

        private static string AssertMessage(float f, float f2, float distance, float tolerance) {
            return String.Format("Expected: float({0})\nBut was:  float({1})\nAbsolute: {2} is greated than allowed delta {3}",
                                    f, f2, distance, tolerance);
        }
    }
}

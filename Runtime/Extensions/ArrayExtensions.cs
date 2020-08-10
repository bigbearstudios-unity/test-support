using NUnit.Framework;

using System;

namespace BBUnity.TestSupport {
    public static class ArrayExtensions {

        /// <summary>
        /// Helper method to allow an array of items to be ran through a Func and 
        /// the result will have IsTrue called on it
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="action"></param>
        public static void IsTrue<T>(this T[] array, Func<T, bool> action) {
            foreach(T value in array) {
                Assert.IsTrue(action(value));
            }
        }

        /// <summary>
        /// Helper method to allow an array of items to be ran through a Func and 
        /// the result will have IsFalse called on it
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="action"></param>
        public static void IsFalse<T>(this T[] array, Func<T, bool> action) {
            foreach(T value in array) {
                Assert.IsFalse(action(value));
            }
        }

        /// <summary>
        /// Helper method to allow an array of items to be ran through a Func and 
        /// the result will have IsNotNull called on it
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="action"></param>
        public static void IsNotNull<T>(this T[] array, Func<T, object> action) {
            foreach(T value in array) {
                Assert.IsNotNull(action(value));
            }
        }

        /// <summary>
        /// Helper method to allow an array of items to be ran through a Func and 
        /// the result will have IsNull called on it
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="action"></param>
        public static void IsNull<T>(this T[] array, Func<T, object> action) {
            foreach(T value in array) {
                Assert.IsNull(action(value));
            }
        }
    }
}
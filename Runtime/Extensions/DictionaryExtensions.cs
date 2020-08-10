using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace BBUnity.TestSupport {
    public static class DictionaryExtensions {

        /// <summary>
        /// Helper method to allow a dictionary of keys / values to be compared after running through a Func which takes
        /// the key and gets compared against the value
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dictionary"></param>
        /// <param name="action"></param>
        public static void AreEqual<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, Func<TKey, TValue> action) {
            foreach (KeyValuePair<TKey, TValue> entry in dictionary) {
                Assert.AreEqual(entry.Value, action(entry.Key));
            }
        }
    }
}
using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace BBUnity.TestSupport {
    public static class DictionaryExtensions {
        public static void AreEqualToString(this Dictionary<string, int> dictionary, Func<int, string> action) {
            foreach (KeyValuePair<string, int> entry in dictionary) {
                Assert.AreEqual(entry.Key, action(entry.Value));
            }
        }

        public static void AreEqualToInt(this Dictionary<int, int> dictionary, Func<int, int> action) {
            foreach (KeyValuePair<int, int> entry in dictionary) {
                Assert.AreEqual(entry.Key, action(entry.Value));
            }
        }
    }
}
using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace BBUnity.TestSupport.Extensions {
    public static class DictionaryExtensions {
        public static void AreEqual<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, Func<TValue, TKey> action) {
            foreach (KeyValuePair<TKey, TValue> entry in dictionary) {
                Assert.AreEqual(entry.Key, action(entry.Value));
            }
        }

        public static void AreEqual(this Dictionary<string, int> dictionary, Func<int, string> action) {
            foreach (KeyValuePair<string, int> entry in dictionary) {
                Assert.AreEqual(entry.Key, action(entry.Value));
            }
        }

        public static void AreEqual(this Dictionary<int, int> dictionary, Func<int, int> action) {
            foreach (KeyValuePair<int, int> entry in dictionary) {
                Assert.AreEqual(entry.Key, action(entry.Value));
            }
        }
    }
}
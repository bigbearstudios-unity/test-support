using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace BBUnity.TestSupport {
    public static class DictionaryExtensions {
        public static void AreEqual<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, Func<TKey, TValue> action) {
            foreach (KeyValuePair<TKey, TValue> entry in dictionary) {
                Assert.AreEqual(entry.Value, action(entry.Key));
            }
        }
    }
}
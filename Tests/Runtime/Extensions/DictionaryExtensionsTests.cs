using NUnit.Framework;
using System.Collections.Generic;

using BBUnity.TestSupport;

namespace Extensions {
    public class DictionaryExtensionsTests {

        private string IntToString(int value) {
            return "" + value;
        }

        private int PlusOne(int value) {
            return value + 1;
        }

        [Test]
        public void AreEqual_ShouldPass_IfStringKeysAndValuesAreEqual() {
            new Dictionary<int, string> {
                { 1, "1" },
                { 10, "10" }
            }.AreEqual(IntToString);
        }

        [Test]
        public void AreEqual_ShouldThrowAssertionException_IfStringKeysAndValuesAreNotEqual() {
            Assert.Throws(typeof(AssertionException), () => {
                new Dictionary<int, string> {
                    { 1, "10" }
                }.AreEqual(IntToString);
            });
        }

        [Test]
        public void AreEqual_ShouldPass_IfIntKeysAndValuesAreEqual() {
            new Dictionary<int, int> {
                { 1, 2 }
            }.AreEqual(PlusOne);
        }

        [Test]
        public void AreEqual_ShouldThrowAssertionException_IfIntKeysAndValuesAreNotEqual() {
            Assert.Throws(typeof(AssertionException), () => {
                new Dictionary<int, int> {
                    { 1, 1 }
                }.AreEqual(PlusOne);
            });
        }
    }
}


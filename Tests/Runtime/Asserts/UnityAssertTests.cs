using NUnit.Framework;
using UnityEngine;

using BBUnity.TestSupport;

namespace Asserts {
    public class UnityAssertTests {

        [Test]
        public void AreEqual_ShouldPass_IfVector2Match() {
            UnityAssert.AreEqual(Vector2.zero, Vector2.zero);
            UnityAssert.AreEqual(Vector2.one, Vector2.one);
            UnityAssert.AreEqual(new Vector2(5.0f, 5.0f), new Vector2(5.0f, 5.0f));
        }

        [Test]
        public void AreEqual_ShouldPass_IfVector3Match() {
            UnityAssert.AreEqual(Vector3.zero, Vector3.zero);
            UnityAssert.AreEqual(Vector3.one, Vector3.one);
            UnityAssert.AreEqual(new Vector3(5.0f, 5.0f, 5.0f), new Vector3(5.0f, 5.0f, 5.0f));
        }

        [Test]
        public void AreEqual_ShouldPass_IfQuaternionMatch() {
            UnityAssert.AreEqual(Quaternion.identity, Quaternion.identity);
            UnityAssert.AreEqual(new Quaternion(1.0f, 1.0f, 1.0f, 1.0f), new Quaternion(1.0f, 1.0f, 1.0f, 1.0f));
            UnityAssert.AreEqual(new Quaternion(1.0f, 6.0f, 1.0f, 1.0f), new Quaternion(1.0f, 6.0f, 1.0f, 1.0f));
        }

        [Test]
        public void AreEqual_ShouldThrowAssertionException_IfVector2DoNotMatch() {
            Assert.Throws(typeof(AssertionException), () => {
                UnityAssert.AreEqual(Vector2.zero, Vector2.one);
            });

            Assert.Throws(typeof(AssertionException), () => { 
                UnityAssert.AreEqual(new Vector2(5.0f, 5.0f), new Vector2(5.0f, 1.0f));
            });
        }

        [Test]
        public void AreEqual_ShouldThrowAssertionException_IfVector3DoNotMatch() {
            Assert.Throws(typeof(AssertionException), () => {
                UnityAssert.AreEqual(Vector3.zero, Vector3.one);
            });

            Assert.Throws(typeof(AssertionException), () => { 
                UnityAssert.AreEqual(new Vector3(5.0f, 5.0f, 5.0f), new Vector3(5.0f, 1.0f, 5.0f));
            });
        }

        [Test]
        public void AreEqual_ShouldThrowAssertionException_IfQuaternionDoNotMatch() {
            Assert.Throws(typeof(AssertionException), () => {
                UnityAssert.AreEqual(Quaternion.identity, new Quaternion(0.0f, 1.0f, 0.0f, 1.0f));
            });

            Assert.Throws(typeof(AssertionException), () => { 
                UnityAssert.AreEqual(Quaternion.identity, new Quaternion(1.0f, 6.0f, 1.0f, 6.0f));
            });
        }

    }
}

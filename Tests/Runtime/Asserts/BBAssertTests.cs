using NUnit.Framework;
using UnityEngine;

using BBUnity.TestSupport;

using System.Collections.Generic;

namespace Asserts {
    public class UnityAssertTests {

        [Test]
        public void ChangeInSceneObjects_ShouldPass_WhenChangeIsTheSame() {
            UAssert.ChangeInSceneObjects(0, () => {

            });

            UAssert.ChangeInSceneObjects(1, () => {
                new GameObject();
            });

            GameObject obj = new GameObject();
            UAssert.ChangeInSceneObjects(-1, () => {
                GameObject.DestroyImmediate(obj);
            });
        }

        [Test]
        public void ChangeInSceneObjects_ShouldThrowAssertionException_WhenChangeDoNotMatch() {
            Assert.Throws(typeof(AssertionException), () => {
                UAssert.ChangeInSceneObjects(1, () => {

                });
            });

            Assert.Throws(typeof(AssertionException), () => {
                UAssert.ChangeInSceneObjects(-1, () => {

                });
            });
        }

        [Test]
        public void AreEqual_ShouldPass_IfVector2Match() {
            UAssert.AreEqual(Vector2.zero, Vector2.zero);
            UAssert.AreEqual(Vector2.one, Vector2.one);
            UAssert.AreEqual(new Vector2(5.0f, 5.0f), new Vector2(5.0f, 5.0f));
        }

        [Test]
        public void AreEqual_ShouldPass_IfVector3Match() {
            UAssert.AreEqual(Vector3.zero, Vector3.zero);
            UAssert.AreEqual(Vector3.one, Vector3.one);
            UAssert.AreEqual(new Vector3(5.0f, 5.0f, 5.0f), new Vector3(5.0f, 5.0f, 5.0f));
        }

        [Test]
        public void AreEqual_ShouldPass_IfQuaternionMatch() {
            UAssert.AreEqual(Quaternion.identity, Quaternion.identity);
            UAssert.AreEqual(new Quaternion(1.0f, 1.0f, 1.0f, 1.0f), new Quaternion(1.0f, 1.0f, 1.0f, 1.0f));
            UAssert.AreEqual(new Quaternion(1.0f, 6.0f, 1.0f, 1.0f), new Quaternion(1.0f, 6.0f, 1.0f, 1.0f));
        }

        [Test]
        public void AreEqual_ShouldThrowAssertionException_IfVector2DoNotMatch() {
            Assert.Throws(typeof(AssertionException), () => {
                UAssert.AreEqual(Vector2.zero, Vector2.one);
            });

            Assert.Throws(typeof(AssertionException), () => { 
                UAssert.AreEqual(new Vector2(5.0f, 5.0f), new Vector2(5.0f, 1.0f));
            });
        }

        [Test]
        public void AreEqual_ShouldThrowAssertionException_IfVector3DoNotMatch() {
            Assert.Throws(typeof(AssertionException), () => {
                UAssert.AreEqual(Vector3.zero, Vector3.one);
            });

            Assert.Throws(typeof(AssertionException), () => { 
                UAssert.AreEqual(new Vector3(5.0f, 5.0f, 5.0f), new Vector3(5.0f, 1.0f, 5.0f));
            });
        }

        [Test]
        public void AreEqual_ShouldThrowAssertionException_IfQuaternionDoNotMatch() {
            Assert.Throws(typeof(AssertionException), () => {
                UAssert.AreEqual(Quaternion.identity, new Quaternion(0.0f, 1.0f, 0.0f, 1.0f));
            });

            Assert.Throws(typeof(AssertionException), () => { 
                UAssert.AreEqual(Quaternion.identity, new Quaternion(1.0f, 6.0f, 1.0f, 6.0f));
            });
        }

        /*
         * Array Tests
         */

        private bool ReturnTrue(int v) {
            return true;
        }

        private bool ReturnFalse(int v) {
            return false;
        }

        [Test]
        public void IsTrue_ShouldPass_IfAllItemsReturnTrue() {
            UAssert.IsTrue(new int[] {
                1, 2
            }, ReturnTrue);
        }

        [Test]
        public void IsTrue_ShouldThrowAssertionException_IfAllItemsReturnFalse() {
            Assert.Throws(typeof(AssertionException), () => {
                UAssert.IsTrue(new int[] {
                    1, 2
                }, ReturnFalse);
            });
        }

        [Test]
        public void IsFalse_ShouldPass_IfAllItemsReturnFalse() {
            UAssert.IsFalse(new int[] {
                1, 2
            }, ReturnFalse);
        }

        [Test]
        public void IsFalse_ShouldThrowAssertionException_IfAllItemsReturnTrue() {
            Assert.Throws(typeof(AssertionException), () => {
                UAssert.IsFalse(new int[] {
                    1, 2
                }, ReturnTrue);
            });
        }

        /*
         * Dictionary Asserts
         */

        private string IntToString(int value) {
            return "" + value;
        }

        private int PlusOne(int value) {
            return value + 1;
        }

        [Test]
        public void AreEqual_ShouldPass_IfStringKeysAndValuesAreEqual() {
            UAssert.AreEqual(new Dictionary<int, string> {
                { 1, "1" },
                { 10, "10" }
            }, IntToString);
        }

        [Test]
        public void AreEqual_ShouldThrowAssertionException_IfStringKeysAndValuesAreNotEqual() {
            Assert.Throws(typeof(AssertionException), () => {
                UAssert.AreEqual(new Dictionary<int, string> {
                    { 1, "10" }
                }, IntToString);
            });
        }

        [Test]
        public void AreEqual_ShouldPass_IfIntKeysAndValuesAreEqual() {
            UAssert.AreEqual(new Dictionary<int, int> {
                { 1, 2 }
            }, PlusOne);
        }

        [Test]
        public void AreEqual_ShouldThrowAssertionException_IfIntKeysAndValuesAreNotEqual() {
            Assert.Throws(typeof(AssertionException), () => {
                 UAssert.AreEqual(new Dictionary<int, int> {
                    { 1, 1 }
                }, PlusOne);
            });
        }
    }
}

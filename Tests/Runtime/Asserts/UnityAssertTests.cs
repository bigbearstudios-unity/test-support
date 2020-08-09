using BBUnity.TestSupport;
using NUnit.Framework;
using System;
using UnityEngine;

public class UnityAssertTests {

    [Test]
    public void ShouldPassForSimilarVector2() {
        UnityAssert.AreEqual(Vector2.zero, Vector2.zero);
        UnityAssert.AreEqual(Vector2.one, Vector2.one);
        UnityAssert.AreEqual(new Vector2(5.0f, 5.0f), new Vector2(5.0f, 5.0f));
    }

    [Test]
    public void ShouldPassForSimilarVector3() {
        UnityAssert.AreEqual(Vector3.zero, Vector3.zero);
        UnityAssert.AreEqual(Vector3.one, Vector3.one);
        UnityAssert.AreEqual(new Vector3(5.0f, 5.0f, 5.0f), new Vector3(5.0f, 5.0f, 5.0f));
    }

    [Test]
    public void ShouldPassForSimilarQuaternion() {
        UnityAssert.AreEqual(Quaternion.identity, Quaternion.identity);
        UnityAssert.AreEqual(new Quaternion(1.0f, 1.0f, 1.0f, 1.0f), new Quaternion(1.0f, 1.0f, 1.0f, 1.0f));
        UnityAssert.AreEqual(new Quaternion(1.0f, 6.0f, 1.0f, 1.0f), new Quaternion(1.0f, 6.0f, 1.0f, 1.0f));
    }

    [Test]
    public void ShouldThrowForNonSimilarVector2() {
        Assert.Throws(typeof(AssertionException), () => {
            UnityAssert.AreEqual(Vector2.zero, Vector2.one);
        });

        Assert.Throws(typeof(AssertionException), () => { 
            UnityAssert.AreEqual(new Vector2(5.0f, 5.0f), new Vector2(5.0f, 1.0f));
        });
    }

    [Test]
    public void ShouldThrowForNonSimilarVector3() {
        Assert.Throws(typeof(AssertionException), () => {
            UnityAssert.AreEqual(Vector3.zero, Vector3.one);
        });

        Assert.Throws(typeof(AssertionException), () => { 
            UnityAssert.AreEqual(new Vector3(5.0f, 5.0f, 5.0f), new Vector3(5.0f, 1.0f, 5.0f));
        });
    }

    [Test]
    public void ShouldThrowForNonSimilarQuaternion() {
        Assert.Throws(typeof(AssertionException), () => {
            UnityAssert.AreEqual(Quaternion.identity, new Quaternion(0.0f, 1.0f, 0.0f, 1.0f));
        });

        Assert.Throws(typeof(AssertionException), () => { 
            UnityAssert.AreEqual(Quaternion.identity, new Quaternion(1.0f, 6.0f, 1.0f, 6.0f));
        });
    }

}

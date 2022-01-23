using NUnit.Framework;
using UnityEngine;

using BBUnity.TestSupport;

public class TestUtilitiesTests {

    [Test]
    public void CreateThenDestroyGameObject_WhenPassedACallback_ShouldCreateThenDestoryTheGameObject() {
        UnityAssert.ChangeInSceneRootObjects(0, () => {
            TestUtilities.CreateThenDestroyGameObject((GameObject obj) => {
                Assert.NotNull(obj);
            });
        });
    }

    [Test]
    public void CreateThenDestroyGameObject_WhenPassedACallbackAndName_ShouldCreateThenDestoryTheGameObject() {
        UnityAssert.ChangeInSceneRootObjects(0, () => {
            TestUtilities.CreateThenDestroyGameObject("Test Object", (GameObject obj) => {
                Assert.NotNull(obj);
                Assert.AreEqual(obj.name, "Test Object");
            });
        });
    }
}
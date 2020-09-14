using NUnit.Framework;
using UnityEngine;

using BBUnity.TestSupport;

namespace Asserts {
    public class UtilitiesTests {

        [Test]
        public void CreateThenDestroyGameObject_WhenPassedACallback_ShouldCreateThenDestoryTheGameObject() {
            UAssert.ChangeInSceneObjects(0, () => {
                Utilities.CreateThenDestroyGameObject((GameObject obj) => {
                    Assert.NotNull(obj);
                });
            });
        }
    }
}
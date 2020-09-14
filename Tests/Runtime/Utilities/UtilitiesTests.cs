﻿using NUnit.Framework;
using UnityEngine;

using BBUnity.TestSupport;

namespace Asserts {
    public class TestUtilitiesTests {

        [Test]
        public void CreateThenDestroyGameObject_WhenPassedACallback_ShouldCreateThenDestoryTheGameObject() {
            BBAssert.ChangeInSceneObjects(0, () => {
                TestUtilities.CreateThenDestroyGameObject((GameObject obj) => {
                    Assert.NotNull(obj);
                });
            });
        }
    }
}
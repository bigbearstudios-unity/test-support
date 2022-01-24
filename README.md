# BBUnity Test Support

Test support library for Unity. The library has two exposed classes:

- Fixtures
- TestUtilities
- UnityAssert

## Namespaces

``` csharp

import BBUnity.TestSupport;

```

## Fixtures

The Fixtures class allows the creation of simple assets instead of loading them from files. See below for examples:

``` csharp

Fixtures.Sprite(); //Creates a single sprite of 0,0
Fixtures.Sprite(500, 500); //Creates a single sprite of 500, 500

Fixtures.Sprites(5); //Creates an array of 5 sprites of 0,0
Fixtures.Sprites(5, 500, 500); //Creates an array of 5 sprites of 500, 500

```

## UnityAssert

The UnityAssert class allows asserts on Unity concepts such as Vector2, Vector3, floats and Quaternions.

``` csharp

//Asserts that the number of Root Scene Objects changed by one, E.g. This would not throw
UnityAssert.ChangeInSceneRootObjects(1, () => {
  new GameObject();
});

//Asserts that the number of Root Scene Objects changed by one, E.g. This would throw
UnityAssert.ChangeInSceneRootObjects(1, () => {});

//Asserts two vectors are equal using a tolerance of 0.001, or you can set your own tolerance
UnityAssert.AreEqual(Vector2.zero, Vector2.zer0);
UnityAssert.AreEqual(Vector2.zero, Vector2.zer0, 0.1f);

//Same with Vector3
UnityAssert.AreEqual(Vector3.zero, Vector3.zer0);
UnityAssert.AreEqual(Vector3.zero, Vector3.zer0, 0.1f);

//Same with floats
UnityAssert.AreEqual(0.0f, 0.0f);
UnityAssert.AreEqual(0.0f, 0.0f, 0.1f);

//Same with Quaternions
UnityAssert.AreEqual(Quaternion.identity, Quaternion.identity);
UnityAssert.AreEqual(Quaternion.identity, Quaternion.identity, 0.1f);

//Allows a Dictionary of values, keys to be asserted against an Action
UnityAssert.AreEqual(new Dictionary<int, string> {
    { 1, "I" },
    { 5, "V" },
    { 10, "X"  }
}, NumberTo.RomanNumeral);

//Allows an Assertion on the number of times an Action is called
UnityAssert.IsCalled(10, (Action called) => {
    for(int i = 0; i < 10; ++i) {
        called();
    }
});

```

## TestUtilities

TestUtilities is a toolkit of methods which ease the writing of Unity tests. See below for examples:

``` csharp

//Static property to get the number of root objects in the scene
TestUtilities.NumberOfRootObjectsInScene

//Method to destory all root objects in a test scene
TestUtilities.DestroyRootObjectsInScene();

/*
 * Collection of methods which create a GameObject and then destroy the GameObject
 * once the Action has been called. There is a couple of variations to allow you to create the
 * game object which you need for the test, below is a few examples.
 */
TestUtilities.CreateThenDestroyGameObject((GameObject createdObject) => {});
TestUtilities.CreateThenDestroyGameObject(parentTransform, (GameObject createdObject) => {});
TestUtilities.CreateThenDestroyGameObject("Name of GameObject", (GameObject createdObject) => {});
TestUtilities.CreateThenDestroyGameObject(new Type[] { typeof(Rigidbody) }, (GameObject createdObject) => {});

/*
 * Collection of methods which create a GameObject and then destroy the GameObject
 * once the Action has been called. These versions take a Generic param which will be
 * the param of the Action.
 */
TestUtilities.CreateThenDestroyGameObject<RigidBody>((RigidBody obj) => {});
TestUtilities.CreateThenDestroyGameObject<RigidBody>(parentTransform, (RigidBody obj) => {});
TestUtilities.CreateThenDestroyGameObject<RigidBody>("Name of GameObject", (RigidBody obj) => {});
TestUtilities.CreateThenDestroyGameObject<RigidBody>(new Type[] { typeof(Rigidbody) }, (RigidBody obj) => {});

```

# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [0.0.1] - 2020-08-09

### Added

- DictionaryExtension.AreEqual, Allows a collection of keys/values to be tested against an action which takes in keys/values
- UnityAssert.AreEqual(Vector2, Vector2, float), Allows two Vector2 to be compared with a tolerance
- UnityAssert.AreEqual(Vector3, Vector3, float), Allows two Vector3 to be compared with a tolerance
- UnityAssert.AreEqual(float, float, float), Allows two floats to be compared with a tolerance
- UnityAssert.AreEqual(Quaternion, Quaternion, float), Allows two Quaternion to be compared with a tolerance

## [0.0.2] - 2020-08-10

### Changed

- Namespaces were shifted from BBUnity.TestSupport.Extensions to BBUnity.TestSupport

## [0.0.3] - 2020-08-10

### Added

- ArrayExtensions, IsTrue, IsFalse, IsNull

## [0.1.0] - 2020-09-14

### Added

- Utilities.NumberOfObjectsInScene, returns the number of root level objects in the scene
- Utilities.ClearSceneObjects, clears all of the root objects in the scene
- Utilities.CreateThenDestroyGameObject(), creates an object and then passes it to the action. The object is destroyed after the action is complete
- Utilities.CreateThenDestroyGameObject(string), creates an object and then passes it to the action. The object is destroyed after the action is complete
- Utilities.CreateThenDestroyGameObject(components), creates an object and then passes it to the action. The object is destroyed after the action is complete

### Changed

- UnityAssert.AreEqual(Dictionary, Action)

### Removed

- ArrayExtensions
- DictionaryExtensions

## [0.2.0] - 2020-09-14

### Changed

- Renamed class Utilities to TestUtilities

## [0.2.1] - 2020-09-14

### Added

- CreateThenDestroyGameObject on TestUtilities, allows it to take a collection of components (System.Type[]).

## [0.2.2] - 2020-09-14

### Added

- IsCalled on BBAssert which allows you to count the number of times an action (or inner action) is called.

## [0.2.3] - 2020-09-15

### Added

- Fixtures
- Fixtures.Sprite, returns a single 0,0 sprite for testing
- Fixtures.Sprites, returns multiple 0,0 sprites for testing

### Changed

- Renamed all of the namespaces to make more sense. Only BBUnity.TestSupport needs to be imported

## [0.2.4] - 2021-01-18

### Changed

- Fixed namespace for FixturesTests
- Renamed BBAssert to UnityAssert

### Added

- Complete CHANGELOG :)

## [1.0.0] - 2021-01-21

### Changed

- Renamed the .meta files
- Added a TODO.md file to track what needs completing
- v1.0.0 release

## [2.0.0] - 2021-01-22

### Changed

- Renamed ClearSceneObjects to DestroyRootObjectsInScene
- Renamed NumberOfObjectsInScene to NumberOfRootObjectsInScene

### Added

- Param variations on the CreateThenDestroyGameObject, CreateThenDestroyGameObject, CreateGameObject

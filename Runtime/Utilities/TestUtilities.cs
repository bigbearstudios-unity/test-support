using System;

using UnityEngine;
using UnityEngine.SceneManagement;

namespace BBUnity.TestSupport {
    public class TestUtilities {

        public static int NumberOfObjectsInScene {
            get {
                Scene scene = SceneManager.GetActiveScene();
                return scene.GetRootGameObjects().Length;
            }
        }

        public static void ClearSceneObjects() {
            Scene scene = SceneManager.GetActiveScene();
            GameObject[] gameObjects = scene.GetRootGameObjects();
            foreach(GameObject gameObject in gameObjects) {
                UnityEngine.Object.DestroyImmediate(gameObject);
            }
        }

        public static void CreateThenDestroyGameObject(Action<GameObject> func) {
            GameObject obj = new GameObject();
            func(obj);
            GameObject.DestroyImmediate(obj);
        }

        public static void CreateThenDestroyGameObject(string name, Action<GameObject> func) {
            GameObject obj = new GameObject(name);
            func(obj);
            GameObject.DestroyImmediate(obj);
        }

        public static void CreateThenDestroyGameObject(string name, System.Type[] components, Action<GameObject> func) {
            GameObject obj = new GameObject(name, components);
            func(obj);
            GameObject.DestroyImmediate(obj);
        }
    }
}
    

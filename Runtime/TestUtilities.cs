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

        public static void CreateThenDestroyGameObject(Type[] components, Action<GameObject> func) {
            GameObject obj = new GameObject("Test Object", components);
            func(obj);
            GameObject.DestroyImmediate(obj);
        }

        public static void CreateThenDestroyGameObject(string name, Type[] components, Action<GameObject> func) {
            GameObject obj = new GameObject(name, components);
            func(obj);
            GameObject.DestroyImmediate(obj);
        }

        public static void CreateThenDestroyGameObject<T>(Action<T> func) where T : Component {
            T component = AddOrGetComponent<T>(new GameObject());
            func(component);
            GameObject.DestroyImmediate(component.gameObject);
        }

        public static void CreateThenDestroyGameObject<T>(string name, Action<T> func) where T : Component {
            T component = AddOrGetComponent<T>(CreateGameObject(name));
            func(component);
            GameObject.DestroyImmediate(component.gameObject);
        }

        public static void CreateThenDestroyGameObject<T>(string name, Type[] components, Action<T> func) where T : Component {
            T component = AddOrGetComponent<T>(CreateGameObject(name, components));
            func(component);
            GameObject.DestroyImmediate(component.gameObject);
        }

        public static void CreateThenDestroyGameObject<T>(string name, Transform parent, Action<T> func) where T : Component {
            T component = AddOrGetComponent<T>(CreateGameObject(name, parent));
            func(component);
            GameObject.DestroyImmediate(component.gameObject);
        }

        public static void CreateThenDestroyGameObject<T>(string name, Transform parent, Type[] components, Action<T> func) where T : Component {
            T component = AddOrGetComponent<T>(CreateGameObject(name, parent, components));
            func(component);
            GameObject.DestroyImmediate(component.gameObject);
        }

        /*
         * Basic Creation
         */

        public static GameObject CreateGameObject(string name) {
            return new GameObject(name);
        }

        public static GameObject CreateGameObject(string name, Transform parent) {
            GameObject obj = new GameObject(name);
            obj.transform.parent = parent;
            return obj;
        }

        public static GameObject CreateGameObject(string name, Type[] components) {
            GameObject obj = new GameObject(name, components);
            return obj;
        }

        public static GameObject CreateGameObject(string name, Transform parent, Type[] components) {
            GameObject obj = new GameObject(name, components);
            obj.transform.parent = parent;
            return obj;
        }

        public static T CreateGameObject<T>() where T : Component {
            return AddOrGetComponent<T>(new GameObject());
        }

        public static T CreateGameObject<T>(string name) where T : Component {
            return AddOrGetComponent<T>(CreateGameObject(name));
        }

        public static T CreateGameObject<T>(string name, Type[] components) where T : Component {
            return AddOrGetComponent<T>(CreateGameObject(name, components));
        }

        public static T CreateGameObject<T>(string name, Transform parent) where T : Component {
            return AddOrGetComponent<T>(CreateGameObject(name, parent));
        }

        public static T CreateGameObject<T>(string name, Transform parent, System.Type[] components) where T : Component {
            return AddOrGetComponent<T>(CreateGameObject(name, parent, components));
        }

        /*
         * Adding Components
         */

        public static T AddOrGetComponent<T>(GameObject obj) where T : Component {
            T component = obj.GetComponent<T>();
            if (component == null) {
                component = obj.AddComponent<T>();
            }

            return component;
        }
    }
}
    

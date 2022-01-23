using System;

using UnityEngine;
using UnityEngine.SceneManagement;

namespace BBUnity.TestSupport {
    public class TestUtilities {

        /// <summary>
        /// Returns the number of root objects in the scene. Please note that this is more
        /// useful to check for the change in root objects rather than the amount you think 
        /// might be there. This is due to the fact that Unity adds various root objects to
        /// blank test scenes.
        /// </summary>
        public static int NumberOfRootObjectsInScene {
            get {
                Scene scene = SceneManager.GetActiveScene();
                return scene.GetRootGameObjects().Length;
            }
        }

        public static void DestroyRootObjectsInScene() {
            Scene scene = SceneManager.GetActiveScene();
            GameObject[] gameObjects = scene.GetRootGameObjects();
            foreach(GameObject gameObject in gameObjects) {
                UnityEngine.Object.DestroyImmediate(gameObject);
            }
        }

        public static void CreateThenDestroyGameObject(Action<GameObject> func) {
            GameObject obj = CreateGameObject();
            func(obj);
            GameObject.DestroyImmediate(obj);
        }

        public static void CreateThenDestroyGameObject(string name, Action<GameObject> func) {
            GameObject obj = CreateGameObject(name);
            func(obj);
            GameObject.DestroyImmediate(obj);
        }

        public static void CreateThenDestroyGameObject(string name, Transform parent, Action<GameObject> func) {
            GameObject obj = CreateGameObject(name, parent);
            func(obj);
            GameObject.DestroyImmediate(obj);
        }

        public static void CreateThenDestroyGameObject(string name, Type[] components, Action<GameObject> func) {
            GameObject obj = CreateGameObject(name, components);
            func(obj);
            GameObject.DestroyImmediate(obj);
        }

        public static void CreateThenDestroyGameObject(string name, Transform parent, Type[] components, Action<GameObject> func) {
            GameObject obj = CreateGameObject(name, parent, components);
            func(obj);
            GameObject.DestroyImmediate(obj);
        }

        public static void CreateThenDestroyGameObject(Transform parent, Action<GameObject> func) {
            GameObject obj = CreateGameObject(parent);
            func(obj);
            GameObject.DestroyImmediate(obj);
        }

        public static void CreateThenDestroyGameObject(Transform parent, Type[] components, Action<GameObject> func) {
            GameObject obj = CreateGameObject(parent, components);
            func(obj);
            GameObject.DestroyImmediate(obj);
        }

        public static void CreateThenDestroyGameObject(Type[] components, Action<GameObject> func) {
            GameObject obj = CreateGameObject(components);
            func(obj);
            GameObject.DestroyImmediate(obj);
        }

        /*
         * Generic Versions
         */

        public static void CreateThenDestroyGameObject<T>(Action<T> func) where T : Component {
            T component = AddOrGetComponent<T>(CreateGameObject());
            func(component);
            GameObject.DestroyImmediate(component.gameObject);
        }

        public static void CreateThenDestroyGameObject<T>(string name, Action<T> func) where T : Component {
            T component = AddOrGetComponent<T>(CreateGameObject(name));
            func(component);
            GameObject.DestroyImmediate(component.gameObject);
        }

        public static void CreateThenDestroyGameObject<T>(string name, Transform parent, Action<T> func) where T : Component {
            T component = AddOrGetComponent<T>(CreateGameObject(name, parent));
            func(component);
            GameObject.DestroyImmediate(component.gameObject);
        }

        public static void CreateThenDestroyGameObject<T>(string name, Type[] components, Action<T> func) where T : Component {
            T component = AddOrGetComponent<T>(CreateGameObject(name, components));
            func(component);
            GameObject.DestroyImmediate(component.gameObject);
        }

        public static void CreateThenDestroyGameObject<T>(string name, Transform parent, Type[] components, Action<T> func) where T : Component {
            T component = AddOrGetComponent<T>(CreateGameObject(name, parent, components));
            func(component);
            GameObject.DestroyImmediate(component.gameObject);
        }

        public static void CreateThenDestroyGameObject<T>(Transform parent, Action<T> func) where T : Component {
            T component = AddOrGetComponent<T>(CreateGameObject(parent));
            func(component);
            GameObject.DestroyImmediate(component.gameObject);
        }

        public static void CreateThenDestroyGameObject<T>(Transform parent, Type[] components, Action<T> func) where T : Component {
            T component = AddOrGetComponent<T>(CreateGameObject(parent, components));
            func(component);
            GameObject.DestroyImmediate(component.gameObject);
        }

        public static void CreateThenDestroyGameObject<T>(Type[] components, Action<T> func) where T : Component {
            T component = AddOrGetComponent<T>(CreateGameObject(components));
            func(component);
            GameObject.DestroyImmediate(component.gameObject);
        }

        /*
         * Basic Creation
         */

        public static GameObject CreateGameObject() {
            return new GameObject();
        }

        public static GameObject CreateGameObject(string name) {
            return new GameObject(name);
        }

        public static GameObject CreateGameObject(string name, Transform parent) {
            GameObject obj = new GameObject(name);
            obj.transform.parent = parent;
            return obj;
        }

        public static GameObject CreateGameObject(string name, Type[] components) {
            return new GameObject(name, components);
        }

        public static GameObject CreateGameObject(string name, Transform parent, Type[] components) {
            GameObject obj = new GameObject(name, components);
            obj.transform.parent = parent;
            return obj;
        }

        public static GameObject CreateGameObject(Transform parent) {
            GameObject obj = new GameObject();
            obj.transform.parent = parent;
            return obj;
        }

        public static GameObject CreateGameObject(Transform parent, Type[] components) {
            GameObject obj = new GameObject("Game Object", components);
            obj.transform.parent = parent;
            return obj;
        }

        public static GameObject CreateGameObject(Type[] components) {
            return new GameObject("Game Object", components);
        }

        public static T CreateGameObject<T>() where T : Component {
            return AddOrGetComponent<T>(CreateGameObject());
        }

        public static T CreateGameObject<T>(string name) where T : Component {
            return AddOrGetComponent<T>(CreateGameObject(name));
        }

        public static T CreateGameObject<T>(string name, Transform parent) where T : Component {
            return AddOrGetComponent<T>(CreateGameObject(name, parent));
        }

        public static T CreateGameObject<T>(string name, Type[] components) where T : Component {
            return AddOrGetComponent<T>(CreateGameObject(name, components));
        }

        public static T CreateGameObject<T>(string name, Transform parent, System.Type[] components) where T : Component {
            return AddOrGetComponent<T>(CreateGameObject(name, parent, components));
        }

        public static T CreateGameObject<T>(Transform parent) where T : Component {
            return AddOrGetComponent<T>(CreateGameObject(parent));
        }

        public static T CreateGameObject<T>(Transform parent, System.Type[] components) where T : Component {
            return AddOrGetComponent<T>(CreateGameObject(parent, components));
        }

        public static T CreateGameObject<T>(Type[] components) where T : Component {
            return AddOrGetComponent<T>(CreateGameObject(components));
        }

        /*
         * Adding Components
         */

        /// <summary>
        /// Private method to Add or Get a Component onto a GameObject
        /// </summary>
        private static T AddOrGetComponent<T>(GameObject obj) where T : Component {
            T component = obj.GetComponent<T>();
            if (component == null) {
                component = obj.AddComponent<T>();
            }

            return component;
        }
    }
}
    

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BBUnity.TestSupport {
    public static class Fixtures {

        /// <summary>
        /// Creates a sprite with a 0,0 texture.
        /// </summary>
        public static Sprite Sprite() {
            return UnityEngine.Sprite.Create(new Texture2D(0,0), Rect.zero, Vector2.zero);
        }

        /// <summary>
        /// Creates a sprite with a texture with the given width / height provided.
        /// </summary>
        public static Sprite Sprite(int width, int height) {
            return UnityEngine.Sprite.Create(
                new Texture2D(width, height), new Rect(0, 0, width, height), new Vector2(width / 2, height / 2)
            );
        }

        /// <summary>
        /// Creates an array of sprites with 0,0 textures.
        /// </summary>
        public static Sprite[] Sprites(int count) {
            Sprite[] sprites = new Sprite[count];
            for(int i = 0; i < count; ++i) {
                sprites[i] = Sprite();
            }
            return sprites;
        }

        /// <summary>
        /// Creates an array of sprites with textures with the given width / height.
        /// </summary>
        public static Sprite[] Sprites(int count, int width, int height) {
            Sprite[] sprites = new Sprite[count];
            for(int i = 0; i < count; ++i) {
                sprites[i] = Sprite(width, height);
            }
            return sprites;
        }
    }
}

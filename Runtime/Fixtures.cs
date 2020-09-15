using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Fixtures {

    public static Sprite Sprite() {
        return UnityEngine.Sprite.Create(new Texture2D(0,0), Rect.zero, Vector2.zero);
    }

    public static Sprite[] Sprites(int count) {
        Sprite[] sprites = new Sprite[count];
        for(int i = 0; i < count; ++i) {
            sprites[i] = Sprite();
        }
        return sprites;
    }
}

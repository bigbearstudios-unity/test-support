using NUnit.Framework;
using UnityEngine;

public class FixturesTests {

    [Test]
    public void Sprite_ShouldCreateASprite() {
        Assert.NotNull(Fixtures.Sprite());
    }

    [Test]
    public void Sprites_ShouldCreateAMatchingNumberOfSprites() {
        Sprite[] sprites = Fixtures.Sprites(2);

        Assert.NotNull(sprites);
        Assert.AreEqual(2, sprites.Length);
    }

    [Test]
    public void Sprites_ShouldCreateAMatchingNumberOfValidSprites() {
        Sprite[] sprites = Fixtures.Sprites(2);
        foreach(Sprite sprite in sprites) {
            Assert.NotNull(sprite);
        }
    }
}

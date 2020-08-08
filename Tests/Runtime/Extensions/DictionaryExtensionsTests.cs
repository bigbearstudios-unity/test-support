using BBUnity.TestSupport.Extensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;

public class DictionaryExtensionsTests {

    private string IntToString(int value) {
        return "" + value;
    }

    private int PlusOne(int value) {
        return value + 1;
    }
         
    [Test]
    public void ShouldAllowCustomActionToBeUsedForIteration() {
        
    }

    [Test]
    public void ShouldAllowTestingOfIntReturnWithStringInput() {
        new Dictionary<string, int> {
            { "1", 1 },
            { "10", 10 }
        }.AreEqual(IntToString);
    }

    [Test]
    public void ShouldThrowOnNonMatchingEqualsOfIntReturnWithStringInput() {
        Assert.Throws(typeof(AssertionException), () => {
            new Dictionary<string, int> {
                { "10", 1 }
            }.AreEqual(IntToString);
        });
    }

    [Test]
    public void ShouldAllowTestingOfIntReturnWithIntInput() {
        new Dictionary<int, int> {
            { 2, 1 }
        }.AreEqual(PlusOne);
    }

    [Test]
    public void ShouldThrowOnNonMatchingEqualsOfIntReturnWithIntInput() {
        Assert.Throws(typeof(AssertionException), () => {
            new Dictionary<int, int> {
                { 1, 1 }
            }.AreEqual(PlusOne);
        });
    }
}

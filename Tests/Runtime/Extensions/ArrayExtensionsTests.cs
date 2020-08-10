using NUnit.Framework;

using BBUnity.TestSupport;

namespace Extensions {
    public class ArrayExtensionsTests {

        private bool ReturnTrue(int v) {
            return true;
        }

        private bool ReturnFalse(int v) {
            return false;
        }

        [Test]
        public void IsTrue_ShouldPass_IfAllItemsReturnTrue() {
            new int[] {
                1,2
            }.IsTrue(ReturnTrue);
        }

        [Test]
        public void IsTrue_ShouldThrowAssertionException_IfAllItemsReturnFalse() {
            Assert.Throws(typeof(AssertionException), () => {
                new int[] {
                    1,2
                }.IsTrue(ReturnFalse);
            });
        }

        [Test]
        public void IsFalse_ShouldPass_IfAllItemsReturnFalse() {
            new int[] {
                1,2
            }.IsFalse(ReturnFalse);
        }

        [Test]
        public void IsFalse_ShouldThrowAssertionException_IfAllItemsReturnTrue() {
            Assert.Throws(typeof(AssertionException), () => {
                new int[] {
                    1,2
                }.IsFalse(ReturnTrue);
            });
        }
    }
}

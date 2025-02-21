using NUnit.Framework;

namespace UnitTest
{
    public class AddiererTests
    {
        private Addierer _addierer;

        [SetUp]
        public void Setup()
        {
            _addierer = new Addierer();
        }

        [Test]
        public void TestVierBitAddierer()
        {
            string result = _addierer.VierBitAddierer("1010", "0110");
            Assert.AreEqual("10000", result);
        }

        [Test]
        public void TestBinaerZuDezimal()
        {
            int decimalValue = _addierer.BinaerZuDezimal("1000");
            Assert.AreEqual(8, decimalValue);
        }

        [Test]
        // Testcases!!!
        public void TestHalbaddierer()
        {
            _addierer.Halbaddierer(1, 1, out int sum, out int carry);
            Assert.AreEqual(0, sum);
            Assert.AreEqual(1, carry);
        }

        [Test]
        public void TestVolladdierer()
        {
            _addierer.Volladdierer(1, 1, 1, out int sum, out int carry);
            Assert.AreEqual(1, sum);
            Assert.AreEqual(1, carry);
        }

        [Test]
        public void TestIstGueltigeBinaerzahl()
        {
            Assert.IsTrue(_addierer.IstGueltigeBinaerzahl("1010"));
            Assert.IsFalse(_addierer.IstGueltigeBinaerzahl("1020"));
            Assert.IsFalse(_addierer.IstGueltigeBinaerzahl("100"));
        }
    }
}

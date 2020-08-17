using System.Reflection;
using System.Reflection.Metadata;
using NUnit.Framework;

namespace kilo.Tests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void CheckIsNumber()
        {
            kilo.Engine engine = new kilo.Engine();
            Assert.IsTrue(engine.IsNumber('0'));
            Assert.IsTrue(engine.IsNumber('1'));
            Assert.IsTrue(engine.IsNumber('2'));
            Assert.IsTrue(engine.IsNumber('3'));
            Assert.IsFalse(engine.IsNumber('m'));
        }


        [Test]
        public void TestSimpleCalculator()
        {
            kilo.Engine engine = new kilo.Engine();
            engine.Calculate("1");
            Assert.AreEqual(engine.Value, 1.0);
        }

        [Test]
        public void TestMultiCalculator()
        {
            kilo.Engine engine = new kilo.Engine();
            engine.Calculate("1k");
            Assert.AreEqual(engine.Value, 1000.0);
        }
    }
}
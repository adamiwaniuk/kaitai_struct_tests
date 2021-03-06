using NUnit.Framework;

namespace Kaitai
{
    [TestFixture]
    public class SpecExpr3 : CommonSpec
    {
        [Test]
        public void TestExpr3()
        {
            var r = Expr3.FromFile(SourceFile("fixed_struct.bin"));
            Assert.AreEqual(r.One, 80);
            Assert.AreEqual(r.Two, "ACK");
    
            Assert.AreEqual(r.Three, "@ACK");
            Assert.AreEqual(r.Four, "_ACK_");
            Assert.AreEqual(r.IsStrEq, true);
            Assert.AreEqual(r.IsStrNe, false);
            Assert.AreEqual(r.IsStrLt, true);
            Assert.AreEqual(r.IsStrGt, false);
            Assert.AreEqual(r.IsStrLe, true);
            Assert.AreEqual(r.IsStrGe, false);
            Assert.AreEqual(r.IsStrLt2, true);
            Assert.AreEqual(r.TestNot, true);
        }
    }
}

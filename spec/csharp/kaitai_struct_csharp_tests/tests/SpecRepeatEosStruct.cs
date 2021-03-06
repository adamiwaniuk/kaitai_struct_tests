using NUnit.Framework;

namespace Kaitai
{
    [TestFixture]
    public class SpecRepeatEosStruct : CommonSpec
    {
        [Test]
        public void TestRepeatEosStruct()
        {
            RepeatEosStruct r = RepeatEosStruct.FromFile(SourceFile("repeat_eos_struct.bin"));

            Assert.AreEqual(r.Chunks.Count, 2);
            Assert.AreEqual(r.Chunks[0].Offset, 0);
            Assert.AreEqual(r.Chunks[0].Len, 0x42);
            Assert.AreEqual(r.Chunks[1].Offset, 0x42);
            Assert.AreEqual(r.Chunks[1].Len, 0x815);
        }
    }
}
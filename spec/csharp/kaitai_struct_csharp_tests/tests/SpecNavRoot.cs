using NUnit.Framework;

namespace Kaitai
{
    [TestFixture]
    public class SpecNavRoot : CommonSpec
    {
        [Test]
        public void TestNavRoot()
        {
            NavRoot r = NavRoot.FromFile(SourceFile("nav.bin"));

            Assert.AreEqual(r.Header.QtyEntries, 2);
            Assert.AreEqual(r.Header.FilenameLen, 8);

            Assert.AreEqual(r.Index.Entries.Count, 2);
            Assert.AreEqual(r.Index.Entries[0].Filename, "FIRST___");
            Assert.AreEqual(r.Index.Entries[1].Filename, "SECOND__");
        }
    }
}
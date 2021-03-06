package io.kaitai.struct.spec;

import io.kaitai.struct.testformats.TermStrz;
import org.testng.annotations.Test;

import static org.testng.Assert.assertEquals;

public class TestTermStrz extends CommonSpec {
    @Test
    public void testTermStrz() throws Exception {
        TermStrz r = TermStrz.fromFile(SRC_DIR + "term_strz.bin");

        assertEquals(r.s1(), "foo");
        assertEquals(r.s2(), "bar");
        assertEquals(r.s3(), "|baz@");
    }
}

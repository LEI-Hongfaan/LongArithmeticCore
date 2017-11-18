using System;
using System.Linq;
using System.Text;

namespace ThisAssembly {
    using Xunit;
    using FsCheck;
    using BigInteger = System.Numerics.BigInteger;
    using TestModule = UltimateOrb.Mathematics.Internal.Testing.ArithmeticOperations.TestModule;
    using ArithmeticOperations = UltimateOrb.Mathematics.Internal.Testing.ArithmeticOperations;
    using DoubleArithmetic = UltimateOrb.Mathematics.DoubleArithmetic;
    using FsCheck.Xunit;

    public partial class Program {

        public static System.Numerics.BigInteger Int64ArrayToBigInteger(params Int64[] bits) {
            var c = bits.Length;
            if (c > 1) {
                var a = (System.Numerics.BigInteger)unchecked((Int64)bits[--c]);
                for (; c > 0;) {
                    a = (a << 64) | unchecked((UInt64)bits[--c]);
                }
                return a;
            }
            if (1 == c) {
                return bits[0];
            }
            return default(System.Numerics.BigInteger);
        }

        public static System.Numerics.BigInteger UInt64ArrayToBigInteger(params UInt64[] bits) {
            return Int64ArrayToBigInteger(((object)bits) as Int64[]);
        }

        public static System.Numerics.BigInteger Int64ArrayToBigIntegerUnsigned(params Int64[] bits) {
            var c = bits.Length;
            if (c > 1) {
                var a = (System.Numerics.BigInteger)unchecked((UInt64)bits[--c]);
                for (; c > 0;) {
                    a = (a << 64) | unchecked((UInt64)bits[--c]);
                }
                return a;
            }
            if (1 == c) {
                return unchecked((UInt64)bits[0]);
            }
            return default(System.Numerics.BigInteger);
        }

        public static System.Numerics.BigInteger UInt64ArrayToBigIntegerUnsigned(params UInt64[] bits) {
            return Int64ArrayToBigIntegerUnsigned(((object)bits) as Int64[]);
        }

        [Property(MaxTest = 1000000, QuietOnSuccess = true)]
        public bool Test_BigMul_0(ulong m0, ulong m1, ulong n0, ulong n1) {
            var mm = UInt64ArrayToBigIntegerUnsigned(m0, m1);
            var nn = UInt64ArrayToBigIntegerUnsigned(n0, n1);
            var p0p = mm * nn;
            var p10 = DoubleArithmetic.BigMul(m0, m1, n0, n1, out UInt64 p11, out UInt64 p12, out UInt64 p13);
            var p1p = UInt64ArrayToBigIntegerUnsigned(p10, p11, p12, p13);
            return p0p == p1p;
        }

        [Property(MaxTest = 1000000, QuietOnSuccess = true)]
        public bool Test_BigMul_1(ulong m0, ulong m1, ulong n0, ulong n1) {
            var mm = UInt64ArrayToBigInteger(m0, m1);
            var nn = UInt64ArrayToBigInteger(n0, n1);
            var p0p = mm * nn;
            var p10 = DoubleArithmetic.BigMul(m0, unchecked((Int64)m1), n0, unchecked((Int64)n1), out UInt64 p11, out UInt64 p12, out Int64 p13);
            var p1p = UInt64ArrayToBigInteger(p10, p11, p12, unchecked((UInt64)p13));
            return p0p == p1p;
        }

        [Property(MaxTest = 1000000, QuietOnSuccess = true)]
        public bool Test_BigMul_2(ulong m0, ulong n0) {
            var mm = UInt64ArrayToBigIntegerUnsigned(m0);
            var nn = UInt64ArrayToBigIntegerUnsigned(n0);
            var p0p = mm * nn;
            var p10 = DoubleArithmetic.BigMul(m0, n0, out UInt64 p11);
            var p1p = UInt64ArrayToBigIntegerUnsigned(p10, p11);
            return p0p == p1p;
        }

        [Property(MaxTest = 1000000, QuietOnSuccess = true)]
        public bool Test_BigMul_3(ulong m0, ulong n0) {
            var mm = UInt64ArrayToBigInteger(m0);
            var nn = UInt64ArrayToBigInteger(n0);
            var p0p = mm * nn;
            var p10 = DoubleArithmetic.BigMul(unchecked((Int64)m0), unchecked((Int64)n0), out Int64 p11);
            var p1p = UInt64ArrayToBigInteger(p10, unchecked((UInt64)p11));
            return p0p == p1p;
        }

        [Property(MaxTest = 1000000, QuietOnSuccess = true)]
        public bool Test_BigMul_8(ulong m0, ulong n0) {
            var mm = UInt64ArrayToBigIntegerUnsigned(m0);
            var nn = UInt64ArrayToBigIntegerUnsigned(n0);
            var p0p = mm * nn;
            var p10 = DoubleArithmetic.BigMul_A_Karatsuba(m0, n0, out UInt64 p11);
            var p1p = UInt64ArrayToBigIntegerUnsigned(p10, p11);
            return p0p == p1p;
        }

        /*
        [Property(MaxTest = 1000000, QuietOnSuccess = true)]
        public bool Test_BigMul_9(ulong m0, ulong n0) {
            var mm = UInt64ArrayToBigInteger(m0);
            var nn = UInt64ArrayToBigInteger(n0);
            var p0p = mm * nn;
            var p10 = DoubleArithmetic.BigMul_A_Karatsuba(unchecked((Int64)m0), unchecked((Int64)n0), out Int64 p11);
            var p1p = UInt64ArrayToBigInteger(p10, unchecked((UInt64)p11));
            return p0p == p1p;
        }
        */

        [Property(QuietOnSuccess = true)]
        public bool Test_BigMul_2_1() {
            var m0 = 0Xe000000000000006UL;
            var m1 = 0X0000000000000001UL;
            var n0 = 0Xe000000000000006UL;
            var n1 = 0X0000000000000001UL;
            return Test_BigMul_0(m0, m1, n0, n1);
        }

        [Property(QuietOnSuccess = true)]
        public bool Test_BigMul_3_1() {
            var m0 = 0Xe000000000000006UL;
            var m1 = 0X0000000000000001UL;
            var n0 = 0Xe000000000000006UL;
            var n1 = 0X0000000000000001UL;
            return Test_BigMul_1(m0, m1, n0, n1);
        }

        [Property(QuietOnSuccess = true)]
        public bool Test_BigMul_2_2() {
            var m0 = 15565588221936131312UL;
            var m1 = 16772529834207146279UL;
            var n0 = 17300158191727734462UL;
            var n1 = 2604930238074063360UL;
            return Test_BigMul_0(m0, m1, n0, n1);
        }

        [Property(QuietOnSuccess = true)]
        public bool Test_BigMul_3_2() {
            var m0 = 15565588221936131312UL;
            var m1 = 16772529834207146279UL;
            var n0 = 17300158191727734462UL;
            var n1 = 2604930238074063360UL;
            return Test_BigMul_1(m0, m1, n0, n1);
        }

        [Property(QuietOnSuccess = true)]
        public bool Test_BigMul_2_3() {
            var m0 = 4614276960546034880UL;
            var m1 = 15600135188658259462UL;
            var n0 = 15231609951630653244UL;
            var n1 = 14447548130359050562UL;
            return Test_BigMul_0(m0, m1, n0, n1);
        }

        [Property(QuietOnSuccess = true)]
        public bool Test_BigMul_3_3() {
            var m0 = 4614276960546034880UL;
            var m1 = 15600135188658259462UL;
            var n0 = 15231609951630653244UL;
            var n1 = 14447548130359050562UL;
            return Test_BigMul_1(m0, m1, n0, n1);
        }

        [Property(QuietOnSuccess = true)]
        public bool Test_BigMul_2_4() {
            var m0 = 14250242442023403520UL;
            var m1 = 13043001765010608401UL;
            var n0 = 18306435212701073408UL;
            var n1 = 15679297132262522895UL;
            return Test_BigMul_0(m0, m1, n0, n1);
        }

        [Property(QuietOnSuccess = true)]
        public bool Test_BigMul_3_4() {
            var m0 = 14250242442023403520UL;
            var m1 = 13043001765010608401UL;
            var n0 = 18306435212701073408UL;
            var n1 = 15679297132262522895UL;
            return Test_BigMul_1(m0, m1, n0, n1);
        }

        [Property(QuietOnSuccess = true)]
        public bool Test_BigMul_4() {
            var cc = 0UL;
            foreach (var a0 in default(UltimateOrb.Mathematics.Internal.Testing.Int64CollectionTestDataSourceMagnitude5)) {
                var m0 = unchecked((ulong)a0);
                foreach (var a1 in default(UltimateOrb.Mathematics.Internal.Testing.Int64CollectionTestDataSourceMagnitude5)) {
                    var m1 = unchecked((ulong)a1);
                    foreach (var a2 in default(UltimateOrb.Mathematics.Internal.Testing.Int64CollectionTestDataSourceMagnitude5)) {
                        var n0 = unchecked((ulong)a2);
                        foreach (var a3 in default(UltimateOrb.Mathematics.Internal.Testing.Int64CollectionTestDataSourceMagnitude5)) {
                            var n1 = unchecked((ulong)a3);
                            if (!Test_BigMul_0(m0, m1, n0, n1)) {
                                return false;
                            }
                            ++cc;
                        }
                    }
                }
            }
            if (0 != (cc ^ cc)) {
                return false;
            }
            return true;
        }

        [Property(QuietOnSuccess = true)]
        public bool Test_BigMul_5() {
            var cc = 0UL;
            foreach (var a0 in default(UltimateOrb.Mathematics.Internal.Testing.Int64CollectionTestDataSourceMagnitude5)) {
                var m0 = unchecked((ulong)a0);
                foreach (var a1 in default(UltimateOrb.Mathematics.Internal.Testing.Int64CollectionTestDataSourceMagnitude5)) {
                    var m1 = unchecked((ulong)a1);
                    foreach (var a2 in default(UltimateOrb.Mathematics.Internal.Testing.Int64CollectionTestDataSourceMagnitude5)) {
                        var n0 = unchecked((ulong)a2);
                        foreach (var a3 in default(UltimateOrb.Mathematics.Internal.Testing.Int64CollectionTestDataSourceMagnitude5)) {
                            var n1 = unchecked((ulong)a3);
                            if (!Test_BigMul_1(m0, m1, n0, n1)) {
                                return false;
                            }
                            ++cc;
                        }
                    }
                }
            }
            if (0 != (cc ^ cc)) {
                return false;
            }
            return true;
        }

        [Property(QuietOnSuccess = true)]
        public bool Test_BigMul_6() {
            var cc = 0UL;
            foreach (var a0 in default(UltimateOrb.Mathematics.Internal.Testing.Int64CollectionTestDataSourceMagnitude10)) {
                var m0 = unchecked((ulong)a0);
                foreach (var a2 in default(UltimateOrb.Mathematics.Internal.Testing.Int64CollectionTestDataSourceMagnitude10)) {
                    var n0 = unchecked((ulong)a2);
                    if (!Test_BigMul_2(m0, n0)) {
                        return false;
                    }
                    ++cc;
                }
            }
            if (0 != (cc ^ cc)) {
                return false;
            }
            return true;
        }

        [Property(QuietOnSuccess = true)]
        public bool Test_BigMul_7() {
            var cc = 0UL;
            foreach (var a0 in default(UltimateOrb.Mathematics.Internal.Testing.Int64CollectionTestDataSourceMagnitude10)) {
                var m0 = unchecked((ulong)a0);
                foreach (var a2 in default(UltimateOrb.Mathematics.Internal.Testing.Int64CollectionTestDataSourceMagnitude10)) {
                    var n0 = unchecked((ulong)a2);
                    if (!Test_BigMul_3(m0, n0)) {
                        return false;
                    }
                    ++cc;
                }
            }
            if (0 != (cc ^ cc)) {
                return false;
            }
            return true;
        }

        [Property(MaxTest = 1000000, QuietOnSuccess = true)]
        public bool Test_BigSquare_0(ulong m0) {
            var mm = UInt64ArrayToBigIntegerUnsigned(m0);
            var p0p = mm * mm;
            var p10 = DoubleArithmetic.BigSquare(m0, out UInt64 p11);
            var p1p = UInt64ArrayToBigIntegerUnsigned(p10, p11);
            return p0p == p1p;
        }

        [Property(MaxTest = 1000000, QuietOnSuccess = true)]
        public bool Test_BigSquare_2(ulong m0, ulong m1) {
            var mm = UInt64ArrayToBigIntegerUnsigned(m0, m1);
            var p0p = mm * mm;
            var p10 = DoubleArithmetic.BigSquare(m0, m1, out UInt64 p11, out UInt64 p12, out UInt64 p13);
            var p1p = UInt64ArrayToBigIntegerUnsigned(p10, p11, p12, p13);
            return p0p == p1p;
        }
    }
}

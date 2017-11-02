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
                return bits[0];
            }
            return default(System.Numerics.BigInteger);
        }

        public static System.Numerics.BigInteger UInt64ArrayToBigIntegerUnsigned(params UInt64[] bits) {
            return Int64ArrayToBigIntegerUnsigned(((object)bits) as Int64[]);
        }

        [Property(MaxTest = 1000000, QuietOnSuccess = true)]
        public bool Test_BigMul_1(Tuple<ulong, ulong, ulong, ulong> a) {
            var m0 = a.Item1;
            var m1 = a.Item2;
            var n0 = a.Item3;
            var n1 = a.Item4;
            var d0 = DoubleArithmetic.BigMul(m0, m1, n0, n1, out UInt64 d1, out UInt64 d2, out UInt64 d3);
            var m = UInt64ArrayToBigIntegerUnsigned(m0, m1);
            var n = UInt64ArrayToBigIntegerUnsigned(n0, n1);
            var p = m * n;
            var d = UInt64ArrayToBigIntegerUnsigned(d0, d1, d2, d3);
            return p == d;
        }

        [Property(MaxTest = 1000000, QuietOnSuccess = true)]
        public bool Test_BigMul_2(Tuple<ulong, ulong, ulong, ulong> a) {
            var m0 = a.Item1;
            var m1 = a.Item2;
            var n0 = a.Item3;
            var n1 = a.Item4;
            var d0 = DoubleArithmetic.BigMul(m0, unchecked((Int64)m1), n0, unchecked((Int64)n1), out UInt64 d1, out UInt64 d2, out Int64 d3);
            var m = UInt64ArrayToBigInteger(m0, m1);
            var n = UInt64ArrayToBigInteger(n0, n1);
            var p = m * n;
            var d = UInt64ArrayToBigInteger(d0, d1, d2, unchecked((UInt64)d3));
            return p == d;
        }
    }
}

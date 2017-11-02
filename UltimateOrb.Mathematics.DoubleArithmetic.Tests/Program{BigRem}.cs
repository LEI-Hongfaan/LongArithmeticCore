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

        [Property(MaxTest = 300000, QuietOnSuccess = true)]
        public bool Test_BigRem_0(Tuple<ulong, ulong, ulong, ulong, ulong, ulong> a) {
            var p0 = a.Item1;
            var p1 = a.Item2;
            var p2 = a.Item3;
            var p3 = a.Item4;
            var d0 = a.Item5;
            var d1 = a.Item6;
            if (0 == d0 && 0 == d1) {
                return true;
            }
            if (DoubleArithmetic.GreaterThanOrEqual(p2, p3, d0, d1)) {
                return true;
            }
            var p = UInt64ArrayToBigIntegerUnsigned(p0, p1, p2, p3);
            var d = UInt64ArrayToBigIntegerUnsigned(d0, d1);
            var r = p % d;
            var s = (System.Numerics.BigInteger?)null;
            try {
                var r0 = DoubleArithmetic.BigRemNoThrow(p0, p1, p2, p3, d0, d1, out var r1);
                s = UInt64ArrayToBigIntegerUnsigned(r0, r1);
            } catch (OverflowException) {
                return false;
            }
            if (r == s) {
                return true;
            }
            return false;
        }

        [Property(MaxTest = 300000, QuietOnSuccess = true)]
        public bool Test_BigRem_NoThrow_0(Tuple<ulong, ulong, ulong, ulong, ulong, ulong> a) {
            var p0 = a.Item1;
            var p1 = a.Item2;
            var p2 = a.Item3;
            var p3 = a.Item4;
            var d0 = a.Item5;
            var d1 = a.Item6;
            if (0 == d0 && 0 == d1) {
                return true;
            }
            if (DoubleArithmetic.GreaterThanOrEqual(p2, p3, d0, d1)) {
                var r0 = DoubleArithmetic.BigRemNoThrow(p0, p1, p2, p3, d0, d1, out var r1);
            }
            return true;
        }

        [Property(MaxTest = 300000, QuietOnSuccess = true)]
        public bool Test_BigRem_1(Tuple<ulong, ulong, ulong> a) {
            var p0 = a.Item1;
            var p1 = a.Item2;
            var d0 = a.Item3;
            if (0 == d0) {
                return true;
            }
            if (p1 >= d0) {
                return true;
            }
            var p = UInt64ArrayToBigIntegerUnsigned(p0, p1);
            var d = UInt64ArrayToBigIntegerUnsigned(d0);
            var r = p % d;
            var r0 = DoubleArithmetic.BigRemNoThrow(p0, p1, d0);
            if (r == UInt64ArrayToBigIntegerUnsigned(r0)) {
                return true;
            }
            return false;
        }
    }
}

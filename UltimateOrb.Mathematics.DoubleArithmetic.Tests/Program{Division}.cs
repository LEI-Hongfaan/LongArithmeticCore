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
        
        [Property(MaxTest = 1000000, QuietOnSuccess = true)]
        public bool Test_Remainder_1(Tuple<ulong, ulong, ulong, ulong> a) {
            var m0 = a.Item1;
            var m1 = a.Item2;
            var n0 = a.Item3;
            var n1 = a.Item4;
            if (0 == n0 && 0 == n1) {
                try {
                    var d0 = DoubleArithmetic.Remainder(m0, m1, n0, n1, out UInt64 d1);
                    return false;
                } catch (DivideByZeroException) {
                    return true;
                }
            } else {
                var d0 = DoubleArithmetic.Remainder(m0, m1, n0, n1, out UInt64 d1);
                var m = UInt64ArrayToBigIntegerUnsigned(m0, m1);
                var n = UInt64ArrayToBigIntegerUnsigned(n0, n1);
                var p = m % n;
                var d = UInt64ArrayToBigIntegerUnsigned(d0, d1);
                return p == d;
            }
        }

        [Property(MaxTest = 1000000, QuietOnSuccess = true)]
        public bool Test_Divide_1(Tuple<ulong, ulong, ulong, ulong> a) {
            var m0 = a.Item1;
            var m1 = a.Item2;
            var n0 = a.Item3;
            var n1 = a.Item4;
            if (0 == n0 && 0 == n1) {
                try {
                    var d0 = DoubleArithmetic.Divide(m0, m1, n0, n1, out UInt64 d1);
                    return false;
                } catch (DivideByZeroException) {
                    return true;
                }
            } else {
                var d0 = DoubleArithmetic.Divide(m0, m1, n0, n1, out UInt64 d1);
                var m = UInt64ArrayToBigIntegerUnsigned(m0, m1);
                var n = UInt64ArrayToBigIntegerUnsigned(n0, n1);
                var p = m / n;
                var d = UInt64ArrayToBigIntegerUnsigned(d0, d1);
                return p == d;
            }
        }
    }
}

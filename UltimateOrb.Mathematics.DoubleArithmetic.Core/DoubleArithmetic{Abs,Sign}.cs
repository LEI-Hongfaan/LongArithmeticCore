using System;

namespace UltimateOrb.Mathematics {

    using UInt = UInt32;
    using ULong = UInt64;
    using Int = Int32;
    using Long = Int64;

    using UInt_Misc = Internal.SizeOfModule.UInt32;
    using ULong_Misc = Internal.SizeOfModule.UInt64;
    using Int_Misc = Internal.SizeOfModule.Int32;
    using Long_Misc = Internal.SizeOfModule.Int64;

    using Math = UltimateOrb.Internal.System.Math;
    using MathEx = DoubleArithmetic;

    public static partial class DoubleArithmetic {

        [System.CLSCompliantAttribute(false)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static ULong AbsSignedAsUnsigned(ULong value_lo, Long value_hi, out ULong result_hi) {
            unchecked {
                if (0 > (Long)value_hi) {
                    return MathEx.NegateUnchecked(value_lo, (ULong)value_hi, out result_hi);
                }
                result_hi = (ULong)value_hi;
                return value_lo;
            }
        }

        [System.CLSCompliantAttribute(false)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static int Sign(ULong value_lo, Long value_hi) {
            unchecked {
                if (0 > value_hi) {
                    return -1;
                }
                if (0 == value_hi && 0 == value_lo) {
                    return 0;
                }
                return 1;
            }
        }
    }
}
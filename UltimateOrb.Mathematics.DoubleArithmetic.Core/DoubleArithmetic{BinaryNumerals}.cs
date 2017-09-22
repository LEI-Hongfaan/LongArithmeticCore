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

    using Math = System.Math;
    using MathEx = DoubleArithmetic;

    public static partial class DoubleArithmetic {

        [System.CLSCompliantAttribute(false)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static ULong NextPermutation(ULong lo, ULong hi, out ULong highResult) {
            unchecked {
                ULong loT;
                ULong hiT;
                ULong loV;
                ULong hiV;
                if (0u == lo) {
                    if (0u == hi) {
                        highResult = ULong.MaxValue;
                        return ULong.MaxValue;
                    }
                    hiT = (hi | (hi - 1u)) + 1u;
                    hiV = hi & (ULong)(-(Long)hi);
                    loV = ((hiT & (ULong)(-(Long)hiT)) / hiV) >> 1;
                    hiV = 0u;
                    if (0u == loV) {
                        highResult = ULong.MaxValue;
                        return ULong.MaxValue;
                    } else {
                        highResult = hiT;
                        return loV - 1u;
                    }
                } else {
                    loT = (lo | (lo - 1u));
                    hiT = hi;
                    if (ULong.MaxValue == loT++) {
                        ++hiT;
                    }
                    loV = lo & (ULong)(-(Long)lo);
                    hiV = hi & ((ULong)(-1u) - hi);
                    loV = MathEx.Divide(loT & (ULong)(-(Long)loT), hiT & ((0u == loT) ? (ULong)(-(Long)hiT) : ((ULong)(-1u) - hiT)), loV, hiV, out hiV);
                    loV = (loV >> 1) | (hiV << (ULong_Misc.BitSizeAsIntUnchecked - 1));
                    hiV = hiV >> 1;
                    if (0u == loV--) {
                        --hiV;
                    }
                    highResult = hiT | hiV;
                    return loT | loV;
                }
            }
        }
    }
}

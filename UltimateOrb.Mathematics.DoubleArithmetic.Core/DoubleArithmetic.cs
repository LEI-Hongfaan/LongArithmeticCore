using System;

[assembly: System.CLSCompliantAttribute(true)]
[assembly: System.Security.SecurityTransparentAttribute()]

namespace UltimateOrb.Mathematics {
    using UInt = UInt32;
    using ULong = UInt64;
    using Int = Int32;
    using Long = Int64;

    // using Math = global::Internal.System.Math;

    public static partial class DoubleArithmetic {
        /*
#if DEBUG
        static DoubleArithmetic() {
            System.Diagnostics.Debug.Assert(Misc.BitSizeOf<UInt>() == Misc.BitSizeOf<Int>());
            System.Diagnostics.Debug.Assert(Misc.BitSizeOf<ULong>() == Misc.BitSizeOf<Long>());
            System.Diagnostics.Debug.Assert(checked(2u * Misc.BitSizeOf<UInt>()) == Misc.BitSizeOf<ULong>());
            System.Diagnostics.Debug.Assert(~0 == -1);
            System.Diagnostics.Debug.Assert(Misc.BitSizeOf<UInt>() > 0);
        }
#endif
         */
    }

    namespace Internal.System {
        using System = global::System;

        using UInt32_Misc = Internal.SizeOfModule.UInt32;
        using UInt64_Misc = Internal.SizeOfModule.UInt64;
        using UIntPtr_Misc = UIntPtr;
        using Int32_Misc = Internal.SizeOfModule.Int32;
        using Int64_Misc = Internal.SizeOfModule.Int64;
        using IntPtr_Misc = IntPtr;

        public static partial class Math {

            [System.CLSCompliantAttribute(false)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public static UInt64 DivRem(UInt64 dividend, UInt64 divisor, out UInt64 remainder) {
                if (UInt64_Misc.Size > UIntPtr_Misc.Size) {
                    var q = dividend / divisor;
                    remainder = unchecked(dividend - q * divisor);
                    return q;
                }
                {
                    remainder = dividend % divisor;
                    return dividend / divisor;
                }
            }

            [System.CLSCompliantAttribute(false)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public static UInt32 DivRem(UInt32 dividend, UInt32 divisor, out UInt32 remainder) {
                remainder = dividend % divisor;
                return dividend / divisor;
            }

            [System.CLSCompliantAttribute(false)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public static Int64 Remainder(Int64 dividend, Int64 divisor) {
                return -1 == divisor ? 0 : dividend % divisor;
            }

            [System.CLSCompliantAttribute(false)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public static Int32 Remainder(Int32 dividend, Int32 divisor) {
                return -1 == divisor ? 0 : dividend % divisor;
            }
        }
    }

    namespace Elementary {

        public static partial class Math {

            [System.CLSCompliantAttribute(false)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public static UInt64 Sqrt_A_I(UInt64 radicand) {
                unchecked {
                    var res = (UInt64)0;
                    var bit = (UInt64)1 << (64 - 2);
                    while (bit != 0) {
                        if (radicand >= res + bit) {
                            radicand -= res + bit;
                            res = (res >> 1) + bit;
                        } else {
                            res >>= 1;
                        }
                        bit >>= 2;
                    }
                    return res;
                }
            }

            [System.CLSCompliantAttribute(false)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public static UInt64 Sqrt_A_F(UInt64 radicand) {
                unchecked {
                    var t = (UInt32)System.Math.Sqrt(radicand);
                    return 0 == t ? (0 == radicand ? 0 : ~(UInt32)0u) : ((UInt64)t * t > radicand ? --t : t);
                }
            }

            [System.CLSCompliantAttribute(false)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            // ~34.9 Cyc
            public static UInt64 Sqrt(UInt64 radicand) {
                return Sqrt_A_F(radicand);
            }

            [System.CLSCompliantAttribute(false)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public static UInt64 SqrtRem_A_I(UInt64 radicand, out UInt64 remainder) {
                unchecked {
                    var res = (UInt64)0;
                    var bit = (UInt64)1 << (64 - 2);
                    while (bit != 0) {
                        if (radicand >= res + bit) {
                            radicand -= res + bit;
                            res = (res >> 1) + bit;
                        } else {
                            res >>= 1;
                        }
                        bit >>= 2;
                    }
                    remainder = radicand;
                    return (UInt32)res;
                }
            }

            [System.CLSCompliantAttribute(false)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public static UInt64 SqrtRem_A_F(UInt64 radicand, out UInt64 remainder) {
                unchecked {
                    UInt64 s;
                    var t = (UInt32)System.Math.Sqrt(radicand);
                    if (0 == t) {
                        if (0 == radicand) {
                            remainder = 0;
                            return 0;
                        } else {
                            remainder = radicand - (UInt64)(~(UInt32)0u) * (~(UInt32)0u);
                            return ~(UInt32)0u;
                        }
                    }
                    s = (UInt64)t * t;
                    if (s > radicand) {
                        remainder = radicand - 1 - (s - (t << 1));
                        return t - 1;
                    } else {
                        remainder = radicand - s;
                        return t;
                    }
                }
            }

            [System.CLSCompliantAttribute(false)]
            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public static UInt64 SqrtRem(UInt64 radicand, out UInt64 remainder) {
                return SqrtRem_A_F(radicand, out remainder);
            }
        }
    }

    namespace Internal.SizeOfModule {
        using System = global::System;

        internal static partial class Int32 {

            public static uint Size {
                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                get {
                    return 4;
                }
            }

            public static long SizeAsLong {

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                get {
                    return Size;
                }
            }

            public static long BitSize {

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                get {
                    return 32;
                }
            }

            public static int BitSizeAsIntUnchecked {

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                get {
                    return 32;
                }
            }
        }

        internal static partial class UInt32 {

            public static uint Size {

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                get {
                    return 4;
                }
            }

            public static long SizeAsLong {

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                get {
                    return Size;
                }
            }

            public static long BitSize {

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                get {
                    return 32;
                }
            }

            public static int BitSizeAsIntUnchecked {

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                get {
                    return 32;
                }
            }
        }

        internal static partial class Int64 {

            public static uint Size {

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                get {
                    return 8;
                }
            }

            public static long SizeAsLong {

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                get {
                    return Size;
                }
            }

            public static long BitSize {

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                get {
                    return 64;
                }
            }

            public static int BitSizeAsIntUnchecked {

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                get {
                    return 64;
                }
            }
        }

        internal static partial class UInt64 {

            public static uint Size {

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]

                get {
                    return 8;
                }
            }

            public static long SizeAsLong {

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                get {
                    return Size;
                }
            }

            public static long BitSize {

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                get {
                    return 64;
                }
            }

            public static int BitSizeAsIntUnchecked {
                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]

                get {
                    return 64;
                }
            }
        }
    }
}

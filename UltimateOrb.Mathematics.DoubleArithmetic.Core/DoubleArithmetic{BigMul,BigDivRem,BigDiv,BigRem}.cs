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
        
    using Math = Internal.System.Math;

    public static partial class DoubleArithmetic {

        [System.CLSCompliantAttribute(false)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static ULong BigDivRem(ULong lowDividend, ULong highDividend, ULong divisor, out ULong remainder) {
            unchecked {
                ULong p, ql, qh;
                if (0u == highDividend) {
                    return Math.DivRem(lowDividend, divisor, out remainder);
                } else if (UInt.MaxValue > divisor) {
                    // 2014Jan08
                    if (divisor <= highDividend && 0u != divisor) {
                        highDividend = checked(0u - highDividend);
                        throw (System.OverflowException)null;
                    }
                    highDividend = (highDividend << UInt_Misc.BitSizeAsIntUnchecked) | (lowDividend >> UInt_Misc.BitSizeAsIntUnchecked);
                    qh = Math.DivRem(highDividend, divisor, out highDividend);
                    highDividend = (highDividend << UInt_Misc.BitSizeAsIntUnchecked) | (UInt)lowDividend;
                    ql = Math.DivRem(highDividend, divisor, out remainder);
                    return (qh << UInt_Misc.BitSizeAsIntUnchecked) | ql;
                } else {
                    // 2013Dec24, 2014Jan08
                    if (divisor <= highDividend) {
                        highDividend = checked(0u - highDividend);
                        throw (System.OverflowException)null;
                    }
                    int c = 0;
                    if (0 <= (Long)divisor) {
                        do {
                            ++c;
                            divisor <<= 1;
                        } while (0 <= (Long)divisor);
                        highDividend = (highDividend << c) | (lowDividend >> (ULong_Misc.BitSizeAsIntUnchecked - c));
                        lowDividend = lowDividend << c;
                    }
                    var dh = (ULong)(UInt)(divisor >> UInt_Misc.BitSizeAsIntUnchecked);
                    var dl = (ULong)(UInt)divisor;
                    qh = Math.DivRem(highDividend, dh, out highDividend);
                    p = qh * dl;
                    highDividend = (highDividend << UInt_Misc.BitSizeAsIntUnchecked) | (lowDividend >> UInt_Misc.BitSizeAsIntUnchecked);
                    if (highDividend < p) {
                        {
                            --qh;
                            highDividend += divisor;
                        }
                        if (highDividend >= divisor) {
                            if (highDividend < p) {
                                --qh;
                                highDividend += divisor;
                            }
                        }
                    }
                    highDividend -= p;
                    ql = Math.DivRem(highDividend, dh, out highDividend);
                    p = ql * dl;
                    highDividend = (highDividend << UInt_Misc.BitSizeAsIntUnchecked) | (UInt)lowDividend;
                    if (highDividend < p) {
                        {
                            --ql;
                            highDividend += divisor;
                        }
                        if (highDividend >= divisor) {
                            if (highDividend < p) {
                                --ql;
                                highDividend += divisor;
                            }
                        }
                    }
                    remainder = (highDividend - p) >> c;
                    return (qh << UInt_Misc.BitSizeAsIntUnchecked) | ql;
                }
            }
        }

        [System.CLSCompliantAttribute(false)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static ULong BigDivRemUnchecked(ULong lowDividend, ULong highDividend, ULong divisor, out ULong remainder) {
            unchecked {
                ULong p, ql, qh;
                if (0u == highDividend) {
                    return Math.DivRem(lowDividend, divisor, out remainder);
                } else if (UInt.MaxValue > divisor) {
                    highDividend = (highDividend << UInt_Misc.BitSizeAsIntUnchecked) | (lowDividend >> UInt_Misc.BitSizeAsIntUnchecked);
                    qh = Math.DivRem(highDividend, divisor, out highDividend);
                    highDividend = (highDividend << UInt_Misc.BitSizeAsIntUnchecked) | (UInt)lowDividend;
                    ql = Math.DivRem(highDividend, divisor, out remainder);
                    return (qh << UInt_Misc.BitSizeAsIntUnchecked) | ql;
                } else {
                    // 2013Dec24
                    int c = 0;
                    if (0 <= (Long)divisor) {
                        do {
                            ++c;
                            divisor <<= 1;
                        } while (0 <= (Long)divisor);
                        highDividend = (highDividend << c) | (lowDividend >> (ULong_Misc.BitSizeAsIntUnchecked - c));
                        lowDividend = lowDividend << c;
                    }
                    var dh = (ULong)(UInt)(divisor >> UInt_Misc.BitSizeAsIntUnchecked);
                    var dl = (ULong)(UInt)divisor;
                    qh = Math.DivRem(highDividend, dh, out highDividend);
                    p = qh * dl;
                    highDividend = (highDividend << UInt_Misc.BitSizeAsIntUnchecked) | (lowDividend >> UInt_Misc.BitSizeAsIntUnchecked);
                    if (highDividend < p) {
                        {
                            --qh;
                            highDividend += divisor;
                        }
                        if (highDividend >= divisor) {
                            if (highDividend < p) {
                                --qh;
                                highDividend += divisor;
                            }
                        }
                    }
                    highDividend -= p;
                    ql = Math.DivRem(highDividend, dh, out highDividend);
                    p = ql * dl;
                    highDividend = (highDividend << UInt_Misc.BitSizeAsIntUnchecked) | (UInt)lowDividend;
                    if (highDividend < p) {
                        {
                            --ql;
                            highDividend += divisor;
                        }
                        if (highDividend >= divisor) {
                            if (highDividend < p) {
                                --ql;
                                highDividend += divisor;
                            }
                        }
                    }
                    remainder = (highDividend - p) >> c;
                    return (qh << UInt_Misc.BitSizeAsIntUnchecked) | ql;
                }
            }
        }

        [System.CLSCompliantAttribute(false)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static ULong BigDivUnchecked(ULong lowDividend, ULong highDividend, ULong divisor) {
            unchecked {
                ULong p, ql, qh;
                if (0u == highDividend) {
                    return lowDividend / divisor;
                } else if (UInt.MaxValue > divisor) {
                    highDividend = (highDividend << UInt_Misc.BitSizeAsIntUnchecked) | (lowDividend >> UInt_Misc.BitSizeAsIntUnchecked);
                    qh = Math.DivRem(highDividend, divisor, out highDividend);
                    highDividend = (highDividend << UInt_Misc.BitSizeAsIntUnchecked) | (UInt)lowDividend;
                    ql = highDividend / divisor;
                    return (qh << UInt_Misc.BitSizeAsIntUnchecked) | ql;
                } else {
                    // 2013Dec24
                    int c = 0;
                    if (0 <= (Long)divisor) {
                        do {
                            ++c;
                            divisor <<= 1;
                        } while (0 <= (Long)divisor);
                        highDividend = (highDividend << c) | (lowDividend >> (ULong_Misc.BitSizeAsIntUnchecked - c));
                        lowDividend = lowDividend << c;
                    }
                    var dh = (ULong)(UInt)(divisor >> UInt_Misc.BitSizeAsIntUnchecked);
                    var dl = (ULong)(UInt)divisor;
                    qh = Math.DivRem(highDividend, dh, out highDividend);
                    p = qh * dl;
                    highDividend = (highDividend << UInt_Misc.BitSizeAsIntUnchecked) | (lowDividend >> UInt_Misc.BitSizeAsIntUnchecked);
                    if (highDividend < p) {
                        {
                            --qh;
                            highDividend += divisor;
                        }
                        if (highDividend >= divisor) {
                            if (highDividend < p) {
                                --qh;
                                highDividend += divisor;
                            }
                        }
                    }
                    highDividend -= p;
                    ql = Math.DivRem(highDividend, dh, out highDividend);
                    p = ql * dl;
                    highDividend = (highDividend << UInt_Misc.BitSizeAsIntUnchecked) | (UInt)lowDividend;
                    if (highDividend < p) {
                        {
                            --ql;
                            highDividend += divisor;
                        }
                        if (highDividend >= divisor) {
                            if (highDividend < p) {
                                --ql;
                            }
                        }
                    }
                    return (qh << UInt_Misc.BitSizeAsIntUnchecked) | ql;
                }
            }
        }

        [System.CLSCompliantAttribute(false)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static ULong BigMul(ULong first, ULong second, out ULong highResult) {
            unchecked {
                if (ULong_Misc.Size > UIntPtr.Size) {
                    // 2013Oct04, 2013Dec24
                    var fl = (UInt)first;
                    var fh = (UInt)(first >> UInt_Misc.BitSizeAsIntUnchecked);
                    var sl = (UInt)second;
                    var sh = (UInt)(second >> UInt_Misc.BitSizeAsIntUnchecked);
                    var ll = (ULong)fl * sl;
                    var lh = (ULong)fl * sh;
                    var hl = (ULong)fh * sl;
                    var hh = (ULong)fh * sh;
                    lh += (UInt)(ll >> UInt_Misc.BitSizeAsIntUnchecked);
                    lh += hl;
                    if (lh < hl) {
                        hh += (ULong)1u << UInt_Misc.BitSizeAsIntUnchecked;
                    }
                    highResult = hh + (UInt)(lh >> UInt_Misc.BitSizeAsIntUnchecked);
                    return ((ULong)(UInt)lh << UInt_Misc.BitSizeAsIntUnchecked) | (UInt)(ll);
                }
                {
                    // 2013Oct04, 2013Dec24
                    var fl = (ULong)(UInt)first;
                    var fh = (ULong)(UInt)(first >> UInt_Misc.BitSizeAsIntUnchecked);
                    var sl = (ULong)(UInt)second;
                    var sh = (ULong)(UInt)(second >> UInt_Misc.BitSizeAsIntUnchecked);
                    var ll = fl * sl;
                    var hh = fh * sh;
                    var fm = fh + fl;
                    var sm = sh + sl;
                    var mm = fm * sm - (hh + ll);
                    var mh = mm >> UInt_Misc.BitSizeAsIntUnchecked;
                    var ml = mm << UInt_Misc.BitSizeAsIntUnchecked;
                    ll += ml;
                    highResult = hh + mh + ((ll < ml) ? (ULong)1u : (ULong)0u) + ((((fm + sm) >> 1) - mh) & ((ULong)UInt.MaxValue << UInt_Misc.BitSizeAsIntUnchecked));
                    return ll;
                }
            }
        }

        [System.CLSCompliantAttribute(false)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static ULong BigMul(Long first, Long second, out Long highResult) {
            ULong r;
            var q = BigMul(unchecked((ULong)first), unchecked((ULong)second), out r);
            highResult = unchecked((Long)r - (-(Long)((ULong)first >> (ULong_Misc.BitSizeAsIntUnchecked - 1)) & second) - (-(Long)((ULong)second >> (ULong_Misc.BitSizeAsIntUnchecked - 1)) & first));
            return q;
        }
        
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        // primary overload
        public static ULong BigMul_A_Karatsuba(ULong first, ULong second, out ULong highResult) {
            unchecked {
                if (ULong_Misc.Size > UIntPtr.Size) {
                    // 2013Oct04
                    // 我很滿意。
                    var fl = (UInt)first;
                    var fh = (UInt)(first >> UInt_Misc.BitSizeAsIntUnchecked);
                    var sl = (UInt)second;
                    var sh = (UInt)(second >> UInt_Misc.BitSizeAsIntUnchecked);
                    var ll = (ULong)fl * sl;
                    var hh = (ULong)fh * sh;
                    var fm = (UInt)fh + fl;
                    var sm = (UInt)sh + sl;
                    var mm = (ULong)(UInt)fm * (UInt)sm - (hh + ll);
                    var mh = (UInt)(mm >> UInt_Misc.BitSizeAsIntUnchecked) + (((UInt)fm < fl) ? (UInt)sm : 0u) + (((UInt)sm < sl) ? (UInt)fm : 0u);
                    var fs = ((ULong)fh + fl) + ((ULong)sh + sl);
                    var ml = mm << UInt_Misc.BitSizeAsIntUnchecked;
                    ll += ml;
                    highResult = hh + ((ULong)mh + ((ll < ml) ? 1u : 0u)) + (((fs >> 1) - mh) & ((ULong)UInt.MaxValue << UInt_Misc.BitSizeAsIntUnchecked));
                    return ll;
                }
                {
                    // 2013Oct03
                    // 我很滿意。
                    var fl = (ULong)(UInt)first;
                    var fh = (ULong)(UInt)(first >> UInt_Misc.BitSizeAsIntUnchecked);
                    var sl = (ULong)(UInt)second;
                    var sh = (ULong)(UInt)(second >> UInt_Misc.BitSizeAsIntUnchecked);
                    var ll = fl * sl;
                    var hh = fh * sh;
                    var fm = fh + fl;
                    var sm = sh + sl;
                    var mm = fm * sm - (hh + ll);
                    // Bod for jitter:
                    // var mh = (ULong)(UInt)(mm >> UInt_Misc.BitSizeAsIntUnchecked);
                    var mh = mm >> UInt_Misc.BitSizeAsIntUnchecked;
                    var ml = mm << UInt_Misc.BitSizeAsIntUnchecked;
                    ll += ml;
                    // Bod for jitter:
                    // highResult = hh + mh + ((ll < ml) ? 1u : 0u) + ((((fm + sm) >> 1) - mh) & ((ULong)UInt.MaxValue << UInt_Misc.BitSizeAsIntUnchecked));
                    highResult = hh + mh + ((ll < ml) ? (ULong)1u : (ULong)0u) + ((((fm + sm) >> 1) - mh) & ((ULong)UInt.MaxValue << UInt_Misc.BitSizeAsIntUnchecked));
                    return ll;
                }
            }
        }

        [System.CLSCompliantAttribute(false)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        // primary overload
        public static ULong BigMul_A_Long(ULong first, ULong second, out ULong highResult) {
            unchecked {
                if (ULong_Misc.Size > UIntPtr.Size) {
                    // 2013Oct03
                    // 我很滿意。
                    var fl = (UInt)first;
                    var fh = (UInt)(first >> UInt_Misc.BitSizeAsIntUnchecked);
                    var sl = (UInt)second;
                    var sh = (UInt)(second >> UInt_Misc.BitSizeAsIntUnchecked);
                    var ll = (ULong)fl * sl;
                    var lh = (ULong)fl * sh;
                    var hl = (ULong)fh * sl;
                    var hh = (ULong)fh * sh;
                    lh += (UInt)(ll >> UInt_Misc.BitSizeAsIntUnchecked);
                    lh += hl;
                    if (lh < hl) {
                        hh += (ULong)1u << UInt_Misc.BitSizeAsIntUnchecked;
                    }
                    highResult = hh + (UInt)(lh >> UInt_Misc.BitSizeAsIntUnchecked);
                    // Bad for jitter:
                    // return (lh << UInt_Misc.BitSizeAsIntUnchecked) + (UInt)(ll);
                    return ((ULong)(UInt)lh << UInt_Misc.BitSizeAsIntUnchecked) | (UInt)(ll);
                }
                {
                    // 2013Oct03
                    // 我很滿意。
                    // Bad for jitter:
                    // fl = (UInt)first;
                    var fl = (ULong)(UInt)first;
                    // Bad for jitter:
                    // var fh = (ULong)(first >> UInt_Misc.BitSizeAsIntUnchecked);
                    var fh = (ULong)(UInt)(first >> UInt_Misc.BitSizeAsIntUnchecked);
                    var sl = (ULong)(UInt)second;
                    var sh = (ULong)(UInt)(second >> UInt_Misc.BitSizeAsIntUnchecked);
                    // Bad for jitter:
                    // var ll = (ULong)(UInt)fl * (ULong)(UInt)sl;
                    var ll = fl * sl;
                    var lh = fl * sh;
                    var hl = fh * sl;
                    var hh = fh * sh;
                    // Bad for jitter:
                    // lh += (UInt)(ll >> UInt_Misc.BitSizeAsIntUnchecked);
                    lh += ll >> UInt_Misc.BitSizeAsIntUnchecked;
                    lh += hl;
                    if (lh < hl) {
                        hh += (ULong)1u << UInt_Misc.BitSizeAsIntUnchecked;
                    }
                    highResult = hh + (lh >> UInt_Misc.BitSizeAsIntUnchecked);
                    return (lh << UInt_Misc.BitSizeAsIntUnchecked) + (UInt)(ll);
                }
            }
            /* // old version
            var xh = first >> UInt_Misc.BitSizeAsIntUnchecked;
            var yh = second >> UInt_Misc.BitSizeAsIntUnchecked;
            var lo = unchecked((ULong)(UInt)first * (UInt)second);
            var xl = unchecked((UInt)first * yh);
            var yl = unchecked(xh * (UInt)second);
            xl = unchecked(xl + yl);
            xh = unchecked(xh * yh);
            yh = unchecked(lo + (xl << UInt_Misc.BitSizeAsIntUnchecked));
            highResult = unchecked((xh + (UInt)(xl >> UInt_Misc.BitSizeAsIntUnchecked)) + ((lo > yh ? (ULong)1 : 0) + (yl > xl ? (ULong)1 << UInt_Misc.BitSizeAsIntUnchecked : 0)));
            return yh;
            */
        }

        [System.CLSCompliantAttribute(false)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static UInt BigMul_M(ULong first, UInt second, out ULong lowResult) {
            var lo = unchecked((ULong)(UInt)first * (UInt)second);
            var yl = unchecked((first >> UInt_Misc.BitSizeAsIntUnchecked) * (UInt)second);
            var yh = unchecked(lo + (yl << UInt_Misc.BitSizeAsIntUnchecked));
            lowResult = yh;
            return unchecked(((UInt)(yl >> UInt_Misc.BitSizeAsIntUnchecked)) + ((lo > yh ? (UInt)1 : 0)));
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static Long BigMulAsSigned(Long first, Long second, out Long highResult) {
            return unchecked((Long)BigMul(first, second, out highResult));
        }

        [System.CLSCompliantAttribute(false)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static ULong BigRemUnchecked(ULong lowDividend, ULong highDividend, ULong divisor) {
            unchecked {
                ULong p;
                if (0u == highDividend) {
                    return lowDividend % divisor;
                } else if (UInt.MaxValue > divisor) {
                    highDividend = (highDividend << UInt_Misc.BitSizeAsIntUnchecked) | (lowDividend >> UInt_Misc.BitSizeAsIntUnchecked);
                    highDividend %= divisor;
                    highDividend = (highDividend << UInt_Misc.BitSizeAsIntUnchecked) | (UInt)lowDividend;
                    return highDividend % divisor;
                } else {
                    // 2013Dec24
                    int c = 0;
                    if (0 <= (Long)divisor) {
                        do {
                            ++c;
                            divisor <<= 1;
                        } while (0 <= (Long)divisor);
                        highDividend = (highDividend << c) | (lowDividend >> (ULong_Misc.BitSizeAsIntUnchecked - c));
                        lowDividend = lowDividend << c;
                    }
                    var dh = (ULong)(UInt)(divisor >> UInt_Misc.BitSizeAsIntUnchecked);
                    var dl = (ULong)(UInt)divisor;
                    p = Math.DivRem(highDividend, dh, out highDividend) * dl;
                    highDividend = (highDividend << UInt_Misc.BitSizeAsIntUnchecked) | (lowDividend >> UInt_Misc.BitSizeAsIntUnchecked);
                    if (highDividend < p) {
                        {
                            highDividend += divisor;
                        }
                        if (highDividend >= divisor) {
                            if (highDividend < p) {
                                highDividend += divisor;
                            }
                        }
                    }
                    highDividend -= p;
                    p = Math.DivRem(highDividend, dh, out highDividend) * dl;
                    highDividend = (highDividend << UInt_Misc.BitSizeAsIntUnchecked) | (UInt)lowDividend;
                    if (highDividend < p) {
                        {
                            highDividend += divisor;
                        }
                        if (highDividend >= divisor) {
                            if (highDividend < p) {
                                highDividend += divisor;
                            }
                        }
                    }
                    return (highDividend - p) >> c;
                }
            }
        }

        [System.CLSCompliantAttribute(false)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static ULong BigSquare(ULong value, out ULong highResult) {
            unchecked {
                if (ULong_Misc.Size > UIntPtr.Size) {
                    // 2013Oct04
                    var fl = (UInt)value;
                    var fh = (UInt)(value >> UInt_Misc.BitSizeAsIntUnchecked);
                    var ll = (ULong)fl * fl;
                    var lh = (ULong)fl * fh;
                    var hl = lh;
                    var hh = (ULong)fh * fh;
                    lh += (UInt)(ll >> UInt_Misc.BitSizeAsIntUnchecked);
                    lh += hl;
                    if (lh < hl) {
                        hh += (ULong)1u << UInt_Misc.BitSizeAsIntUnchecked;
                    }
                    highResult = hh + (UInt)(lh >> UInt_Misc.BitSizeAsIntUnchecked);
                    return ((ULong)(UInt)lh << UInt_Misc.BitSizeAsIntUnchecked) | (UInt)(ll);
                }
                {
                    // 2013Oct04
                    var fl = (ULong)(UInt)value;
                    var fh = (ULong)(UInt)(value >> UInt_Misc.BitSizeAsIntUnchecked);
                    var ll = fl * fl;
                    var lh = fl * fh;
                    var hl = lh;
                    var hh = fh * fh;
                    lh += ll >> UInt_Misc.BitSizeAsIntUnchecked;
                    lh += hl;
                    if (lh < hl) {
                        hh += (ULong)1u << UInt_Misc.BitSizeAsIntUnchecked;
                    }
                    highResult = hh + (lh >> UInt_Misc.BitSizeAsIntUnchecked);
                    return (lh << UInt_Misc.BitSizeAsIntUnchecked) + (UInt)(ll);
                }
            }
        }
        
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        internal static ULong BigDivRemInternal(ULong lowDividend, ULong highDividend, ULong divisor, out ULong remainder) {
            unchecked {
                ULong p, ql, qh;
                if (0u == highDividend) {
                    return Math.DivRem(lowDividend, divisor, out remainder);
                } else if (UInt.MaxValue > divisor) {
                    highDividend = (highDividend << UInt_Misc.BitSizeAsIntUnchecked) | (lowDividend >> UInt_Misc.BitSizeAsIntUnchecked);
                    qh = Math.DivRem(highDividend, divisor, out highDividend);
                    highDividend = (highDividend << UInt_Misc.BitSizeAsIntUnchecked) | (UInt)lowDividend;
                    ql = Math.DivRem(highDividend, divisor, out remainder);
                    return (qh << UInt_Misc.BitSizeAsIntUnchecked) | ql;
                } else {
                    // 2013Dec24
                    int c = 0;
                    if (0 <= (Long)divisor) {
                        do {
                            ++c;
                            divisor <<= 1;
                        } while (0 <= (Long)divisor);
                        highDividend = (highDividend << c) | (lowDividend >> (ULong_Misc.BitSizeAsIntUnchecked - c));
                        lowDividend = lowDividend << c;
                    }
                    var dh = (ULong)(UInt)(divisor >> UInt_Misc.BitSizeAsIntUnchecked);
                    var dl = (ULong)(UInt)divisor;
                    qh = Math.DivRem(highDividend, dh, out highDividend);
                    p = qh * dl;
                    highDividend = (highDividend << UInt_Misc.BitSizeAsIntUnchecked) | (lowDividend >> UInt_Misc.BitSizeAsIntUnchecked);
                    if (highDividend < p) {
                        {
                            --qh;
                            highDividend += divisor;
                        }
                        if (highDividend >= divisor) {
                            if (highDividend < p) {
                                --qh;
                                highDividend += divisor;
                            }
                        }
                    }
                    highDividend -= p;
                    ql = Math.DivRem(highDividend, dh, out highDividend);
                    p = ql * dl;
                    highDividend = (highDividend << UInt_Misc.BitSizeAsIntUnchecked) | (UInt)lowDividend;
                    if (highDividend < p) {
                        {
                            --ql;
                            highDividend += divisor;
                        }
                        if (highDividend >= divisor) {
                            if (highDividend < p) {
                                --ql;
                                highDividend += divisor;
                            }
                        }
                    }
                    remainder = (highDividend - p) >> c;
                    return (qh << UInt_Misc.BitSizeAsIntUnchecked) | ql;
                }
            }
        }

        // [System.CLSCompliantAttribute(false)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        internal static ULong BigRemInternal(ULong lowDividend, ULong highDividend, ULong divisor) {
            // 2014Sep19
            unchecked {
                ULong p, ql, qh;
                if (0u == highDividend) {
                    return lowDividend % divisor;
                } else if (UInt.MaxValue > divisor) {
                    highDividend = (highDividend << UInt_Misc.BitSizeAsIntUnchecked) | (lowDividend >> UInt_Misc.BitSizeAsIntUnchecked);
                    highDividend = highDividend % divisor;
                    highDividend = (highDividend << UInt_Misc.BitSizeAsIntUnchecked) | (UInt)lowDividend;
                    return highDividend % divisor;
                } else {
                    // 2013Dec24
                    int c = 0;
                    if (0 <= (Long)divisor) {
                        do {
                            ++c;
                            divisor <<= 1;
                        } while (0 <= (Long)divisor);
                        highDividend = (highDividend << c) | (lowDividend >> (ULong_Misc.BitSizeAsIntUnchecked - c));
                        lowDividend = lowDividend << c;
                    }
                    var dh = (ULong)(UInt)(divisor >> UInt_Misc.BitSizeAsIntUnchecked);
                    var dl = (ULong)(UInt)divisor;
                    qh = Math.DivRem(highDividend, dh, out highDividend);
                    p = qh * dl;
                    highDividend = (highDividend << UInt_Misc.BitSizeAsIntUnchecked) | (lowDividend >> UInt_Misc.BitSizeAsIntUnchecked);
                    if (highDividend < p) {
                        {
                            --qh;
                            highDividend += divisor;
                        }
                        if (highDividend >= divisor) {
                            if (highDividend < p) {
                                --qh;
                                highDividend += divisor;
                            }
                        }
                    }
                    highDividend -= p;
                    ql = Math.DivRem(highDividend, dh, out highDividend);
                    p = ql * dl;
                    highDividend = (highDividend << UInt_Misc.BitSizeAsIntUnchecked) | (UInt)lowDividend;
                    if (highDividend < p) {
                        {
                            highDividend += divisor;
                        }
                        if (highDividend >= divisor) {
                            if (highDividend < p) {
                                highDividend += divisor;
                            }
                        }
                    }
                    return (highDividend - p) >> c;
                }
            }
        }

        // [System.CLSCompliantAttribute(false)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        internal static ULong BigDivInternal(ULong lowDividend, ULong highDividend, ULong divisor) {
            // 2014Sep13
            unchecked {
                ULong p, ql, qh;
                if (0u == highDividend) {
                    return lowDividend / divisor;
                } else if (UInt.MaxValue > divisor) {
                    highDividend = (highDividend << UInt_Misc.BitSizeAsIntUnchecked) | (lowDividend >> UInt_Misc.BitSizeAsIntUnchecked);
                    qh = Math.DivRem(highDividend, divisor, out highDividend);
                    highDividend = (highDividend << UInt_Misc.BitSizeAsIntUnchecked) | (UInt)lowDividend;
                    ql = highDividend / divisor;
                    return (qh << UInt_Misc.BitSizeAsIntUnchecked) | ql;
                } else {
                    // 2013Dec24
                    int c = 0;
                    if (0 <= (Long)divisor) {
                        do {
                            ++c;
                            divisor <<= 1;
                        } while (0 <= (Long)divisor);
                        highDividend = (highDividend << c) | (lowDividend >> (ULong_Misc.BitSizeAsIntUnchecked - c));
                        lowDividend = lowDividend << c;
                    }
                    var dh = (ULong)(UInt)(divisor >> UInt_Misc.BitSizeAsIntUnchecked);
                    var dl = (ULong)(UInt)divisor;
                    qh = Math.DivRem(highDividend, dh, out highDividend);
                    p = qh * dl;
                    highDividend = (highDividend << UInt_Misc.BitSizeAsIntUnchecked) | (lowDividend >> UInt_Misc.BitSizeAsIntUnchecked);
                    if (highDividend < p) {
                        {
                            --qh;
                            highDividend += divisor;
                        }
                        if (highDividend >= divisor) {
                            if (highDividend < p) {
                                --qh;
                                highDividend += divisor;
                            }
                        }
                    }
                    highDividend -= p;
                    ql = Math.DivRem(highDividend, dh, out highDividend);
                    p = ql * dl;
                    highDividend = (highDividend << UInt_Misc.BitSizeAsIntUnchecked) | (UInt)lowDividend;
                    if (highDividend < p) {
                        {
                            --ql;
                            highDividend += divisor;
                        }
                        if (highDividend >= divisor) {
                            if (highDividend < p) {
                                --ql;
                                // highDividend += divisor;
                            }
                        }
                    }
                    // remainder = (highDividend - p) >> c;
                    return (qh << UInt_Misc.BitSizeAsIntUnchecked) | ql;
                }
            }
        }

        // [System.CLSCompliantAttribute(false)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        internal static ULong BigDivRemPartialInternal(ULong lowDividend, ULong highDividend, ULong divisor, out ULong remainder) {
            unchecked {
                var dh = (ULong)(UInt)(divisor >> UInt_Misc.BitSizeAsIntUnchecked);
                var dl = (ULong)(UInt)divisor;
                var qh = Math.DivRem(highDividend, dh, out highDividend);
                var p = qh * dl;
                highDividend = (highDividend << UInt_Misc.BitSizeAsIntUnchecked) | (lowDividend >> UInt_Misc.BitSizeAsIntUnchecked);
                if (highDividend < p) {
                    {
                        --qh;
                        highDividend += divisor;
                    }
                    if (highDividend >= divisor) {
                        if (highDividend < p) {
                            --qh;
                            highDividend += divisor;
                        }
                    }
                }
                highDividend -= p;
                var ql = Math.DivRem(highDividend, dh, out highDividend);
                p = ql * dl;
                highDividend = (highDividend << UInt_Misc.BitSizeAsIntUnchecked) | (UInt)lowDividend;
                if (highDividend < p) {
                    {
                        --ql;
                        highDividend += divisor;
                    }
                    if (highDividend >= divisor) {
                        if (highDividend < p) {
                            --ql;
                            highDividend += divisor;
                        }
                    }
                }
                remainder = highDividend - p;
                return (qh << UInt_Misc.BitSizeAsIntUnchecked) | ql;
            }
        }
    }
}

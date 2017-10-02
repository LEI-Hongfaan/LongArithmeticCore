using System;
using System.Collections.Generic;

namespace UltimateOrb.Mathematics.Internal.Testing {
    using Typed.Collections.Generic;
    using System.Collections;

    using BigInteger = System.Numerics.BigInteger;

	public partial struct Int64CollectionTestDataSourceMagnitude5 : Typed.Collections.Generic.IEnumerable<Int64, Int64CollectionTestDataSourceMagnitude5.Enumerator> {
	    
		public static readonly Int64CollectionTestDataSourceMagnitude5 Default;

        public partial struct Enumerator : IEnumerator<Int64> {
		    
            private Int64 i;

            public Int64 Current {

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                get {
                    var i = unchecked(this.i - 1);
                    var j =
                        ((((Int64)0x1 << 0) & i) << (0 - 0)) |
                        ((((Int64)0x1 << 1) & i) << (31 - 1)) |
                        ((((Int64)0x3 << 2) & i) << (62 - 2));
                    return 0x10 <= i ? ~j : j;
                }
            }

            object IEnumerator.Current {

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                get {
                    return this.Current;
                }
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void Dispose() {
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool MoveNext() {
                var i = this.i;
                if (0x20 > i) {
                    unchecked {
                        ++i;
                    }
                    this.i = i;
                    return true;
                }
                return false;
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void Reset() {
                this.i = 0;
            }
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public Enumerator GetEnumerator() {
            return default(Enumerator);
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        IEnumerator IEnumerable.GetEnumerator() {
            return default(Enumerator);
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        IEnumerator<Int64> IEnumerable<Int64>.GetEnumerator() {
            return default(Enumerator);
        }
    }

	public partial struct Int64CollectionTestDataSourceMagnitude6 : Typed.Collections.Generic.IEnumerable<Int64, Int64CollectionTestDataSourceMagnitude6.Enumerator> {
	    
		public static readonly Int64CollectionTestDataSourceMagnitude6 Default;

        public partial struct Enumerator : IEnumerator<Int64> {
		    
            private Int64 i;

            public Int64 Current {

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                get {
                    var i = unchecked(this.i - 1);
                    var j =
                        ((((Int64)0x3 << 0) & i) << (0 - 0)) |
                        ((((Int64)0x1 << 2) & i) << (31 - 2)) |
                        ((((Int64)0x3 << 3) & i) << (62 - 3));
                    return 0x20 <= i ? ~j : j;
                }
            }

            object IEnumerator.Current {

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                get {
                    return this.Current;
                }
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void Dispose() {
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool MoveNext() {
                var i = this.i;
                if (0x40 > i) {
                    unchecked {
                        ++i;
                    }
                    this.i = i;
                    return true;
                }
                return false;
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void Reset() {
                this.i = 0;
            }
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public Enumerator GetEnumerator() {
            return default(Enumerator);
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        IEnumerator IEnumerable.GetEnumerator() {
            return default(Enumerator);
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        IEnumerator<Int64> IEnumerable<Int64>.GetEnumerator() {
            return default(Enumerator);
        }
    }

    public partial struct Int64CollectionTestDataSourceMagnitude7 : Typed.Collections.Generic.IEnumerable<Int64, Int64CollectionTestDataSourceMagnitude7.Enumerator> {
	    
		public static readonly Int64CollectionTestDataSourceMagnitude7 Default;

        public partial struct Enumerator : IEnumerator<Int64> {

            private Int64 i;

            public Int64 Current {

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                get {
                    var i = unchecked(this.i - 1);
                    var j =
                        ((((Int64)0x3 << 0) & i) << (0 - 0)) |
                        ((((Int64)0x1 << 2) & i) << (31 - 2)) |
                        ((((Int64)0x7 << 3) & i) << (61 - 3));
                    return 0x40 <= i ? ~j : j;
                }
            }

            object IEnumerator.Current {

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                get {
                    return this.Current;
                }
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void Dispose() {
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool MoveNext() {
                var i = this.i;
                if (0x80 > i) {
                    unchecked {
                        ++i;
                    }
                    this.i = i;
                    return true;
                }
                return false;
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void Reset() {
                this.i = 0;
            }
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public Enumerator GetEnumerator() {
            return default(Enumerator);
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        IEnumerator IEnumerable.GetEnumerator() {
            return default(Enumerator);
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        IEnumerator<Int64> IEnumerable<Int64>.GetEnumerator() {
            return default(Enumerator);
        }
    }

	public partial struct Int64CollectionTestDataSourceMagnitude10 : Typed.Collections.Generic.IEnumerable<Int64, Int64CollectionTestDataSourceMagnitude10.Enumerator> {
	    
		public static readonly Int64CollectionTestDataSourceMagnitude10 Default;

        public partial struct Enumerator : IEnumerator<Int64> {

            private Int64 i;

            public Int64 Current {

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                get {
                    var i = unchecked(this.i - 1);
                    var j =
                        ((((Int64)0x3 << 0) & i) << (0 - 0)) |
						((((Int64)0x1 << 2) & i) << (15 - 2)) |
                        ((((Int64)0x3 << 3) & i) << (31 - 3)) |
						((((Int64)0x1 << 5) & i) << (47 - 5)) |
                        ((((Int64)0x7 << 6) & i) << (61 - 6));
                    return 0x200 <= i ? ~j : j;
                }
            }

            object IEnumerator.Current {

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                get {
                    return this.Current;
                }
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void Dispose() {
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool MoveNext() {
                var i = this.i;
                if (0x400 > i) {
                    unchecked {
                        ++i;
                    }
                    this.i = i;
                    return true;
                }
                return false;
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void Reset() {
                this.i = 0;
            }
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public Enumerator GetEnumerator() {
            return default(Enumerator);
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        IEnumerator IEnumerable.GetEnumerator() {
            return default(Enumerator);
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        IEnumerator<Int64> IEnumerable<Int64>.GetEnumerator() {
            return default(Enumerator);
        }
    }

    public partial struct Int64CollectionTestDataSourceMagnitude12 : Typed.Collections.Generic.IEnumerable<Int64, Int64CollectionTestDataSourceMagnitude12.Enumerator> {
	    
		public static readonly Int64CollectionTestDataSourceMagnitude12 Default;

        public partial struct Enumerator : IEnumerator<Int64> {

            private Int64 i;

            public Int64 Current {

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                get {
                    var i = unchecked(this.i - 1);
                    var j =
                        ((((Int64)0x3 << 0) & i) << (0 - 0)) |
						((((Int64)0x3 << 2) & i) << (15 - 2)) |
                        ((((Int64)0x3 << 4) & i) << (31 - 4)) |
						((((Int64)0x3 << 6) & i) << (47 - 6)) |
                        ((((Int64)0x7 << 8) & i) << (61 - 8));
                    return 0x800 <= i ? ~j : j;
                }
            }

            object IEnumerator.Current {

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                get {
                    return this.Current;
                }
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void Dispose() {
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool MoveNext() {
                var i = this.i;
                if (0x1000 > i) {
                    unchecked {
                        ++i;
                    }
                    this.i = i;
                    return true;
                }
                return false;
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void Reset() {
                this.i = 0;
            }
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public Enumerator GetEnumerator() {
            return default(Enumerator);
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        IEnumerator IEnumerable.GetEnumerator() {
            return default(Enumerator);
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        IEnumerator<Int64> IEnumerable<Int64>.GetEnumerator() {
            return default(Enumerator);
        }
    }

	public partial struct Int64CollectionTestDataSourceMagnitude13 : Typed.Collections.Generic.IEnumerable<Int64, Int64CollectionTestDataSourceMagnitude13.Enumerator> {
	    
		public static readonly Int64CollectionTestDataSourceMagnitude13 Default;

        public partial struct Enumerator : IEnumerator<Int64> {

            private Int64 i;

            public Int64 Current {

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                get {
                    var i = unchecked(this.i - 1);
                    var j =
                        ((((Int64)0x3 << 0) & i) << (0 - 0)) |
						((((Int64)0x3 << 2) & i) << (15 - 2)) |
                        ((((Int64)0x3 << 4) & i) << (31 - 4)) |
						((((Int64)0x3 << 6) & i) << (47 - 6)) |
                        ((((Int64)0x15 << 8) & i) << (60 - 8));
                    return 0x1000 <= i ? ~j : j;
                }
            }

            object IEnumerator.Current {

                [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                get {
                    return this.Current;
                }
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void Dispose() {
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool MoveNext() {
                var i = this.i;
                if (0x2000 > i) {
                    unchecked {
                        ++i;
                    }
                    this.i = i;
                    return true;
                }
                return false;
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void Reset() {
                this.i = 0;
            }
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public Enumerator GetEnumerator() {
            return default(Enumerator);
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        IEnumerator IEnumerable.GetEnumerator() {
            return default(Enumerator);
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        IEnumerator<Int64> IEnumerable<Int64>.GetEnumerator() {
            return default(Enumerator);
        }
    }
}

namespace UltimateOrb.Mathematics.Internal.Testing.ArithmeticOperations {
    using BigInteger = System.Numerics.BigInteger;
	
	public static partial class TestModule {
	    
		internal static BigInteger ToBigIntegerUnsigned(Int64 lo, Int64 hi) {
		    return
			    unchecked((UInt64)lo) |
			    ((BigInteger)unchecked((UInt64)hi) << 64);
		}

		internal static BigInteger ToBigIntegerSigned(Int64 lo, Int64 hi) {
		    return
			    unchecked((UInt64)lo) |
			    ((BigInteger)unchecked((Int64)hi) << 64);
		}
	}
}

namespace UltimateOrb.Mathematics.Internal.Testing.ArithmeticOperations {
    using BigInteger = System.Numerics.BigInteger;
	
	public static partial class TestModule {
	    
		public static readonly BigInteger UInt128_MinValue = ToBigIntegerUnsigned(unchecked((Int64)(UInt64.MinValue)), unchecked((Int64)(UInt64.MinValue)));

		public static readonly BigInteger UInt128_MaxValue = ToBigIntegerUnsigned(unchecked((Int64)(UInt64.MaxValue)), unchecked((Int64)(UInt64.MaxValue)));

		public static readonly BigInteger Int128_MinValue = ToBigIntegerSigned(unchecked((Int64)(UInt64.MinValue)), unchecked((Int64)(Int64.MinValue)));

		public static readonly BigInteger Int128_MaxValue = ToBigIntegerSigned(unchecked((Int64)(UInt64.MaxValue)), unchecked((Int64)(Int64.MaxValue)));
	}
}

namespace UltimateOrb.Mathematics.Internal.Testing.ArithmeticOperations {
    using IntT = Int64;
    using UIntT = UInt64;

    using BigInteger = System.Numerics.BigInteger;
	using static TestModule;

#region Unary Operations
    public delegate BigInteger Operation_IX_MapsTo_IX(BigInteger value);

    public delegate IntT Operation_U2_MapsTo_U2Checked_WithSignature_I_I_MapsTo_I_I(IntT value_lo, IntT value_hi, out IntT result_hi);
    
    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_MapsTo_IX referenceImpl, Operation_U2_MapsTo_U2Checked_WithSignature_I_I_MapsTo_I_I testImpl, IntT value_lo, IntT value_hi) {
            var r_value = ToBigIntegerUnsigned(unchecked((IntT)value_lo), unchecked((IntT)value_hi));
            bool r_ov = false;
			var r_result = referenceImpl(r_value);
			if (/*= checked(2 * T) */UInt128_MinValue > r_result || r_result > /*= checked(2 * T) */UInt128_MaxValue) {
                r_ov = true;
				r_result = default(BigInteger);
			}
            bool t_ov = false;
			IntT t_result_lo = 0;
			IntT t_result_hi = 0;
            try {
                t_result_lo = testImpl(value_lo, value_hi, out t_result_hi);
            } catch(OverflowException) {
                t_ov = true;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			var t_result = ToBigIntegerUnsigned(unchecked((IntT)t_result_lo), unchecked((IntT)t_result_hi));
            return r_ov == t_ov && r_result == t_result;
        }

		public static bool TestOperation(Operation_IX_MapsTo_IX referenceImpl, Operation_U2_MapsTo_U2Checked_WithSignature_I_I_MapsTo_I_I testImpl) {
		    foreach (var hi in Int64CollectionTestDataSourceMagnitude10.Default) {
			    foreach (var lo in Int64CollectionTestDataSourceMagnitude10.Default) {
			        if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((IntT)lo), unchecked((IntT)hi))) {
					    return false;
					}
			    }
			}
			return true;
		}
    }

    public delegate IntT Operation_I2_MapsTo_I2Checked_WithSignature_I_I_MapsTo_I_I(IntT value_lo, IntT value_hi, out IntT result_hi);

    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_MapsTo_IX referenceImpl, Operation_I2_MapsTo_I2Checked_WithSignature_I_I_MapsTo_I_I testImpl, IntT value_lo, IntT value_hi) {
            var r_value = ToBigIntegerSigned(unchecked((IntT)value_lo), unchecked((IntT)value_hi));
            bool r_ov = false;
			var r_result = referenceImpl(r_value);
			if (/*= checked(2 * T) */Int128_MinValue > r_result || r_result > /*= checked(2 * T) */Int128_MaxValue) {
                r_ov = true;
				r_result = default(BigInteger);
			}
            bool t_ov = false;
			IntT t_result_lo = 0;
			IntT t_result_hi = 0;
            try {
                t_result_lo = testImpl(value_lo, value_hi, out t_result_hi);
            } catch(OverflowException) {
                t_ov = true;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			var t_result = ToBigIntegerSigned(unchecked((IntT)t_result_lo), unchecked((IntT)t_result_hi));
            return r_ov == t_ov && r_result == t_result;
        }

		public static bool TestOperation(Operation_IX_MapsTo_IX referenceImpl, Operation_I2_MapsTo_I2Checked_WithSignature_I_I_MapsTo_I_I testImpl) {
		    foreach (var hi in Int64CollectionTestDataSourceMagnitude10.Default) {
			    foreach (var lo in Int64CollectionTestDataSourceMagnitude10.Default) {
			        if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((IntT)lo), unchecked((IntT)hi))) {
					    return false;
					}
			    }
			}
			return true;
		}
    }

    // usually same as Operation_I2_MapsTo_I2Unchecked_WithSignature_I_I_MapsTo_I_I
    public delegate IntT Operation_U2_MapsTo_U2Unchecked_WithSignature_I_I_MapsTo_I_I(IntT value_lo, IntT value_hi, out IntT result_hi);
    
	public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_MapsTo_IX referenceImpl, Operation_U2_MapsTo_U2Unchecked_WithSignature_I_I_MapsTo_I_I testImpl, IntT value_lo, IntT value_hi) {
            var r_value = ToBigIntegerUnsigned(unchecked((IntT)value_lo), unchecked((IntT)value_hi));
			var r_result = referenceImpl(r_value);
			IntT t_result_lo;
			IntT t_result_hi;
            try {
                t_result_lo = testImpl(value_lo, value_hi, out t_result_hi);
            } catch(OverflowException) {
				return false;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			IntT r_result_lo = unchecked((IntT)(UIntT)(UIntT.MaxValue & r_result));
			IntT r_result_hi = unchecked((IntT)(UIntT)(UIntT.MaxValue & (r_result >> /*= T - 1 */63/**/ >> 1)));
            return r_result_lo == t_result_lo && r_result_hi == t_result_hi;
        }

		public static bool TestOperation(Operation_IX_MapsTo_IX referenceImpl, Operation_U2_MapsTo_U2Unchecked_WithSignature_I_I_MapsTo_I_I testImpl) {
		    foreach (var hi in Int64CollectionTestDataSourceMagnitude10.Default) {
			    foreach (var lo in Int64CollectionTestDataSourceMagnitude10.Default) {
			        if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((IntT)lo), unchecked((IntT)hi))) {
					    return false;
					}
			    }
			}
			return true;
		}
    }

    // usually same as Operation_U2_MapsTo_U2Unchecked_WithSignature_I_I_MapsTo_I_I
    public delegate IntT Operation_I2_MapsTo_I2Unchecked_WithSignature_I_I_MapsTo_I_I(IntT value_lo, IntT value_hi, out IntT result_hi);

    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_MapsTo_IX referenceImpl, Operation_I2_MapsTo_I2Unchecked_WithSignature_I_I_MapsTo_I_I testImpl, IntT value_lo, IntT value_hi) {
            var r_value = ToBigIntegerSigned(unchecked((IntT)value_lo), unchecked((IntT)value_hi));
			var r_result = referenceImpl(r_value);
			IntT t_result_lo;
			IntT t_result_hi;
            try {
                t_result_lo = testImpl(value_lo, value_hi, out t_result_hi);
            } catch(OverflowException) {
				return false;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			IntT r_result_lo = unchecked((IntT)(UIntT)(UIntT.MaxValue & r_result));
			IntT r_result_hi = unchecked((IntT)(UIntT)(UIntT.MaxValue & (r_result >> /*= T - 1 */63/**/ >> 1)));
            return r_result_lo == t_result_lo && r_result_hi == t_result_hi;
        }

		public static bool TestOperation(Operation_IX_MapsTo_IX referenceImpl, Operation_I2_MapsTo_I2Unchecked_WithSignature_I_I_MapsTo_I_I testImpl) {
		    foreach (var hi in Int64CollectionTestDataSourceMagnitude10.Default) {
			    foreach (var lo in Int64CollectionTestDataSourceMagnitude10.Default) {
			        if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((IntT)lo), unchecked((IntT)hi))) {
					    return false;
					}
			    }
			}
			return true;
		}
    }

    public delegate UIntT Operation_U2_MapsTo_U2Checked_WithSignature_U_I_MapsTo_U_I(UIntT value_lo, IntT value_hi, out IntT result_hi);
    
    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_MapsTo_IX referenceImpl, Operation_U2_MapsTo_U2Checked_WithSignature_U_I_MapsTo_U_I testImpl, UIntT value_lo, IntT value_hi) {
            var r_value = ToBigIntegerUnsigned(unchecked((IntT)value_lo), unchecked((IntT)value_hi));
            bool r_ov = false;
			var r_result = referenceImpl(r_value);
			if (/*= checked(2 * T) */UInt128_MinValue > r_result || r_result > /*= checked(2 * T) */UInt128_MaxValue) {
                r_ov = true;
				r_result = default(BigInteger);
			}
            bool t_ov = false;
			UIntT t_result_lo = 0;
			IntT t_result_hi = 0;
            try {
                t_result_lo = testImpl(value_lo, value_hi, out t_result_hi);
            } catch(OverflowException) {
                t_ov = true;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			var t_result = ToBigIntegerUnsigned(unchecked((IntT)t_result_lo), unchecked((IntT)t_result_hi));
            return r_ov == t_ov && r_result == t_result;
        }

		public static bool TestOperation(Operation_IX_MapsTo_IX referenceImpl, Operation_U2_MapsTo_U2Checked_WithSignature_U_I_MapsTo_U_I testImpl) {
		    foreach (var hi in Int64CollectionTestDataSourceMagnitude10.Default) {
			    foreach (var lo in Int64CollectionTestDataSourceMagnitude10.Default) {
			        if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((UIntT)lo), unchecked((IntT)hi))) {
					    return false;
					}
			    }
			}
			return true;
		}
    }

    public delegate UIntT Operation_I2_MapsTo_I2Checked_WithSignature_U_I_MapsTo_U_I(UIntT value_lo, IntT value_hi, out IntT result_hi);

    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_MapsTo_IX referenceImpl, Operation_I2_MapsTo_I2Checked_WithSignature_U_I_MapsTo_U_I testImpl, UIntT value_lo, IntT value_hi) {
            var r_value = ToBigIntegerSigned(unchecked((IntT)value_lo), unchecked((IntT)value_hi));
            bool r_ov = false;
			var r_result = referenceImpl(r_value);
			if (/*= checked(2 * T) */Int128_MinValue > r_result || r_result > /*= checked(2 * T) */Int128_MaxValue) {
                r_ov = true;
				r_result = default(BigInteger);
			}
            bool t_ov = false;
			UIntT t_result_lo = 0;
			IntT t_result_hi = 0;
            try {
                t_result_lo = testImpl(value_lo, value_hi, out t_result_hi);
            } catch(OverflowException) {
                t_ov = true;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			var t_result = ToBigIntegerSigned(unchecked((IntT)t_result_lo), unchecked((IntT)t_result_hi));
            return r_ov == t_ov && r_result == t_result;
        }

		public static bool TestOperation(Operation_IX_MapsTo_IX referenceImpl, Operation_I2_MapsTo_I2Checked_WithSignature_U_I_MapsTo_U_I testImpl) {
		    foreach (var hi in Int64CollectionTestDataSourceMagnitude10.Default) {
			    foreach (var lo in Int64CollectionTestDataSourceMagnitude10.Default) {
			        if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((UIntT)lo), unchecked((IntT)hi))) {
					    return false;
					}
			    }
			}
			return true;
		}
    }

    // usually same as Operation_I2_MapsTo_I2Unchecked_WithSignature_U_I_MapsTo_U_I
    public delegate UIntT Operation_U2_MapsTo_U2Unchecked_WithSignature_U_I_MapsTo_U_I(UIntT value_lo, IntT value_hi, out IntT result_hi);
    
	public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_MapsTo_IX referenceImpl, Operation_U2_MapsTo_U2Unchecked_WithSignature_U_I_MapsTo_U_I testImpl, UIntT value_lo, IntT value_hi) {
            var r_value = ToBigIntegerUnsigned(unchecked((IntT)value_lo), unchecked((IntT)value_hi));
			var r_result = referenceImpl(r_value);
			UIntT t_result_lo;
			IntT t_result_hi;
            try {
                t_result_lo = testImpl(value_lo, value_hi, out t_result_hi);
            } catch(OverflowException) {
				return false;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			UIntT r_result_lo = unchecked((UIntT)(UIntT)(UIntT.MaxValue & r_result));
			IntT r_result_hi = unchecked((IntT)(UIntT)(UIntT.MaxValue & (r_result >> /*= T - 1 */63/**/ >> 1)));
            return r_result_lo == t_result_lo && r_result_hi == t_result_hi;
        }

		public static bool TestOperation(Operation_IX_MapsTo_IX referenceImpl, Operation_U2_MapsTo_U2Unchecked_WithSignature_U_I_MapsTo_U_I testImpl) {
		    foreach (var hi in Int64CollectionTestDataSourceMagnitude10.Default) {
			    foreach (var lo in Int64CollectionTestDataSourceMagnitude10.Default) {
			        if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((UIntT)lo), unchecked((IntT)hi))) {
					    return false;
					}
			    }
			}
			return true;
		}
    }

    // usually same as Operation_U2_MapsTo_U2Unchecked_WithSignature_U_I_MapsTo_U_I
    public delegate UIntT Operation_I2_MapsTo_I2Unchecked_WithSignature_U_I_MapsTo_U_I(UIntT value_lo, IntT value_hi, out IntT result_hi);

    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_MapsTo_IX referenceImpl, Operation_I2_MapsTo_I2Unchecked_WithSignature_U_I_MapsTo_U_I testImpl, UIntT value_lo, IntT value_hi) {
            var r_value = ToBigIntegerSigned(unchecked((IntT)value_lo), unchecked((IntT)value_hi));
			var r_result = referenceImpl(r_value);
			UIntT t_result_lo;
			IntT t_result_hi;
            try {
                t_result_lo = testImpl(value_lo, value_hi, out t_result_hi);
            } catch(OverflowException) {
				return false;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			UIntT r_result_lo = unchecked((UIntT)(UIntT)(UIntT.MaxValue & r_result));
			IntT r_result_hi = unchecked((IntT)(UIntT)(UIntT.MaxValue & (r_result >> /*= T - 1 */63/**/ >> 1)));
            return r_result_lo == t_result_lo && r_result_hi == t_result_hi;
        }

		public static bool TestOperation(Operation_IX_MapsTo_IX referenceImpl, Operation_I2_MapsTo_I2Unchecked_WithSignature_U_I_MapsTo_U_I testImpl) {
		    foreach (var hi in Int64CollectionTestDataSourceMagnitude10.Default) {
			    foreach (var lo in Int64CollectionTestDataSourceMagnitude10.Default) {
			        if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((UIntT)lo), unchecked((IntT)hi))) {
					    return false;
					}
			    }
			}
			return true;
		}
    }

    public delegate IntT Operation_U2_MapsTo_U2Checked_WithSignature_I_U_MapsTo_I_U(IntT value_lo, UIntT value_hi, out UIntT result_hi);
    
    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_MapsTo_IX referenceImpl, Operation_U2_MapsTo_U2Checked_WithSignature_I_U_MapsTo_I_U testImpl, IntT value_lo, UIntT value_hi) {
            var r_value = ToBigIntegerUnsigned(unchecked((IntT)value_lo), unchecked((IntT)value_hi));
            bool r_ov = false;
			var r_result = referenceImpl(r_value);
			if (/*= checked(2 * T) */UInt128_MinValue > r_result || r_result > /*= checked(2 * T) */UInt128_MaxValue) {
                r_ov = true;
				r_result = default(BigInteger);
			}
            bool t_ov = false;
			IntT t_result_lo = 0;
			UIntT t_result_hi = 0;
            try {
                t_result_lo = testImpl(value_lo, value_hi, out t_result_hi);
            } catch(OverflowException) {
                t_ov = true;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			var t_result = ToBigIntegerUnsigned(unchecked((IntT)t_result_lo), unchecked((IntT)t_result_hi));
            return r_ov == t_ov && r_result == t_result;
        }

		public static bool TestOperation(Operation_IX_MapsTo_IX referenceImpl, Operation_U2_MapsTo_U2Checked_WithSignature_I_U_MapsTo_I_U testImpl) {
		    foreach (var hi in Int64CollectionTestDataSourceMagnitude10.Default) {
			    foreach (var lo in Int64CollectionTestDataSourceMagnitude10.Default) {
			        if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((IntT)lo), unchecked((UIntT)hi))) {
					    return false;
					}
			    }
			}
			return true;
		}
    }

    public delegate IntT Operation_I2_MapsTo_I2Checked_WithSignature_I_U_MapsTo_I_U(IntT value_lo, UIntT value_hi, out UIntT result_hi);

    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_MapsTo_IX referenceImpl, Operation_I2_MapsTo_I2Checked_WithSignature_I_U_MapsTo_I_U testImpl, IntT value_lo, UIntT value_hi) {
            var r_value = ToBigIntegerSigned(unchecked((IntT)value_lo), unchecked((IntT)value_hi));
            bool r_ov = false;
			var r_result = referenceImpl(r_value);
			if (/*= checked(2 * T) */Int128_MinValue > r_result || r_result > /*= checked(2 * T) */Int128_MaxValue) {
                r_ov = true;
				r_result = default(BigInteger);
			}
            bool t_ov = false;
			IntT t_result_lo = 0;
			UIntT t_result_hi = 0;
            try {
                t_result_lo = testImpl(value_lo, value_hi, out t_result_hi);
            } catch(OverflowException) {
                t_ov = true;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			var t_result = ToBigIntegerSigned(unchecked((IntT)t_result_lo), unchecked((IntT)t_result_hi));
            return r_ov == t_ov && r_result == t_result;
        }

		public static bool TestOperation(Operation_IX_MapsTo_IX referenceImpl, Operation_I2_MapsTo_I2Checked_WithSignature_I_U_MapsTo_I_U testImpl) {
		    foreach (var hi in Int64CollectionTestDataSourceMagnitude10.Default) {
			    foreach (var lo in Int64CollectionTestDataSourceMagnitude10.Default) {
			        if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((IntT)lo), unchecked((UIntT)hi))) {
					    return false;
					}
			    }
			}
			return true;
		}
    }

    // usually same as Operation_I2_MapsTo_I2Unchecked_WithSignature_I_U_MapsTo_I_U
    public delegate IntT Operation_U2_MapsTo_U2Unchecked_WithSignature_I_U_MapsTo_I_U(IntT value_lo, UIntT value_hi, out UIntT result_hi);
    
	public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_MapsTo_IX referenceImpl, Operation_U2_MapsTo_U2Unchecked_WithSignature_I_U_MapsTo_I_U testImpl, IntT value_lo, UIntT value_hi) {
            var r_value = ToBigIntegerUnsigned(unchecked((IntT)value_lo), unchecked((IntT)value_hi));
			var r_result = referenceImpl(r_value);
			IntT t_result_lo;
			UIntT t_result_hi;
            try {
                t_result_lo = testImpl(value_lo, value_hi, out t_result_hi);
            } catch(OverflowException) {
				return false;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			IntT r_result_lo = unchecked((IntT)(UIntT)(UIntT.MaxValue & r_result));
			UIntT r_result_hi = unchecked((UIntT)(UIntT)(UIntT.MaxValue & (r_result >> /*= T - 1 */63/**/ >> 1)));
            return r_result_lo == t_result_lo && r_result_hi == t_result_hi;
        }

		public static bool TestOperation(Operation_IX_MapsTo_IX referenceImpl, Operation_U2_MapsTo_U2Unchecked_WithSignature_I_U_MapsTo_I_U testImpl) {
		    foreach (var hi in Int64CollectionTestDataSourceMagnitude10.Default) {
			    foreach (var lo in Int64CollectionTestDataSourceMagnitude10.Default) {
			        if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((IntT)lo), unchecked((UIntT)hi))) {
					    return false;
					}
			    }
			}
			return true;
		}
    }

    // usually same as Operation_U2_MapsTo_U2Unchecked_WithSignature_I_U_MapsTo_I_U
    public delegate IntT Operation_I2_MapsTo_I2Unchecked_WithSignature_I_U_MapsTo_I_U(IntT value_lo, UIntT value_hi, out UIntT result_hi);

    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_MapsTo_IX referenceImpl, Operation_I2_MapsTo_I2Unchecked_WithSignature_I_U_MapsTo_I_U testImpl, IntT value_lo, UIntT value_hi) {
            var r_value = ToBigIntegerSigned(unchecked((IntT)value_lo), unchecked((IntT)value_hi));
			var r_result = referenceImpl(r_value);
			IntT t_result_lo;
			UIntT t_result_hi;
            try {
                t_result_lo = testImpl(value_lo, value_hi, out t_result_hi);
            } catch(OverflowException) {
				return false;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			IntT r_result_lo = unchecked((IntT)(UIntT)(UIntT.MaxValue & r_result));
			UIntT r_result_hi = unchecked((UIntT)(UIntT)(UIntT.MaxValue & (r_result >> /*= T - 1 */63/**/ >> 1)));
            return r_result_lo == t_result_lo && r_result_hi == t_result_hi;
        }

		public static bool TestOperation(Operation_IX_MapsTo_IX referenceImpl, Operation_I2_MapsTo_I2Unchecked_WithSignature_I_U_MapsTo_I_U testImpl) {
		    foreach (var hi in Int64CollectionTestDataSourceMagnitude10.Default) {
			    foreach (var lo in Int64CollectionTestDataSourceMagnitude10.Default) {
			        if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((IntT)lo), unchecked((UIntT)hi))) {
					    return false;
					}
			    }
			}
			return true;
		}
    }

    public delegate UIntT Operation_U2_MapsTo_U2Checked_WithSignature_U_U_MapsTo_U_U(UIntT value_lo, UIntT value_hi, out UIntT result_hi);
    
    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_MapsTo_IX referenceImpl, Operation_U2_MapsTo_U2Checked_WithSignature_U_U_MapsTo_U_U testImpl, UIntT value_lo, UIntT value_hi) {
            var r_value = ToBigIntegerUnsigned(unchecked((IntT)value_lo), unchecked((IntT)value_hi));
            bool r_ov = false;
			var r_result = referenceImpl(r_value);
			if (/*= checked(2 * T) */UInt128_MinValue > r_result || r_result > /*= checked(2 * T) */UInt128_MaxValue) {
                r_ov = true;
				r_result = default(BigInteger);
			}
            bool t_ov = false;
			UIntT t_result_lo = 0;
			UIntT t_result_hi = 0;
            try {
                t_result_lo = testImpl(value_lo, value_hi, out t_result_hi);
            } catch(OverflowException) {
                t_ov = true;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			var t_result = ToBigIntegerUnsigned(unchecked((IntT)t_result_lo), unchecked((IntT)t_result_hi));
            return r_ov == t_ov && r_result == t_result;
        }

		public static bool TestOperation(Operation_IX_MapsTo_IX referenceImpl, Operation_U2_MapsTo_U2Checked_WithSignature_U_U_MapsTo_U_U testImpl) {
		    foreach (var hi in Int64CollectionTestDataSourceMagnitude10.Default) {
			    foreach (var lo in Int64CollectionTestDataSourceMagnitude10.Default) {
			        if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((UIntT)lo), unchecked((UIntT)hi))) {
					    return false;
					}
			    }
			}
			return true;
		}
    }

    public delegate UIntT Operation_I2_MapsTo_I2Checked_WithSignature_U_U_MapsTo_U_U(UIntT value_lo, UIntT value_hi, out UIntT result_hi);

    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_MapsTo_IX referenceImpl, Operation_I2_MapsTo_I2Checked_WithSignature_U_U_MapsTo_U_U testImpl, UIntT value_lo, UIntT value_hi) {
            var r_value = ToBigIntegerSigned(unchecked((IntT)value_lo), unchecked((IntT)value_hi));
            bool r_ov = false;
			var r_result = referenceImpl(r_value);
			if (/*= checked(2 * T) */Int128_MinValue > r_result || r_result > /*= checked(2 * T) */Int128_MaxValue) {
                r_ov = true;
				r_result = default(BigInteger);
			}
            bool t_ov = false;
			UIntT t_result_lo = 0;
			UIntT t_result_hi = 0;
            try {
                t_result_lo = testImpl(value_lo, value_hi, out t_result_hi);
            } catch(OverflowException) {
                t_ov = true;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			var t_result = ToBigIntegerSigned(unchecked((IntT)t_result_lo), unchecked((IntT)t_result_hi));
            return r_ov == t_ov && r_result == t_result;
        }

		public static bool TestOperation(Operation_IX_MapsTo_IX referenceImpl, Operation_I2_MapsTo_I2Checked_WithSignature_U_U_MapsTo_U_U testImpl) {
		    foreach (var hi in Int64CollectionTestDataSourceMagnitude10.Default) {
			    foreach (var lo in Int64CollectionTestDataSourceMagnitude10.Default) {
			        if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((UIntT)lo), unchecked((UIntT)hi))) {
					    return false;
					}
			    }
			}
			return true;
		}
    }

    // usually same as Operation_I2_MapsTo_I2Unchecked_WithSignature_U_U_MapsTo_U_U
    public delegate UIntT Operation_U2_MapsTo_U2Unchecked_WithSignature_U_U_MapsTo_U_U(UIntT value_lo, UIntT value_hi, out UIntT result_hi);
    
	public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_MapsTo_IX referenceImpl, Operation_U2_MapsTo_U2Unchecked_WithSignature_U_U_MapsTo_U_U testImpl, UIntT value_lo, UIntT value_hi) {
            var r_value = ToBigIntegerUnsigned(unchecked((IntT)value_lo), unchecked((IntT)value_hi));
			var r_result = referenceImpl(r_value);
			UIntT t_result_lo;
			UIntT t_result_hi;
            try {
                t_result_lo = testImpl(value_lo, value_hi, out t_result_hi);
            } catch(OverflowException) {
				return false;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			UIntT r_result_lo = unchecked((UIntT)(UIntT)(UIntT.MaxValue & r_result));
			UIntT r_result_hi = unchecked((UIntT)(UIntT)(UIntT.MaxValue & (r_result >> /*= T - 1 */63/**/ >> 1)));
            return r_result_lo == t_result_lo && r_result_hi == t_result_hi;
        }

		public static bool TestOperation(Operation_IX_MapsTo_IX referenceImpl, Operation_U2_MapsTo_U2Unchecked_WithSignature_U_U_MapsTo_U_U testImpl) {
		    foreach (var hi in Int64CollectionTestDataSourceMagnitude10.Default) {
			    foreach (var lo in Int64CollectionTestDataSourceMagnitude10.Default) {
			        if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((UIntT)lo), unchecked((UIntT)hi))) {
					    return false;
					}
			    }
			}
			return true;
		}
    }

    // usually same as Operation_U2_MapsTo_U2Unchecked_WithSignature_U_U_MapsTo_U_U
    public delegate UIntT Operation_I2_MapsTo_I2Unchecked_WithSignature_U_U_MapsTo_U_U(UIntT value_lo, UIntT value_hi, out UIntT result_hi);

    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_MapsTo_IX referenceImpl, Operation_I2_MapsTo_I2Unchecked_WithSignature_U_U_MapsTo_U_U testImpl, UIntT value_lo, UIntT value_hi) {
            var r_value = ToBigIntegerSigned(unchecked((IntT)value_lo), unchecked((IntT)value_hi));
			var r_result = referenceImpl(r_value);
			UIntT t_result_lo;
			UIntT t_result_hi;
            try {
                t_result_lo = testImpl(value_lo, value_hi, out t_result_hi);
            } catch(OverflowException) {
				return false;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			UIntT r_result_lo = unchecked((UIntT)(UIntT)(UIntT.MaxValue & r_result));
			UIntT r_result_hi = unchecked((UIntT)(UIntT)(UIntT.MaxValue & (r_result >> /*= T - 1 */63/**/ >> 1)));
            return r_result_lo == t_result_lo && r_result_hi == t_result_hi;
        }

		public static bool TestOperation(Operation_IX_MapsTo_IX referenceImpl, Operation_I2_MapsTo_I2Unchecked_WithSignature_U_U_MapsTo_U_U testImpl) {
		    foreach (var hi in Int64CollectionTestDataSourceMagnitude10.Default) {
			    foreach (var lo in Int64CollectionTestDataSourceMagnitude10.Default) {
			        if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((UIntT)lo), unchecked((UIntT)hi))) {
					    return false;
					}
			    }
			}
			return true;
		}
    }
#endregion

#region Binary Operations Basic
    public delegate BigInteger Operation_IX_IX_MapsTo_IX(BigInteger first, BigInteger second);

    public delegate IntT Operation_U2_U2_MapsTo_U2Checked_WithSignature_I_I_I_I_MapsTo_I_I(IntT first_lo, IntT first_hi, IntT second_lo, IntT second_hi, out IntT result_hi);
    
    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_IX_MapsTo_IX referenceImpl, Operation_U2_U2_MapsTo_U2Checked_WithSignature_I_I_I_I_MapsTo_I_I testImpl, IntT first_lo, IntT first_hi, IntT second_lo, IntT second_hi) {
            var r_first = ToBigIntegerUnsigned(unchecked((IntT)first_lo), unchecked((IntT)first_hi));
            var r_second = ToBigIntegerUnsigned(unchecked((IntT)second_lo), unchecked((IntT)second_hi));
            bool r_ov = false;
			var r_result = referenceImpl(r_first, r_second);
			if (/*= checked(2 * T) */UInt128_MinValue > r_result || r_result > /*= checked(2 * T) */UInt128_MaxValue) {
                r_ov = true;
				r_result = default(BigInteger);
			}
            bool t_ov = false;
			IntT t_result_lo = 0;
			IntT t_result_hi = 0;
            try {
                t_result_lo = testImpl(first_lo, first_hi, second_lo, second_hi, out t_result_hi);
            } catch(OverflowException) {
                t_ov = true;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			var t_result = ToBigIntegerUnsigned(unchecked((IntT)t_result_lo), unchecked((IntT)t_result_hi));
            return r_ov == t_ov && r_result == t_result;
        }

		public static bool TestOperation(Operation_IX_IX_MapsTo_IX referenceImpl, Operation_U2_U2_MapsTo_U2Checked_WithSignature_I_I_I_I_MapsTo_I_I testImpl) {
		    foreach (var first_hi in Int64CollectionTestDataSourceMagnitude5.Default) {
			    foreach (var first_lo in Int64CollectionTestDataSourceMagnitude5.Default) {
				    foreach (var second_hi in Int64CollectionTestDataSourceMagnitude5.Default) {
			            foreach (var second_lo in Int64CollectionTestDataSourceMagnitude5.Default) {
			                if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((IntT)first_lo), unchecked((IntT)first_hi), unchecked((IntT)second_lo), unchecked((IntT)second_hi))) {
							    Console.WriteLine("{0}\r\n\t{1}", Convert.ToString(first_hi, 2).PadLeft(64, '0'), Convert.ToString(first_lo, 2).PadLeft(64, '0'));
								Console.WriteLine("{0}\r\n\t{1}", Convert.ToString(second_hi, 2).PadLeft(64, '0'), Convert.ToString(second_lo, 2).PadLeft(64, '0'));
					            return false;
					        }
						}
					}
			    }
			}
			return true;
		}
    }

    public delegate IntT Operation_I2_I2_MapsTo_I2Checked_WithSignature_I_I_I_I_MapsTo_I_I(IntT first_lo, IntT first_hi, IntT second_lo, IntT second_hi, out IntT result_hi);

    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_IX_MapsTo_IX referenceImpl, Operation_I2_I2_MapsTo_I2Checked_WithSignature_I_I_I_I_MapsTo_I_I testImpl, IntT first_lo, IntT first_hi, IntT second_lo, IntT second_hi) {
            var r_first = ToBigIntegerSigned(unchecked((IntT)first_lo), unchecked((IntT)first_hi));
            var r_second = ToBigIntegerSigned(unchecked((IntT)second_lo), unchecked((IntT)second_hi));
            bool r_ov = false;
			var r_result = referenceImpl(r_first, r_second);
			if (/*= checked(2 * T) */Int128_MinValue > r_result || r_result > /*= checked(2 * T) */Int128_MaxValue) {
                r_ov = true;
				r_result = default(BigInteger);
			}
            bool t_ov = false;
			IntT t_result_lo = 0;
			IntT t_result_hi = 0;
            try {
                t_result_lo = testImpl(first_lo, first_hi, second_lo, second_hi, out t_result_hi);
            } catch(OverflowException) {
                t_ov = true;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			var t_result = ToBigIntegerSigned(unchecked((IntT)t_result_lo), unchecked((IntT)t_result_hi));
            return r_ov == t_ov && r_result == t_result;
        }

		public static bool TestOperation(Operation_IX_IX_MapsTo_IX referenceImpl, Operation_I2_I2_MapsTo_I2Checked_WithSignature_I_I_I_I_MapsTo_I_I testImpl) {
		    foreach (var first_hi in Int64CollectionTestDataSourceMagnitude5.Default) {
			    foreach (var first_lo in Int64CollectionTestDataSourceMagnitude5.Default) {
				    foreach (var second_hi in Int64CollectionTestDataSourceMagnitude5.Default) {
			            foreach (var second_lo in Int64CollectionTestDataSourceMagnitude5.Default) {
			                if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((IntT)first_lo), unchecked((IntT)first_hi), unchecked((IntT)second_lo), unchecked((IntT)second_hi))) {
							    Console.WriteLine("{0}\r\n\t{1}", Convert.ToString(first_hi, 2).PadLeft(64, '0'), Convert.ToString(first_lo, 2).PadLeft(64, '0'));
								Console.WriteLine("{0}\r\n\t{1}", Convert.ToString(second_hi, 2).PadLeft(64, '0'), Convert.ToString(second_lo, 2).PadLeft(64, '0'));
					            return false;
					        }
						}
					}
			    }
			}
			return true;
		}
    }

    // usually same as Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_I_I_I_I_MapsTo_I_I(IntT first_lo, IntT first_hi, IntT second_lo, IntT second_hi, out IntT result_hi)
    public delegate IntT Operation_U2_U2_MapsTo_U2Unchecked_WithSignature_I_I_I_I_MapsTo_I_I(IntT first_lo, IntT first_hi, IntT second_lo, IntT second_hi, out IntT result_hi);
    
	public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_IX_MapsTo_IX referenceImpl, Operation_U2_U2_MapsTo_U2Unchecked_WithSignature_I_I_I_I_MapsTo_I_I testImpl, IntT first_lo, IntT first_hi, IntT second_lo, IntT second_hi) {
            var r_first = ToBigIntegerUnsigned(unchecked((IntT)first_lo), unchecked((IntT)first_hi));
            var r_second = ToBigIntegerUnsigned(unchecked((IntT)second_lo), unchecked((IntT)second_hi));
			var r_result = referenceImpl(r_first, r_second);
			IntT t_result_lo;
			IntT t_result_hi;
            try {
                t_result_lo = testImpl(first_lo, first_hi, second_lo, second_hi, out t_result_hi);
            } catch(OverflowException) {
				return false;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			IntT r_result_lo = unchecked((IntT)(UIntT)(UIntT.MaxValue & r_result));
			IntT r_result_hi = unchecked((IntT)(UIntT)(UIntT.MaxValue & (r_result >> /*= T - 1 */63/**/ >> 1)));
            return r_result_lo == t_result_lo && r_result_hi == t_result_hi;
        }

		public static bool TestOperation(Operation_IX_IX_MapsTo_IX referenceImpl, Operation_U2_U2_MapsTo_U2Unchecked_WithSignature_I_I_I_I_MapsTo_I_I testImpl) {
		    foreach (var first_hi in Int64CollectionTestDataSourceMagnitude6.Default) {
			    foreach (var first_lo in Int64CollectionTestDataSourceMagnitude6.Default) {
				    foreach (var second_hi in Int64CollectionTestDataSourceMagnitude6.Default) {
			            foreach (var second_lo in Int64CollectionTestDataSourceMagnitude6.Default) {
			                if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((IntT)first_lo), unchecked((IntT)first_hi), unchecked((IntT)second_lo), unchecked((IntT)second_hi))) {
							    Console.WriteLine("{0}\r\n\t{1}", Convert.ToString(first_hi, 2).PadLeft(64, '0'), Convert.ToString(first_lo, 2).PadLeft(64, '0'));
								Console.WriteLine("{0}\r\n\t{1}", Convert.ToString(second_hi, 2).PadLeft(64, '0'), Convert.ToString(second_lo, 2).PadLeft(64, '0'));
					            return false;
					        }
						}
					}
			    }
			}
			return true;
		}
    }

    // usually same as Operation_U2_U2_MapsTo_U2Unchecked_WithSignature_I_I_I_I_MapsTo_I_I(IntT first_lo, IntT first_hi, IntT second_lo, IntT second_hi, out IntT result_hi)
    public delegate IntT Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_I_I_I_I_MapsTo_I_I(IntT first_lo, IntT first_hi, IntT second_lo, IntT second_hi, out IntT result_hi);

    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_IX_MapsTo_IX referenceImpl, Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_I_I_I_I_MapsTo_I_I testImpl, IntT first_lo, IntT first_hi, IntT second_lo, IntT second_hi) {
            var r_first = ToBigIntegerSigned(unchecked((IntT)first_lo), unchecked((IntT)first_hi));
            var r_second = ToBigIntegerSigned(unchecked((IntT)second_lo), unchecked((IntT)second_hi));
			var r_result = referenceImpl(r_first, r_second);
			IntT t_result_lo;
			IntT t_result_hi;
            try {
                t_result_lo = testImpl(first_lo, first_hi, second_lo, second_hi, out t_result_hi);
            } catch(OverflowException) {
				return false;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			IntT r_result_lo = unchecked((IntT)(UIntT)(UIntT.MaxValue & r_result));
			IntT r_result_hi = unchecked((IntT)(UIntT)(UIntT.MaxValue & (r_result >> /*= T - 1 */63/**/ >> 1)));
            return r_result_lo == t_result_lo && r_result_hi == t_result_hi;
        }

		public static bool TestOperation(Operation_IX_IX_MapsTo_IX referenceImpl, Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_I_I_I_I_MapsTo_I_I testImpl) {
		    foreach (var first_hi in Int64CollectionTestDataSourceMagnitude6.Default) {
			    foreach (var first_lo in Int64CollectionTestDataSourceMagnitude6.Default) {
				    foreach (var second_hi in Int64CollectionTestDataSourceMagnitude6.Default) {
			            foreach (var second_lo in Int64CollectionTestDataSourceMagnitude6.Default) {
			                if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((IntT)first_lo), unchecked((IntT)first_hi), unchecked((IntT)second_lo), unchecked((IntT)second_hi))) {
							    Console.WriteLine("{0}\r\n\t{1}", Convert.ToString(first_hi, 2).PadLeft(64, '0'), Convert.ToString(first_lo, 2).PadLeft(64, '0'));
								Console.WriteLine("{0}\r\n\t{1}", Convert.ToString(second_hi, 2).PadLeft(64, '0'), Convert.ToString(second_lo, 2).PadLeft(64, '0'));
					            return false;
					        }
						}
					}
			    }
			}
			return true;
		}
    }

    public delegate UIntT Operation_U2_U2_MapsTo_U2Checked_WithSignature_U_I_U_I_MapsTo_U_I(UIntT first_lo, IntT first_hi, UIntT second_lo, IntT second_hi, out IntT result_hi);
    
    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_IX_MapsTo_IX referenceImpl, Operation_U2_U2_MapsTo_U2Checked_WithSignature_U_I_U_I_MapsTo_U_I testImpl, UIntT first_lo, IntT first_hi, UIntT second_lo, IntT second_hi) {
            var r_first = ToBigIntegerUnsigned(unchecked((IntT)first_lo), unchecked((IntT)first_hi));
            var r_second = ToBigIntegerUnsigned(unchecked((IntT)second_lo), unchecked((IntT)second_hi));
            bool r_ov = false;
			var r_result = referenceImpl(r_first, r_second);
			if (/*= checked(2 * T) */UInt128_MinValue > r_result || r_result > /*= checked(2 * T) */UInt128_MaxValue) {
                r_ov = true;
				r_result = default(BigInteger);
			}
            bool t_ov = false;
			UIntT t_result_lo = 0;
			IntT t_result_hi = 0;
            try {
                t_result_lo = testImpl(first_lo, first_hi, second_lo, second_hi, out t_result_hi);
            } catch(OverflowException) {
                t_ov = true;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			var t_result = ToBigIntegerUnsigned(unchecked((IntT)t_result_lo), unchecked((IntT)t_result_hi));
            return r_ov == t_ov && r_result == t_result;
        }

		public static bool TestOperation(Operation_IX_IX_MapsTo_IX referenceImpl, Operation_U2_U2_MapsTo_U2Checked_WithSignature_U_I_U_I_MapsTo_U_I testImpl) {
		    foreach (var first_hi in Int64CollectionTestDataSourceMagnitude5.Default) {
			    foreach (var first_lo in Int64CollectionTestDataSourceMagnitude5.Default) {
				    foreach (var second_hi in Int64CollectionTestDataSourceMagnitude5.Default) {
			            foreach (var second_lo in Int64CollectionTestDataSourceMagnitude5.Default) {
			                if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((UIntT)first_lo), unchecked((IntT)first_hi), unchecked((UIntT)second_lo), unchecked((IntT)second_hi))) {
							    Console.WriteLine("{0}\r\n\t{1}", Convert.ToString(first_hi, 2).PadLeft(64, '0'), Convert.ToString(first_lo, 2).PadLeft(64, '0'));
								Console.WriteLine("{0}\r\n\t{1}", Convert.ToString(second_hi, 2).PadLeft(64, '0'), Convert.ToString(second_lo, 2).PadLeft(64, '0'));
					            return false;
					        }
						}
					}
			    }
			}
			return true;
		}
    }

    public delegate UIntT Operation_I2_I2_MapsTo_I2Checked_WithSignature_U_I_U_I_MapsTo_U_I(UIntT first_lo, IntT first_hi, UIntT second_lo, IntT second_hi, out IntT result_hi);

    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_IX_MapsTo_IX referenceImpl, Operation_I2_I2_MapsTo_I2Checked_WithSignature_U_I_U_I_MapsTo_U_I testImpl, UIntT first_lo, IntT first_hi, UIntT second_lo, IntT second_hi) {
            var r_first = ToBigIntegerSigned(unchecked((IntT)first_lo), unchecked((IntT)first_hi));
            var r_second = ToBigIntegerSigned(unchecked((IntT)second_lo), unchecked((IntT)second_hi));
            bool r_ov = false;
			var r_result = referenceImpl(r_first, r_second);
			if (/*= checked(2 * T) */Int128_MinValue > r_result || r_result > /*= checked(2 * T) */Int128_MaxValue) {
                r_ov = true;
				r_result = default(BigInteger);
			}
            bool t_ov = false;
			UIntT t_result_lo = 0;
			IntT t_result_hi = 0;
            try {
                t_result_lo = testImpl(first_lo, first_hi, second_lo, second_hi, out t_result_hi);
            } catch(OverflowException) {
                t_ov = true;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			var t_result = ToBigIntegerSigned(unchecked((IntT)t_result_lo), unchecked((IntT)t_result_hi));
            return r_ov == t_ov && r_result == t_result;
        }

		public static bool TestOperation(Operation_IX_IX_MapsTo_IX referenceImpl, Operation_I2_I2_MapsTo_I2Checked_WithSignature_U_I_U_I_MapsTo_U_I testImpl) {
		    foreach (var first_hi in Int64CollectionTestDataSourceMagnitude5.Default) {
			    foreach (var first_lo in Int64CollectionTestDataSourceMagnitude5.Default) {
				    foreach (var second_hi in Int64CollectionTestDataSourceMagnitude5.Default) {
			            foreach (var second_lo in Int64CollectionTestDataSourceMagnitude5.Default) {
			                if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((UIntT)first_lo), unchecked((IntT)first_hi), unchecked((UIntT)second_lo), unchecked((IntT)second_hi))) {
							    Console.WriteLine("{0}\r\n\t{1}", Convert.ToString(first_hi, 2).PadLeft(64, '0'), Convert.ToString(first_lo, 2).PadLeft(64, '0'));
								Console.WriteLine("{0}\r\n\t{1}", Convert.ToString(second_hi, 2).PadLeft(64, '0'), Convert.ToString(second_lo, 2).PadLeft(64, '0'));
					            return false;
					        }
						}
					}
			    }
			}
			return true;
		}
    }

    // usually same as Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_U_I_U_I_MapsTo_U_I(UIntT first_lo, IntT first_hi, UIntT second_lo, IntT second_hi, out IntT result_hi)
    public delegate UIntT Operation_U2_U2_MapsTo_U2Unchecked_WithSignature_U_I_U_I_MapsTo_U_I(UIntT first_lo, IntT first_hi, UIntT second_lo, IntT second_hi, out IntT result_hi);
    
	public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_IX_MapsTo_IX referenceImpl, Operation_U2_U2_MapsTo_U2Unchecked_WithSignature_U_I_U_I_MapsTo_U_I testImpl, UIntT first_lo, IntT first_hi, UIntT second_lo, IntT second_hi) {
            var r_first = ToBigIntegerUnsigned(unchecked((IntT)first_lo), unchecked((IntT)first_hi));
            var r_second = ToBigIntegerUnsigned(unchecked((IntT)second_lo), unchecked((IntT)second_hi));
			var r_result = referenceImpl(r_first, r_second);
			UIntT t_result_lo;
			IntT t_result_hi;
            try {
                t_result_lo = testImpl(first_lo, first_hi, second_lo, second_hi, out t_result_hi);
            } catch(OverflowException) {
				return false;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			UIntT r_result_lo = unchecked((UIntT)(UIntT)(UIntT.MaxValue & r_result));
			IntT r_result_hi = unchecked((IntT)(UIntT)(UIntT.MaxValue & (r_result >> /*= T - 1 */63/**/ >> 1)));
            return r_result_lo == t_result_lo && r_result_hi == t_result_hi;
        }

		public static bool TestOperation(Operation_IX_IX_MapsTo_IX referenceImpl, Operation_U2_U2_MapsTo_U2Unchecked_WithSignature_U_I_U_I_MapsTo_U_I testImpl) {
		    foreach (var first_hi in Int64CollectionTestDataSourceMagnitude6.Default) {
			    foreach (var first_lo in Int64CollectionTestDataSourceMagnitude6.Default) {
				    foreach (var second_hi in Int64CollectionTestDataSourceMagnitude6.Default) {
			            foreach (var second_lo in Int64CollectionTestDataSourceMagnitude6.Default) {
			                if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((UIntT)first_lo), unchecked((IntT)first_hi), unchecked((UIntT)second_lo), unchecked((IntT)second_hi))) {
							    Console.WriteLine("{0}\r\n\t{1}", Convert.ToString(first_hi, 2).PadLeft(64, '0'), Convert.ToString(first_lo, 2).PadLeft(64, '0'));
								Console.WriteLine("{0}\r\n\t{1}", Convert.ToString(second_hi, 2).PadLeft(64, '0'), Convert.ToString(second_lo, 2).PadLeft(64, '0'));
					            return false;
					        }
						}
					}
			    }
			}
			return true;
		}
    }

    // usually same as Operation_U2_U2_MapsTo_U2Unchecked_WithSignature_U_I_U_I_MapsTo_U_I(UIntT first_lo, IntT first_hi, UIntT second_lo, IntT second_hi, out IntT result_hi)
    public delegate UIntT Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_U_I_U_I_MapsTo_U_I(UIntT first_lo, IntT first_hi, UIntT second_lo, IntT second_hi, out IntT result_hi);

    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_IX_MapsTo_IX referenceImpl, Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_U_I_U_I_MapsTo_U_I testImpl, UIntT first_lo, IntT first_hi, UIntT second_lo, IntT second_hi) {
            var r_first = ToBigIntegerSigned(unchecked((IntT)first_lo), unchecked((IntT)first_hi));
            var r_second = ToBigIntegerSigned(unchecked((IntT)second_lo), unchecked((IntT)second_hi));
			var r_result = referenceImpl(r_first, r_second);
			UIntT t_result_lo;
			IntT t_result_hi;
            try {
                t_result_lo = testImpl(first_lo, first_hi, second_lo, second_hi, out t_result_hi);
            } catch(OverflowException) {
				return false;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			UIntT r_result_lo = unchecked((UIntT)(UIntT)(UIntT.MaxValue & r_result));
			IntT r_result_hi = unchecked((IntT)(UIntT)(UIntT.MaxValue & (r_result >> /*= T - 1 */63/**/ >> 1)));
            return r_result_lo == t_result_lo && r_result_hi == t_result_hi;
        }

		public static bool TestOperation(Operation_IX_IX_MapsTo_IX referenceImpl, Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_U_I_U_I_MapsTo_U_I testImpl) {
		    foreach (var first_hi in Int64CollectionTestDataSourceMagnitude6.Default) {
			    foreach (var first_lo in Int64CollectionTestDataSourceMagnitude6.Default) {
				    foreach (var second_hi in Int64CollectionTestDataSourceMagnitude6.Default) {
			            foreach (var second_lo in Int64CollectionTestDataSourceMagnitude6.Default) {
			                if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((UIntT)first_lo), unchecked((IntT)first_hi), unchecked((UIntT)second_lo), unchecked((IntT)second_hi))) {
							    Console.WriteLine("{0}\r\n\t{1}", Convert.ToString(first_hi, 2).PadLeft(64, '0'), Convert.ToString(first_lo, 2).PadLeft(64, '0'));
								Console.WriteLine("{0}\r\n\t{1}", Convert.ToString(second_hi, 2).PadLeft(64, '0'), Convert.ToString(second_lo, 2).PadLeft(64, '0'));
					            return false;
					        }
						}
					}
			    }
			}
			return true;
		}
    }

    public delegate IntT Operation_U2_U2_MapsTo_U2Checked_WithSignature_I_U_I_U_MapsTo_I_U(IntT first_lo, UIntT first_hi, IntT second_lo, UIntT second_hi, out UIntT result_hi);
    
    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_IX_MapsTo_IX referenceImpl, Operation_U2_U2_MapsTo_U2Checked_WithSignature_I_U_I_U_MapsTo_I_U testImpl, IntT first_lo, UIntT first_hi, IntT second_lo, UIntT second_hi) {
            var r_first = ToBigIntegerUnsigned(unchecked((IntT)first_lo), unchecked((IntT)first_hi));
            var r_second = ToBigIntegerUnsigned(unchecked((IntT)second_lo), unchecked((IntT)second_hi));
            bool r_ov = false;
			var r_result = referenceImpl(r_first, r_second);
			if (/*= checked(2 * T) */UInt128_MinValue > r_result || r_result > /*= checked(2 * T) */UInt128_MaxValue) {
                r_ov = true;
				r_result = default(BigInteger);
			}
            bool t_ov = false;
			IntT t_result_lo = 0;
			UIntT t_result_hi = 0;
            try {
                t_result_lo = testImpl(first_lo, first_hi, second_lo, second_hi, out t_result_hi);
            } catch(OverflowException) {
                t_ov = true;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			var t_result = ToBigIntegerUnsigned(unchecked((IntT)t_result_lo), unchecked((IntT)t_result_hi));
            return r_ov == t_ov && r_result == t_result;
        }

		public static bool TestOperation(Operation_IX_IX_MapsTo_IX referenceImpl, Operation_U2_U2_MapsTo_U2Checked_WithSignature_I_U_I_U_MapsTo_I_U testImpl) {
		    foreach (var first_hi in Int64CollectionTestDataSourceMagnitude5.Default) {
			    foreach (var first_lo in Int64CollectionTestDataSourceMagnitude5.Default) {
				    foreach (var second_hi in Int64CollectionTestDataSourceMagnitude5.Default) {
			            foreach (var second_lo in Int64CollectionTestDataSourceMagnitude5.Default) {
			                if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((IntT)first_lo), unchecked((UIntT)first_hi), unchecked((IntT)second_lo), unchecked((UIntT)second_hi))) {
							    Console.WriteLine("{0}\r\n\t{1}", Convert.ToString(first_hi, 2).PadLeft(64, '0'), Convert.ToString(first_lo, 2).PadLeft(64, '0'));
								Console.WriteLine("{0}\r\n\t{1}", Convert.ToString(second_hi, 2).PadLeft(64, '0'), Convert.ToString(second_lo, 2).PadLeft(64, '0'));
					            return false;
					        }
						}
					}
			    }
			}
			return true;
		}
    }

    public delegate IntT Operation_I2_I2_MapsTo_I2Checked_WithSignature_I_U_I_U_MapsTo_I_U(IntT first_lo, UIntT first_hi, IntT second_lo, UIntT second_hi, out UIntT result_hi);

    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_IX_MapsTo_IX referenceImpl, Operation_I2_I2_MapsTo_I2Checked_WithSignature_I_U_I_U_MapsTo_I_U testImpl, IntT first_lo, UIntT first_hi, IntT second_lo, UIntT second_hi) {
            var r_first = ToBigIntegerSigned(unchecked((IntT)first_lo), unchecked((IntT)first_hi));
            var r_second = ToBigIntegerSigned(unchecked((IntT)second_lo), unchecked((IntT)second_hi));
            bool r_ov = false;
			var r_result = referenceImpl(r_first, r_second);
			if (/*= checked(2 * T) */Int128_MinValue > r_result || r_result > /*= checked(2 * T) */Int128_MaxValue) {
                r_ov = true;
				r_result = default(BigInteger);
			}
            bool t_ov = false;
			IntT t_result_lo = 0;
			UIntT t_result_hi = 0;
            try {
                t_result_lo = testImpl(first_lo, first_hi, second_lo, second_hi, out t_result_hi);
            } catch(OverflowException) {
                t_ov = true;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			var t_result = ToBigIntegerSigned(unchecked((IntT)t_result_lo), unchecked((IntT)t_result_hi));
            return r_ov == t_ov && r_result == t_result;
        }

		public static bool TestOperation(Operation_IX_IX_MapsTo_IX referenceImpl, Operation_I2_I2_MapsTo_I2Checked_WithSignature_I_U_I_U_MapsTo_I_U testImpl) {
		    foreach (var first_hi in Int64CollectionTestDataSourceMagnitude5.Default) {
			    foreach (var first_lo in Int64CollectionTestDataSourceMagnitude5.Default) {
				    foreach (var second_hi in Int64CollectionTestDataSourceMagnitude5.Default) {
			            foreach (var second_lo in Int64CollectionTestDataSourceMagnitude5.Default) {
			                if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((IntT)first_lo), unchecked((UIntT)first_hi), unchecked((IntT)second_lo), unchecked((UIntT)second_hi))) {
							    Console.WriteLine("{0}\r\n\t{1}", Convert.ToString(first_hi, 2).PadLeft(64, '0'), Convert.ToString(first_lo, 2).PadLeft(64, '0'));
								Console.WriteLine("{0}\r\n\t{1}", Convert.ToString(second_hi, 2).PadLeft(64, '0'), Convert.ToString(second_lo, 2).PadLeft(64, '0'));
					            return false;
					        }
						}
					}
			    }
			}
			return true;
		}
    }

    // usually same as Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_I_U_I_U_MapsTo_I_U(IntT first_lo, UIntT first_hi, IntT second_lo, UIntT second_hi, out UIntT result_hi)
    public delegate IntT Operation_U2_U2_MapsTo_U2Unchecked_WithSignature_I_U_I_U_MapsTo_I_U(IntT first_lo, UIntT first_hi, IntT second_lo, UIntT second_hi, out UIntT result_hi);
    
	public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_IX_MapsTo_IX referenceImpl, Operation_U2_U2_MapsTo_U2Unchecked_WithSignature_I_U_I_U_MapsTo_I_U testImpl, IntT first_lo, UIntT first_hi, IntT second_lo, UIntT second_hi) {
            var r_first = ToBigIntegerUnsigned(unchecked((IntT)first_lo), unchecked((IntT)first_hi));
            var r_second = ToBigIntegerUnsigned(unchecked((IntT)second_lo), unchecked((IntT)second_hi));
			var r_result = referenceImpl(r_first, r_second);
			IntT t_result_lo;
			UIntT t_result_hi;
            try {
                t_result_lo = testImpl(first_lo, first_hi, second_lo, second_hi, out t_result_hi);
            } catch(OverflowException) {
				return false;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			IntT r_result_lo = unchecked((IntT)(UIntT)(UIntT.MaxValue & r_result));
			UIntT r_result_hi = unchecked((UIntT)(UIntT)(UIntT.MaxValue & (r_result >> /*= T - 1 */63/**/ >> 1)));
            return r_result_lo == t_result_lo && r_result_hi == t_result_hi;
        }

		public static bool TestOperation(Operation_IX_IX_MapsTo_IX referenceImpl, Operation_U2_U2_MapsTo_U2Unchecked_WithSignature_I_U_I_U_MapsTo_I_U testImpl) {
		    foreach (var first_hi in Int64CollectionTestDataSourceMagnitude6.Default) {
			    foreach (var first_lo in Int64CollectionTestDataSourceMagnitude6.Default) {
				    foreach (var second_hi in Int64CollectionTestDataSourceMagnitude6.Default) {
			            foreach (var second_lo in Int64CollectionTestDataSourceMagnitude6.Default) {
			                if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((IntT)first_lo), unchecked((UIntT)first_hi), unchecked((IntT)second_lo), unchecked((UIntT)second_hi))) {
							    Console.WriteLine("{0}\r\n\t{1}", Convert.ToString(first_hi, 2).PadLeft(64, '0'), Convert.ToString(first_lo, 2).PadLeft(64, '0'));
								Console.WriteLine("{0}\r\n\t{1}", Convert.ToString(second_hi, 2).PadLeft(64, '0'), Convert.ToString(second_lo, 2).PadLeft(64, '0'));
					            return false;
					        }
						}
					}
			    }
			}
			return true;
		}
    }

    // usually same as Operation_U2_U2_MapsTo_U2Unchecked_WithSignature_I_U_I_U_MapsTo_I_U(IntT first_lo, UIntT first_hi, IntT second_lo, UIntT second_hi, out UIntT result_hi)
    public delegate IntT Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_I_U_I_U_MapsTo_I_U(IntT first_lo, UIntT first_hi, IntT second_lo, UIntT second_hi, out UIntT result_hi);

    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_IX_MapsTo_IX referenceImpl, Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_I_U_I_U_MapsTo_I_U testImpl, IntT first_lo, UIntT first_hi, IntT second_lo, UIntT second_hi) {
            var r_first = ToBigIntegerSigned(unchecked((IntT)first_lo), unchecked((IntT)first_hi));
            var r_second = ToBigIntegerSigned(unchecked((IntT)second_lo), unchecked((IntT)second_hi));
			var r_result = referenceImpl(r_first, r_second);
			IntT t_result_lo;
			UIntT t_result_hi;
            try {
                t_result_lo = testImpl(first_lo, first_hi, second_lo, second_hi, out t_result_hi);
            } catch(OverflowException) {
				return false;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			IntT r_result_lo = unchecked((IntT)(UIntT)(UIntT.MaxValue & r_result));
			UIntT r_result_hi = unchecked((UIntT)(UIntT)(UIntT.MaxValue & (r_result >> /*= T - 1 */63/**/ >> 1)));
            return r_result_lo == t_result_lo && r_result_hi == t_result_hi;
        }

		public static bool TestOperation(Operation_IX_IX_MapsTo_IX referenceImpl, Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_I_U_I_U_MapsTo_I_U testImpl) {
		    foreach (var first_hi in Int64CollectionTestDataSourceMagnitude6.Default) {
			    foreach (var first_lo in Int64CollectionTestDataSourceMagnitude6.Default) {
				    foreach (var second_hi in Int64CollectionTestDataSourceMagnitude6.Default) {
			            foreach (var second_lo in Int64CollectionTestDataSourceMagnitude6.Default) {
			                if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((IntT)first_lo), unchecked((UIntT)first_hi), unchecked((IntT)second_lo), unchecked((UIntT)second_hi))) {
							    Console.WriteLine("{0}\r\n\t{1}", Convert.ToString(first_hi, 2).PadLeft(64, '0'), Convert.ToString(first_lo, 2).PadLeft(64, '0'));
								Console.WriteLine("{0}\r\n\t{1}", Convert.ToString(second_hi, 2).PadLeft(64, '0'), Convert.ToString(second_lo, 2).PadLeft(64, '0'));
					            return false;
					        }
						}
					}
			    }
			}
			return true;
		}
    }

    public delegate UIntT Operation_U2_U2_MapsTo_U2Checked_WithSignature_U_U_U_U_MapsTo_U_U(UIntT first_lo, UIntT first_hi, UIntT second_lo, UIntT second_hi, out UIntT result_hi);
    
    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_IX_MapsTo_IX referenceImpl, Operation_U2_U2_MapsTo_U2Checked_WithSignature_U_U_U_U_MapsTo_U_U testImpl, UIntT first_lo, UIntT first_hi, UIntT second_lo, UIntT second_hi) {
            var r_first = ToBigIntegerUnsigned(unchecked((IntT)first_lo), unchecked((IntT)first_hi));
            var r_second = ToBigIntegerUnsigned(unchecked((IntT)second_lo), unchecked((IntT)second_hi));
            bool r_ov = false;
			var r_result = referenceImpl(r_first, r_second);
			if (/*= checked(2 * T) */UInt128_MinValue > r_result || r_result > /*= checked(2 * T) */UInt128_MaxValue) {
                r_ov = true;
				r_result = default(BigInteger);
			}
            bool t_ov = false;
			UIntT t_result_lo = 0;
			UIntT t_result_hi = 0;
            try {
                t_result_lo = testImpl(first_lo, first_hi, second_lo, second_hi, out t_result_hi);
            } catch(OverflowException) {
                t_ov = true;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			var t_result = ToBigIntegerUnsigned(unchecked((IntT)t_result_lo), unchecked((IntT)t_result_hi));
            return r_ov == t_ov && r_result == t_result;
        }

		public static bool TestOperation(Operation_IX_IX_MapsTo_IX referenceImpl, Operation_U2_U2_MapsTo_U2Checked_WithSignature_U_U_U_U_MapsTo_U_U testImpl) {
		    foreach (var first_hi in Int64CollectionTestDataSourceMagnitude5.Default) {
			    foreach (var first_lo in Int64CollectionTestDataSourceMagnitude5.Default) {
				    foreach (var second_hi in Int64CollectionTestDataSourceMagnitude5.Default) {
			            foreach (var second_lo in Int64CollectionTestDataSourceMagnitude5.Default) {
			                if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((UIntT)first_lo), unchecked((UIntT)first_hi), unchecked((UIntT)second_lo), unchecked((UIntT)second_hi))) {
							    Console.WriteLine("{0}\r\n\t{1}", Convert.ToString(first_hi, 2).PadLeft(64, '0'), Convert.ToString(first_lo, 2).PadLeft(64, '0'));
								Console.WriteLine("{0}\r\n\t{1}", Convert.ToString(second_hi, 2).PadLeft(64, '0'), Convert.ToString(second_lo, 2).PadLeft(64, '0'));
					            return false;
					        }
						}
					}
			    }
			}
			return true;
		}
    }

    public delegate UIntT Operation_I2_I2_MapsTo_I2Checked_WithSignature_U_U_U_U_MapsTo_U_U(UIntT first_lo, UIntT first_hi, UIntT second_lo, UIntT second_hi, out UIntT result_hi);

    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_IX_MapsTo_IX referenceImpl, Operation_I2_I2_MapsTo_I2Checked_WithSignature_U_U_U_U_MapsTo_U_U testImpl, UIntT first_lo, UIntT first_hi, UIntT second_lo, UIntT second_hi) {
            var r_first = ToBigIntegerSigned(unchecked((IntT)first_lo), unchecked((IntT)first_hi));
            var r_second = ToBigIntegerSigned(unchecked((IntT)second_lo), unchecked((IntT)second_hi));
            bool r_ov = false;
			var r_result = referenceImpl(r_first, r_second);
			if (/*= checked(2 * T) */Int128_MinValue > r_result || r_result > /*= checked(2 * T) */Int128_MaxValue) {
                r_ov = true;
				r_result = default(BigInteger);
			}
            bool t_ov = false;
			UIntT t_result_lo = 0;
			UIntT t_result_hi = 0;
            try {
                t_result_lo = testImpl(first_lo, first_hi, second_lo, second_hi, out t_result_hi);
            } catch(OverflowException) {
                t_ov = true;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			var t_result = ToBigIntegerSigned(unchecked((IntT)t_result_lo), unchecked((IntT)t_result_hi));
            return r_ov == t_ov && r_result == t_result;
        }

		public static bool TestOperation(Operation_IX_IX_MapsTo_IX referenceImpl, Operation_I2_I2_MapsTo_I2Checked_WithSignature_U_U_U_U_MapsTo_U_U testImpl) {
		    foreach (var first_hi in Int64CollectionTestDataSourceMagnitude5.Default) {
			    foreach (var first_lo in Int64CollectionTestDataSourceMagnitude5.Default) {
				    foreach (var second_hi in Int64CollectionTestDataSourceMagnitude5.Default) {
			            foreach (var second_lo in Int64CollectionTestDataSourceMagnitude5.Default) {
			                if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((UIntT)first_lo), unchecked((UIntT)first_hi), unchecked((UIntT)second_lo), unchecked((UIntT)second_hi))) {
							    Console.WriteLine("{0}\r\n\t{1}", Convert.ToString(first_hi, 2).PadLeft(64, '0'), Convert.ToString(first_lo, 2).PadLeft(64, '0'));
								Console.WriteLine("{0}\r\n\t{1}", Convert.ToString(second_hi, 2).PadLeft(64, '0'), Convert.ToString(second_lo, 2).PadLeft(64, '0'));
					            return false;
					        }
						}
					}
			    }
			}
			return true;
		}
    }

    // usually same as Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_U_U_U_U_MapsTo_U_U(UIntT first_lo, UIntT first_hi, UIntT second_lo, UIntT second_hi, out UIntT result_hi)
    public delegate UIntT Operation_U2_U2_MapsTo_U2Unchecked_WithSignature_U_U_U_U_MapsTo_U_U(UIntT first_lo, UIntT first_hi, UIntT second_lo, UIntT second_hi, out UIntT result_hi);
    
	public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_IX_MapsTo_IX referenceImpl, Operation_U2_U2_MapsTo_U2Unchecked_WithSignature_U_U_U_U_MapsTo_U_U testImpl, UIntT first_lo, UIntT first_hi, UIntT second_lo, UIntT second_hi) {
            var r_first = ToBigIntegerUnsigned(unchecked((IntT)first_lo), unchecked((IntT)first_hi));
            var r_second = ToBigIntegerUnsigned(unchecked((IntT)second_lo), unchecked((IntT)second_hi));
			var r_result = referenceImpl(r_first, r_second);
			UIntT t_result_lo;
			UIntT t_result_hi;
            try {
                t_result_lo = testImpl(first_lo, first_hi, second_lo, second_hi, out t_result_hi);
            } catch(OverflowException) {
				return false;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			UIntT r_result_lo = unchecked((UIntT)(UIntT)(UIntT.MaxValue & r_result));
			UIntT r_result_hi = unchecked((UIntT)(UIntT)(UIntT.MaxValue & (r_result >> /*= T - 1 */63/**/ >> 1)));
            return r_result_lo == t_result_lo && r_result_hi == t_result_hi;
        }

		public static bool TestOperation(Operation_IX_IX_MapsTo_IX referenceImpl, Operation_U2_U2_MapsTo_U2Unchecked_WithSignature_U_U_U_U_MapsTo_U_U testImpl) {
		    foreach (var first_hi in Int64CollectionTestDataSourceMagnitude6.Default) {
			    foreach (var first_lo in Int64CollectionTestDataSourceMagnitude6.Default) {
				    foreach (var second_hi in Int64CollectionTestDataSourceMagnitude6.Default) {
			            foreach (var second_lo in Int64CollectionTestDataSourceMagnitude6.Default) {
			                if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((UIntT)first_lo), unchecked((UIntT)first_hi), unchecked((UIntT)second_lo), unchecked((UIntT)second_hi))) {
							    Console.WriteLine("{0}\r\n\t{1}", Convert.ToString(first_hi, 2).PadLeft(64, '0'), Convert.ToString(first_lo, 2).PadLeft(64, '0'));
								Console.WriteLine("{0}\r\n\t{1}", Convert.ToString(second_hi, 2).PadLeft(64, '0'), Convert.ToString(second_lo, 2).PadLeft(64, '0'));
					            return false;
					        }
						}
					}
			    }
			}
			return true;
		}
    }

    // usually same as Operation_U2_U2_MapsTo_U2Unchecked_WithSignature_U_U_U_U_MapsTo_U_U(UIntT first_lo, UIntT first_hi, UIntT second_lo, UIntT second_hi, out UIntT result_hi)
    public delegate UIntT Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_U_U_U_U_MapsTo_U_U(UIntT first_lo, UIntT first_hi, UIntT second_lo, UIntT second_hi, out UIntT result_hi);

    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_IX_MapsTo_IX referenceImpl, Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_U_U_U_U_MapsTo_U_U testImpl, UIntT first_lo, UIntT first_hi, UIntT second_lo, UIntT second_hi) {
            var r_first = ToBigIntegerSigned(unchecked((IntT)first_lo), unchecked((IntT)first_hi));
            var r_second = ToBigIntegerSigned(unchecked((IntT)second_lo), unchecked((IntT)second_hi));
			var r_result = referenceImpl(r_first, r_second);
			UIntT t_result_lo;
			UIntT t_result_hi;
            try {
                t_result_lo = testImpl(first_lo, first_hi, second_lo, second_hi, out t_result_hi);
            } catch(OverflowException) {
				return false;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			UIntT r_result_lo = unchecked((UIntT)(UIntT)(UIntT.MaxValue & r_result));
			UIntT r_result_hi = unchecked((UIntT)(UIntT)(UIntT.MaxValue & (r_result >> /*= T - 1 */63/**/ >> 1)));
            return r_result_lo == t_result_lo && r_result_hi == t_result_hi;
        }

		public static bool TestOperation(Operation_IX_IX_MapsTo_IX referenceImpl, Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_U_U_U_U_MapsTo_U_U testImpl) {
		    foreach (var first_hi in Int64CollectionTestDataSourceMagnitude6.Default) {
			    foreach (var first_lo in Int64CollectionTestDataSourceMagnitude6.Default) {
				    foreach (var second_hi in Int64CollectionTestDataSourceMagnitude6.Default) {
			            foreach (var second_lo in Int64CollectionTestDataSourceMagnitude6.Default) {
			                if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((UIntT)first_lo), unchecked((UIntT)first_hi), unchecked((UIntT)second_lo), unchecked((UIntT)second_hi))) {
							    Console.WriteLine("{0}\r\n\t{1}", Convert.ToString(first_hi, 2).PadLeft(64, '0'), Convert.ToString(first_lo, 2).PadLeft(64, '0'));
								Console.WriteLine("{0}\r\n\t{1}", Convert.ToString(second_hi, 2).PadLeft(64, '0'), Convert.ToString(second_lo, 2).PadLeft(64, '0'));
					            return false;
					        }
						}
					}
			    }
			}
			return true;
		}
    }
#endregion

#region Binary Operations Shift
    public delegate BigInteger Operation_IX_int_MapsTo_IX(BigInteger first, int second);

    public delegate IntT Operation_U2_int_MapsTo_U2Checked_WithSignature_I_I_int_MapsTo_I_I(IntT first_lo, IntT first_hi, int second, out IntT result_hi);
    
    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_int_MapsTo_IX referenceImpl, Operation_U2_int_MapsTo_U2Checked_WithSignature_I_I_int_MapsTo_I_I testImpl, IntT first_lo, IntT first_hi, int second) {
            var r_first = ToBigIntegerUnsigned(unchecked((IntT)first_lo), unchecked((IntT)first_hi));
            bool r_ov = false;
			var second_ = second & (/*= checked(2 * T) */128/**/ - 1);
			var r_result = r_first;
			for (; second_ > 17; second_ -= 17) {
			    r_result = referenceImpl(r_result, 17);
			}
			r_result = referenceImpl(r_result, second_);
			if (/*= checked(2 * T) */UInt128_MinValue > r_result || r_result > /*= checked(2 * T) */UInt128_MaxValue) {
                r_ov = true;
				r_result = default(BigInteger);
			}
            bool t_ov = false;
			IntT t_result_lo = 0;
			IntT t_result_hi = 0;
            try {
                t_result_lo = testImpl(first_lo, first_hi, second, out t_result_hi);
            } catch(OverflowException) {
                t_ov = true;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			var t_result = ToBigIntegerUnsigned(unchecked((IntT)t_result_lo), unchecked((IntT)t_result_hi));
            return r_ov == t_ov && r_result == t_result;
        }

		public static bool TestOperation(Operation_IX_int_MapsTo_IX referenceImpl, Operation_U2_int_MapsTo_U2Checked_WithSignature_I_I_int_MapsTo_I_I testImpl) {
		    foreach (var first_hi in Int64CollectionTestDataSourceMagnitude6.Default) {
			    foreach (var first_lo in Int64CollectionTestDataSourceMagnitude6.Default) {
				    for (var second = 0 - 4; second <= 128 + 4; ++second) {
					    if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((IntT)first_lo), unchecked((IntT)first_hi), second)) {
					        return false;
					    }
					}
			    }
			}
			return true;
		}
    }

    public delegate IntT Operation_I2_int_MapsTo_I2Checked_WithSignature_I_I_int_MapsTo_I_I(IntT first_lo, IntT first_hi, int second, out IntT result_hi);

    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_int_MapsTo_IX referenceImpl, Operation_I2_int_MapsTo_I2Checked_WithSignature_I_I_int_MapsTo_I_I testImpl, IntT first_lo, IntT first_hi, int second) {
            var r_first = ToBigIntegerSigned(unchecked((IntT)first_lo), unchecked((IntT)first_hi));
            bool r_ov = false;
			var second_ = second & (/*= checked(2 * T) */128/**/ - 1);
			var r_result = r_first;
			for (; second_ > 17; second_ -= 17) {
			    r_result = referenceImpl(r_result, 17);
			}
			r_result = referenceImpl(r_result, second_);
			if (/*= checked(2 * T) */Int128_MinValue > r_result || r_result > /*= checked(2 * T) */Int128_MaxValue) {
                r_ov = true;
				r_result = default(BigInteger);
			}
            bool t_ov = false;
			IntT t_result_lo = 0;
			IntT t_result_hi = 0;
            try {
                t_result_lo = testImpl(first_lo, first_hi, second, out t_result_hi);
            } catch(OverflowException) {
                t_ov = true;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			var t_result = ToBigIntegerSigned(unchecked((IntT)t_result_lo), unchecked((IntT)t_result_hi));
            return r_ov == t_ov && r_result == t_result;
        }

		public static bool TestOperation(Operation_IX_int_MapsTo_IX referenceImpl, Operation_I2_int_MapsTo_I2Checked_WithSignature_I_I_int_MapsTo_I_I testImpl) {
		    foreach (var first_hi in Int64CollectionTestDataSourceMagnitude6.Default) {
			    foreach (var first_lo in Int64CollectionTestDataSourceMagnitude6.Default) {
				    for (var second = 0 - 4; second <= 128 + 4; ++second) {
					    if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((IntT)first_lo), unchecked((IntT)first_hi), second)) {
					        return false;
					    }
					}
			    }
			}
			return true;
		}
    }

    // usually same as Operation_I2_int_MapsTo_I2Unchecked_WithSignature_I_I_int_MapsTo_I_I
    public delegate IntT Operation_U2_int_MapsTo_U2Unchecked_WithSignature_I_I_int_MapsTo_I_I(IntT first_lo, IntT first_hi, int second, out IntT result_hi);
    
	public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_int_MapsTo_IX referenceImpl, Operation_U2_int_MapsTo_U2Unchecked_WithSignature_I_I_int_MapsTo_I_I testImpl, IntT first_lo, IntT first_hi, int second) {
            var r_first = ToBigIntegerUnsigned(unchecked((IntT)first_lo), unchecked((IntT)first_hi));
			var second_ = second & (/*= checked(2 * T) */128/**/ - 1);
			var r_result = r_first;
			for (; second_ > 17; second_ -= 17) {
			    r_result = referenceImpl(r_result, 17);
			}
			r_result = referenceImpl(r_result, second_);
			IntT t_result_lo;
			IntT t_result_hi;
            try {
                t_result_lo = testImpl(first_lo, first_hi, second, out t_result_hi);
            } catch(OverflowException) {
				return false;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			IntT r_result_lo = unchecked((IntT)(UIntT)(UIntT.MaxValue & r_result));
			IntT r_result_hi = unchecked((IntT)(UIntT)(UIntT.MaxValue & (r_result >> /*= T - 1 */63/**/ >> 1)));
            return r_result_lo == t_result_lo && r_result_hi == t_result_hi;
        }

		public static bool TestOperation(Operation_IX_int_MapsTo_IX referenceImpl, Operation_U2_int_MapsTo_U2Unchecked_WithSignature_I_I_int_MapsTo_I_I testImpl) {
		    foreach (var first_hi in Int64CollectionTestDataSourceMagnitude6.Default) {
			    foreach (var first_lo in Int64CollectionTestDataSourceMagnitude6.Default) {
				    for (var second = 0 - 4; second <= 128 + 4; ++second) {
					    if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((IntT)first_lo), unchecked((IntT)first_hi), second)) {
					        return false;
					    }
					}
			    }
			}
			return true;
		}
    }

    // usually same as Operation_U2_int_MapsTo_U2Unchecked_WithSignature_I_I_int_MapsTo_I_I
    public delegate IntT Operation_I2_int_MapsTo_I2Unchecked_WithSignature_I_I_int_MapsTo_I_I(IntT first_lo, IntT first_hi, int second, out IntT result_hi);

    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_int_MapsTo_IX referenceImpl, Operation_I2_int_MapsTo_I2Unchecked_WithSignature_I_I_int_MapsTo_I_I testImpl, IntT first_lo, IntT first_hi, int second) {
            var r_first = ToBigIntegerSigned(unchecked((IntT)first_lo), unchecked((IntT)first_hi));
			var second_ = second & (/*= checked(2 * T) */128/**/ - 1);
			var r_result = r_first;
			for (; second_ > 17; second_ -= 17) {
			    r_result = referenceImpl(r_result, 17);
			}
			r_result = referenceImpl(r_result, second_);
			IntT t_result_lo;
			IntT t_result_hi;
            try {
                t_result_lo = testImpl(first_lo, first_hi, second, out t_result_hi);
            } catch(OverflowException) {
				return false;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			IntT r_result_lo = unchecked((IntT)(UIntT)(UIntT.MaxValue & r_result));
			IntT r_result_hi = unchecked((IntT)(UIntT)(UIntT.MaxValue & (r_result >> /*= T - 1 */63/**/ >> 1)));
            return r_result_lo == t_result_lo && r_result_hi == t_result_hi;
        }

		public static bool TestOperation(Operation_IX_int_MapsTo_IX referenceImpl, Operation_I2_int_MapsTo_I2Unchecked_WithSignature_I_I_int_MapsTo_I_I testImpl) {
		    foreach (var first_hi in Int64CollectionTestDataSourceMagnitude6.Default) {
			    foreach (var first_lo in Int64CollectionTestDataSourceMagnitude6.Default) {
				    for (var second = 0 - 4; second <= 128 + 4; ++second) {
					    if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((IntT)first_lo), unchecked((IntT)first_hi), second)) {
					        return false;
					    }
					}
			    }
			}
			return true;
		}
    }

    public delegate UIntT Operation_U2_int_MapsTo_U2Checked_WithSignature_U_I_int_MapsTo_U_I(UIntT first_lo, IntT first_hi, int second, out IntT result_hi);
    
    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_int_MapsTo_IX referenceImpl, Operation_U2_int_MapsTo_U2Checked_WithSignature_U_I_int_MapsTo_U_I testImpl, UIntT first_lo, IntT first_hi, int second) {
            var r_first = ToBigIntegerUnsigned(unchecked((IntT)first_lo), unchecked((IntT)first_hi));
            bool r_ov = false;
			var second_ = second & (/*= checked(2 * T) */128/**/ - 1);
			var r_result = r_first;
			for (; second_ > 17; second_ -= 17) {
			    r_result = referenceImpl(r_result, 17);
			}
			r_result = referenceImpl(r_result, second_);
			if (/*= checked(2 * T) */UInt128_MinValue > r_result || r_result > /*= checked(2 * T) */UInt128_MaxValue) {
                r_ov = true;
				r_result = default(BigInteger);
			}
            bool t_ov = false;
			UIntT t_result_lo = 0;
			IntT t_result_hi = 0;
            try {
                t_result_lo = testImpl(first_lo, first_hi, second, out t_result_hi);
            } catch(OverflowException) {
                t_ov = true;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			var t_result = ToBigIntegerUnsigned(unchecked((IntT)t_result_lo), unchecked((IntT)t_result_hi));
            return r_ov == t_ov && r_result == t_result;
        }

		public static bool TestOperation(Operation_IX_int_MapsTo_IX referenceImpl, Operation_U2_int_MapsTo_U2Checked_WithSignature_U_I_int_MapsTo_U_I testImpl) {
		    foreach (var first_hi in Int64CollectionTestDataSourceMagnitude6.Default) {
			    foreach (var first_lo in Int64CollectionTestDataSourceMagnitude6.Default) {
				    for (var second = 0 - 4; second <= 128 + 4; ++second) {
					    if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((UIntT)first_lo), unchecked((IntT)first_hi), second)) {
					        return false;
					    }
					}
			    }
			}
			return true;
		}
    }

    public delegate UIntT Operation_I2_int_MapsTo_I2Checked_WithSignature_U_I_int_MapsTo_U_I(UIntT first_lo, IntT first_hi, int second, out IntT result_hi);

    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_int_MapsTo_IX referenceImpl, Operation_I2_int_MapsTo_I2Checked_WithSignature_U_I_int_MapsTo_U_I testImpl, UIntT first_lo, IntT first_hi, int second) {
            var r_first = ToBigIntegerSigned(unchecked((IntT)first_lo), unchecked((IntT)first_hi));
            bool r_ov = false;
			var second_ = second & (/*= checked(2 * T) */128/**/ - 1);
			var r_result = r_first;
			for (; second_ > 17; second_ -= 17) {
			    r_result = referenceImpl(r_result, 17);
			}
			r_result = referenceImpl(r_result, second_);
			if (/*= checked(2 * T) */Int128_MinValue > r_result || r_result > /*= checked(2 * T) */Int128_MaxValue) {
                r_ov = true;
				r_result = default(BigInteger);
			}
            bool t_ov = false;
			UIntT t_result_lo = 0;
			IntT t_result_hi = 0;
            try {
                t_result_lo = testImpl(first_lo, first_hi, second, out t_result_hi);
            } catch(OverflowException) {
                t_ov = true;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			var t_result = ToBigIntegerSigned(unchecked((IntT)t_result_lo), unchecked((IntT)t_result_hi));
            return r_ov == t_ov && r_result == t_result;
        }

		public static bool TestOperation(Operation_IX_int_MapsTo_IX referenceImpl, Operation_I2_int_MapsTo_I2Checked_WithSignature_U_I_int_MapsTo_U_I testImpl) {
		    foreach (var first_hi in Int64CollectionTestDataSourceMagnitude6.Default) {
			    foreach (var first_lo in Int64CollectionTestDataSourceMagnitude6.Default) {
				    for (var second = 0 - 4; second <= 128 + 4; ++second) {
					    if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((UIntT)first_lo), unchecked((IntT)first_hi), second)) {
					        return false;
					    }
					}
			    }
			}
			return true;
		}
    }

    // usually same as Operation_I2_int_MapsTo_I2Unchecked_WithSignature_U_I_int_MapsTo_U_I
    public delegate UIntT Operation_U2_int_MapsTo_U2Unchecked_WithSignature_U_I_int_MapsTo_U_I(UIntT first_lo, IntT first_hi, int second, out IntT result_hi);
    
	public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_int_MapsTo_IX referenceImpl, Operation_U2_int_MapsTo_U2Unchecked_WithSignature_U_I_int_MapsTo_U_I testImpl, UIntT first_lo, IntT first_hi, int second) {
            var r_first = ToBigIntegerUnsigned(unchecked((IntT)first_lo), unchecked((IntT)first_hi));
			var second_ = second & (/*= checked(2 * T) */128/**/ - 1);
			var r_result = r_first;
			for (; second_ > 17; second_ -= 17) {
			    r_result = referenceImpl(r_result, 17);
			}
			r_result = referenceImpl(r_result, second_);
			UIntT t_result_lo;
			IntT t_result_hi;
            try {
                t_result_lo = testImpl(first_lo, first_hi, second, out t_result_hi);
            } catch(OverflowException) {
				return false;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			UIntT r_result_lo = unchecked((UIntT)(UIntT)(UIntT.MaxValue & r_result));
			IntT r_result_hi = unchecked((IntT)(UIntT)(UIntT.MaxValue & (r_result >> /*= T - 1 */63/**/ >> 1)));
            return r_result_lo == t_result_lo && r_result_hi == t_result_hi;
        }

		public static bool TestOperation(Operation_IX_int_MapsTo_IX referenceImpl, Operation_U2_int_MapsTo_U2Unchecked_WithSignature_U_I_int_MapsTo_U_I testImpl) {
		    foreach (var first_hi in Int64CollectionTestDataSourceMagnitude6.Default) {
			    foreach (var first_lo in Int64CollectionTestDataSourceMagnitude6.Default) {
				    for (var second = 0 - 4; second <= 128 + 4; ++second) {
					    if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((UIntT)first_lo), unchecked((IntT)first_hi), second)) {
					        return false;
					    }
					}
			    }
			}
			return true;
		}
    }

    // usually same as Operation_U2_int_MapsTo_U2Unchecked_WithSignature_U_I_int_MapsTo_U_I
    public delegate UIntT Operation_I2_int_MapsTo_I2Unchecked_WithSignature_U_I_int_MapsTo_U_I(UIntT first_lo, IntT first_hi, int second, out IntT result_hi);

    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_int_MapsTo_IX referenceImpl, Operation_I2_int_MapsTo_I2Unchecked_WithSignature_U_I_int_MapsTo_U_I testImpl, UIntT first_lo, IntT first_hi, int second) {
            var r_first = ToBigIntegerSigned(unchecked((IntT)first_lo), unchecked((IntT)first_hi));
			var second_ = second & (/*= checked(2 * T) */128/**/ - 1);
			var r_result = r_first;
			for (; second_ > 17; second_ -= 17) {
			    r_result = referenceImpl(r_result, 17);
			}
			r_result = referenceImpl(r_result, second_);
			UIntT t_result_lo;
			IntT t_result_hi;
            try {
                t_result_lo = testImpl(first_lo, first_hi, second, out t_result_hi);
            } catch(OverflowException) {
				return false;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			UIntT r_result_lo = unchecked((UIntT)(UIntT)(UIntT.MaxValue & r_result));
			IntT r_result_hi = unchecked((IntT)(UIntT)(UIntT.MaxValue & (r_result >> /*= T - 1 */63/**/ >> 1)));
            return r_result_lo == t_result_lo && r_result_hi == t_result_hi;
        }

		public static bool TestOperation(Operation_IX_int_MapsTo_IX referenceImpl, Operation_I2_int_MapsTo_I2Unchecked_WithSignature_U_I_int_MapsTo_U_I testImpl) {
		    foreach (var first_hi in Int64CollectionTestDataSourceMagnitude6.Default) {
			    foreach (var first_lo in Int64CollectionTestDataSourceMagnitude6.Default) {
				    for (var second = 0 - 4; second <= 128 + 4; ++second) {
					    if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((UIntT)first_lo), unchecked((IntT)first_hi), second)) {
					        return false;
					    }
					}
			    }
			}
			return true;
		}
    }

    public delegate IntT Operation_U2_int_MapsTo_U2Checked_WithSignature_I_U_int_MapsTo_I_U(IntT first_lo, UIntT first_hi, int second, out UIntT result_hi);
    
    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_int_MapsTo_IX referenceImpl, Operation_U2_int_MapsTo_U2Checked_WithSignature_I_U_int_MapsTo_I_U testImpl, IntT first_lo, UIntT first_hi, int second) {
            var r_first = ToBigIntegerUnsigned(unchecked((IntT)first_lo), unchecked((IntT)first_hi));
            bool r_ov = false;
			var second_ = second & (/*= checked(2 * T) */128/**/ - 1);
			var r_result = r_first;
			for (; second_ > 17; second_ -= 17) {
			    r_result = referenceImpl(r_result, 17);
			}
			r_result = referenceImpl(r_result, second_);
			if (/*= checked(2 * T) */UInt128_MinValue > r_result || r_result > /*= checked(2 * T) */UInt128_MaxValue) {
                r_ov = true;
				r_result = default(BigInteger);
			}
            bool t_ov = false;
			IntT t_result_lo = 0;
			UIntT t_result_hi = 0;
            try {
                t_result_lo = testImpl(first_lo, first_hi, second, out t_result_hi);
            } catch(OverflowException) {
                t_ov = true;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			var t_result = ToBigIntegerUnsigned(unchecked((IntT)t_result_lo), unchecked((IntT)t_result_hi));
            return r_ov == t_ov && r_result == t_result;
        }

		public static bool TestOperation(Operation_IX_int_MapsTo_IX referenceImpl, Operation_U2_int_MapsTo_U2Checked_WithSignature_I_U_int_MapsTo_I_U testImpl) {
		    foreach (var first_hi in Int64CollectionTestDataSourceMagnitude6.Default) {
			    foreach (var first_lo in Int64CollectionTestDataSourceMagnitude6.Default) {
				    for (var second = 0 - 4; second <= 128 + 4; ++second) {
					    if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((IntT)first_lo), unchecked((UIntT)first_hi), second)) {
					        return false;
					    }
					}
			    }
			}
			return true;
		}
    }

    public delegate IntT Operation_I2_int_MapsTo_I2Checked_WithSignature_I_U_int_MapsTo_I_U(IntT first_lo, UIntT first_hi, int second, out UIntT result_hi);

    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_int_MapsTo_IX referenceImpl, Operation_I2_int_MapsTo_I2Checked_WithSignature_I_U_int_MapsTo_I_U testImpl, IntT first_lo, UIntT first_hi, int second) {
            var r_first = ToBigIntegerSigned(unchecked((IntT)first_lo), unchecked((IntT)first_hi));
            bool r_ov = false;
			var second_ = second & (/*= checked(2 * T) */128/**/ - 1);
			var r_result = r_first;
			for (; second_ > 17; second_ -= 17) {
			    r_result = referenceImpl(r_result, 17);
			}
			r_result = referenceImpl(r_result, second_);
			if (/*= checked(2 * T) */Int128_MinValue > r_result || r_result > /*= checked(2 * T) */Int128_MaxValue) {
                r_ov = true;
				r_result = default(BigInteger);
			}
            bool t_ov = false;
			IntT t_result_lo = 0;
			UIntT t_result_hi = 0;
            try {
                t_result_lo = testImpl(first_lo, first_hi, second, out t_result_hi);
            } catch(OverflowException) {
                t_ov = true;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			var t_result = ToBigIntegerSigned(unchecked((IntT)t_result_lo), unchecked((IntT)t_result_hi));
            return r_ov == t_ov && r_result == t_result;
        }

		public static bool TestOperation(Operation_IX_int_MapsTo_IX referenceImpl, Operation_I2_int_MapsTo_I2Checked_WithSignature_I_U_int_MapsTo_I_U testImpl) {
		    foreach (var first_hi in Int64CollectionTestDataSourceMagnitude6.Default) {
			    foreach (var first_lo in Int64CollectionTestDataSourceMagnitude6.Default) {
				    for (var second = 0 - 4; second <= 128 + 4; ++second) {
					    if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((IntT)first_lo), unchecked((UIntT)first_hi), second)) {
					        return false;
					    }
					}
			    }
			}
			return true;
		}
    }

    // usually same as Operation_I2_int_MapsTo_I2Unchecked_WithSignature_I_U_int_MapsTo_I_U
    public delegate IntT Operation_U2_int_MapsTo_U2Unchecked_WithSignature_I_U_int_MapsTo_I_U(IntT first_lo, UIntT first_hi, int second, out UIntT result_hi);
    
	public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_int_MapsTo_IX referenceImpl, Operation_U2_int_MapsTo_U2Unchecked_WithSignature_I_U_int_MapsTo_I_U testImpl, IntT first_lo, UIntT first_hi, int second) {
            var r_first = ToBigIntegerUnsigned(unchecked((IntT)first_lo), unchecked((IntT)first_hi));
			var second_ = second & (/*= checked(2 * T) */128/**/ - 1);
			var r_result = r_first;
			for (; second_ > 17; second_ -= 17) {
			    r_result = referenceImpl(r_result, 17);
			}
			r_result = referenceImpl(r_result, second_);
			IntT t_result_lo;
			UIntT t_result_hi;
            try {
                t_result_lo = testImpl(first_lo, first_hi, second, out t_result_hi);
            } catch(OverflowException) {
				return false;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			IntT r_result_lo = unchecked((IntT)(UIntT)(UIntT.MaxValue & r_result));
			UIntT r_result_hi = unchecked((UIntT)(UIntT)(UIntT.MaxValue & (r_result >> /*= T - 1 */63/**/ >> 1)));
            return r_result_lo == t_result_lo && r_result_hi == t_result_hi;
        }

		public static bool TestOperation(Operation_IX_int_MapsTo_IX referenceImpl, Operation_U2_int_MapsTo_U2Unchecked_WithSignature_I_U_int_MapsTo_I_U testImpl) {
		    foreach (var first_hi in Int64CollectionTestDataSourceMagnitude6.Default) {
			    foreach (var first_lo in Int64CollectionTestDataSourceMagnitude6.Default) {
				    for (var second = 0 - 4; second <= 128 + 4; ++second) {
					    if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((IntT)first_lo), unchecked((UIntT)first_hi), second)) {
					        return false;
					    }
					}
			    }
			}
			return true;
		}
    }

    // usually same as Operation_U2_int_MapsTo_U2Unchecked_WithSignature_I_U_int_MapsTo_I_U
    public delegate IntT Operation_I2_int_MapsTo_I2Unchecked_WithSignature_I_U_int_MapsTo_I_U(IntT first_lo, UIntT first_hi, int second, out UIntT result_hi);

    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_int_MapsTo_IX referenceImpl, Operation_I2_int_MapsTo_I2Unchecked_WithSignature_I_U_int_MapsTo_I_U testImpl, IntT first_lo, UIntT first_hi, int second) {
            var r_first = ToBigIntegerSigned(unchecked((IntT)first_lo), unchecked((IntT)first_hi));
			var second_ = second & (/*= checked(2 * T) */128/**/ - 1);
			var r_result = r_first;
			for (; second_ > 17; second_ -= 17) {
			    r_result = referenceImpl(r_result, 17);
			}
			r_result = referenceImpl(r_result, second_);
			IntT t_result_lo;
			UIntT t_result_hi;
            try {
                t_result_lo = testImpl(first_lo, first_hi, second, out t_result_hi);
            } catch(OverflowException) {
				return false;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			IntT r_result_lo = unchecked((IntT)(UIntT)(UIntT.MaxValue & r_result));
			UIntT r_result_hi = unchecked((UIntT)(UIntT)(UIntT.MaxValue & (r_result >> /*= T - 1 */63/**/ >> 1)));
            return r_result_lo == t_result_lo && r_result_hi == t_result_hi;
        }

		public static bool TestOperation(Operation_IX_int_MapsTo_IX referenceImpl, Operation_I2_int_MapsTo_I2Unchecked_WithSignature_I_U_int_MapsTo_I_U testImpl) {
		    foreach (var first_hi in Int64CollectionTestDataSourceMagnitude6.Default) {
			    foreach (var first_lo in Int64CollectionTestDataSourceMagnitude6.Default) {
				    for (var second = 0 - 4; second <= 128 + 4; ++second) {
					    if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((IntT)first_lo), unchecked((UIntT)first_hi), second)) {
					        return false;
					    }
					}
			    }
			}
			return true;
		}
    }

    public delegate UIntT Operation_U2_int_MapsTo_U2Checked_WithSignature_U_U_int_MapsTo_U_U(UIntT first_lo, UIntT first_hi, int second, out UIntT result_hi);
    
    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_int_MapsTo_IX referenceImpl, Operation_U2_int_MapsTo_U2Checked_WithSignature_U_U_int_MapsTo_U_U testImpl, UIntT first_lo, UIntT first_hi, int second) {
            var r_first = ToBigIntegerUnsigned(unchecked((IntT)first_lo), unchecked((IntT)first_hi));
            bool r_ov = false;
			var second_ = second & (/*= checked(2 * T) */128/**/ - 1);
			var r_result = r_first;
			for (; second_ > 17; second_ -= 17) {
			    r_result = referenceImpl(r_result, 17);
			}
			r_result = referenceImpl(r_result, second_);
			if (/*= checked(2 * T) */UInt128_MinValue > r_result || r_result > /*= checked(2 * T) */UInt128_MaxValue) {
                r_ov = true;
				r_result = default(BigInteger);
			}
            bool t_ov = false;
			UIntT t_result_lo = 0;
			UIntT t_result_hi = 0;
            try {
                t_result_lo = testImpl(first_lo, first_hi, second, out t_result_hi);
            } catch(OverflowException) {
                t_ov = true;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			var t_result = ToBigIntegerUnsigned(unchecked((IntT)t_result_lo), unchecked((IntT)t_result_hi));
            return r_ov == t_ov && r_result == t_result;
        }

		public static bool TestOperation(Operation_IX_int_MapsTo_IX referenceImpl, Operation_U2_int_MapsTo_U2Checked_WithSignature_U_U_int_MapsTo_U_U testImpl) {
		    foreach (var first_hi in Int64CollectionTestDataSourceMagnitude6.Default) {
			    foreach (var first_lo in Int64CollectionTestDataSourceMagnitude6.Default) {
				    for (var second = 0 - 4; second <= 128 + 4; ++second) {
					    if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((UIntT)first_lo), unchecked((UIntT)first_hi), second)) {
					        return false;
					    }
					}
			    }
			}
			return true;
		}
    }

    public delegate UIntT Operation_I2_int_MapsTo_I2Checked_WithSignature_U_U_int_MapsTo_U_U(UIntT first_lo, UIntT first_hi, int second, out UIntT result_hi);

    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_int_MapsTo_IX referenceImpl, Operation_I2_int_MapsTo_I2Checked_WithSignature_U_U_int_MapsTo_U_U testImpl, UIntT first_lo, UIntT first_hi, int second) {
            var r_first = ToBigIntegerSigned(unchecked((IntT)first_lo), unchecked((IntT)first_hi));
            bool r_ov = false;
			var second_ = second & (/*= checked(2 * T) */128/**/ - 1);
			var r_result = r_first;
			for (; second_ > 17; second_ -= 17) {
			    r_result = referenceImpl(r_result, 17);
			}
			r_result = referenceImpl(r_result, second_);
			if (/*= checked(2 * T) */Int128_MinValue > r_result || r_result > /*= checked(2 * T) */Int128_MaxValue) {
                r_ov = true;
				r_result = default(BigInteger);
			}
            bool t_ov = false;
			UIntT t_result_lo = 0;
			UIntT t_result_hi = 0;
            try {
                t_result_lo = testImpl(first_lo, first_hi, second, out t_result_hi);
            } catch(OverflowException) {
                t_ov = true;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			var t_result = ToBigIntegerSigned(unchecked((IntT)t_result_lo), unchecked((IntT)t_result_hi));
            return r_ov == t_ov && r_result == t_result;
        }

		public static bool TestOperation(Operation_IX_int_MapsTo_IX referenceImpl, Operation_I2_int_MapsTo_I2Checked_WithSignature_U_U_int_MapsTo_U_U testImpl) {
		    foreach (var first_hi in Int64CollectionTestDataSourceMagnitude6.Default) {
			    foreach (var first_lo in Int64CollectionTestDataSourceMagnitude6.Default) {
				    for (var second = 0 - 4; second <= 128 + 4; ++second) {
					    if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((UIntT)first_lo), unchecked((UIntT)first_hi), second)) {
					        return false;
					    }
					}
			    }
			}
			return true;
		}
    }

    // usually same as Operation_I2_int_MapsTo_I2Unchecked_WithSignature_U_U_int_MapsTo_U_U
    public delegate UIntT Operation_U2_int_MapsTo_U2Unchecked_WithSignature_U_U_int_MapsTo_U_U(UIntT first_lo, UIntT first_hi, int second, out UIntT result_hi);
    
	public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_int_MapsTo_IX referenceImpl, Operation_U2_int_MapsTo_U2Unchecked_WithSignature_U_U_int_MapsTo_U_U testImpl, UIntT first_lo, UIntT first_hi, int second) {
            var r_first = ToBigIntegerUnsigned(unchecked((IntT)first_lo), unchecked((IntT)first_hi));
			var second_ = second & (/*= checked(2 * T) */128/**/ - 1);
			var r_result = r_first;
			for (; second_ > 17; second_ -= 17) {
			    r_result = referenceImpl(r_result, 17);
			}
			r_result = referenceImpl(r_result, second_);
			UIntT t_result_lo;
			UIntT t_result_hi;
            try {
                t_result_lo = testImpl(first_lo, first_hi, second, out t_result_hi);
            } catch(OverflowException) {
				return false;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			UIntT r_result_lo = unchecked((UIntT)(UIntT)(UIntT.MaxValue & r_result));
			UIntT r_result_hi = unchecked((UIntT)(UIntT)(UIntT.MaxValue & (r_result >> /*= T - 1 */63/**/ >> 1)));
            return r_result_lo == t_result_lo && r_result_hi == t_result_hi;
        }

		public static bool TestOperation(Operation_IX_int_MapsTo_IX referenceImpl, Operation_U2_int_MapsTo_U2Unchecked_WithSignature_U_U_int_MapsTo_U_U testImpl) {
		    foreach (var first_hi in Int64CollectionTestDataSourceMagnitude6.Default) {
			    foreach (var first_lo in Int64CollectionTestDataSourceMagnitude6.Default) {
				    for (var second = 0 - 4; second <= 128 + 4; ++second) {
					    if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((UIntT)first_lo), unchecked((UIntT)first_hi), second)) {
					        return false;
					    }
					}
			    }
			}
			return true;
		}
    }

    // usually same as Operation_U2_int_MapsTo_U2Unchecked_WithSignature_U_U_int_MapsTo_U_U
    public delegate UIntT Operation_I2_int_MapsTo_I2Unchecked_WithSignature_U_U_int_MapsTo_U_U(UIntT first_lo, UIntT first_hi, int second, out UIntT result_hi);

    public static partial class TestModule {
        
        public static bool TestOperationSingleRun(Operation_IX_int_MapsTo_IX referenceImpl, Operation_I2_int_MapsTo_I2Unchecked_WithSignature_U_U_int_MapsTo_U_U testImpl, UIntT first_lo, UIntT first_hi, int second) {
            var r_first = ToBigIntegerSigned(unchecked((IntT)first_lo), unchecked((IntT)first_hi));
			var second_ = second & (/*= checked(2 * T) */128/**/ - 1);
			var r_result = r_first;
			for (; second_ > 17; second_ -= 17) {
			    r_result = referenceImpl(r_result, 17);
			}
			r_result = referenceImpl(r_result, second_);
			UIntT t_result_lo;
			UIntT t_result_hi;
            try {
                t_result_lo = testImpl(first_lo, first_hi, second, out t_result_hi);
            } catch(OverflowException) {
				return false;
            } catch {
			    // Unexcepted situations.
				return false;
            }
			UIntT r_result_lo = unchecked((UIntT)(UIntT)(UIntT.MaxValue & r_result));
			UIntT r_result_hi = unchecked((UIntT)(UIntT)(UIntT.MaxValue & (r_result >> /*= T - 1 */63/**/ >> 1)));
            return r_result_lo == t_result_lo && r_result_hi == t_result_hi;
        }

		public static bool TestOperation(Operation_IX_int_MapsTo_IX referenceImpl, Operation_I2_int_MapsTo_I2Unchecked_WithSignature_U_U_int_MapsTo_U_U testImpl) {
		    foreach (var first_hi in Int64CollectionTestDataSourceMagnitude6.Default) {
			    foreach (var first_lo in Int64CollectionTestDataSourceMagnitude6.Default) {
				    for (var second = 0 - 4; second <= 128 + 4; ++second) {
					    if (!TestOperationSingleRun(referenceImpl, testImpl, unchecked((UIntT)first_lo), unchecked((UIntT)first_hi), second)) {
					        return false;
					    }
					}
			    }
			}
			return true;
		}
    }
#endregion
}

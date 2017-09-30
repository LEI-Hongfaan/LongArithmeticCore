using System;

namespace UltimateOrb.Mathematics {
	using UInt = UInt32;
	using ULong = UInt64;
	using Int = Int32;
	using Long = Int64;

	using Math = UltimateOrb.Internal.System.Math;

	using IntT = Int64;
	using UIntT = UInt64;
	
	using LIntT = UInt64;
	using HIntT = UInt64;

	public static partial class DoubleArithmetic {

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		// 2.67 Cyc (special input set test6)
		public static LIntT AddUnchecked(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(first_lo + second_lo);
			var result_hi_ = unchecked(first_hi + second_hi);
			if (unchecked((UIntT)result_lo_) < unchecked((UIntT)first_lo)) {
				result_hi_ = unchecked(result_hi_ + unchecked((HIntT)(UIntT)1u));
			}
			result_hi = result_hi_;
			return result_lo_;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT AddSigned(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(first_lo + second_lo);
			IntT result_hi_;
			if (unchecked((UIntT)result_lo_) >= unchecked((UIntT)first_lo)) {
				result_hi_ = checked(unchecked((IntT)first_hi) + unchecked((IntT)second_hi));
			} else {
				if (IntT.MaxValue != unchecked((IntT)first_hi)) {
					result_hi_ = unchecked(1 + unchecked((IntT)first_hi));
					result_hi_ = checked(result_hi_ + unchecked((IntT)second_hi));
				} else {
					result_hi_ = checked(unchecked((IntT)second_hi) - IntT.MinValue);
				}
			}
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT AddUnsigned(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(first_lo + second_lo);
			var result_hi_ = checked(unchecked((UIntT)first_hi) + unchecked((UIntT)second_hi));
			if (unchecked((UIntT)result_lo_) < unchecked((UIntT)first_lo)) {
				result_hi_ = checked(result_hi_ + 1u);
			}
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}


		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT SubtractUnchecked(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(first_lo - second_lo);
			var result_hi_ = unchecked(first_hi - second_hi);
			if (unchecked((UIntT)result_lo_) > unchecked((UIntT)first_lo)) {
				result_hi_ = unchecked(result_hi_ - unchecked((HIntT)(UIntT)1u));
			}
			result_hi = result_hi_;
			return result_lo_;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT SubtractSigned(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(first_lo - second_lo);
			var result_hi_ = checked(unchecked((IntT)first_hi) - unchecked((IntT)second_hi));
			if (unchecked((UIntT)result_lo_) > unchecked((UIntT)first_lo)) {
				result_hi_ = checked(result_hi_ - 1);
			}
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT SubtractUnsigned(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(first_lo - second_lo);
			var result_hi_ = checked(unchecked((UIntT)first_hi) - unchecked((UIntT)second_hi));
			if (unchecked((UIntT)result_lo_) > unchecked((UIntT)first_lo)) {
				result_hi_ = checked(result_hi_ - 1u);
			}
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT NegateUnchecked(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			var result_lo_ = unchecked((LIntT)(-(IntT)value_lo));
			var result_hi_ = (((LIntT)0 == value_lo) ? unchecked((HIntT)(-(IntT)value_hi)) : unchecked((HIntT)(-1 - (IntT)value_hi)));
			result_hi = result_hi_;
			return result_lo_;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT NegateSigned(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			var result_lo_ = unchecked((LIntT)(-(IntT)value_lo));
			var result_hi_ = (((LIntT)0 == value_lo) ? unchecked((HIntT)checked(-unchecked((IntT)value_hi))) : unchecked((HIntT)(-1 - (IntT)value_hi)));
			result_hi = result_hi_;
			return result_lo_;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT NegateUnsigned(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			if (0 != unchecked((IntT)value_lo)) {
				var u = checked(0 - unchecked((UIntT)value_lo));
				throw (OverflowException)null;
			} else if (0 != unchecked((IntT)value_hi)) {
				var u = checked(0 - unchecked((UIntT)value_hi));
				throw (OverflowException)null;
			}
			result_hi = 0;
			return 0;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		// ~17.5 cyc
		public static LIntT MultiplyUnsignedUnchecked(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			UIntT result_hi_;
			var result_lo_ = BigMul(unchecked((UIntT)first_lo), unchecked((UIntT)second_lo), out result_hi_);
			result_hi = unchecked((HIntT)unchecked(result_hi_ + (UIntT)first_lo * (UIntT)second_hi + (UIntT)first_hi * (UIntT)second_lo));
			return unchecked((LIntT)result_lo_);
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT MultiplyUnsigned(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			UIntT result_hi_;
			if (first_hi != (HIntT)0u && second_hi != (HIntT)0u) {
				result_hi_ = checked(0u - unchecked((UIntT)first_hi));
				throw (OverflowException)null;
			}
			var result_lo_ = BigMul(unchecked((UIntT)first_lo), unchecked((UIntT)second_lo), out result_hi_);
			result_hi = unchecked((HIntT)checked(result_hi_ + unchecked((UIntT)first_lo) * unchecked((UIntT)second_hi) + unchecked((UIntT)first_hi) * unchecked((UIntT)second_lo)));
			return unchecked((LIntT)result_lo_);
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT MultiplySigned(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			var s = (0 > unchecked((IntT)(first_hi ^ second_hi)));
			if (0 > unchecked((IntT)first_hi)) {
				first_lo = NegateUnchecked(first_lo, first_hi, out first_hi);
			}
			if (0 > unchecked((IntT)second_hi)) {
				second_lo = NegateUnchecked(second_lo, second_hi, out second_hi);
			}
			{
				UIntT result_hi_;
				if (first_hi != (HIntT)0u && second_hi != (HIntT)0u) {
					result_hi_ = checked(0u - unchecked((UIntT)first_hi));
					throw (OverflowException)null;
				}
				var result_lo_ = BigMul(unchecked((UIntT)first_lo), unchecked((UIntT)second_lo), out result_hi_);
				result_hi_ = checked(result_hi_ + unchecked((UIntT)first_lo) * unchecked((UIntT)second_hi) + unchecked((UIntT)first_hi) * unchecked((UIntT)second_lo));
				if (unchecked((UIntT)IntT.MinValue) <= result_hi_) {
					if ((unchecked((UIntT)IntT.MinValue) == result_hi_) && (unchecked((UIntT)UIntT.MinValue) == result_lo_) && s) {
						result_hi = unchecked((HIntT)IntT.MinValue);
						return unchecked((LIntT)UIntT.MinValue);
					}
					result_hi_ = checked(0u - unchecked((UIntT)result_hi_));
					throw (OverflowException)null;
				}
				if (s) {
					result_lo_ = NegateUnchecked(result_lo_, result_hi_, out result_hi_);
				}
				result_hi = unchecked((HIntT)result_hi_);
				return unchecked((LIntT)result_lo_);
			}
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT MultiplySignedUnchecked(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
		    var s = (0 > unchecked((IntT)(first_hi ^ second_hi)));
			if (0 > unchecked((IntT)first_hi)) {
				first_lo = NegateUnchecked(first_lo, first_hi, out first_hi);
			}
			if (0 > unchecked((IntT)second_hi)) {
				second_lo = NegateUnchecked(second_lo, second_hi, out second_hi);
			}
			{
				UIntT result_hi_;
				var result_lo_ = BigMul(unchecked((UIntT)first_lo), unchecked((UIntT)second_lo), out result_hi_);
				result_hi_ = unchecked(result_hi_ + unchecked((UIntT)first_lo) * unchecked((UIntT)second_hi) + unchecked((UIntT)first_hi) * unchecked((UIntT)second_lo));
				if (s) {
					result_lo_ = NegateUnchecked(result_lo_, result_hi_, out result_hi_);
				}
				result_hi = unchecked((HIntT)result_hi_);
				return unchecked((LIntT)result_lo_);
			}
		}
	}
}

namespace UltimateOrb.Mathematics {
	using UInt = UInt32;
	using ULong = UInt64;
	using Int = Int32;
	using Long = Int64;

	using Math = UltimateOrb.Internal.System.Math;

	using IntT = Int64;
	using UIntT = UInt64;
	
	using LIntT = UInt64;
	using HIntT = Int64;

	public static partial class DoubleArithmetic {

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		// 2.67 Cyc (special input set test6)
		public static LIntT AddUnchecked(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(first_lo + second_lo);
			var result_hi_ = unchecked(first_hi + second_hi);
			if (unchecked((UIntT)result_lo_) < unchecked((UIntT)first_lo)) {
				result_hi_ = unchecked(result_hi_ + unchecked((HIntT)(UIntT)1u));
			}
			result_hi = result_hi_;
			return result_lo_;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT AddSigned(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(first_lo + second_lo);
			IntT result_hi_;
			if (unchecked((UIntT)result_lo_) >= unchecked((UIntT)first_lo)) {
				result_hi_ = checked(unchecked((IntT)first_hi) + unchecked((IntT)second_hi));
			} else {
				if (IntT.MaxValue != unchecked((IntT)first_hi)) {
					result_hi_ = unchecked(1 + unchecked((IntT)first_hi));
					result_hi_ = checked(result_hi_ + unchecked((IntT)second_hi));
				} else {
					result_hi_ = checked(unchecked((IntT)second_hi) - IntT.MinValue);
				}
			}
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT AddUnsigned(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(first_lo + second_lo);
			var result_hi_ = checked(unchecked((UIntT)first_hi) + unchecked((UIntT)second_hi));
			if (unchecked((UIntT)result_lo_) < unchecked((UIntT)first_lo)) {
				result_hi_ = checked(result_hi_ + 1u);
			}
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}


		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT SubtractUnchecked(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(first_lo - second_lo);
			var result_hi_ = unchecked(first_hi - second_hi);
			if (unchecked((UIntT)result_lo_) > unchecked((UIntT)first_lo)) {
				result_hi_ = unchecked(result_hi_ - unchecked((HIntT)(UIntT)1u));
			}
			result_hi = result_hi_;
			return result_lo_;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT SubtractSigned(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(first_lo - second_lo);
			var result_hi_ = checked(unchecked((IntT)first_hi) - unchecked((IntT)second_hi));
			if (unchecked((UIntT)result_lo_) > unchecked((UIntT)first_lo)) {
				result_hi_ = checked(result_hi_ - 1);
			}
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT SubtractUnsigned(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(first_lo - second_lo);
			var result_hi_ = checked(unchecked((UIntT)first_hi) - unchecked((UIntT)second_hi));
			if (unchecked((UIntT)result_lo_) > unchecked((UIntT)first_lo)) {
				result_hi_ = checked(result_hi_ - 1u);
			}
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT NegateUnchecked(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			var result_lo_ = unchecked((LIntT)(-(IntT)value_lo));
			var result_hi_ = (((LIntT)0 == value_lo) ? unchecked((HIntT)(-(IntT)value_hi)) : unchecked((HIntT)(-1 - (IntT)value_hi)));
			result_hi = result_hi_;
			return result_lo_;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT NegateSigned(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			var result_lo_ = unchecked((LIntT)(-(IntT)value_lo));
			var result_hi_ = (((LIntT)0 == value_lo) ? unchecked((HIntT)checked(-unchecked((IntT)value_hi))) : unchecked((HIntT)(-1 - (IntT)value_hi)));
			result_hi = result_hi_;
			return result_lo_;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT NegateUnsigned(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			if (0 != unchecked((IntT)value_lo)) {
				var u = checked(0 - unchecked((UIntT)value_lo));
				throw (OverflowException)null;
			} else if (0 != unchecked((IntT)value_hi)) {
				var u = checked(0 - unchecked((UIntT)value_hi));
				throw (OverflowException)null;
			}
			result_hi = 0;
			return 0;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		// ~17.5 cyc
		public static LIntT MultiplyUnsignedUnchecked(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			UIntT result_hi_;
			var result_lo_ = BigMul(unchecked((UIntT)first_lo), unchecked((UIntT)second_lo), out result_hi_);
			result_hi = unchecked((HIntT)unchecked(result_hi_ + (UIntT)first_lo * (UIntT)second_hi + (UIntT)first_hi * (UIntT)second_lo));
			return unchecked((LIntT)result_lo_);
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT MultiplyUnsigned(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			UIntT result_hi_;
			if (first_hi != (HIntT)0u && second_hi != (HIntT)0u) {
				result_hi_ = checked(0u - unchecked((UIntT)first_hi));
				throw (OverflowException)null;
			}
			var result_lo_ = BigMul(unchecked((UIntT)first_lo), unchecked((UIntT)second_lo), out result_hi_);
			result_hi = unchecked((HIntT)checked(result_hi_ + unchecked((UIntT)first_lo) * unchecked((UIntT)second_hi) + unchecked((UIntT)first_hi) * unchecked((UIntT)second_lo)));
			return unchecked((LIntT)result_lo_);
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT MultiplySigned(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			var s = (0 > unchecked((IntT)(first_hi ^ second_hi)));
			if (0 > unchecked((IntT)first_hi)) {
				first_lo = NegateUnchecked(first_lo, first_hi, out first_hi);
			}
			if (0 > unchecked((IntT)second_hi)) {
				second_lo = NegateUnchecked(second_lo, second_hi, out second_hi);
			}
			{
				UIntT result_hi_;
				if (first_hi != (HIntT)0u && second_hi != (HIntT)0u) {
					result_hi_ = checked(0u - unchecked((UIntT)first_hi));
					throw (OverflowException)null;
				}
				var result_lo_ = BigMul(unchecked((UIntT)first_lo), unchecked((UIntT)second_lo), out result_hi_);
				result_hi_ = checked(result_hi_ + unchecked((UIntT)first_lo) * unchecked((UIntT)second_hi) + unchecked((UIntT)first_hi) * unchecked((UIntT)second_lo));
				if (unchecked((UIntT)IntT.MinValue) <= result_hi_) {
					if ((unchecked((UIntT)IntT.MinValue) == result_hi_) && (unchecked((UIntT)UIntT.MinValue) == result_lo_) && s) {
						result_hi = unchecked((HIntT)IntT.MinValue);
						return unchecked((LIntT)UIntT.MinValue);
					}
					result_hi_ = checked(0u - unchecked((UIntT)result_hi_));
					throw (OverflowException)null;
				}
				if (s) {
					result_lo_ = NegateUnchecked(result_lo_, result_hi_, out result_hi_);
				}
				result_hi = unchecked((HIntT)result_hi_);
				return unchecked((LIntT)result_lo_);
			}
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT MultiplySignedUnchecked(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
		    var s = (0 > unchecked((IntT)(first_hi ^ second_hi)));
			if (0 > unchecked((IntT)first_hi)) {
				first_lo = NegateUnchecked(first_lo, first_hi, out first_hi);
			}
			if (0 > unchecked((IntT)second_hi)) {
				second_lo = NegateUnchecked(second_lo, second_hi, out second_hi);
			}
			{
				UIntT result_hi_;
				var result_lo_ = BigMul(unchecked((UIntT)first_lo), unchecked((UIntT)second_lo), out result_hi_);
				result_hi_ = unchecked(result_hi_ + unchecked((UIntT)first_lo) * unchecked((UIntT)second_hi) + unchecked((UIntT)first_hi) * unchecked((UIntT)second_lo));
				if (s) {
					result_lo_ = NegateUnchecked(result_lo_, result_hi_, out result_hi_);
				}
				result_hi = unchecked((HIntT)result_hi_);
				return unchecked((LIntT)result_lo_);
			}
		}
	}
}

namespace UltimateOrb.Mathematics {
	using UInt = UInt32;
	using ULong = UInt64;
	using Int = Int32;
	using Long = Int64;

	using Math = UltimateOrb.Internal.System.Math;

	using IntT = Int64;
	using UIntT = UInt64;
	
	using LIntT = Int64;
	using HIntT = UInt64;

	public static partial class DoubleArithmetic {

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		// 2.67 Cyc (special input set test6)
		public static LIntT AddUnchecked(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(first_lo + second_lo);
			var result_hi_ = unchecked(first_hi + second_hi);
			if (unchecked((UIntT)result_lo_) < unchecked((UIntT)first_lo)) {
				result_hi_ = unchecked(result_hi_ + unchecked((HIntT)(UIntT)1u));
			}
			result_hi = result_hi_;
			return result_lo_;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT AddSigned(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(first_lo + second_lo);
			IntT result_hi_;
			if (unchecked((UIntT)result_lo_) >= unchecked((UIntT)first_lo)) {
				result_hi_ = checked(unchecked((IntT)first_hi) + unchecked((IntT)second_hi));
			} else {
				if (IntT.MaxValue != unchecked((IntT)first_hi)) {
					result_hi_ = unchecked(1 + unchecked((IntT)first_hi));
					result_hi_ = checked(result_hi_ + unchecked((IntT)second_hi));
				} else {
					result_hi_ = checked(unchecked((IntT)second_hi) - IntT.MinValue);
				}
			}
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT AddUnsigned(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(first_lo + second_lo);
			var result_hi_ = checked(unchecked((UIntT)first_hi) + unchecked((UIntT)second_hi));
			if (unchecked((UIntT)result_lo_) < unchecked((UIntT)first_lo)) {
				result_hi_ = checked(result_hi_ + 1u);
			}
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}


		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT SubtractUnchecked(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(first_lo - second_lo);
			var result_hi_ = unchecked(first_hi - second_hi);
			if (unchecked((UIntT)result_lo_) > unchecked((UIntT)first_lo)) {
				result_hi_ = unchecked(result_hi_ - unchecked((HIntT)(UIntT)1u));
			}
			result_hi = result_hi_;
			return result_lo_;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT SubtractSigned(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(first_lo - second_lo);
			var result_hi_ = checked(unchecked((IntT)first_hi) - unchecked((IntT)second_hi));
			if (unchecked((UIntT)result_lo_) > unchecked((UIntT)first_lo)) {
				result_hi_ = checked(result_hi_ - 1);
			}
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT SubtractUnsigned(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(first_lo - second_lo);
			var result_hi_ = checked(unchecked((UIntT)first_hi) - unchecked((UIntT)second_hi));
			if (unchecked((UIntT)result_lo_) > unchecked((UIntT)first_lo)) {
				result_hi_ = checked(result_hi_ - 1u);
			}
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT NegateUnchecked(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			var result_lo_ = unchecked((LIntT)(-(IntT)value_lo));
			var result_hi_ = (((LIntT)0 == value_lo) ? unchecked((HIntT)(-(IntT)value_hi)) : unchecked((HIntT)(-1 - (IntT)value_hi)));
			result_hi = result_hi_;
			return result_lo_;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT NegateSigned(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			var result_lo_ = unchecked((LIntT)(-(IntT)value_lo));
			var result_hi_ = (((LIntT)0 == value_lo) ? unchecked((HIntT)checked(-unchecked((IntT)value_hi))) : unchecked((HIntT)(-1 - (IntT)value_hi)));
			result_hi = result_hi_;
			return result_lo_;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT NegateUnsigned(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			if (0 != unchecked((IntT)value_lo)) {
				var u = checked(0 - unchecked((UIntT)value_lo));
				throw (OverflowException)null;
			} else if (0 != unchecked((IntT)value_hi)) {
				var u = checked(0 - unchecked((UIntT)value_hi));
				throw (OverflowException)null;
			}
			result_hi = 0;
			return 0;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		// ~17.5 cyc
		public static LIntT MultiplyUnsignedUnchecked(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			UIntT result_hi_;
			var result_lo_ = BigMul(unchecked((UIntT)first_lo), unchecked((UIntT)second_lo), out result_hi_);
			result_hi = unchecked((HIntT)unchecked(result_hi_ + (UIntT)first_lo * (UIntT)second_hi + (UIntT)first_hi * (UIntT)second_lo));
			return unchecked((LIntT)result_lo_);
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT MultiplyUnsigned(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			UIntT result_hi_;
			if (first_hi != (HIntT)0u && second_hi != (HIntT)0u) {
				result_hi_ = checked(0u - unchecked((UIntT)first_hi));
				throw (OverflowException)null;
			}
			var result_lo_ = BigMul(unchecked((UIntT)first_lo), unchecked((UIntT)second_lo), out result_hi_);
			result_hi = unchecked((HIntT)checked(result_hi_ + unchecked((UIntT)first_lo) * unchecked((UIntT)second_hi) + unchecked((UIntT)first_hi) * unchecked((UIntT)second_lo)));
			return unchecked((LIntT)result_lo_);
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT MultiplySigned(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			var s = (0 > unchecked((IntT)(first_hi ^ second_hi)));
			if (0 > unchecked((IntT)first_hi)) {
				first_lo = NegateUnchecked(first_lo, first_hi, out first_hi);
			}
			if (0 > unchecked((IntT)second_hi)) {
				second_lo = NegateUnchecked(second_lo, second_hi, out second_hi);
			}
			{
				UIntT result_hi_;
				if (first_hi != (HIntT)0u && second_hi != (HIntT)0u) {
					result_hi_ = checked(0u - unchecked((UIntT)first_hi));
					throw (OverflowException)null;
				}
				var result_lo_ = BigMul(unchecked((UIntT)first_lo), unchecked((UIntT)second_lo), out result_hi_);
				result_hi_ = checked(result_hi_ + unchecked((UIntT)first_lo) * unchecked((UIntT)second_hi) + unchecked((UIntT)first_hi) * unchecked((UIntT)second_lo));
				if (unchecked((UIntT)IntT.MinValue) <= result_hi_) {
					if ((unchecked((UIntT)IntT.MinValue) == result_hi_) && (unchecked((UIntT)UIntT.MinValue) == result_lo_) && s) {
						result_hi = unchecked((HIntT)IntT.MinValue);
						return unchecked((LIntT)UIntT.MinValue);
					}
					result_hi_ = checked(0u - unchecked((UIntT)result_hi_));
					throw (OverflowException)null;
				}
				if (s) {
					result_lo_ = NegateUnchecked(result_lo_, result_hi_, out result_hi_);
				}
				result_hi = unchecked((HIntT)result_hi_);
				return unchecked((LIntT)result_lo_);
			}
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT MultiplySignedUnchecked(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
		    var s = (0 > unchecked((IntT)(first_hi ^ second_hi)));
			if (0 > unchecked((IntT)first_hi)) {
				first_lo = NegateUnchecked(first_lo, first_hi, out first_hi);
			}
			if (0 > unchecked((IntT)second_hi)) {
				second_lo = NegateUnchecked(second_lo, second_hi, out second_hi);
			}
			{
				UIntT result_hi_;
				var result_lo_ = BigMul(unchecked((UIntT)first_lo), unchecked((UIntT)second_lo), out result_hi_);
				result_hi_ = unchecked(result_hi_ + unchecked((UIntT)first_lo) * unchecked((UIntT)second_hi) + unchecked((UIntT)first_hi) * unchecked((UIntT)second_lo));
				if (s) {
					result_lo_ = NegateUnchecked(result_lo_, result_hi_, out result_hi_);
				}
				result_hi = unchecked((HIntT)result_hi_);
				return unchecked((LIntT)result_lo_);
			}
		}
	}
}

namespace UltimateOrb.Mathematics {
	using UInt = UInt32;
	using ULong = UInt64;
	using Int = Int32;
	using Long = Int64;

	using Math = UltimateOrb.Internal.System.Math;

	using IntT = Int64;
	using UIntT = UInt64;
	
	using LIntT = Int64;
	using HIntT = Int64;

	public static partial class DoubleArithmetic {

		[System.CLSCompliantAttribute(true)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		// 2.67 Cyc (special input set test6)
		public static LIntT AddUnchecked(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(first_lo + second_lo);
			var result_hi_ = unchecked(first_hi + second_hi);
			if (unchecked((UIntT)result_lo_) < unchecked((UIntT)first_lo)) {
				result_hi_ = unchecked(result_hi_ + unchecked((HIntT)(UIntT)1u));
			}
			result_hi = result_hi_;
			return result_lo_;
		}

		[System.CLSCompliantAttribute(true)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT AddSigned(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(first_lo + second_lo);
			IntT result_hi_;
			if (unchecked((UIntT)result_lo_) >= unchecked((UIntT)first_lo)) {
				result_hi_ = checked(unchecked((IntT)first_hi) + unchecked((IntT)second_hi));
			} else {
				if (IntT.MaxValue != unchecked((IntT)first_hi)) {
					result_hi_ = unchecked(1 + unchecked((IntT)first_hi));
					result_hi_ = checked(result_hi_ + unchecked((IntT)second_hi));
				} else {
					result_hi_ = checked(unchecked((IntT)second_hi) - IntT.MinValue);
				}
			}
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}

		[System.CLSCompliantAttribute(true)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT AddUnsigned(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(first_lo + second_lo);
			var result_hi_ = checked(unchecked((UIntT)first_hi) + unchecked((UIntT)second_hi));
			if (unchecked((UIntT)result_lo_) < unchecked((UIntT)first_lo)) {
				result_hi_ = checked(result_hi_ + 1u);
			}
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}


		[System.CLSCompliantAttribute(true)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT SubtractUnchecked(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(first_lo - second_lo);
			var result_hi_ = unchecked(first_hi - second_hi);
			if (unchecked((UIntT)result_lo_) > unchecked((UIntT)first_lo)) {
				result_hi_ = unchecked(result_hi_ - unchecked((HIntT)(UIntT)1u));
			}
			result_hi = result_hi_;
			return result_lo_;
		}

		[System.CLSCompliantAttribute(true)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT SubtractSigned(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(first_lo - second_lo);
			var result_hi_ = checked(unchecked((IntT)first_hi) - unchecked((IntT)second_hi));
			if (unchecked((UIntT)result_lo_) > unchecked((UIntT)first_lo)) {
				result_hi_ = checked(result_hi_ - 1);
			}
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}

		[System.CLSCompliantAttribute(true)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT SubtractUnsigned(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(first_lo - second_lo);
			var result_hi_ = checked(unchecked((UIntT)first_hi) - unchecked((UIntT)second_hi));
			if (unchecked((UIntT)result_lo_) > unchecked((UIntT)first_lo)) {
				result_hi_ = checked(result_hi_ - 1u);
			}
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}

		[System.CLSCompliantAttribute(true)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT NegateUnchecked(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			var result_lo_ = unchecked((LIntT)(-(IntT)value_lo));
			var result_hi_ = (((LIntT)0 == value_lo) ? unchecked((HIntT)(-(IntT)value_hi)) : unchecked((HIntT)(-1 - (IntT)value_hi)));
			result_hi = result_hi_;
			return result_lo_;
		}

		[System.CLSCompliantAttribute(true)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT NegateSigned(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			var result_lo_ = unchecked((LIntT)(-(IntT)value_lo));
			var result_hi_ = (((LIntT)0 == value_lo) ? unchecked((HIntT)checked(-unchecked((IntT)value_hi))) : unchecked((HIntT)(-1 - (IntT)value_hi)));
			result_hi = result_hi_;
			return result_lo_;
		}

		[System.CLSCompliantAttribute(true)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT NegateUnsigned(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			if (0 != unchecked((IntT)value_lo)) {
				var u = checked(0 - unchecked((UIntT)value_lo));
				throw (OverflowException)null;
			} else if (0 != unchecked((IntT)value_hi)) {
				var u = checked(0 - unchecked((UIntT)value_hi));
				throw (OverflowException)null;
			}
			result_hi = 0;
			return 0;
		}

		[System.CLSCompliantAttribute(true)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		// ~17.5 cyc
		public static LIntT MultiplyUnsignedUnchecked(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			UIntT result_hi_;
			var result_lo_ = BigMul(unchecked((UIntT)first_lo), unchecked((UIntT)second_lo), out result_hi_);
			result_hi = unchecked((HIntT)unchecked(result_hi_ + (UIntT)first_lo * (UIntT)second_hi + (UIntT)first_hi * (UIntT)second_lo));
			return unchecked((LIntT)result_lo_);
		}

		[System.CLSCompliantAttribute(true)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT MultiplyUnsigned(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			UIntT result_hi_;
			if (first_hi != (HIntT)0u && second_hi != (HIntT)0u) {
				result_hi_ = checked(0u - unchecked((UIntT)first_hi));
				throw (OverflowException)null;
			}
			var result_lo_ = BigMul(unchecked((UIntT)first_lo), unchecked((UIntT)second_lo), out result_hi_);
			result_hi = unchecked((HIntT)checked(result_hi_ + unchecked((UIntT)first_lo) * unchecked((UIntT)second_hi) + unchecked((UIntT)first_hi) * unchecked((UIntT)second_lo)));
			return unchecked((LIntT)result_lo_);
		}

		[System.CLSCompliantAttribute(true)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT MultiplySigned(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
			var s = (0 > unchecked((IntT)(first_hi ^ second_hi)));
			if (0 > unchecked((IntT)first_hi)) {
				first_lo = NegateUnchecked(first_lo, first_hi, out first_hi);
			}
			if (0 > unchecked((IntT)second_hi)) {
				second_lo = NegateUnchecked(second_lo, second_hi, out second_hi);
			}
			{
				UIntT result_hi_;
				if (first_hi != (HIntT)0u && second_hi != (HIntT)0u) {
					result_hi_ = checked(0u - unchecked((UIntT)first_hi));
					throw (OverflowException)null;
				}
				var result_lo_ = BigMul(unchecked((UIntT)first_lo), unchecked((UIntT)second_lo), out result_hi_);
				result_hi_ = checked(result_hi_ + unchecked((UIntT)first_lo) * unchecked((UIntT)second_hi) + unchecked((UIntT)first_hi) * unchecked((UIntT)second_lo));
				if (unchecked((UIntT)IntT.MinValue) <= result_hi_) {
					if ((unchecked((UIntT)IntT.MinValue) == result_hi_) && (unchecked((UIntT)UIntT.MinValue) == result_lo_) && s) {
						result_hi = unchecked((HIntT)IntT.MinValue);
						return unchecked((LIntT)UIntT.MinValue);
					}
					result_hi_ = checked(0u - unchecked((UIntT)result_hi_));
					throw (OverflowException)null;
				}
				if (s) {
					result_lo_ = NegateUnchecked(result_lo_, result_hi_, out result_hi_);
				}
				result_hi = unchecked((HIntT)result_hi_);
				return unchecked((LIntT)result_lo_);
			}
		}

		[System.CLSCompliantAttribute(true)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT MultiplySignedUnchecked(LIntT first_lo, HIntT first_hi, LIntT second_lo, HIntT second_hi, out HIntT result_hi) {
		    var s = (0 > unchecked((IntT)(first_hi ^ second_hi)));
			if (0 > unchecked((IntT)first_hi)) {
				first_lo = NegateUnchecked(first_lo, first_hi, out first_hi);
			}
			if (0 > unchecked((IntT)second_hi)) {
				second_lo = NegateUnchecked(second_lo, second_hi, out second_hi);
			}
			{
				UIntT result_hi_;
				var result_lo_ = BigMul(unchecked((UIntT)first_lo), unchecked((UIntT)second_lo), out result_hi_);
				result_hi_ = unchecked(result_hi_ + unchecked((UIntT)first_lo) * unchecked((UIntT)second_hi) + unchecked((UIntT)first_hi) * unchecked((UIntT)second_lo));
				if (s) {
					result_lo_ = NegateUnchecked(result_lo_, result_hi_, out result_hi_);
				}
				result_hi = unchecked((HIntT)result_hi_);
				return unchecked((LIntT)result_lo_);
			}
		}
	}
}

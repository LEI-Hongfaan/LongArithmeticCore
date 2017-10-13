using System;
using System.Linq;
using System.Text;

namespace ThisAssembly {
    using Xunit;
    using BigInteger = System.Numerics.BigInteger;
    using TestModule = UltimateOrb.Mathematics.Internal.Testing.ArithmeticOperations.TestModule;
    using ArithmeticOperations = UltimateOrb.Mathematics.Internal.Testing.ArithmeticOperations;
    using DoubleArithmetic = UltimateOrb.Mathematics.DoubleArithmetic;

    public partial class Program {
        
        [Fact]
        public void Test_0_0_0_0() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => -x);
            var testImpl = (ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_I_I_MapsTo_I_I)DoubleArithmetic.NegateUnchecked;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_I_I_MapsTo_I_I),
                    nameof(DoubleArithmetic.NegateUnchecked)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_0_0_1() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => -x);
            var testImpl = (ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_U_I_MapsTo_U_I)DoubleArithmetic.NegateUnchecked;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_U_I_MapsTo_U_I),
                    nameof(DoubleArithmetic.NegateUnchecked)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_0_0_2() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => -x);
            var testImpl = (ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_I_U_MapsTo_I_U)DoubleArithmetic.NegateUnchecked;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_I_U_MapsTo_I_U),
                    nameof(DoubleArithmetic.NegateUnchecked)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_0_0_3() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => -x);
            var testImpl = (ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_U_U_MapsTo_U_U)DoubleArithmetic.NegateUnchecked;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_U_U_MapsTo_U_U),
                    nameof(DoubleArithmetic.NegateUnchecked)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_0_1_0() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => -x);
            var testImpl = (ArithmeticOperations.Operation_I2_MapsTo_I2Checked_WithSignature_I_I_MapsTo_I_I)DoubleArithmetic.NegateSigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_MapsTo_I2Checked_WithSignature_I_I_MapsTo_I_I),
                    nameof(DoubleArithmetic.NegateSigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_0_1_1() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => -x);
            var testImpl = (ArithmeticOperations.Operation_I2_MapsTo_I2Checked_WithSignature_U_I_MapsTo_U_I)DoubleArithmetic.NegateSigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_MapsTo_I2Checked_WithSignature_U_I_MapsTo_U_I),
                    nameof(DoubleArithmetic.NegateSigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_0_1_2() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => -x);
            var testImpl = (ArithmeticOperations.Operation_I2_MapsTo_I2Checked_WithSignature_I_U_MapsTo_I_U)DoubleArithmetic.NegateSigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_MapsTo_I2Checked_WithSignature_I_U_MapsTo_I_U),
                    nameof(DoubleArithmetic.NegateSigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_0_1_3() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => -x);
            var testImpl = (ArithmeticOperations.Operation_I2_MapsTo_I2Checked_WithSignature_U_U_MapsTo_U_U)DoubleArithmetic.NegateSigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_MapsTo_I2Checked_WithSignature_U_U_MapsTo_U_U),
                    nameof(DoubleArithmetic.NegateSigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_0_2_0() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => -x);
            var testImpl = (ArithmeticOperations.Operation_U2_MapsTo_U2Checked_WithSignature_I_I_MapsTo_I_I)DoubleArithmetic.NegateUnsigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_U2_MapsTo_U2Checked_WithSignature_I_I_MapsTo_I_I),
                    nameof(DoubleArithmetic.NegateUnsigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_0_2_1() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => -x);
            var testImpl = (ArithmeticOperations.Operation_U2_MapsTo_U2Checked_WithSignature_U_I_MapsTo_U_I)DoubleArithmetic.NegateUnsigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_U2_MapsTo_U2Checked_WithSignature_U_I_MapsTo_U_I),
                    nameof(DoubleArithmetic.NegateUnsigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_0_2_2() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => -x);
            var testImpl = (ArithmeticOperations.Operation_U2_MapsTo_U2Checked_WithSignature_I_U_MapsTo_I_U)DoubleArithmetic.NegateUnsigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_U2_MapsTo_U2Checked_WithSignature_I_U_MapsTo_I_U),
                    nameof(DoubleArithmetic.NegateUnsigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_0_2_3() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => -x);
            var testImpl = (ArithmeticOperations.Operation_U2_MapsTo_U2Checked_WithSignature_U_U_MapsTo_U_U)DoubleArithmetic.NegateUnsigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_U2_MapsTo_U2Checked_WithSignature_U_U_MapsTo_U_U),
                    nameof(DoubleArithmetic.NegateUnsigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_1_0_0() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => ++x);
            var testImpl = (ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_I_I_MapsTo_I_I)DoubleArithmetic.IncreaseUnchecked;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_I_I_MapsTo_I_I),
                    nameof(DoubleArithmetic.IncreaseUnchecked)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_1_0_1() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => ++x);
            var testImpl = (ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_U_I_MapsTo_U_I)DoubleArithmetic.IncreaseUnchecked;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_U_I_MapsTo_U_I),
                    nameof(DoubleArithmetic.IncreaseUnchecked)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_1_0_2() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => ++x);
            var testImpl = (ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_I_U_MapsTo_I_U)DoubleArithmetic.IncreaseUnchecked;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_I_U_MapsTo_I_U),
                    nameof(DoubleArithmetic.IncreaseUnchecked)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_1_0_3() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => ++x);
            var testImpl = (ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_U_U_MapsTo_U_U)DoubleArithmetic.IncreaseUnchecked;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_U_U_MapsTo_U_U),
                    nameof(DoubleArithmetic.IncreaseUnchecked)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_1_1_0() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => ++x);
            var testImpl = (ArithmeticOperations.Operation_I2_MapsTo_I2Checked_WithSignature_I_I_MapsTo_I_I)DoubleArithmetic.IncreaseSigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_MapsTo_I2Checked_WithSignature_I_I_MapsTo_I_I),
                    nameof(DoubleArithmetic.IncreaseSigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_1_1_1() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => ++x);
            var testImpl = (ArithmeticOperations.Operation_I2_MapsTo_I2Checked_WithSignature_U_I_MapsTo_U_I)DoubleArithmetic.IncreaseSigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_MapsTo_I2Checked_WithSignature_U_I_MapsTo_U_I),
                    nameof(DoubleArithmetic.IncreaseSigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_1_1_2() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => ++x);
            var testImpl = (ArithmeticOperations.Operation_I2_MapsTo_I2Checked_WithSignature_I_U_MapsTo_I_U)DoubleArithmetic.IncreaseSigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_MapsTo_I2Checked_WithSignature_I_U_MapsTo_I_U),
                    nameof(DoubleArithmetic.IncreaseSigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_1_1_3() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => ++x);
            var testImpl = (ArithmeticOperations.Operation_I2_MapsTo_I2Checked_WithSignature_U_U_MapsTo_U_U)DoubleArithmetic.IncreaseSigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_MapsTo_I2Checked_WithSignature_U_U_MapsTo_U_U),
                    nameof(DoubleArithmetic.IncreaseSigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_1_2_0() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => ++x);
            var testImpl = (ArithmeticOperations.Operation_U2_MapsTo_U2Checked_WithSignature_I_I_MapsTo_I_I)DoubleArithmetic.IncreaseUnsigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_U2_MapsTo_U2Checked_WithSignature_I_I_MapsTo_I_I),
                    nameof(DoubleArithmetic.IncreaseUnsigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_1_2_1() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => ++x);
            var testImpl = (ArithmeticOperations.Operation_U2_MapsTo_U2Checked_WithSignature_U_I_MapsTo_U_I)DoubleArithmetic.IncreaseUnsigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_U2_MapsTo_U2Checked_WithSignature_U_I_MapsTo_U_I),
                    nameof(DoubleArithmetic.IncreaseUnsigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_1_2_2() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => ++x);
            var testImpl = (ArithmeticOperations.Operation_U2_MapsTo_U2Checked_WithSignature_I_U_MapsTo_I_U)DoubleArithmetic.IncreaseUnsigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_U2_MapsTo_U2Checked_WithSignature_I_U_MapsTo_I_U),
                    nameof(DoubleArithmetic.IncreaseUnsigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_1_2_3() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => ++x);
            var testImpl = (ArithmeticOperations.Operation_U2_MapsTo_U2Checked_WithSignature_U_U_MapsTo_U_U)DoubleArithmetic.IncreaseUnsigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_U2_MapsTo_U2Checked_WithSignature_U_U_MapsTo_U_U),
                    nameof(DoubleArithmetic.IncreaseUnsigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_2_0_0() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => --x);
            var testImpl = (ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_I_I_MapsTo_I_I)DoubleArithmetic.DecreaseUnchecked;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_I_I_MapsTo_I_I),
                    nameof(DoubleArithmetic.DecreaseUnchecked)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_2_0_1() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => --x);
            var testImpl = (ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_U_I_MapsTo_U_I)DoubleArithmetic.DecreaseUnchecked;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_U_I_MapsTo_U_I),
                    nameof(DoubleArithmetic.DecreaseUnchecked)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_2_0_2() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => --x);
            var testImpl = (ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_I_U_MapsTo_I_U)DoubleArithmetic.DecreaseUnchecked;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_I_U_MapsTo_I_U),
                    nameof(DoubleArithmetic.DecreaseUnchecked)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_2_0_3() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => --x);
            var testImpl = (ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_U_U_MapsTo_U_U)DoubleArithmetic.DecreaseUnchecked;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_U_U_MapsTo_U_U),
                    nameof(DoubleArithmetic.DecreaseUnchecked)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_2_1_0() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => --x);
            var testImpl = (ArithmeticOperations.Operation_I2_MapsTo_I2Checked_WithSignature_I_I_MapsTo_I_I)DoubleArithmetic.DecreaseSigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_MapsTo_I2Checked_WithSignature_I_I_MapsTo_I_I),
                    nameof(DoubleArithmetic.DecreaseSigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_2_1_1() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => --x);
            var testImpl = (ArithmeticOperations.Operation_I2_MapsTo_I2Checked_WithSignature_U_I_MapsTo_U_I)DoubleArithmetic.DecreaseSigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_MapsTo_I2Checked_WithSignature_U_I_MapsTo_U_I),
                    nameof(DoubleArithmetic.DecreaseSigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_2_1_2() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => --x);
            var testImpl = (ArithmeticOperations.Operation_I2_MapsTo_I2Checked_WithSignature_I_U_MapsTo_I_U)DoubleArithmetic.DecreaseSigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_MapsTo_I2Checked_WithSignature_I_U_MapsTo_I_U),
                    nameof(DoubleArithmetic.DecreaseSigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_2_1_3() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => --x);
            var testImpl = (ArithmeticOperations.Operation_I2_MapsTo_I2Checked_WithSignature_U_U_MapsTo_U_U)DoubleArithmetic.DecreaseSigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_MapsTo_I2Checked_WithSignature_U_U_MapsTo_U_U),
                    nameof(DoubleArithmetic.DecreaseSigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_2_2_0() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => --x);
            var testImpl = (ArithmeticOperations.Operation_U2_MapsTo_U2Checked_WithSignature_I_I_MapsTo_I_I)DoubleArithmetic.DecreaseUnsigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_U2_MapsTo_U2Checked_WithSignature_I_I_MapsTo_I_I),
                    nameof(DoubleArithmetic.DecreaseUnsigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_2_2_1() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => --x);
            var testImpl = (ArithmeticOperations.Operation_U2_MapsTo_U2Checked_WithSignature_U_I_MapsTo_U_I)DoubleArithmetic.DecreaseUnsigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_U2_MapsTo_U2Checked_WithSignature_U_I_MapsTo_U_I),
                    nameof(DoubleArithmetic.DecreaseUnsigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_2_2_2() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => --x);
            var testImpl = (ArithmeticOperations.Operation_U2_MapsTo_U2Checked_WithSignature_I_U_MapsTo_I_U)DoubleArithmetic.DecreaseUnsigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_U2_MapsTo_U2Checked_WithSignature_I_U_MapsTo_I_U),
                    nameof(DoubleArithmetic.DecreaseUnsigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_0_2_2_3() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => --x);
            var testImpl = (ArithmeticOperations.Operation_U2_MapsTo_U2Checked_WithSignature_U_U_MapsTo_U_U)DoubleArithmetic.DecreaseUnsigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_U2_MapsTo_U2Checked_WithSignature_U_U_MapsTo_U_U),
                    nameof(DoubleArithmetic.DecreaseUnsigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_2_0_0_0() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => x >> 1);
            var testImpl = (ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_I_I_MapsTo_I_I)DoubleArithmetic.ShiftRightSigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_I_I_MapsTo_I_I),
                    nameof(DoubleArithmetic.ShiftRightSigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_2_0_0_1() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => x >> 1);
            var testImpl = (ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_U_I_MapsTo_U_I)DoubleArithmetic.ShiftRightSigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_U_I_MapsTo_U_I),
                    nameof(DoubleArithmetic.ShiftRightSigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_2_0_0_2() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => x >> 1);
            var testImpl = (ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_I_U_MapsTo_I_U)DoubleArithmetic.ShiftRightSigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_I_U_MapsTo_I_U),
                    nameof(DoubleArithmetic.ShiftRightSigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_2_0_0_3() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => x >> 1);
            var testImpl = (ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_U_U_MapsTo_U_U)DoubleArithmetic.ShiftRightSigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_U_U_MapsTo_U_U),
                    nameof(DoubleArithmetic.ShiftRightSigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_2_0_1_0() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => x >> 1);
            var testImpl = (ArithmeticOperations.Operation_U2_MapsTo_U2Unchecked_WithSignature_I_I_MapsTo_I_I)DoubleArithmetic.ShiftRightUnsigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_U2_MapsTo_U2Unchecked_WithSignature_I_I_MapsTo_I_I),
                    nameof(DoubleArithmetic.ShiftRightUnsigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_2_0_1_1() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => x >> 1);
            var testImpl = (ArithmeticOperations.Operation_U2_MapsTo_U2Unchecked_WithSignature_U_I_MapsTo_U_I)DoubleArithmetic.ShiftRightUnsigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_U2_MapsTo_U2Unchecked_WithSignature_U_I_MapsTo_U_I),
                    nameof(DoubleArithmetic.ShiftRightUnsigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_2_0_1_2() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => x >> 1);
            var testImpl = (ArithmeticOperations.Operation_U2_MapsTo_U2Unchecked_WithSignature_I_U_MapsTo_I_U)DoubleArithmetic.ShiftRightUnsigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_U2_MapsTo_U2Unchecked_WithSignature_I_U_MapsTo_I_U),
                    nameof(DoubleArithmetic.ShiftRightUnsigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_2_0_1_3() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => x >> 1);
            var testImpl = (ArithmeticOperations.Operation_U2_MapsTo_U2Unchecked_WithSignature_U_U_MapsTo_U_U)DoubleArithmetic.ShiftRightUnsigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_U2_MapsTo_U2Unchecked_WithSignature_U_U_MapsTo_U_U),
                    nameof(DoubleArithmetic.ShiftRightUnsigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_3_0_0_0() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => x << 1);
            var testImpl = (ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_I_I_MapsTo_I_I)DoubleArithmetic.ShiftLeft;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_I_I_MapsTo_I_I),
                    nameof(DoubleArithmetic.ShiftLeft)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_3_0_0_1() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => x << 1);
            var testImpl = (ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_U_I_MapsTo_U_I)DoubleArithmetic.ShiftLeft;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_U_I_MapsTo_U_I),
                    nameof(DoubleArithmetic.ShiftLeft)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_3_0_0_2() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => x << 1);
            var testImpl = (ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_I_U_MapsTo_I_U)DoubleArithmetic.ShiftLeft;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_I_U_MapsTo_I_U),
                    nameof(DoubleArithmetic.ShiftLeft)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_3_0_0_3() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_MapsTo_IX)((x) => x << 1);
            var testImpl = (ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_U_U_MapsTo_U_U)DoubleArithmetic.ShiftLeft;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_MapsTo_I2Unchecked_WithSignature_U_U_MapsTo_U_U),
                    nameof(DoubleArithmetic.ShiftLeft)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_0_0_0() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x + y);
            var testImpl = (ArithmeticOperations.Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_I_I_I_I_MapsTo_I_I)DoubleArithmetic.AddUnchecked;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_I_I_I_I_MapsTo_I_I),
                    nameof(DoubleArithmetic.AddUnchecked)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_0_0_1() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x + y);
            var testImpl = (ArithmeticOperations.Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_U_I_U_I_MapsTo_U_I)DoubleArithmetic.AddUnchecked;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_U_I_U_I_MapsTo_U_I),
                    nameof(DoubleArithmetic.AddUnchecked)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_0_0_2() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x + y);
            var testImpl = (ArithmeticOperations.Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_I_U_I_U_MapsTo_I_U)DoubleArithmetic.AddUnchecked;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_I_U_I_U_MapsTo_I_U),
                    nameof(DoubleArithmetic.AddUnchecked)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_0_0_3() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x + y);
            var testImpl = (ArithmeticOperations.Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_U_U_U_U_MapsTo_U_U)DoubleArithmetic.AddUnchecked;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_U_U_U_U_MapsTo_U_U),
                    nameof(DoubleArithmetic.AddUnchecked)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_0_1_0() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x + y);
            var testImpl = (ArithmeticOperations.Operation_I2_I2_MapsTo_I2Checked_WithSignature_I_I_I_I_MapsTo_I_I)DoubleArithmetic.AddSigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_I2_MapsTo_I2Checked_WithSignature_I_I_I_I_MapsTo_I_I),
                    nameof(DoubleArithmetic.AddSigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_0_1_1() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x + y);
            var testImpl = (ArithmeticOperations.Operation_I2_I2_MapsTo_I2Checked_WithSignature_U_I_U_I_MapsTo_U_I)DoubleArithmetic.AddSigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_I2_MapsTo_I2Checked_WithSignature_U_I_U_I_MapsTo_U_I),
                    nameof(DoubleArithmetic.AddSigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_0_1_2() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x + y);
            var testImpl = (ArithmeticOperations.Operation_I2_I2_MapsTo_I2Checked_WithSignature_I_U_I_U_MapsTo_I_U)DoubleArithmetic.AddSigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_I2_MapsTo_I2Checked_WithSignature_I_U_I_U_MapsTo_I_U),
                    nameof(DoubleArithmetic.AddSigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_0_1_3() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x + y);
            var testImpl = (ArithmeticOperations.Operation_I2_I2_MapsTo_I2Checked_WithSignature_U_U_U_U_MapsTo_U_U)DoubleArithmetic.AddSigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_I2_MapsTo_I2Checked_WithSignature_U_U_U_U_MapsTo_U_U),
                    nameof(DoubleArithmetic.AddSigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_0_2_0() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x + y);
            var testImpl = (ArithmeticOperations.Operation_U2_U2_MapsTo_U2Checked_WithSignature_I_I_I_I_MapsTo_I_I)DoubleArithmetic.AddUnsigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_U2_U2_MapsTo_U2Checked_WithSignature_I_I_I_I_MapsTo_I_I),
                    nameof(DoubleArithmetic.AddUnsigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_0_2_1() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x + y);
            var testImpl = (ArithmeticOperations.Operation_U2_U2_MapsTo_U2Checked_WithSignature_U_I_U_I_MapsTo_U_I)DoubleArithmetic.AddUnsigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_U2_U2_MapsTo_U2Checked_WithSignature_U_I_U_I_MapsTo_U_I),
                    nameof(DoubleArithmetic.AddUnsigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_0_2_2() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x + y);
            var testImpl = (ArithmeticOperations.Operation_U2_U2_MapsTo_U2Checked_WithSignature_I_U_I_U_MapsTo_I_U)DoubleArithmetic.AddUnsigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_U2_U2_MapsTo_U2Checked_WithSignature_I_U_I_U_MapsTo_I_U),
                    nameof(DoubleArithmetic.AddUnsigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_0_2_3() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x + y);
            var testImpl = (ArithmeticOperations.Operation_U2_U2_MapsTo_U2Checked_WithSignature_U_U_U_U_MapsTo_U_U)DoubleArithmetic.AddUnsigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_U2_U2_MapsTo_U2Checked_WithSignature_U_U_U_U_MapsTo_U_U),
                    nameof(DoubleArithmetic.AddUnsigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_1_0_0() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x - y);
            var testImpl = (ArithmeticOperations.Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_I_I_I_I_MapsTo_I_I)DoubleArithmetic.SubtractUnchecked;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_I_I_I_I_MapsTo_I_I),
                    nameof(DoubleArithmetic.SubtractUnchecked)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_1_0_1() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x - y);
            var testImpl = (ArithmeticOperations.Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_U_I_U_I_MapsTo_U_I)DoubleArithmetic.SubtractUnchecked;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_U_I_U_I_MapsTo_U_I),
                    nameof(DoubleArithmetic.SubtractUnchecked)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_1_0_2() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x - y);
            var testImpl = (ArithmeticOperations.Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_I_U_I_U_MapsTo_I_U)DoubleArithmetic.SubtractUnchecked;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_I_U_I_U_MapsTo_I_U),
                    nameof(DoubleArithmetic.SubtractUnchecked)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_1_0_3() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x - y);
            var testImpl = (ArithmeticOperations.Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_U_U_U_U_MapsTo_U_U)DoubleArithmetic.SubtractUnchecked;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_U_U_U_U_MapsTo_U_U),
                    nameof(DoubleArithmetic.SubtractUnchecked)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_1_1_0() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x - y);
            var testImpl = (ArithmeticOperations.Operation_I2_I2_MapsTo_I2Checked_WithSignature_I_I_I_I_MapsTo_I_I)DoubleArithmetic.SubtractSigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_I2_MapsTo_I2Checked_WithSignature_I_I_I_I_MapsTo_I_I),
                    nameof(DoubleArithmetic.SubtractSigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_1_1_1() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x - y);
            var testImpl = (ArithmeticOperations.Operation_I2_I2_MapsTo_I2Checked_WithSignature_U_I_U_I_MapsTo_U_I)DoubleArithmetic.SubtractSigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_I2_MapsTo_I2Checked_WithSignature_U_I_U_I_MapsTo_U_I),
                    nameof(DoubleArithmetic.SubtractSigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_1_1_2() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x - y);
            var testImpl = (ArithmeticOperations.Operation_I2_I2_MapsTo_I2Checked_WithSignature_I_U_I_U_MapsTo_I_U)DoubleArithmetic.SubtractSigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_I2_MapsTo_I2Checked_WithSignature_I_U_I_U_MapsTo_I_U),
                    nameof(DoubleArithmetic.SubtractSigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_1_1_3() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x - y);
            var testImpl = (ArithmeticOperations.Operation_I2_I2_MapsTo_I2Checked_WithSignature_U_U_U_U_MapsTo_U_U)DoubleArithmetic.SubtractSigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_I2_MapsTo_I2Checked_WithSignature_U_U_U_U_MapsTo_U_U),
                    nameof(DoubleArithmetic.SubtractSigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_1_2_0() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x - y);
            var testImpl = (ArithmeticOperations.Operation_U2_U2_MapsTo_U2Checked_WithSignature_I_I_I_I_MapsTo_I_I)DoubleArithmetic.SubtractUnsigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_U2_U2_MapsTo_U2Checked_WithSignature_I_I_I_I_MapsTo_I_I),
                    nameof(DoubleArithmetic.SubtractUnsigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_1_2_1() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x - y);
            var testImpl = (ArithmeticOperations.Operation_U2_U2_MapsTo_U2Checked_WithSignature_U_I_U_I_MapsTo_U_I)DoubleArithmetic.SubtractUnsigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_U2_U2_MapsTo_U2Checked_WithSignature_U_I_U_I_MapsTo_U_I),
                    nameof(DoubleArithmetic.SubtractUnsigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_1_2_2() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x - y);
            var testImpl = (ArithmeticOperations.Operation_U2_U2_MapsTo_U2Checked_WithSignature_I_U_I_U_MapsTo_I_U)DoubleArithmetic.SubtractUnsigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_U2_U2_MapsTo_U2Checked_WithSignature_I_U_I_U_MapsTo_I_U),
                    nameof(DoubleArithmetic.SubtractUnsigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_1_2_3() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x - y);
            var testImpl = (ArithmeticOperations.Operation_U2_U2_MapsTo_U2Checked_WithSignature_U_U_U_U_MapsTo_U_U)DoubleArithmetic.SubtractUnsigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_U2_U2_MapsTo_U2Checked_WithSignature_U_U_U_U_MapsTo_U_U),
                    nameof(DoubleArithmetic.SubtractUnsigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_2_0_0() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x * y);
            var testImpl = (ArithmeticOperations.Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_I_I_I_I_MapsTo_I_I)DoubleArithmetic.MultiplyUnchecked;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_I_I_I_I_MapsTo_I_I),
                    nameof(DoubleArithmetic.MultiplyUnchecked)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_2_0_1() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x * y);
            var testImpl = (ArithmeticOperations.Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_U_I_U_I_MapsTo_U_I)DoubleArithmetic.MultiplyUnchecked;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_U_I_U_I_MapsTo_U_I),
                    nameof(DoubleArithmetic.MultiplyUnchecked)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_2_0_2() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x * y);
            var testImpl = (ArithmeticOperations.Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_I_U_I_U_MapsTo_I_U)DoubleArithmetic.MultiplyUnchecked;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_I_U_I_U_MapsTo_I_U),
                    nameof(DoubleArithmetic.MultiplyUnchecked)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_2_0_3() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x * y);
            var testImpl = (ArithmeticOperations.Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_U_U_U_U_MapsTo_U_U)DoubleArithmetic.MultiplyUnchecked;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_I2_MapsTo_I2Unchecked_WithSignature_U_U_U_U_MapsTo_U_U),
                    nameof(DoubleArithmetic.MultiplyUnchecked)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_2_1_0() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x * y);
            var testImpl = (ArithmeticOperations.Operation_I2_I2_MapsTo_I2Checked_WithSignature_I_I_I_I_MapsTo_I_I)DoubleArithmetic.MultiplySigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_I2_MapsTo_I2Checked_WithSignature_I_I_I_I_MapsTo_I_I),
                    nameof(DoubleArithmetic.MultiplySigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_2_1_1() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x * y);
            var testImpl = (ArithmeticOperations.Operation_I2_I2_MapsTo_I2Checked_WithSignature_U_I_U_I_MapsTo_U_I)DoubleArithmetic.MultiplySigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_I2_MapsTo_I2Checked_WithSignature_U_I_U_I_MapsTo_U_I),
                    nameof(DoubleArithmetic.MultiplySigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_2_1_2() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x * y);
            var testImpl = (ArithmeticOperations.Operation_I2_I2_MapsTo_I2Checked_WithSignature_I_U_I_U_MapsTo_I_U)DoubleArithmetic.MultiplySigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_I2_MapsTo_I2Checked_WithSignature_I_U_I_U_MapsTo_I_U),
                    nameof(DoubleArithmetic.MultiplySigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_2_1_3() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x * y);
            var testImpl = (ArithmeticOperations.Operation_I2_I2_MapsTo_I2Checked_WithSignature_U_U_U_U_MapsTo_U_U)DoubleArithmetic.MultiplySigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_I2_MapsTo_I2Checked_WithSignature_U_U_U_U_MapsTo_U_U),
                    nameof(DoubleArithmetic.MultiplySigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_2_2_0() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x * y);
            var testImpl = (ArithmeticOperations.Operation_U2_U2_MapsTo_U2Checked_WithSignature_I_I_I_I_MapsTo_I_I)DoubleArithmetic.MultiplyUnsigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_U2_U2_MapsTo_U2Checked_WithSignature_I_I_I_I_MapsTo_I_I),
                    nameof(DoubleArithmetic.MultiplyUnsigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_2_2_1() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x * y);
            var testImpl = (ArithmeticOperations.Operation_U2_U2_MapsTo_U2Checked_WithSignature_U_I_U_I_MapsTo_U_I)DoubleArithmetic.MultiplyUnsigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_U2_U2_MapsTo_U2Checked_WithSignature_U_I_U_I_MapsTo_U_I),
                    nameof(DoubleArithmetic.MultiplyUnsigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_2_2_2() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x * y);
            var testImpl = (ArithmeticOperations.Operation_U2_U2_MapsTo_U2Checked_WithSignature_I_U_I_U_MapsTo_I_U)DoubleArithmetic.MultiplyUnsigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_U2_U2_MapsTo_U2Checked_WithSignature_I_U_I_U_MapsTo_I_U),
                    nameof(DoubleArithmetic.MultiplyUnsigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_1_2_2_3() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_IX_MapsTo_IX)((x, y) => x * y);
            var testImpl = (ArithmeticOperations.Operation_U2_U2_MapsTo_U2Checked_WithSignature_U_U_U_U_MapsTo_U_U)DoubleArithmetic.MultiplyUnsigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_U2_U2_MapsTo_U2Checked_WithSignature_U_U_U_U_MapsTo_U_U),
                    nameof(DoubleArithmetic.MultiplyUnsigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_4_0_0_0() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_int_MapsTo_IX)((x, y) => x >> y);
            var testImpl = (ArithmeticOperations.Operation_I2_int_MapsTo_I2Unchecked_WithSignature_I_I_int_MapsTo_I_I)DoubleArithmetic.ShiftRightSigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_int_MapsTo_I2Unchecked_WithSignature_I_I_int_MapsTo_I_I),
                    nameof(DoubleArithmetic.ShiftRightSigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_4_0_0_1() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_int_MapsTo_IX)((x, y) => x >> y);
            var testImpl = (ArithmeticOperations.Operation_I2_int_MapsTo_I2Unchecked_WithSignature_U_I_int_MapsTo_U_I)DoubleArithmetic.ShiftRightSigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_int_MapsTo_I2Unchecked_WithSignature_U_I_int_MapsTo_U_I),
                    nameof(DoubleArithmetic.ShiftRightSigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_4_0_0_2() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_int_MapsTo_IX)((x, y) => x >> y);
            var testImpl = (ArithmeticOperations.Operation_I2_int_MapsTo_I2Unchecked_WithSignature_I_U_int_MapsTo_I_U)DoubleArithmetic.ShiftRightSigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_int_MapsTo_I2Unchecked_WithSignature_I_U_int_MapsTo_I_U),
                    nameof(DoubleArithmetic.ShiftRightSigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_4_0_0_3() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_int_MapsTo_IX)((x, y) => x >> y);
            var testImpl = (ArithmeticOperations.Operation_I2_int_MapsTo_I2Unchecked_WithSignature_U_U_int_MapsTo_U_U)DoubleArithmetic.ShiftRightSigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_int_MapsTo_I2Unchecked_WithSignature_U_U_int_MapsTo_U_U),
                    nameof(DoubleArithmetic.ShiftRightSigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_4_0_1_0() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_int_MapsTo_IX)((x, y) => x >> y);
            var testImpl = (ArithmeticOperations.Operation_U2_int_MapsTo_U2Unchecked_WithSignature_I_I_int_MapsTo_I_I)DoubleArithmetic.ShiftRightUnsigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_U2_int_MapsTo_U2Unchecked_WithSignature_I_I_int_MapsTo_I_I),
                    nameof(DoubleArithmetic.ShiftRightUnsigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_4_0_1_1() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_int_MapsTo_IX)((x, y) => x >> y);
            var testImpl = (ArithmeticOperations.Operation_U2_int_MapsTo_U2Unchecked_WithSignature_U_I_int_MapsTo_U_I)DoubleArithmetic.ShiftRightUnsigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_U2_int_MapsTo_U2Unchecked_WithSignature_U_I_int_MapsTo_U_I),
                    nameof(DoubleArithmetic.ShiftRightUnsigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_4_0_1_2() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_int_MapsTo_IX)((x, y) => x >> y);
            var testImpl = (ArithmeticOperations.Operation_U2_int_MapsTo_U2Unchecked_WithSignature_I_U_int_MapsTo_I_U)DoubleArithmetic.ShiftRightUnsigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_U2_int_MapsTo_U2Unchecked_WithSignature_I_U_int_MapsTo_I_U),
                    nameof(DoubleArithmetic.ShiftRightUnsigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_4_0_1_3() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_int_MapsTo_IX)((x, y) => x >> y);
            var testImpl = (ArithmeticOperations.Operation_U2_int_MapsTo_U2Unchecked_WithSignature_U_U_int_MapsTo_U_U)DoubleArithmetic.ShiftRightUnsigned;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_U2_int_MapsTo_U2Unchecked_WithSignature_U_U_int_MapsTo_U_U),
                    nameof(DoubleArithmetic.ShiftRightUnsigned)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_5_0_0_0() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_int_MapsTo_IX)((x, y) => x << y);
            var testImpl = (ArithmeticOperations.Operation_I2_int_MapsTo_I2Unchecked_WithSignature_I_I_int_MapsTo_I_I)DoubleArithmetic.ShiftLeft;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_int_MapsTo_I2Unchecked_WithSignature_I_I_int_MapsTo_I_I),
                    nameof(DoubleArithmetic.ShiftLeft)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_5_0_0_1() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_int_MapsTo_IX)((x, y) => x << y);
            var testImpl = (ArithmeticOperations.Operation_I2_int_MapsTo_I2Unchecked_WithSignature_U_I_int_MapsTo_U_I)DoubleArithmetic.ShiftLeft;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_int_MapsTo_I2Unchecked_WithSignature_U_I_int_MapsTo_U_I),
                    nameof(DoubleArithmetic.ShiftLeft)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_5_0_0_2() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_int_MapsTo_IX)((x, y) => x << y);
            var testImpl = (ArithmeticOperations.Operation_I2_int_MapsTo_I2Unchecked_WithSignature_I_U_int_MapsTo_I_U)DoubleArithmetic.ShiftLeft;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_int_MapsTo_I2Unchecked_WithSignature_I_U_int_MapsTo_I_U),
                    nameof(DoubleArithmetic.ShiftLeft)));
				Assert.True(false, sb.ToString());
            }
        }
        
        [Fact]
        public void Test_5_0_0_3() {
            var referenceImpl = (ArithmeticOperations.Operation_IX_int_MapsTo_IX)((x, y) => x << y);
            var testImpl = (ArithmeticOperations.Operation_I2_int_MapsTo_I2Unchecked_WithSignature_U_U_int_MapsTo_U_U)DoubleArithmetic.ShiftLeft;
            var b = TestModule.TestOperation(referenceImpl, testImpl);
            if (!b) {
                var sb = new StringBuilder();
                sb.AppendLine(string.Format(
                    "!!! {1}\r\n\t{0}",
                    nameof(ArithmeticOperations.Operation_I2_int_MapsTo_I2Unchecked_WithSignature_U_U_int_MapsTo_U_U),
                    nameof(DoubleArithmetic.ShiftLeft)));
				Assert.True(false, sb.ToString());
            }
        }
    }
}

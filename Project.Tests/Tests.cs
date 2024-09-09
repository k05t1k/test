using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project;
using System;

namespace PasswordValidation.Tests
{
    [TestClass]
    public class PasswordTests
    {
        private PasswordValidator _passwordValidator;

        [TestInitialize]
        public void TestInitialize()
        {
            _passwordValidator = new PasswordValidator();
        }

        [TestMethod]
        public void EvaluatePasswordStrength_ContainsDigit_Returns1()
        {
            int result = _passwordValidator.EvaluatePasswordStrength("123");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void EvaluatePasswordStrength_ContainsLowercaseLetter_Returns2()
        {
            int result = _passwordValidator.EvaluatePasswordStrength("abc123");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void EvaluatePasswordStrength_ContainsUppercaseLetter_Returns3()
        {
            int result = _passwordValidator.EvaluatePasswordStrength("Abc123");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void EvaluatePasswordStrength_ContainsSpecialCharacter_Returns4()
        {
            int result = _passwordValidator.EvaluatePasswordStrength("Abc123@#");
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void EvaluatePasswordStrength_LengthMoreThan10_Returns5()
        {
            int result = _passwordValidator.EvaluatePasswordStrength("A1b2c3d4e5f6!");
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void EvaluatePasswordStrength_NoCriteriaMet_Returns0()
        {
            int result = _passwordValidator.EvaluatePasswordStrength("");
            Assert.AreEqual(0, result);
        }

        static void Main() 
        {
        
        }
    }
}

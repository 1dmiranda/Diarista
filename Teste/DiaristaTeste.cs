using System;
using Diarista.Functions;
using Diarista.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Teste
{
    [TestClass]
    public class DiaristaTest
    {
        [TestMethod]
        public void TestLogin()
        {
            User user = Authentication.Login("barbosamiranda418@hotmail.com", "123");

            Assert.AreEqual("barbosamiranda418@hotmail.com", user.Email);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestLoginException()
        {
            User user = Authentication.Login("barbosa@hotmail.com", "123");

        }
    }
}

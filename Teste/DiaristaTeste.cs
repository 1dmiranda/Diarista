using System;
using System.Web.Mvc;
using Diarista.Controllers;
using Diarista.Data;
using Diarista.Functions;
using Diarista.Models;
using Diarista.ViewModels;
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
            Assert.AreEqual("123", user.Password);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestLoginExceptionUser()
        {
            User user = Authentication.Login("barbosa@hotmail.com", "123");

            Assert.AreEqual("barbosamiranda418@hotmail.com", user.Email);
            Assert.AreEqual("123", user.Password);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestLoginExceptionPassword()
        {
            User user = Authentication.Login("barbosamiranda418@hotmail.com", "1234");

            Assert.AreEqual("barbosamiranda418@hotmail.com", user.Email);
            Assert.AreEqual("123", user.Password);
        }
    }
}

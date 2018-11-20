using System;
using Diarista.Controllers;
using System.Web.Mvc;
using Diarista.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Diarista.Tests
{
    [TestClass]
    public class Testes
    {
        [TestMethod]
        public void TestLogin()
        {
            var controller = new AuthenticationController();
            var user = controller.Login("barbosamiranda418@hotmail.com", "123", null) as ViewResult;
            var userTest = (User) user.ViewData.Model;

            Assert.AreEqual("barbosamiranda418@hotmail.com", userTest.Email);
            
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestLoginException()
        {
            var controller = new AuthenticationController();
            var user = controller.Login("barbosa123@hotmail.com", "123", null) as ViewResult;
            var user2 = (User)user.ViewData.Model;
        }

    }
}

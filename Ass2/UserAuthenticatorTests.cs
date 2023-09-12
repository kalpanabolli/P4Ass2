using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nunit;
using NUnit.Framework;

namespace Ass2
{
    [TestFixture]
    public class UserAuthenticatorTests
    {
        public UserAuthenticator authenticator;

        [SetUp]
        public void Setup()
        {
            authenticator = new UserAuthenticator();
        }

        [Test]
        public void TestUserRegistration()
        {
            Assert.IsTrue(authenticator.RegisterUser("user1", "pwd1"));
            Assert.IsFalse(authenticator.RegisterUser("user1", "pwd2")); 
        }

        [Test]
        public void TestUserLogin()
        {
            authenticator.RegisterUser("user3", "pwd3");

            Assert.IsTrue(authenticator.LoginUser("user3", "pwd3"));
            Assert.IsFalse(authenticator.LoginUser("user3", "wrongpwd")); 
            Assert.IsFalse(authenticator.LoginUser("nonexistentuser", "pwd")); 
        }

        [Test]
        public void TestPasswordReset()
        {
            authenticator.RegisterUser("user4", "pwd4");

            Assert.IsTrue(authenticator.ResetPassword("user4", "newpwd"));
            Assert.IsFalse(authenticator.ResetPassword("nonexistentuser", "newpwd")); 
        }
    }
}


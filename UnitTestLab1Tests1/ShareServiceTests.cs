using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestLab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestLab1.Tests
{
    [TestClass()]
    public class ShareServiceTests
    {
        [TestMethod()]
        public void ValidateMemberNoAccountTest_傳入帳號密碼_若無此帳號_回傳NoAccount()
        {
            ShareService shareService = new ShareService();
            string account = "";
            string password = "";
            string expected = "";
            string actual = "";
            account = "adminErr";
            password = "admin123";
            expected = "No Account!";
            actual = shareService.ValidateMemberNoAccount(account, password);

            Assert.AreEqual(expected, actual);


        }

        [TestMethod()]
        public void ValidateMemberPasswordErrorTest_傳入帳號密碼_若有此帳號但密碼錯誤_回傳PasswordError()
        {
            ShareService shareService = new ShareService();
            string account = "";
            string password = "";
            string expected = "";
            string actual = "";
            account = "admin";
            password = "adminErr";
            expected = "Password Error!";
            actual = shareService.ValidateMemberPasswordError(account, password);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ValidateMemberSuccessTest_傳入帳號密碼_若有此帳號且密碼正確_回傳Success()
        {
            ShareService shareService = new ShareService();
            string account = "";
            string password = "";
            string expected = "";
            string actual = "";
            account = "admin";
            password = "admin123";
            expected = "Success!";
            actual = shareService.ValidateMemberSuccess(account, password);

            Assert.AreEqual(expected, actual);
        }
    }
}
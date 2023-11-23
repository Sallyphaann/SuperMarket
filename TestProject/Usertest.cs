using BusinessLogic;
using BusinessLogic.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockDataAccessLayer;
using System;

namespace TestProject
{
    [TestClass]
    public class Usertest
    {
        private static MockUserDAL mockUser = new MockUserDAL();
        private readonly UserAdministration userAdmin = new UserAdministration(mockUser);
        [TestMethod]
        public void TestAddAdmin()
        {
            Admin admin = new Admin("david", "phan", "davidphan@gmail.com", "121Hk Amsterdam", "David", "123", "123", "Admin");
            bool result = userAdmin.AddAdmin(admin);
            Assert.AreEqual(true, result);

        }
        [TestMethod]
        public void TestAddMember()
        {
            Member member = new Member("maria", "Smith", "maria@gmail.com", "2578 KH Hilversum", "maria", "456", "456", "Loving freedom");
            Member member1 = new Member("Jenny", "Le", "Jenny@gmail.com", "USA", "jennyle", "456", "456", "love peace");

            bool result = userAdmin.AddMember(member);
            bool result1 = userAdmin.AddMember(member1);
            Assert.AreEqual(true, result);
            Assert.AreEqual(false, result1);
        }

        [TestMethod]
        public void TestConstructor()
        {
            UserAdministration userAdministrator = new UserAdministration(new MockUserDAL());
            Assert.ReferenceEquals(userAdministrator, userAdmin);
        }
        [TestMethod]
        public void TestCheckLogin()
        {
            try
            {
                var result = userAdmin.CanLogin("Luka", "789");
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "Failed to authenticate.");
            }

        }
        [TestMethod]
        public void TestGetid()
        {
              string username = "Luka";
              int id = userAdmin.Getid(username);
              Assert.AreEqual(2, id);
        }



    }
}
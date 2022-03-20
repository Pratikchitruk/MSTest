using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTest;

namespace MsTestUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            FirstName home = new FirstName();
            string result = home.GetFirstName(1);
            Assert.AreEqual(result, "pratik");
        }

        public void TestMethod2()
        {
            LastName home = new LastName();
            string result = home.GetLastName(1);
            Assert.AreEqual(result, "chitruk");

        }

        public void TestMethod3()
        {
            Email email = new Email();
            string result = email.GetEmail(1);
            Assert.AreEqual(result, "pratik.chitruk@gmail.com");
        }

        public void TestMethod4()
        { 
        MobileNo mobileNo = new MobileNo();
            string result = mobileNo.GetPhoneNo(1);
            Assert.AreEqual(result, "8208508814");
        
        }
        public void testMethod5()
        {
        Password password = new Password();
            string result = password.GetPassword(1);
            Assert.AreEqual(result, "1234567");
        
        }



    }
}



        
   
    

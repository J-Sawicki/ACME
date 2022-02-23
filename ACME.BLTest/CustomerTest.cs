using ACME.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACME.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "James",
                LastName = "Delaney"
            };
            string expected = "Delaney, James";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                LastName = "Delaney"
            };
            string expected = "Delaney";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "James"
            };
            string expected = "James";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void StaticTest()
        {
            //-- Arrange
            var c1 = new Customer();
            Customer.InstanceCount++;

            var c2 = new Customer();
            Customer.InstanceCount++;
            
            var c3 = new Customer();
            Customer.InstanceCount++;

            //--Act

            //--Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }
    }
}

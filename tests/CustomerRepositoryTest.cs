using ACM.BL;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //-- Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1) //by inserting 1 as parameter same as we would write below  customerId = 1 
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins"
            }; //object initializor syntax

            //-- Act
            var actual = customerRepository.Retrieve(1);


            //-- Assert

            //Assert.AreEqual(expected, actual); 
            //will fail test
            //because even if we are comparing the same property value
            // it is not the same objects and are not equal

            //one way is to compare each property
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);



        }
    }

}

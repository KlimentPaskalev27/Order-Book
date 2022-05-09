using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {
                
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }
        public int CustomerId { get; private set; } //we want to get the ID but never set it

        //everytime we define a property
        private string _lastName; //define a variable to hold the value aka Backing Field

        //Property with get and set accessor
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        //Now lets define the First Name property with the accessor shorthand
        //Auto-implemented property
        public string FirstName { get; set; }
        // behind the scenes, a Backing Field is created but we dont need to manage it.

        //Using snippets Edit-IntelliSense-Insert Snippet  or Right click-Snippet- Insert snippet
        //for a property snippet select the Visual C#- prop
        //propfull is with full code of get set
        //propg is public getter with private setter
        public string EmailAddress { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public static int InstanceCount { get; set; }
        //static denotes that the class member belongs to the class itself rather than a specific instance



        /// <summary>
        /// Validates the customer data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }


        ///<summary>
        /// Retrieve one customer.
        /// </summary>
        public Customer Retrieve(int customerId)
        {
            //Code that retrieves the defined customer

            return new Customer();
        }


        ///<summary>
        /// Retrieve all customer.
        /// </summary>
        public List<Customer> Retrieve()
        {
            //Code that retrieves all of the customers

            return new List<Customer>();
        }


        /// <summary>
        /// Saves current customer.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //Code that saves the defined customer

            return true;
        }
    }
}

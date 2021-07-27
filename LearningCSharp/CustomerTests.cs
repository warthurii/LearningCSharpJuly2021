using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LearningCSharp
{
    public class CustomerTests
    {
        [Fact]
        public void CreatingAnInstanceOfAClass()
        {
            var bob = new Customer();
            bob.Name = "Robert Smith";
           // bob.SetName("Robert Smith");

            var sue = new Customer();
            sue.Name = "Sue Jones";

            Assert.Equal("Robert Smith", bob.Name);
            Assert.Equal("Sue Jones", sue.Name);
            Assert.Equal(5000M, sue.AvailableCredit);

            var myBirthday = new DateTime(1969, 4, 20, 11,59,00);

            var today = DateTime.Now;


        }
    }

    public class Customer
    {
        private string _name; // "backing field"
        private decimal _availableCredit = 5000;
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public decimal AvailableCredit
        {
            get
            {
                return _availableCredit;
            }
        }

        public string EmailAddress { get; set; } // Auto Property

        public string GetInfo()
        {
            return $"Customer {Name} has an availble Credit of {AvailableCredit:c} and can be reached at {EmailAddress}";
        }
    }
}

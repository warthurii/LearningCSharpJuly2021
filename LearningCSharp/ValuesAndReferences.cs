using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace LearningCSharp
{
    public class ValuesAndReferences
    {
        [Fact]
        public void SomeExamples()
        {
            // old skool
            int age;
            age = 32;

            Assert.Equal(32, age);
            age = 33;
            age += 5; // age = age + 5;
            Assert.Equal(38, age);

            Int32 yourAge = 24;
            Assert.Equal(24, yourAge);

            ValuesAndReferences me;


            string name = "Bob";
            String yourName = "Sue";
            decimal myPay = 22.53M;

            // 3.0 (2008) they added the "var" keyword for implicitly typed local variables
            var hisName = "Roger";
            ///hisName = 1138;
            var yourPay = 18.53M;




        }

        [Fact]
        public void AssignmentWithValueTypes()
        {
            int x = 10;
            int y = x;

            y = 12;

            Assert.Equal(10, x);
        }
        [Fact]
        public void AssignmentWithReferenceTypes()
        {
            Dog x = new Dog();
            x.Name = "Fido";

            Dog y = x;
            y.Name = "Rover";

            Assert.Equal("Rover", x.Name);
        }

        [Fact]
        public void WashingTheDog()
        {
            var d = new Dog() { Name = "Java" }; // that is an object initializer.

            var g = new DogGroomer();

            g.WashTheDog(d);

            Assert.NotEqual("Java", d.Name);
        }

        [Fact]
        public void WashingTheInteger()
        {
            var x = 32;

            var g = new DogGroomer();

            g.WashTheNumber(ref x);

            Assert.Equal(64, x);
        }
        [Fact]
        public void SwappingSomeNumbers()
        {
            var x = 10;
            var y = 20;

            // Step 2: Magic!
            Swap<int>(ref x, ref y);
            Assert.Equal(20, x);
            Assert.Equal(10, y);


            var x2 = "Joe";
            var y2 = "Sue";

            // ??
            Swap<string>(ref x2, ref y2);

            Assert.Equal("Sue", x2);
            Assert.Equal("Joe", y2);
        }

        public void Swap<T>(ref T x, ref T y)
        {
            var temp = x;
            x = y;
            y = temp;
        }
        // overload

    }

    public class Dog
    {
        public string Name; // this is a public field. bad idea. more later.
    }

}

using System;
using System.Collections.Generic;
using System.Text;
using checke;
using Xunit;

namespace CourseApp.Tests
{
    class Class1
    {
        public class Persontest
        {
            [Fact]
            public void Test1()
            {
                Person person1 = new Person(18, "leha");
                Assert.Equal(18, person1.Age);
                Assert.Equal("leha", person1.Name);
            }

            [Fact]
            public void Test2()
            {
                Person person1 = new Person(18);
                Assert.Equal(18, person1.Age);
            }

            [Fact]
            public void Test3()
            {
                Person person2 = new Person(18);
                Assert.Equal(18, person2.Age);
            }

            [Fact]
            public void Test4()
            {
                Person person2 = new Person(18);
                Assert.Equal(18, Person.Age);
                person2.Age = 23;
                Assert.Equal(23, person2.Age);
            }

            [Fact]
            public void TestNameSet()
            {
                Person person2 = new Person(18);
                person2.Name = "Anton";
                Assert.Equal("Anton", person2.Name);
            }

            [Fact]
            public void TestNegativeAge()
            {
                Person person2 = new Person(18);
                Assert.Equal(18, person2.Age);
                person2.Age = -23;
                Assert.Equal(18, person2.Age);
            }

            [Fact]
            public void TestGetInfo()
            {
                Person person2 = new Person(18);
                var exp = "Имя: Noname  Возраст: 18";
                Assert.Equal(exp, person2.GetInfo());
            }

            [Fact]
            public void TestNegativAgeInConstructor()
            {
                Person person2 = new Person(-118);
                Assert.Equal(0, person2.Age);
            }
        }
    }
}
}

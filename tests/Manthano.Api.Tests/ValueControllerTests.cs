using System.Linq;
using FluentAssertions;
using Manthano.Api.Controllers;
using NUnit.Framework;

namespace Manthano.Api.Tests
{
    public class ValueControllerTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void GetValues_Test()
        {
            var sut = new ValuesController();
            var values = sut.Get();
            values.Count().Should().Be(2);
        }
    }
}
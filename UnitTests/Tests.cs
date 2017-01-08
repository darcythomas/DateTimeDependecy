using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependableDateTime;
using FluentAssertions;
using Xunit;

namespace UnitTests
{
    public class Tests
    {
        [Fact]
        public void TestBasics()
        {
            true.Should().BeTrue();
        }
        [Fact]
        public void CanGetDateTimeOffsetNow()
        {
            IDateTimeOffSet sut = new DateTimeOffsetProvider();

            sut.Now.ShouldBeEquivalentTo(DateTimeOffset.Now);
            sut.UtcNow.ShouldBeEquivalentTo(DateTimeOffset.UtcNow);
        }
    }
}

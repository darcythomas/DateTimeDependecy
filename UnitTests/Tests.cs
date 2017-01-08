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
            (new Class1()).Truth.Should().BeTrue();
        }
    }
}

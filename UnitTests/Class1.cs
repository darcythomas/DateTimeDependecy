using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace UnitTests
{
    public class Class1
    {
        [Fact]
        public void TestBasics()
        {
            true.Should().BeTrue();
        }
    }
}

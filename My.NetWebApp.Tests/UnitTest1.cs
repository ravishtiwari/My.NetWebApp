using System;
using Xunit;

namespace My.NetWebApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var user = "User";
            Xunit.Assert.Equal("User", user);
        }
    }
}

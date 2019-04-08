using RazorApp.Pages;
using System;
using Xunit;

namespace RazorApp.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            IndexModel index = new IndexModel();
            index.OnGet();
        }
    }
}

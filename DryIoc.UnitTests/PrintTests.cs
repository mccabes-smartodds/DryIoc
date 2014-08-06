﻿using System.Text;
using NUnit.Framework;

namespace DryIoc.UnitTests
{
    [TestFixture]
    public class PrintTests
    {
        [Test]
        public void Print_enumerable_should_print_empty_string_for_empty_enumerable()
        {
            Assert.That(new StringBuilder().Print(new object[0]).ToString(), Is.Empty);
        }
    }
}

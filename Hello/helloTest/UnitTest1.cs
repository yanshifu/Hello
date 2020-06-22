using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hello;
namespace helloTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			Assert.AreEqual("Hello World", Program.createMessage());
		}
	}
}

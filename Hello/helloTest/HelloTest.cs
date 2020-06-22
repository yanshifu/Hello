using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hello;
namespace helloTest
{
	[TestClass]
	public class HelloTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			Assert.AreEqual("Hello WestWorld", Program.createMessage());
		}
	}
}

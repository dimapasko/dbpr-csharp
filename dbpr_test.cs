using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace dbpr
{
	[TestClass]
	public class dbpr_test
	{
		[TestMethod]
		public void TestNyx()
		{
			var nyx = "nyx";
			AreEqual(nyx, nyx);
		}
	}
}

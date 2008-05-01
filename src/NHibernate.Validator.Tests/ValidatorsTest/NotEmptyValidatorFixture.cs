using System.Collections.Generic;
using NUnit.Framework;

namespace NHibernate.Validator.Tests.ValidatorsTest
{
	[TestFixture]
	public class NotEmptyValidatorFixture
	{
		[Test]
		public void IsValid()
		{
			NotNullOrEmptyValidator v = new NotNullOrEmptyValidator();
			Assert.IsTrue(v.IsValid("abc"));
			Assert.IsTrue(v.IsValid(new int[] { 1 }));
			Assert.IsTrue(v.IsValid(new List<int>(new int[] { 1 })));

			Assert.IsFalse(v.IsValid(null));
			Assert.IsFalse(v.IsValid(""));
			Assert.IsFalse(v.IsValid(123));
			Assert.IsFalse(v.IsValid(new int[0]));
			Assert.IsFalse(v.IsValid(new List<int>()));
		}
	}
}
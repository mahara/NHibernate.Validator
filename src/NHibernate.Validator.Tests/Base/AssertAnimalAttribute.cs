using System;
using NHibernate.Validator.Engine;
using NHibernate.Validator.Tests.Base;

namespace NHibernate.Validator.Tests.Base
{
	[AttributeUsage(AttributeTargets.Class)]
	[ValidatorClass(typeof(AssertAnimalValidator))]
	public class AssertAnimalAttribute : Attribute, IHasMessage
	{
		private string message = "not an animal";

		public string Message
		{
			get { return message; }
			set { message = value; }
		}
	}

	public class AssertAnimalValidator : IInitializableValidator<AssertAnimalAttribute>
	{
		public bool IsValid(object value)
		{
			return value is Animal;
		}

		public void Initialize(AssertAnimalAttribute parameters)
		{
			
		}
	}
}
using ErrorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTests
{
	[TestClass]
	public class ABStest
	{
		public TestContext TestContext { get; set; }
		[DataSource("System.Data.SqlClient", @"Data Source=(local)\SQLEXPRESS;Initial Catalog=CalcDatabase;Integrated Security=True", "ABS", DataAccessMethod.Sequential)]
		[TestMethod]
		public void ABSmethod()
		{
			try
			{
				long test_value = Convert.ToInt64(TestContext.DataRow["test_value"]);
				long expected_value = 0;
				try
				{
					 expected_value = Convert.ToInt64(TestContext.DataRow["result_value"]);
				}
				catch
				{ }

				int result = CalcClassBr.CalcClass.ABS(test_value);
				Assert.AreEqual(expected_value, result);
			}
			catch (ArgumentOutOfRangeException ex) {
				Assert.AreEqual(ErrorsExpression.ERROR_06, ex.ParamName);
			}
		}
	}
}

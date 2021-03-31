using System;

namespace Plugins.MathUtils
{
	public static class ComparisonUtility
	{
		public static bool Compare<T>(T x, ComparisonOperator comparisonOperator, T y) where T : IComparable
		{
			return comparisonOperator switch
			{
				ComparisonOperator.EqualTo => x.CompareTo(y) == 0,
				ComparisonOperator.NotEqual => x.CompareTo(y) != 0,
				ComparisonOperator.GreaterThan => x.CompareTo(y) > 0,
				ComparisonOperator.GreaterThanOrEqualTo => x.CompareTo(y) >= 0,
				ComparisonOperator.LessThan => x.CompareTo(y) < 0,
				ComparisonOperator.LessThanOrEqualTo => x.CompareTo(y) <= 0,
				_ => throw new ArgumentOutOfRangeException()
			};
		}
	}
}
using System;

namespace Plugins.MathUtils {
	public static class ComparisonUtility<T> where T : IComparable {
		public static bool Compare(T x, ComparisonOperator comparisonOperator, T y) {
			return comparisonOperator switch {
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
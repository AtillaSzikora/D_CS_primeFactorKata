using System.Collections.Generic;

namespace PrimeFactorKata {
	public class PrimeFactors {

		public static List<int> PrimeFactorsGenerate(int number) {
			List<int> result = new List<int>();
			int divisor = 2;
			while (number > 1) {
				if (number % divisor == 0) {
					result.Add(divisor);
					number = number / divisor; }
				else { divisor++; } }
			return result; }

		private static void Main(string[] args) {}
	}
}
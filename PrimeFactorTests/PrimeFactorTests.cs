using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeFactorTests {
	[TestClass]
	public class PrimeFactorTests {

		[TestMethod]
		public void Zero_ReturnsEmptyList () {
			//Arrange
			List<int> result;
			//Act
			result = PrimeFactorKata.PrimeFactors.PrimeFactorsGenerate(0);
			//Assert
			CollectionAssert.AreEqual(result, new List<int>()); }

		[TestMethod]
		public void One_ReturnsEmptyList () {
			//Arrange
			List<int> result;
			//Act
			result = PrimeFactorKata.PrimeFactors.PrimeFactorsGenerate(1);
			//Assert
			CollectionAssert.AreEqual(result, new List<int>()); }

		[TestMethod]
		public void Two_ReturnsListWithValueOf2 () {
			//Arrange
			List<int> result;
			List<int> temp = new List<int>();
			//Act
			result = PrimeFactorKata.PrimeFactors.PrimeFactorsGenerate(2);
			//Assert
			temp.Add(2);
			CollectionAssert.AreEqual(result, temp); }

		[TestMethod]
		public void Three_ReturnsListWithValueOf3 () {
			//Arrange
			List<int> result;
			List<int> temp = new List<int>();
			//Act
			result = PrimeFactorKata.PrimeFactors.PrimeFactorsGenerate(3);
			//Assert
			temp.Add(3);
			CollectionAssert.AreEqual(result, temp); }

		[TestMethod]
		public void Four_ReturnsListWithValueOf2_2 () {
			//Arrange
			List<int> result;
			List<int> temp = new List<int>();
			//Act
			result = PrimeFactorKata.PrimeFactors.PrimeFactorsGenerate(4);
			//Assert
			temp.Add(2);
			temp.Add(2);
			CollectionAssert.AreEqual(result, temp); }

		[TestMethod]
		public void Six_ReturnsListWithValueOf2_3 () {
			//Arrange
			List<int> result;
			List<int> temp = new List<int>();
			//Act
			result = PrimeFactorKata.PrimeFactors.PrimeFactorsGenerate(6);
			//Assert
			temp.Add(2);
			temp.Add(3);
			CollectionAssert.AreEqual(result, temp); }

		[TestMethod]
		public void Nine_ReturnsListWithValueOf3_3 () {
			//Arrange
			List<int> result;
			List<int> temp = new List<int>();
			//Act
			result = PrimeFactorKata.PrimeFactors.PrimeFactorsGenerate(9);
			//Assert
			temp.Add(3);
			temp.Add(3);
			CollectionAssert.AreEqual(result, temp); }
	}
}
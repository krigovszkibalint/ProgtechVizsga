using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BehelyettesitesTeszt
{
	[TestClass]
	public class UnitTest1
	{
		// Minden A-t kicserél E-re
		[TestMethod]
		public void testReplaceAllAsWithEs()
		{
			string result;
			string bemenet = "alma";
			char keresettKarakter = 'a';
			char helyettesitoKarakter = 'e';
			int cserelendoElemek = 1;


			TDD.Behelyettesites behelyettesites = new TDD.Behelyettesites();
			result = behelyettesites.behelyettesit(bemenet, keresettKarakter, helyettesitoKarakter, cserelendoElemek);
			Assert.AreEqual("elme", result);

			bemenet = "almaaaaaaaaaaaaaaa";
			result = behelyettesites.behelyettesit(bemenet, keresettKarakter, helyettesitoKarakter, cserelendoElemek);
			Assert.AreEqual("elmeeeeeeeeeeeeeee", result);
		}
		// Minden 3. A-t kicserél K-ra
		[TestMethod]
		public void testReplaceEveryThirdAwithK()
		{
			string result;
			string bemenet = "almaaaaaaaaaaaaa";
			char keresettKarakter = 'a';
			char helyettesitoKarakter = 'k';
			int cserelendoElemek = 3;

			TDD.Behelyettesites behelyettesites = new TDD.Behelyettesites();
			result = behelyettesites.behelyettesit(bemenet, keresettKarakter, helyettesitoKarakter, cserelendoElemek);

			Assert.AreEqual("almakaakaakaakaa", result);
		}
		//
		[TestMethod]
		public void testNoCharsReplaced()
		{
			string result;
			string bemenet = "alma";
			char keresettKarakter = 'a';
			char helyettesitoKarakter = 'k';
			int cserelendoElemek = 0;

			TDD.Behelyettesites behelyettesites = new TDD.Behelyettesites();
			result = behelyettesites.behelyettesit(bemenet, keresettKarakter, helyettesitoKarakter, cserelendoElemek);
			Assert.AreEqual("alma", result);
		}

		[TestMethod]
		[ExpectedException(typeof(TDD.NullParamException))]
		public void testThrowsNullParamException()
		{
			string bemenet = null;
			char keresettKarakter = 'a';
			char helyettesitoKarakter = 'k';
			int cserelendoElemek = 0;
		}

		[TestMethod]
		[ExpectedException(typeof(TDD.NegativeParamException))]
		public void testNegativeException()
		{
			string bemenet = null;
			char keresettKarakter = 'a';
			char helyettesitoKarakter = 'k';
			int cserelendoElemek = 0;
		}
	}
}
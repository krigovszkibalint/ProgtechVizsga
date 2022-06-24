using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
	public class Behelyettesites
	{
		public string behelyettesit(string bemenet, char keresettElem, char csereKarakter, int csereSzam) {
		string result = "";
		
		if (csereSzam == 0)
			return bemenet;
		
		if (bemenet.Equals(null))
			throw new TDD.NullParamException();

		if (csereSzam< 0)
			throw new TDD.NegativeParamException();
		
		for (int i = 0; i<bemenet.Length; i++) 
		{

			if ((bemenet[i] == keresettElem) && (i % csereSzam == 0))
				result += csereKarakter;

			else
				result += bemenet[i];
		}
		return result;
	}
}
}

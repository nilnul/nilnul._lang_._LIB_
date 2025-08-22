using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.character.lang.s
{
	/// <summary>
	/// a lang contains exactly one str: the empty str.
	/// </summary>
	public partial class White:LangI
	{

		static public White Singleton = SingletonByDefault<White>.Instance;

		public IEnumerator<string> GetEnumerator()
		{
			yield return "";
			throw new NotImplementedException();
		}

	

		public bool contains(string element)
		{
			return element == "";
			throw new NotImplementedException();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.character.lang.set
{
	/// <summary>
	/// empty and white
	/// </summary>

	public partial class LangsGeneratedByEmptyAlphabet
		:nilnul.collection.SetI3<LangI>
	{


		public IEnumerator<LangI> GetEnumerator()
		{
			yield return lang.s.Empty.Singleton;
			yield return lang.s.White.Singleton;

		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();

			throw new NotImplementedException();
		}
	}
}

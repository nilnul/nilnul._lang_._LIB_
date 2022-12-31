using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.character.lang.set
{
	/// <summary>
	/// </summary>

	public partial class LangsGeneratedByZeroOnly
		:nilnul.collection.SetI3<LangI>
	{

		/// <summary>
		/// uncountable. So returned type IEnumerable is not right.
		/// </summary>
		/// <returns></returns>
		public IEnumerator<LangI> GetEnumerator()
		{
			///

			throw new NotImplementedException();

		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();

			throw new NotImplementedException();
		}
	}
}

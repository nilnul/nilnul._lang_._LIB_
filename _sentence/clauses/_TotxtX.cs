using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang._sentence.clauses
{

	/// <summary>
	/// 
	/// </summary>
	/// vs: <see cref="sentence_.primitives.IToTxt"/>
	/// 
	static public class _TxtenX
	{
		/// <summary>
		/// seal the clause.
		/// </summary>
		/// <remarks>
		/// sealed clause is a basic sentence;
		/// vs:'.', which is also used in <see cref="_lex.adage_._FloatedX.POINT"/>
		/// </remarks>
		public const char SEPARATOR = ';';
		static public readonly string Separator = SEPARATOR.ToString();
		static public string _Txten_0clauses(IEnumerable<string> clauses) {
			return string.Join(
				Separator
				,
				clauses
			);
		}

		static public string _Txten_pars0clauses(params string[] clauses) {
			return _Txten_0clauses(
				clauses
			);
		}



	}
}

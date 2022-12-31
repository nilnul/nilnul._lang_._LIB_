using nilnul.lang.eg.logic._lex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.eg.logic.parser._parenExt
{
	public class RecurInsideParen
	{

		/// <summary>
		/// single out every paren and process it.
		/// </summary>
		/// <param name="tokens"></param>
		/// <returns></returns>
		static public IEnumerable<_lex.token.str.List> Eval(_lex.token.str.List tokens) {
			var r = new _lex.token.str.List();
			foreach (var item in tokens)
			{
				if (item is _lex.token.LeftParen)
				{

					///split the following tokenings.
					/// 

					///
				}
				else
				{
					r.Add(item);
				}

			}


			throw new NotImplementedException();
		}

		static public IEnumerable<_lex.token.str.List> _Eval(_lex.token.str.List tokens_noParen) {

			var r = new _lex.token.str.List();



		}


	}

}

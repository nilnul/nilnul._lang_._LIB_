using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.eg.logic._lex.token.str
{
	static public class ToTxtX
	{
		static public string _ToTxt(IEnumerable<Symbol> _str) {
			return string.Join(",", _str);
		}
		static public string _ToTxt(IEnumerable<TokenI> _str) {
			return string.Join(",", _str);
		}


	}
}

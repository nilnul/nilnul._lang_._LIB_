using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.eg.logic._lex.token
{
	public class Priority : ord.InsideA<TokenI>
	{


		static public readonly Priority Instance = new Priority();

		public override bool inside(TokenI x, TokenI y)
		{



			throw new NotImplementedException();
		}

		public  bool inside(token.RightParen left, TokenI right) {
			return true;
		}



		public bool inside(token.Not a, token.Var1 b) {
			return false;
		}

		public bool inside(token.Not a, token.AtomicI b) {
			return false;
		}

		public bool inside(token.Not a, token.Not b) {
			return false;
		}

		public bool inside(token.Not a, token.DuoOpI b) {
			return true;
		}

		public bool inside(token.Not a, token.LeftParen b) {
			return false;
		}

		public bool priorTo(TokenI x, TokenI y) {

			return inside(x, y);

		}







		//public bool inside(token.AtomicI a, TokenI b) {

		//	if (b is )
		//	{

		//	}

		//}
	}
}

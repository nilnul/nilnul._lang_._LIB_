using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.eg.logic._parser
{



	public class Expr<TToken> :nilnul._lang._syntax.grammar_._parser.RuleI<SymbolI>{

		public SymbolI eval() {
			///read next
			/// if it's (, then  use ParenExpr
			/// 
			var token = read();

			if (token is lexer.LeftParen)
			{
				/// while not eof
				/// 
				/// (
				///  
				/// push expr
				/// while not right paren
				///		expr
				///  end
				///  return
				///  
				/// )
				/// error.
				/// 
				/// 
				/// if
				/// right paren. return.
				/// else 
				///		read next and determine.

			}
			else if(token is lexer.Not)
			{

			}
			else if(token is lexer.One)
			{

			}

			else if(token is lexer.Zero)
			{

			}

			else if (token is lexer.Var)
			{

			}
			else 
			{
				throw new Exception();	///error.
			}



			throw new NotImplementedException();
		}

		public TToken read() {
			throw new NotImplementedException();
		}

	}

	
}

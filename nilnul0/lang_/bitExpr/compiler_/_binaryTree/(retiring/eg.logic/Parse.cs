using nilnul.lang.eg.logic._lex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.eg.logic
{
	/// <summary>
	/// 
	/// </summary>
	public class Parse
	{
		IEnumerable<_lex.Symbol> tokens;

		Symbol lookahead;


		public void run() {



		}

		/// <summary>
		/// Expr:
		///		Atom	//a-z, 1,0
		///		ParenExpr	//(
		///		NotExpr		//!
		///		DuoCall		//
		/// 
		/// AtomOrDuoCall
		///		Atom	
		///		AtomArg_DuoCall
		///		DuoCall
		/// 
		/// DuoCall
		///		OrExpr
		///		AndExpr
		/// AndExpr
		///		AndArg & AndArg1
		/// AndArg1
		///		ParenExpr
		///		NotExpr
		///		Atom
		/// AndArg
		///		AndArg1
		///		AndExpr
		/// OrExpr
		///		OrArg & OrArg1
		/// OrArg1
		///		Atom
		///		ParenExpr
		///		NotExpr
		///		AndExpr
		/// OrArg
		///		OrArg1
		///		OrExpr
		///
		/// NotExpr
		///		! NotArg
		///		
		/// NotArg:
		///		Atom
		///		ParenExpr
		///		NotExpr
		/// 
		/// ParenExpr
		///		(Expr)
		/// Atom
		///		Var|0|1
		/// 
		/// 
		/// 
		/// 
		/// LeExpr
		///		LeArg =&lt; LeArg1
		/// ...
		/// EqExpr
		///		EqArg ~ EqArg1
		/// ...
		/// </summary>
		public void parseS() {

			switch (lookahead.GetType().Name)
			{

				case nameof(nilnul.lang.eg.logic._lex.Var):
					parseVar();
					break;
				default:
					break;
			}
		}

		public void parseVar() { }
	}
}

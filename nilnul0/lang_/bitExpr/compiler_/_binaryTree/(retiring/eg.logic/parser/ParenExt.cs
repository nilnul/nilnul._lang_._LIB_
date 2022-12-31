using nilnul.lang._lex;
using nilnul.lang.eg.logic._lex;
using nilnul.lang.eg.logic._lex.token;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.eg.logic.parser
{
	/// <summary>
	/// first insert parenthesis. the parse it. This enbodies the concept: parenthesis is a syntax sign, not a semantic one.
		/// </summary>
	public class ParenX
	{
		Stack tokenStack;

		eg.logic._parser.symbol.Stack symbols;

		IEnumerable<_lex.Symbol> tokens;

		Symbol lookahead;
		Symbol neck;

		private nilnul.lang.eg.logic._lex.token.Stream _tokens;

		public nilnul.lang.eg.logic._lex.token.Stream tokens1
		{
			get { return _tokens; }
			set { _tokens = value; }
		}

		private lang.eg.logic._lex.TokenI _current;

		public lang.eg.logic._lex.TokenI current
		{
			get { return _current; }
			set { _current = value; }
		}





		public void parseS()
		{
			tokenStack.Push(null);
			next2head();


			switch (lookahead.GetType().Name)
			{

				case nameof(nilnul.lang.eg.logic._lex.Var):
					parseHeaded_Var();
					break;
				default:
					break;
			}


		}



		public void next2head() {

			_current = tokens1.next();



		}

		public void parseTail2expr() {
			next2head();
			switch (lookahead.GetType().Name)
			{

				case nameof(nilnul.lang.eg.logic._lex.Var1):
					parseHeaded2expr();
					break;
				case nameof(nilnul.lang.eg.logic._lex.One):
				case nameof(nilnul.lang.eg.logic._lex.Zero):
					parseHeaded_noCall__2expr();
					break;
					
				default:
					break;
			}

		}

		private void parseHeaded_noCall__2expr()
		{
			//reduce
			if (lookahead is _lex.One)
			{
				symbols.Push( new _parser.symbol.One());

			}
			else
			{
				symbols.Push( new _parser.symbol.One());

			}

			symbolStackReduced_parseTail();

		}

		private void symbolStackReduced_parseTail()
		{
			///check the stack
			next2head();

			symbolStackReduced_parseHeaded();
		}

		private void symbolStackReduced_parseHeaded()
		{
			if (symbols.Count==0)
			{
				//
				symbolsReduced_parseHeaded_expectingExpr();
			}

			throw new NotImplementedException();
		}


		public void symbolsReduced_parseHeaded_expectingExpr() {
			if (current ==null)
			{
				error("expecting expr");
			}
			else
			{
				tokenStack.Push(current);
				if (current is eg.logic._lex.token.Not)
				{
					symbolsReduced_parseTail_expectingNoArg();
				}
				else if(eg.logic._lex.token.be.Atomic.Eval( current))
				{
					next2head();
					tokenStack.Push(current);
					if (eg.logic._lex.token.be.DuoOp.Eval(current))
					{

						symbolsReduced_parseTail_expectingDuoOpArg1_();
					}
					else if(current ==null )
					{
						//success
						return;
					}
					else
					{
						error($"unexpected :{current}");


					}

				}

			}
		}

		private void symbolsReduced_parseTail_expectingDuoOpArg1_()
		{
			throw new NotImplementedException();
		}

		private void symbolsReduced_parseTail_expectingNoArg()
		{
			next2headAndStack();
			//try reduce.
			symbols2reduce2noCall_parseTail();



			throw new NotImplementedException();
		}

		private void symbols2reduce2noCall_parseTail()
		{
			//try reduce.
			if (current == null)
			{
				error("expecting noArg");
			}
			else if(current is eg.logic._lex.token.Var1)
			{
				//reduce to no Call.
				

			}

			throw new NotImplementedException();
		}

		private void next2headAndStack()
		{
			next2head();
			tokenStack.Push(current);
		
		}

		private void parseHead2noCall()
		{


			throw new NotImplementedException();
		}

		public void parseHeaded2expr() {
			var oldCurrent = lookahead;	//the var

			next2head();
			if (eg.logic._lex.token.be.DuoOp.Eval(_current) )
			{
				parseHeaded2DuoCall();
			}
			else if (_current==null)
			{
				parseHeaded2var();
			}
			else
			{
				error("cannot parsed as expr");
			}



		}



		private void error(string v)
		{
			throw new NotImplementedException();
		}

		private void parseHeaded2var()
		{
			throw new NotImplementedException();
		}

		private void parseHeaded2DuoCall()
		{
			throw new NotImplementedException();
		}

		private void parseHeaded_Var()
		{

			var oldCurrent = lookahead;
			next2head();
			if (eg.logic._lex.token.be.DuoOp.Eval(_current) )
			{
				
			}




			throw new NotImplementedException();
		}
	}
}

using nilnul.lang.eg.logic._lex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.eg.logic.parser._parenExt
{

	/// <summary>
	/// for any mono/duo op, add "()"
	/// 
	/// before this stage of processing, make sure the syntax is right.
	/// </summary>
	public class InsertParen
	{

		private eg.logic._lex.token.Stream _stream;

		public eg.logic._lex.token.Stream stream
		{
			get { return _stream; }
			set { _stream = value; }
		}

		public eg.logic._lex.token.str.List _input { get; set; }

		private eg.logic._lex.TokenI _current;

		public eg.logic._lex.TokenI current
		{
			get { return _current; }
			set { _current = value; }
		}


		private List<eg.logic._lex.TokenI> _outTokens;

		public List<eg.logic._lex.TokenI> outTokens
		{
			get { return _outTokens; }
			set { _outTokens = value; }



		}

		private List<eg.logic._lex.token.RightParen> _appendedRightParen;

		public List<eg.logic._lex.token.RightParen> appendRightParen
		{
			get { return _appendedRightParen; }
			set { _appendedRightParen = value; }
		}




		private List<eg.logic._parser.SymbolI> _symbols;

		public List<eg.logic._parser.SymbolI> symbols
		{
			get { return _symbols; }
			set { _symbols = value; }
		}

		private eg.logic._parser.symbol.Stack _symbolStack;

		public eg.logic._parser.symbol.Stack symbolStack
		{
			get { return _symbolStack; }
			set { _symbolStack = value; }
		}

		public void parseStr()
		{
			next2current();

			parseHeaded();
		}

		public void next2current()
		{
			_current = _stream.next();

		}


		public List<TokenI> parse(List<TokenI> tokens) {

			var r = new List<TokenI>();
			var first = tokens.First();
			tokens.RemoveAt(0);
			if (first == null)
			{
				//error will be checked at the next stage, not in this class.
			}

			if (first is _lex.token.AtomicI)
			{
				r.Add(first);
				//expecting null, or duoOp

				first = tokens.First();

				if (first ==null)
				{
					return r;

				}
				if (first is _lex.token.DuoOpI)
				{
					r.Add(first);

					// the first arg is finalized, compacted.

					duoOpArg1Pushed_parse();
				}

				r.AddRange(parse(tokens.Skip(1).ToList()));

				return r;
			}

			if (tokens.First() is _lex.token.Not)
			{
				r.Add(tokens.First());
				tokens.RemoveAt(0);	
				//seeking next token.



				

			}


		}

		private void duoOpArgPushed_parseHeaded(TokenI duoOp)
		{

			addLeftParen2outTokens();

			var i = 0;
			for (i = 0; i < _input.Count; i++)
			{


				if (_current is _lex.token.LeftParen)
				{

					///seeking the RightParen.
					/// 

				}
				else if (_current is _lex.token.Var1)
				{

				}
				else if (_current is _lex.token.AtomicI)
				{


				}
				else if(_current is _lex.token.DuoOpI) 
				{
					if (_lex.token.Priority.Instance.priorTo(duoOp, _current ))
					{
						//_input.Insert(i, new _lex.token.RightParen());

					}


					break;

				}


				else if (_current is _lex.token.Or)
				{
					_input.Insert(i, new _lex.token.RightParen());

				}

				else if (_current is _lex.token.Le)
				{
					_input.Insert(i, new _lex.token.RightParen());

				}
				else if (_current is _lex.token.Eq)
				{
					_input.Insert(i, new _lex.token.RightParen());

				}

			}

			_input.Insert(i, new _lex.token.RightParen());

			processExprInsideParen();

			leftExpr_parseTail();


			throw new NotImplementedException();
		}



		/// <summary>
		/// from the point of expr, we are in the duoOp expr, seeking second arg till some other expr which is of higher op priority.
		/// </summary>
		/// <param name="currentOp"></param>
		private void duoOp_And__ArgPushed_parse(_lex.token.DuoOpI currentOp)
		{

			addLeftParen2outTokens();
			next2current();

			//seek the position.
			var i = 0;

			for ( i = 0; i < _input.Count; i++)
			{

			
				if (_current is _lex.token.LeftParen)
				{

					///seeking the RightParen.
					/// 

				}
				else if ( _current is _lex.token.Var1)
				{

				}
				else if(_current is _lex.token.AtomicI)
				{


				}
				else if (_current is _lex.token.And)
				{
					break;

				}

				else if (_current is _lex.token.Or)
				{
					_input.Insert(i,new _lex.token.RightParen());

				}

				else if (_current is _lex.token.Le)
				{
					_input.Insert(i,new _lex.token.RightParen());

				}
				else if (_current is _lex.token.Eq)
				{
					_input.Insert(i,new _lex.token.RightParen());

				}

			}
			_input.Insert(i,new _lex.token.RightParen());

			processExprInsideParen();

			leftExpr_parseTail();

			///,
			/// 
			//where to insert the rightToken?

			throw new NotImplementedException();
		}

		private void processExprInsideParen()
		{
			throw new NotImplementedException();
		}

		private void leftExpr_parseTail()
		{
			next2current();
			if (_current ==null)
			{
				return;

			}
			else if(_current is _lex.token.DuoOpI)
			{

				_outTokens.Add(_current);



			}

		}

		public void parseHeaded()
		{
			if (_current is eg.logic._lex.token.Not)
			{

				_outTokens.Add(_current);

				parsedNot_Str_determineParen();

			}

			else if (_current is eg.logic._lex.token.And)
			{
				_outTokens.Add(_current);

				parsedAnd_str_determineParen();


			}
		}

		private void parsedAnd_str_determineParen()
		{
			addLeftParen2outTokens();





			throw new NotImplementedException();
		}

		private void addLeftParen2outTokens()
		{
			_outTokens.Add(new eg.logic._lex.token.LeftParen());

			//throw new NotImplementedException();
		}
		private void addRightParen2outTokens()
		{
			_outTokens.Add(new eg.logic._lex.token.RightParen());

		}

		public void addCurrent2outTokens()
		{
			_outTokens.Add(_current);

		}


		public void parsedNot_Str_determineParen__alwaysInsert()
		{

			addLeftParen2outTokens();


			next2current();



			if (eg.logic._lex.token.be.Atomic.Eval(_current))
			{

				addRightParen2outTokens();

				addCurrent2outTokens();
				addLeftParen2outTokens();

				parseTail();
			}

			else if (_current is _lex.token.LeftParen)
			{
				parsedEndingLeftParen_rightNotINSERTED__parseTail();
			}


			else if (_current is _lex.token.Not)
			{
				_outTokens.Add(new eg.logic._lex.token.LeftParen());



			}


			_outTokens.Add(_current);

			parseStr();




		}





		private void parsedEndingLeftParen_rightNotINSERTED__parseTail()
		{
			next2current();

			if (_current is _lex.token.LeftParen)
			{
				addCurrent2outTokens();

				leftParen__parseTail();

				parsedEndingLeftParen_rightNotINSERTED__parseTail();

			}

			else
			{
				continueHeadedNotLefParen();
			}


			throw new NotImplementedException();
		}

		private void leftParen__parseTail()
		{
			next2current();
			parseHeaded_expectingRightParen();



			throw new NotImplementedException();
		}

		private void parseHeaded_expectingRightParen()
		{


			if (_current is _lex.token.RightParen)
			{
				addCurrent2outTokens();

				parseTail();

			}


			throw new NotImplementedException();
		}



		private void continueHeadedNotLefParen()
		{


			throw new NotImplementedException();
		}

		private void parseTail()
		{


			throw new NotImplementedException();
		}

		public void parsedNot_Str_determineParen()
		{


			next2current();

			if (eg.logic._lex.token.be.Atomic.Eval(_current))
			{
				//reduce it.
			}

			else if (_current is _lex.token.LeftParen)
			{

			}


			else if (_current is _lex.token.Not)
			{
				_outTokens.Add(new eg.logic._lex.token.LeftParen());



			}


			_outTokens.Add(_current);

			parseStr();




		}

		public void insertRightParen(_lex.TokenI token)
		{

			//find all the tokens that priority le this.



		}
		static public IEnumerable<TokenI> Eval(IEnumerable<TokenI> tokens)
		{

		}
	}
}
